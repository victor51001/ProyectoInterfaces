using InmoSolution.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InmoSolution.Controladores
{
    public class ControladorInmueble
    {
        public static List<Inmueble> ListaInmuebles = new List<Inmueble>();

        public static void RellenarListaInmuebles()
        {
            foreach (Alquiler alquiler in ControladorAlquiler.ListaAlquileres)
            {
                ListaInmuebles.Add(alquiler);
            }
            foreach (EnVenta venta in ControladorEnVenta.ListaEnVenta)
            {
                ListaInmuebles.Add(venta);
            }
        }
    }
}
