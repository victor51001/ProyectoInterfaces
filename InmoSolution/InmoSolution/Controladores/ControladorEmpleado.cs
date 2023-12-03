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
        public static bool Cambios { get => cambios; set => cambios = value; }

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
            catch (Exception ex) 
            {
                MessageBox.Show($"Error al leer empleados: {ex.Message}");
            }
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
            catch (Exception ex) 
            { 
                MessageBox.Show($"Error al escribir empleados: {ex.Message}");
            }
        }

        public static Empleado.Puestos GetPuesto()
        {
            switch (new Random().Next(1, 4))
            {
                case 1:
                    return Empleado.Puestos.Administrativo;
                case 2:
                    return Empleado.Puestos.Agente;
                case 3:
                    return Empleado.Puestos.Jefe;
                default:
                    return Empleado.Puestos.nulo;
            }
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
        public static char CalcularLetraDNI(int numerosDNI)
        {
            char[] letrasDNI = { 'T', 'R', 'W', 'A', 'G', 'M', 'Y', 'F', 'P', 'D', 'X', 'B', 'N', 'J', 'Z', 'S', 'Q', 'V', 'H', 'L', 'C', 'K', 'E' };

            int resto = numerosDNI % 23;

            return letrasDNI[resto];
        }
        public static Empleado GenerarEmpleado()
        {
            string[] nombres = { "Carlos", "Laura", "Alejandro", "Sofía", "José", "Beatriz", "Miguel", "Lucía", "David", "Eva" };
            string[] apelli2 = { "González", "López", "Díaz", "Martínez", "Pérez", "García", "Fernández", "Moreno", "Hernández", "Ruiz" };

            Random rand = new Random();

            int numerosDNI = rand.Next(10000000, 99999999);
            string dni = numerosDNI.ToString() + CalcularLetraDNI(numerosDNI);
            string nombre = nombres[rand.Next(nombres.Length)];
            string apellidos = $"{apelli2[rand.Next(apelli2.Length)]} {apelli2[rand.Next(apelli2.Length)]}";
            int telefono = rand.Next(600000000, 799999999);
            string email = $"{nombre.ToLower()}_{apellidos.ToLower()}@inmosolution.com";

            Usuario usuario = ControladorUsuario.GenerarUsuario(nombre, apellidos);
            ControladorUsuario.ListaUsuarios.Add(usuario);

            Empleado.Puestos puesto = GetPuesto();

            return new Empleado(dni, nombre, apellidos, email, telefono, usuario, puesto);
        }

        public static Empleado.Puestos ParseString(string texto)
        {
            switch (texto)
            {
                case "Administrador":
                    return Empleado.Puestos.Administrador;
                case "Administrativo":
                    return Empleado.Puestos.Administrativo;
                case "Agente":
                    return Empleado.Puestos.Agente;
                case "Jefe":
                    return Empleado.Puestos.Jefe;
                default:
                    return Empleado.Puestos.nulo;
            }
        }
    }
}
