using InmoSolution.Controladores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace InmoSolution.Clases
{
    [Serializable]
    public class Empleado : IXmlSerializable
    {        
        [Serializable]
        public enum Puestos
        {
            Administrador,
            Administrativo,
            Agente,
            Jefe,
            nulo
        }
        //atributos
        private string dni;
        private string nombre;
        private string apellidos;
        private int telefono;
        private string email;
        private Usuario usuario;
        private Puestos puesto;
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
        public double Sueldo { get => sueldo; set => sueldo = value; }

        //metodos
        public override string ToString()
        {
            return "Dni: " + this.dni +
                   " Nombre: " + this.nombre +
                   " Apellidos: " + this.apellidos +
                   " Teléfono: " + this.telefono +
                   " Email: " + this.email +
                   " Puesto: " + this.puesto +
                   " Sueldo: " + this.sueldo +
                   " Usuario: " + this.usuario.ToString();
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
        public System.Xml.Schema.XmlSchema GetSchema()
        {
            return null;
        }
        public void ReadXml(System.Xml.XmlReader reader)
        {
            reader.ReadStartElement();

            this.Dni = reader.ReadElementContentAsString("Dni", "");
            this.Nombre = reader.ReadElementContentAsString("Nombre", "");
            this.Apellidos = reader.ReadElementContentAsString("Apellidos", "");
            this.Telefono = int.Parse(reader.ReadElementContentAsString("Telefono", ""));
            this.Email = reader.ReadElementContentAsString("Email", "");
            this.Puesto = (Puestos)Enum.Parse(typeof(Puestos), reader.ReadElementContentAsString("Puesto", ""));
            this.Sueldo = double.Parse(reader.ReadElementContentAsString("Sueldo", ""));
            this.Usuario = ControladorUsuario.GetUsuario(int.Parse(reader.ReadElementContentAsString("IdUsuario", "")));

            reader.ReadEndElement();
        }

        public void WriteXml(System.Xml.XmlWriter writer)
        {
            writer.WriteElementString("Dni", this.Dni);
            writer.WriteElementString("Nombre", this.Nombre);
            writer.WriteElementString("Apellidos", this.Apellidos);
            writer.WriteElementString("Telefono", this.Telefono.ToString());
            writer.WriteElementString("Email", this.Email);
            writer.WriteElementString("Puesto", this.Puesto.ToString());
            writer.WriteElementString("Sueldo", this.Sueldo.ToString());
            writer.WriteElementString("IdUsuario", this.Usuario.Id.ToString());
        }
    }
}
