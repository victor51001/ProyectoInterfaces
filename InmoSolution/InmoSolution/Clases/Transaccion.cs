using InmoSolution.Controladores;
using ProtoBuf;

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
            return $"{Id,-10:D2} {new DateOnly(Fecha.Year,Fecha.Month,Fecha.Day),-15} {Empleado.Dni,-15} {Cliente.Dni,-15} {Inmueble.Direccion,-30} {Precio,-15:C} {Beneficio,0:C}";
        }
    }
}
