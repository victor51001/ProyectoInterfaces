using InmoSolution.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Nett;

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
                ListaVisitas = Toml.ReadFile<List<Visita>>("visitas.toml");
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"Error al leer/visitas: {ex.Message}");
            }
        }

        public static void EscribirVisitas()
        {
            try
            {
                Toml.WriteFile(ListaVisitas, "visitas.toml");
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"Error al escribir/visitas: {ex.Message}");
            }
        }

        public static bool ExisteFichero()
        {
            return File.Exists("visitas.toml");
        }
    }
}
