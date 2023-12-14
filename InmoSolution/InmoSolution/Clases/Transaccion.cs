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
        private Empleado empleado;
        [ProtoMember(4)]
        private Cliente cliente;
        [ProtoMember(5)]
        private Inmueble inmueble;
        [ProtoMember(6)]
        private int precio;
        [ProtoMember(7)]
        private double beneficio;

        //constructor
        public Transaccion(DateOnly fecha, Inmueble inmueble, Empleado empleado, Cliente cliente)
        {
            Id = ControladorTransaccion.ListaTransacciones.Count + 1;
            Fecha = fecha.ToDateTime(new TimeOnly(0,0,0));
            Inmueble = inmueble;
            Inmueble.Disponible = false;
            Inmueble.Propietario = cliente;
            Empleado = empleado;
            Cliente = cliente;
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
        public Empleado Empleado { get => empleado; set => empleado = value; }
        public Cliente Cliente { get => cliente; set => cliente = value; }
        public Inmueble Inmueble { get => inmueble; set => inmueble = value; }
        public int Precio { get => precio; set => precio = value; }
        public double Beneficio { get => beneficio; set => beneficio = value; }

        //metodos
        public override string ToString()
        {
            return $"{Id,-10} {Fecha,-15} {Empleado,-15} {Cliente,-15} {Inmueble,-15} {Precio,-10} {Beneficio,-10}";
        }
    }
}
