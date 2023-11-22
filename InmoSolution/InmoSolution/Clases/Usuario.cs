using InmoSolution.Controladores;
using InmoSolution.Formularios.Usuarios;
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
        private int id;
        private string nombre;
        private string clave;

        //constructor
        public Usuario(string nombre, string clave)
        {
            Id = ControladorUsuario.id++;
            Nombre = nombre;
            Clave = clave;
        }
        public Usuario(int id, string nombre, string clave)
        {
            Id = id;
            Nombre = nombre;
            Clave = clave;
        }

        //getters y setters
        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Clave { get => clave; set => clave = value; }

        //metodos
        public override string ToString()
        {
            return Id + " " + Nombre;
        }
    }
}
