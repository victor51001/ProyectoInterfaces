using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InmoSolution.Clases
{
    public enum Puesto
    {
        Administrador,
        Agente,
        Jefe
    }
    public class Empleado
    {
        //atributos
        private string dni;
        private string nombre;
        private string apellidos;
        private string telefono;
        private string email;
        private Usuario usuario;
        private Puesto puesto;
        private double sueldoBase;
        private double comision;

        //constructor
        public Empleado(string dni, string nombre, string apellidos, string telefono, string email, Usuario usuario, Puesto puesto, double sueldoBase, double comision)
        {
            this.Dni = dni;
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.Telefono = telefono;
            this.Email = email;
            this.Usuario = usuario;
            this.Puesto = puesto;
            this.SueldoBase = sueldoBase;
            this.Comision = comision;
        }

        //getters y setters
        public string Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Email { get => email; set => email = value; }
        public Usuario Usuario { get => usuario; set => usuario = value; }
        public Puesto Puesto { get => puesto; set => puesto = value; }
        public double SueldoBase { get => sueldoBase; set => sueldoBase = value; }
        public double Comision { get => comision; set => comision = value; }

        //metodos
        public override string ToString()
        {
            return " Dni: " + this.Dni + " Nombre: " + this.Nombre + " Apellido: " + this.Apellidos + " Telefono: " + this.Telefono + " Email: " + this.Email + " Usuario: " + this.Usuario + " Puesto: " + this.Puesto + " Sueldo Base: " + this.SueldoBase + " Comision: " + this.Comision;
        }
        public double CalcularNomina()
        {
            double nomina = (this.SueldoBase + this.Comision) - ((this.SueldoBase + this.Comision)*IRPF)/100;
            return nomina;
        }
    }
}
