using InmoSolution.Clases;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

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
    }
}
