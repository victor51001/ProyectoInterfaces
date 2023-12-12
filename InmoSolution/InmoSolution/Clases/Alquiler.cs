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
        [ProtoMember(10)]
        private int precioMensual;

        //constructores
        public Alquiler(string direccion, int habitaciones, 
            int baños, int metrosCuadrados, int antiguedad, bool disponible, 
            Cliente propietario, string localidad) 
            : base(direccion, habitaciones, baños, metrosCuadrados, 
                  antiguedad, disponible, propietario, localidad)
        {
            this.Id = ControladorAlquiler.ListaAlquileres.Count + 1;
            this.PrecioMensual = GenerarPrecioMensual();
        }
        public Alquiler() { }

        //getters y setters
        public int PrecioMensual { get => precioMensual; set => precioMensual = value; }

        //metodos
        public override string ToString()
        {
            return base.ToString() + "    " + this.PrecioMensual;
        }
        public int GenerarPrecioMensual()
        {
            double multiLocal;
            double sumanBaños = this.Baños * 100;
            double sumanHabitaciones = this.Habitaciones * 50;
            double susAntiguedad = this.Antiguedad * 10;
            double sumanMetros = this.MetrosCuadrados * 2;

            switch (this.Localidad)
            {
                case "Madrid":
                    multiLocal = 4;
                    break;
                case "Alcalá de Henares":
                    multiLocal = 1;
                    break;
                case "Getafe":
                    multiLocal = 1;
                    break;
                case "Móstoles":
                    multiLocal = 3;
                    break;
                case "Alcorcón":
                    multiLocal = 2;
                    break;
                case "Fuenlabrada":
                    multiLocal = 3;
                    break;
                default:
                    multiLocal = 0;
                    break;
            }
            
            return (int)(200* multiLocal + (sumanBaños + sumanHabitaciones+ sumanMetros - susAntiguedad));
        }
    }
}
