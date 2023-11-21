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
        //atributos
        private string nombre;
        private string clave;

        //constructor
        public Usuario(string nombre, string clave)
        {
            Nombre = nombre;
            Clave = clave;
        }

        //getters y setters
        public string Nombre { get => nombre; set => nombre = value; }
        public string Clave { get => clave; set => clave = value; }
    }
}
