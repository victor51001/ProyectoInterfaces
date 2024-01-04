using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InmoSolution.Controladores;
using ProtoBuf;

namespace InmoSolution.Clases
{
    [ProtoContract]
    public class EnVenta : Inmueble
    {
        //atributos
        [ProtoMember(10)]
        private int precioMetroCuadrado;
        [ProtoMember(11)]
        private int precio;

        //constructores
        public EnVenta(string direccion, int habitaciones, 
                       int baños, int metrosCuadrados, int antiguedad, bool disponible, 
                                  Cliente propietario, string localidad, int precioMetroCuadrado) 
            : base(direccion, habitaciones, baños, metrosCuadrados, 
                                   antiguedad, disponible, propietario, localidad)
        {
            this.Id = ControladorEnVenta.ListaEnVenta.Count + 1;
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
            return $"{base.ToString()} {PrecioMetroCuadrado,-10:C0} {Precio,10:C0}";
        }
    }
}
