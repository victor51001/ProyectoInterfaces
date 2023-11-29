using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace InmoSolution.Clases
{
    [ProtoContract]
    [ProtoInclude(20, typeof(Alquiler))]
    [ProtoInclude(21, typeof(EnVenta))]
    public abstract class Inmueble
    {
        //atributos
        [ProtoMember(1)]
        private int id;
        [ProtoMember(2)]
        private string direccion;
        [ProtoMember(3)]
        private int habitaciones;
        [ProtoMember(4)]
        private int baños;
        [ProtoMember(5)]
        private int metrosCuadrados;
        [ProtoMember(6)]
        private int antiguedad;
        [ProtoMember(7)]
        private bool disponible;
        [ProtoMember(8)]
        private Cliente propietario;
        [ProtoMember(9)]
        private string localidad;
        [ProtoMember(10)]
        private bool libre;
        
        //constructores
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
        public Inmueble() { }

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
