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
        private int telefono;
        private string email;
        
        //constructores
        public Cliente(string dni, string nombre, string apellidos, int telefono, string email)
        {
            this.Dni = dni;
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.Telefono = telefono;
            this.Email = email;
        }
        public Cliente() { }

        //getters y setters
        public string Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public string Email { get => email; set => email = value; }

        //metodos
        public override string ToString()
        {
            return " Dni: " + this.Dni + " Nombre: " + this.Nombre + " Apellido: " + this.Apellidos + " Telefono: " + this.Telefono + " Email: " + this.Email;
        }
    }
}
