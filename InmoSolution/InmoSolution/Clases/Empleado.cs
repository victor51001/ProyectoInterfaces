﻿using InmoSolution.Controladores;
using System.Xml.Serialization;
using ProtoBuf;

namespace InmoSolution.Clases
{
    [ProtoContract]
    [XmlRoot("Empleado")]
    public class Empleado
    {
        [ProtoContract]
        public enum Puestos
        {
            Administrador,
            Administrativo,
            Agente,
            Jefe,
            nulo
        }
        //atributos
        [ProtoMember(1)]
        [XmlElement("Dni")]
        private string dni;
        [ProtoMember(2)]
        [XmlElement("Nombre")]
        private string nombre;
        [ProtoMember(3)]
        [XmlElement("Apellidos")]
        private string apellidos;
        [ProtoMember(4)]
        [XmlElement("Telefono")]
        private int telefono;
        [ProtoMember(5)]
        [XmlElement("Email")]
        private string email;
        [ProtoMember(6)]
        [XmlElement("Usuario")]
        private Usuario usuario;
        [ProtoMember(7)]
        [XmlElement("Puesto")]
        private Puestos puesto;
        [ProtoMember(8)]
        [XmlElement("Sueldo")]
        private double sueldo;

        //constructores
        public Empleado(string dni, string nombre, string apellidos, string email, int telefono,Usuario usuario, Puestos puesto)
        {
            this.Dni = dni;
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.Telefono = telefono;
            this.Email = email;
            this.Usuario = usuario;
            this.Puesto = puesto;
            this.Sueldo = CalcularSueldo();
        }
        public Empleado() { }

        //getters y setters
        public string Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public string Email { get => email; set => email = value; }
        public Usuario Usuario { get => usuario; set => usuario = value; }
        public Puestos Puesto { get => puesto; set => puesto = value; }
        public double Sueldo { get => sueldo; set => sueldo = Math.Round(value,2); }

        //metodos
        public override string ToString()
        {
            return $"{Dni, -10} {Nombre, -10} {Apellidos, -20} {Telefono, -10} {Email, -20} {Puesto, -10} {Sueldo, -10} {Usuario.Id}";
        }

        public double CalcularComision(int alquileres, int ventas)
        {
            return (alquileres*ControladorEmpleado.COMISION_ALQUILER + ventas*ControladorEmpleado.COMISION_VENTA);
        }
        public double CalcularSueldo()
        {
            switch (this.Puesto.ToString())
            {
                case "Administrador":
                    return ControladorEmpleado.SUELDO_MINIMO * 1.8;
                case "Administrativo":
                    return ControladorEmpleado.SUELDO_MINIMO * 1.1;
                case "Agente":
                    return ControladorEmpleado.SUELDO_MINIMO + GetComisionAlquileres() + GetComisionVentas();
                case "Jefe":
                    return ControladorEmpleado.SUELDO_MINIMO * 2.5;
                default:
                    return 0;
            }
        }
        public double GetComisionAlquileres()
        {
            double comision = 0;
            Alquiler alquiler;
            foreach (Transaccion t in ControladorTransaccion.ListaTransacciones)
            {
                if (t.Empleado.Equals(this))
                {
                    if (t.Inmueble.GetType().Equals(typeof(Alquiler)))
                    {
                        alquiler = (Alquiler)t.Inmueble;
                        comision += alquiler.PrecioMensual * 12 * ControladorEmpleado.COMISION_ALQUILER;
                    }
                }
            }
            return comision;
        }

        public double GetComisionVentas()
        {
            double comision = 0;
            EnVenta venta;
            foreach (Transaccion t in ControladorTransaccion.ListaTransacciones)
            {
                if (t.Empleado.Equals(this))
                {
                    if (t.Inmueble.GetType().Equals(typeof(EnVenta)))
                    {
                        venta = (EnVenta)t.Inmueble;
                        comision += venta.Precio * ControladorEmpleado.COMISION_VENTA;
                    }
                }            
            }
            return comision;
        }
    }
}
