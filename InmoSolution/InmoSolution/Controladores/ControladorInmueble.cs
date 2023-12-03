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
        public static string[] ListaLocalidades = { "Madrid", "Alcalá de Henares", "Getafe", "Móstoles", "Alcorcón", "Fuenlabrada" };

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
        public static DateTime AddFecha(DateTime fecha)
        {
            switch (new Random().Next(6))
            {
                case 0:
                    fecha = fecha.AddMonths(3);
                    break;
                case 1:
                    fecha = fecha.AddMonths(6);
                    break;
                case 2:
                    fecha = fecha.AddMonths(9);
                    break;
                case 3:
                    fecha = fecha.AddYears(1);
                    break;
                case 4:
                    fecha = fecha.AddYears(2);
                    break;
                case 5:
                    fecha = fecha.AddYears(3);
                    break;
                default:
                    break;
            }
            return fecha;
        }
        public static KeyValuePair<string, string> GenerarDireccionLocalidad()
        {
            string[] direccionesMadrid = {
            "Calle Gran Vía, 123","Avenida de la Castellana, 456",
            "Plaza Mayor, 7","Calle Serrano, 89","Paseo del Prado, 210"
        };
            string[] direccionesAlcalaDeHenares = {
            "Calle Mayor, 34","Avenida Complutense, 78","Plaza Cervantes, 12",
            "Calle Libreros, 45","Paseo de la Estación, 102"
        };
            string[] direccionesGetafe = {
            "Calle Toledo, 56","Avenida Juan de la Cierva, 23",
            "Plaza General Palacio, 9","Calle Madrid, 71","Paseo de la Estación, 150"
        };
            string[] direccionesMostoles = {
            "Calle Libertad, 20","Avenida Dos de Mayo, 45","Plaza del Pradillo, 8",
            "Calle Granada, 33","Paseo de Arroyomolinos, 112"
        };
            string[] direccionesAlcorcon = {
            "Calle Mayor, 76","Avenida de Leganés, 123",
            "Plaza de España, 5","Calle Fuenlabrada, 31","Paseo de la Libertad, 88"
        };
            string[] direccionesFuenlabrada = {
            "Calle Cervantes, 10","Avenida de la Hispanidad, 55",
            "Plaza de la Constitución, 15","Calle Leganés, 40","Paseo de la Solidaridad, 78"
        };
            int op = new Random().Next(6);
            switch (op)
            {
                case 0:
                    return new KeyValuePair<string, string>(ListaLocalidades[op], direccionesMadrid[new Random().Next(direccionesMadrid.Length)]);
                case 1:
                    return new KeyValuePair<string, string>(ListaLocalidades[op], direccionesAlcalaDeHenares[new Random().Next(direccionesAlcalaDeHenares.Length)]);
                case 2:
                    return new KeyValuePair<string, string>(ListaLocalidades[op], direccionesGetafe[new Random().Next(direccionesGetafe.Length)]);
                case 3:
                    return new KeyValuePair<string, string>(ListaLocalidades[op], direccionesMostoles[new Random().Next(direccionesMostoles.Length)]);
                case 4:
                    return new KeyValuePair<string, string>(ListaLocalidades[op], direccionesAlcorcon[new Random().Next(direccionesAlcorcon.Length)]);
                case 5:
                    return new KeyValuePair<string, string>(ListaLocalidades[op], direccionesFuenlabrada[new Random().Next(direccionesFuenlabrada.Length)]);
                default:
                    return new KeyValuePair<string, string>("", "");
            }
        }
    }
}
