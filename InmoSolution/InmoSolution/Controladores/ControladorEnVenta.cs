using CsvHelper;
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
        public static List<EnVenta> ListaEnVentas = new List<EnVenta>();
        public static bool cambios;

        public static void LeerEnVentas()
        {
            try
            {
                string jsonString = File.ReadAllText("enVenta.json");
                ListaEnVentas = JsonSerializer.Deserialize<List<EnVenta>>(jsonString);
            }
            catch (Exception)
            { }
        }

        public static void EscribirEnVentas()
        {
            try
            {
                string jsonString = JsonSerializer.Serialize(ListaEnVentas);
                File.WriteAllText("enVenta.json", jsonString);
            }
            catch (Exception)
            { }
        }
        public static bool ExisteFichero()
        {
            return File.Exists("enVenta.json");
        }
    }
}
