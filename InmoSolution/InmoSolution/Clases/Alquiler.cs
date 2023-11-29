using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace InmoSolution.Clases
{
    [ProtoContract]
    public class Alquiler : Inmueble
    {
        //atributos
        [ProtoMember(11)]
        private int precioMensual;

        //constructores
        public Alquiler(int id, string direccion, int habitaciones, 
            int baños, int metrosCuadrados, int antiguedad, bool disponible, 
            Cliente propietario, string localidad, int precioMensual) 
            : base(id, direccion, habitaciones, baños, metrosCuadrados, 
                  antiguedad, disponible, propietario, localidad)
        {
            this.PrecioMensual = precioMensual;
        }
        public Alquiler() { }

        //getters y setters
        public int PrecioMensual { get => precioMensual; set => precioMensual = value; }

        //metodos
        public override string ToString()
        {
            return base.ToString() + " Precio: " + this.PrecioMensual;
        }
    }
}
