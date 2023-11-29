using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace InmoSolution.Clases
{
    [ProtoContract]
    public class EnVenta : Inmueble
    {
        //atributos
        [ProtoMember(11)]
        private int precioMetroCuadrado;
        [ProtoMember(12)]
        private int precio;

        //constructores
        public EnVenta(int id, string direccion, int habitaciones, 
                       int baños, int metrosCuadrados, int antiguedad, bool disponible, 
                                  Cliente propietario, string localidad, int precioMetroCuadrado) 
            : base(id, direccion, habitaciones, baños, metrosCuadrados, 
                                   antiguedad, disponible, propietario, localidad)
        {
            this.PrecioMetroCuadrado = precioMetroCuadrado;
            this.Precio = PrecioMetroCuadrado * MetrosCuadrados;
        }
        public EnVenta() { }

        //getters y setters
        public int Precio { get => precio; set => precio = value; }
        public int PrecioMetroCuadrado { get => precioMetroCuadrado; set => precioMetroCuadrado = value; }

        //metodos
        public override string ToString()
        {
            return base.ToString() + " Precio por metro cuadrado: " + this.PrecioMetroCuadrado + " Precio: " + this.Precio;
        }
    }
}
