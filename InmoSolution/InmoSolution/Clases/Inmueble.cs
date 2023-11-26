using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InmoSolution.Clases
{
    public abstract class Inmueble
    {
        //atributos
        private int id;
        private string direccion;
        private int habitaciones;
        private int baños;
        private int metrosCuadrados;
        private int antiguedad;
        private bool disponible;
        private Cliente propietario;
        private string localidad;
        private bool libre;
        
        //constructor
        public Inmueble(int id, string direccion, int habitaciones, int baños, int metrosCuadrados, int antiguedad, bool disponible, Cliente propietario, string localidad)
        {
            this.Id = id;
            this.Direccion = direccion;
            this.Habitaciones = habitaciones;
            this.Baños = baños;
            this.MetrosCuadrados = metrosCuadrados;
            this.Antiguedad = antiguedad;
            this.Disponible = disponible;
            this.Propietario = propietario;
            this.Localidad = localidad;
            this.libre = true;
        }

        //getters y setters
        public int Id { get => id; set => id = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public int Habitaciones { get => habitaciones; set => habitaciones = value; }
        public int Baños { get => baños; set => baños = value; }
        public int MetrosCuadrados { get => metrosCuadrados; set => metrosCuadrados = value; }
        public int Antiguedad { get => antiguedad; set => antiguedad = value; }
        public bool Disponible { get => disponible; set => disponible = value; }
        public Cliente Propietario { get => propietario; set => propietario = value; }
        public string Localidad { get => localidad; set => localidad = value; }
        public bool Libre { get => libre; set => libre = value; }

        //metodos
        public override string ToString()
        {
            return "Id: " + this.Id + " Direccion: " + this.Direccion + " Habitaciones: " + this.Habitaciones + " Baños: " + this.Baños + " Metros Cuadrados: " + this.MetrosCuadrados + " Antiguedad: " + this.Antiguedad + " Disponible: " + this.Disponible + " Propietario: " + this.Propietario + " Localidad: " + this.Localidad + " Libre: " + this.Libre;
        }
    }
}
