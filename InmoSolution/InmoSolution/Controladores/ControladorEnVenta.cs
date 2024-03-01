using InmoSolution.Clases;
using System.Text;
using System.Text.Json;

namespace InmoSolution.Controladores
{
    public class ControladorEnVenta
    {
        public static List<EnVenta> ListaEnVenta = new List<EnVenta>();
        public static bool cambios;
        public static bool Cambios { get => cambios; set => cambios = value; }

        public static void LeerEnVentas()
        {
            try
            {
                string jsonString = File.ReadAllText("enVenta.json");
                ListaEnVenta = JsonSerializer.Deserialize<List<EnVenta>>(jsonString);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al leer enventa: {ex.Message}");
            }
        }

        public static void EscribirEnVentas()
        {
            try
            {
                string jsonString = JsonSerializer.Serialize(ListaEnVenta);
                File.WriteAllText("enVenta.json", jsonString, Encoding.UTF8);
            }
            catch (Exception ex)
            { 
                MessageBox.Show($"Error al escribir enventa: {ex.Message}");
            }
        }
        public static bool ExisteFichero()
        {
            return File.Exists("enVenta.json");
        }
        public static int GetPrecioMetroCuadrado(string localidad)
        {
            int precioMetroCuadrado = 0;
            switch (localidad)
            {
                case "Madrid":
                    return 4000;
                case "Alcalá de Henares":
                case "Getafe":
                case "Móstoles":
                case "Alcorcón":
                case "Fuenlabrada":
                    return 2000;
                default:
                    break;
            }
            return precioMetroCuadrado;
        }

        public static EnVenta GenerarEnVenta()
        {
            Random r = new Random();
            KeyValuePair<string, string> dirLoc = ControladorInmueble.GenerarDireccionLocalidad();
            string direccion = dirLoc.Value;
            int habitaciones = r.Next(1, 6);
            int baños = r.Next(1, 4);
            int metrosCuadrados = r.Next(40, 201);
            int antiguedad = r.Next(1, 51);
            Cliente propietario = ControladorCliente.ListaClientes[r.Next(ControladorCliente.ListaClientes.Count)];
            string localidad = dirLoc.Key;
            bool disponible = true;
            int precioMetroCuadrado = GetPrecioMetroCuadrado(localidad);
            return new EnVenta(direccion, habitaciones, baños, metrosCuadrados, antiguedad, disponible, propietario, localidad, precioMetroCuadrado);
        }
    }
}
