using InmoSolution.Controladores;
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
        private int precio;
        [ProtoMember(8)]
        private double beneficio;

        //constructor
        public Transaccion(DateOnly fecha, Inmueble inmueble)
        {
            Id = ControladorTransaccion.ListaTransacciones.Count + 1;
            Fecha = fecha.ToDateTime(new TimeOnly(0,0,0));
            Inmueble = inmueble;
            Visitas = inmueble.GetVisitas();
            Empleado = Visitas[Visitas.Length - 1].Empleado;
            Cliente = Visitas[Visitas.Length - 1].Cliente;
            Inmueble.Disponible = false;
            if (Inmueble is Alquiler)
            {
                Precio = ((Alquiler)Inmueble).PrecioMensual;
                Beneficio = Precio;
                ControladorTransaccion.AddFechaAlquiler(Fecha);
            }
            else
            {
                Precio = ((EnVenta)Inmueble).Precio;
                Beneficio = Precio * 0.1;
                ControladorTransaccion.AddFechaVenta(Fecha);
            }
        }
        public Transaccion() { }

        //getters y setters
        public int Id { get => id; set => id = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public Visita[] Visitas { get => visitas; set => visitas = value; }
        public Empleado Empleado { get => empleado; set => empleado = value; }
        public Cliente Cliente { get => cliente; set => cliente = value; }
        public Inmueble Inmueble { get => inmueble; set => inmueble = value; }
        public int Precio { get => precio; set => precio = value; }
        public double Beneficio { get => beneficio; set => beneficio = value; }

        //metodos
        public override string ToString()
        {
            return " Id: " + Id + " Fecha: " + Fecha + " Visitas: " + Visitas.ToString() + " Empleado: " + Empleado + " Cliente: " + Cliente + " Inmueble: " + Inmueble + " Precio: " + Precio + " Beneficio: " + Beneficio;
        }
    }
}
