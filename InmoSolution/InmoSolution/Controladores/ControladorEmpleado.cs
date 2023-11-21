using InmoSolution.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace InmoSolution.Controladores
{
    public class ControladorEmpleado
    {
        public static List<Empleado> ListaEmpleados = new List<Empleado>();
        public static bool cambios;
        public static void LeerEmpleados()
        {
            try
            {
                string xml = File.ReadAllText("empleados.xml");
                using (var reader = new StringReader(xml))
                {
                    XmlSerializer serializer = new XmlSerializer(ListaEmpleados.GetType());
                    ListaEmpleados = (List<Empleado>)serializer.Deserialize(reader);
                }
            }
            catch (Exception) { }
        }

        public static void EscribirEmpleados()
        {
            try
            {
                using (var writer = new StreamWriter("empleados.xml"))
                {
                    var namespaces = new XmlSerializerNamespaces();
                    namespaces.Add(string.Empty, string.Empty);
                    var serializer = new XmlSerializer(ListaEmpleados.GetType());
                    serializer.Serialize(writer, ListaEmpleados, namespaces);
                }
            }
            catch (Exception) { }
        }
    }
}
