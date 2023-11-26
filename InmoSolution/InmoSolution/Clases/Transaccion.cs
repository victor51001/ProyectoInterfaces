using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InmoSolution.Clases
{
    [Serializable]
    public class Transaccion
    {
        //atributos
        private int id;
        private DateTime fecha;
        private Visita[] visitas;
        private Empleado empleado;
        private Cliente cliente;
        private Inmueble inmueble;
        private double precio;
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
            return " Id: " + this.Id + " Fecha: " + this.Fecha + " Visitas: " + this.Visitas + " Empleado: " + this.Empleado + " Cliente: " + this.Cliente + " Inmueble: " + this.Inmueble + " Precio: " + this.Precio + " Beneficio: " + this.Beneficio;
        }
    }
}
