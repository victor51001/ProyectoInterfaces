using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InmoSolution.Clases
{
    public class Visita
    {
        //atributos
        private int id;
        private DateTime fechaHora;
        private Cliente cliente;
        private Inmueble inmueble;
        private Empleado empleado;

        //constructor
        public Visita(int id, DateTime fechaHora, Cliente cliente, Inmueble inmueble, Empleado empleado)
        {
            this.Id = id;
            this.FechaHora = fechaHora;
            this.Cliente = cliente;
            this.Inmueble = inmueble;
            this.Empleado = empleado;
        }

        //getters y setters
        public int Id { get => id; set => id = value; }
        public DateTime FechaHora { get => fechaHora; set => fechaHora = value; }
        public Cliente Cliente { get => cliente; set => cliente = value; }
        public Inmueble Inmueble { get => inmueble; set => inmueble = value; }
        public Empleado Empleado { get => empleado; set => empleado = value; }

        //metodos
        public override string ToString()
        {
            return "Id: " + this.Id + " Fecha y Hora: " + this.FechaHora + " Cliente: " + this.Cliente + " Inmueble: " + this.Inmueble + " Empleado: " + this.Empleado;
        }
    }
}
