using CsvHelper;
using InmoSolution.Clases;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
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
                StreamReader reader = new StreamReader("enventa.csv");
                CsvReader csv = new CsvReader(reader, CultureInfo.InvariantCulture);
                ListaEnVentas = csv.GetRecords<EnVenta>().ToList();
                reader.Dispose();
                csv.Dispose();
            }
            catch (Exception)
            { }
        }

        public static void EscribirEnVentas()
        {
            try
            {
                StreamWriter writer = new StreamWriter("enventa.csv");
                CsvWriter csv = new CsvWriter(writer, CultureInfo.InvariantCulture);
                csv.WriteRecords(ListaEnVentas);
                writer.Dispose();
                csv.Dispose();
            }
            catch (Exception)
            { }
        }
    }
}
