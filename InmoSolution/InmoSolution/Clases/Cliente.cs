using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InmoSolution.Clases
{
    [Serializable]
    public class Cliente
    {
        //atributos
        private string dni;
        private string nombre;
        private string apellidos;
        private string telefono;
        private string email;
        
        //constructor
        public Cliente(string dni, string nombre, string apellidos, string telefono, string email)
        {
            this.Dni = dni;
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.Telefono = telefono;
            this.Email = email;
        }

        //getters y setters
        public string Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Email { get => email; set => email = value; }

        //metodos
        public override string ToString()
        {
            return " Dni: " + this.Dni + " Nombre: " + this.Nombre + " Apellido: " + this.Apellidos + " Telefono: " + this.Telefono + " Email: " + this.Email;
        }
    }
}
