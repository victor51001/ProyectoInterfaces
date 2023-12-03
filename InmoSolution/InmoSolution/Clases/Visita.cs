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
    public class Visita
    {
        //atributos
        [ProtoMember(1)]
        private int id;
        [ProtoMember(2)]
        private DateTime fechaHora;
        [ProtoMember(3)]
        private Cliente cliente;
        [ProtoMember(4)]
        private Inmueble inmueble;
        [ProtoMember(5)]
        private Empleado empleado;

        //constructores
        public Visita(DateTime fechaHora, Cliente cliente, Inmueble inmueble, Empleado empleado)
        {
            this.Id = ControladorVisita.ListaVisitas.Count + 1;
            this.FechaHora = fechaHora;
            this.Cliente = cliente;
            this.Inmueble = inmueble;
            this.Empleado = empleado;
        }
        public Visita() { }

        //getters y setters
        public int Id { get => id; set => id = value; }
        public DateTime FechaHora { get => fechaHora; set => fechaHora = value; }
        public Cliente Cliente { get => cliente; set => cliente = value; }
        public Inmueble Inmueble { get => inmueble; set => inmueble = value; }
        public Empleado Empleado { get => empleado; set => empleado = value; }

        //metodos
        public override string ToString()
        {
            return "Id: " + this.Id + " Fecha y Hora: " + this.FechaHora + " Cliente: " + this.Cliente.ToString()+ " Inmueble: " + this.Inmueble.ToString() + " Empleado: " + this.Empleado.ToString();
        }
    }
}
