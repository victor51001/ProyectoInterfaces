using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InmoSolution.Clases
{
    [ProtoContract]
    public class Transaccion
    {
        //atributos
        [ProtoMember(1)]
        private int id;
        [ProtoMember(2)]
        private DateTime fecha;
        [ProtoMember(3)]
        private Visita[] visitas;
        [ProtoMember(4)]
        private Empleado empleado;
        [ProtoMember(5)]
        private Cliente cliente;
        [ProtoMember(6)]
        private Inmueble inmueble;
        [ProtoMember(7)]
        private double precio;
        [ProtoMember(8)]
        private double beneficio;

        //constructor
        public Transaccion(int id, DateTime fecha, Visita[] visitas, Empleado empleado, Cliente cliente, Inmueble inmueble, double precio, double beneficio)
        {
            this.Id = id;
            this.Fecha = fecha;
            this.Visitas = visitas;
            this.Empleado = empleado;
            this.Cliente = cliente;
            this.Inmueble = inmueble;
            this.Inmueble.Libre = false;
            this.Precio = precio;
            this.Beneficio = beneficio;
        }
        public Transaccion() { }

        //getters y setters
        public int Id { get => id; set => id = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public Visita[] Visitas { get => visitas; set => visitas = value; }
        public Empleado Empleado { get => empleado; set => empleado = value; }
        public Cliente Cliente { get => cliente; set => cliente = value; }
        public Inmueble Inmueble { get => inmueble; set => inmueble = value; }
        public double Precio { get => precio; set => precio = value; }
        public double Beneficio { get => beneficio; set => beneficio = value; }

        //metodos
        public override string ToString()
        {
            return " Id: " + this.Id + " Fecha: " + this.Fecha + " Visitas: " + this.Visitas.ToString() + " Empleado: " + this.Empleado + " Cliente: " + this.Cliente + " Inmueble: " + this.Inmueble + " Precio: " + this.Precio + " Beneficio: " + this.Beneficio;
        }
    }
}
