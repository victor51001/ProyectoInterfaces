using InmoSolution.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using static InmoSolution.Clases.Empleado;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace InmoSolution.Controladores
{
    public class ControladorEmpleado
    {
        public static List<Empleado> ListaEmpleados = new List<Empleado>();
        public static bool cambios;
        public const double SUELDO_MINIMO = 900;
        public const double COMISION_ALQUILER = 0.05;
        public const double COMISION_VENTA = 0.1;
        public const double IRPF = 0.15;

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
            catch (Exception) 
            { }
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
            catch (Exception) 
            { }
        }

        public static bool EsJefe(Usuario user)
        {
            foreach (Empleado emp in ListaEmpleados)
            {
                if (emp.Usuario.Id == user.Id)
                {
                    if (emp.Puesto == Puestos.Jefe)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool EsAdministrativo(Usuario user)
        {
            foreach (Empleado emp in ListaEmpleados)
            {
                if (emp.Usuario.Id == user.Id)
                {
                    if (emp.Puesto == Puestos.Administrativo)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static void EliminarEmpleado(Empleado empleado)
        {
            foreach (Empleado emp in ListaEmpleados)
            {
                if (emp == empleado)
                {
                    ListaEmpleados.Remove(emp);
                    return;
                }
            }
        }

        public static void ModificarEmpleado(Empleado empleado, int telefono, string email, Empleado.Puestos puesto)
        {
            if (telefono != 0)
            {
                empleado.Telefono = telefono;
            }
            if (email != null)
            {
                empleado.Email = email;
            }
            if (puesto != Empleado.Puestos.nulo)
            {
                empleado.Puesto = puesto;
            }            
        }
        public static bool ExisteFichero()
        {
            return File.Exists("empleados.xml");
        }
    }
}
