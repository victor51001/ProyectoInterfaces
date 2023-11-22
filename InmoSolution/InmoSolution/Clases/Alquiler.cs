using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InmoSolution.Clases
{
    public class Alquiler : Inmueble
    {
        //atributos
        private int precio;

        //constructor
        public Alquiler(int id, string direccion, int habitaciones, 
            int baños, int metrosCuadrados, int antiguedad, bool disponible, 
            Cliente propietario, string localidad, int precio) 
            : base(id, direccion, habitaciones, baños, metrosCuadrados, 
                  antiguedad, disponible, propietario, localidad)
        {
            this.Precio = precio;
        }

        //getters y setters
        public int Precio { get => precio; set => precio = value; }

        //metodos
        public override string ToString()
        {
            return base.ToString() + " Precio: " + this.Precio;
        }
    }
}
