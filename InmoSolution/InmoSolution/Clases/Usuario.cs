using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InmoSolution.Clases
{
    [Serializable]
    public class Usuario
    {
        private string nombre;
        private string clave;
        public string Nombre { get => nombre; set => nombre = value; }
        public string Clave { get => clave; set => clave = value; }

        public Usuario(string nombre, string clave)
        {
            Nombre = nombre;
            Clave = clave;
        }
    }
}
