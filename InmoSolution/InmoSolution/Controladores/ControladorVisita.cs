using InmoSolution.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tomlyn;

namespace InmoSolution.Controladores
{
    public class ControladorVisita
    {
        public static List<Visita> ListaVisitas = new List<Visita>();
        public static bool cambios;
        public static void LeerVisitas()
        {
            try
            {
                string toml = File.ReadAllText("visitas.toml");
                var table = Toml.Parse(toml);
                var visits = table.ToModel<List<Visita>>();
                ListaVisitas = visits ?? new List<Visita>();
            }
            catch (Exception) { }
        }

        public static void EscribirVisitas()
        {
            try
            {
                if (!File.Exists("visitas.toml"))
                {
                    File.Create("visitas.toml").Close();
                }
                var table = Toml.FromModel(ListaVisitas);
                File.WriteAllText("visitas.toml", table);
            }
            catch (Exception) { }
        }

        public static bool ExisteFichero()
        {
            return File.Exists("visitas.toml");
        }
    }
}
