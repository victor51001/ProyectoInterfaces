using InmoSolution.Clases;
using System;
using System.Collections.Generic;
using System.IO;
using ProtoBuf;

namespace InmoSolution.Controladores
{
    public class ControladorTransaccion
    {
        public static List<Transaccion> ListaTransacciones = new List<Transaccion>();
        public static Dictionary<DateTime, int> ContadorPorFechasAlquileres = new Dictionary<DateTime, int>();
        public static Dictionary<DateTime, int> ContadorPorFechasVentas = new Dictionary<DateTime, int>();
        public static bool cambios;
        public static bool Cambios { get => cambios; set => cambios = value; }

        public static void LeerTransacciones()
        {
            try
            {
                using (FileStream fs = new FileStream("transacciones.dat", FileMode.Open))
                {
                    ListaTransacciones = Serializer.Deserialize<List<Transaccion>>(fs);
                }
                foreach (Transaccion transaccion in ListaTransacciones)
                {
                    if (transaccion.Inmueble is Alquiler) 
                    {
                        AddFechaAlquiler(transaccion.Fecha);
                    } 
                    else
                    {
                        AddFechaVenta(transaccion.Fecha);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al leer transacciones: {ex.Message}");
            }
        }

        public static void EscribirTransacciones()
        {
            try
            {
                using (FileStream fs = new FileStream("transacciones.dat", FileMode.Create)) 
                {   
                    Serializer.Serialize(fs, ListaTransacciones);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al escribir transacciones: {ex.Message}");
            }
        }
        public static bool ExisteFichero()
        {
            return File.Exists("transacciones.dat");
        }
        public static Inmueble GetInmueble()
        {
            Random random = new Random();
            Inmueble inmueble = ControladorVisita.ListaVisitas[random.Next(ControladorVisita.ListaVisitas.Count)].Inmueble;
            while (!inmueble.Disponible)
            {
                inmueble = ControladorVisita.ListaVisitas[random.Next(ControladorVisita.ListaVisitas.Count)].Inmueble;
            }
            return inmueble;
        }

        public static Transaccion GenerarTransaccion()
        {
            DateOnly fecha = GenerarFecha();
            Inmueble inmueble = GetInmueble();
            return new Transaccion(fecha, inmueble);
        }
        public static DateOnly GenerarFecha()
        {
            Random r = new Random();
            switch (r.Next(4)+1)
            {
                case 1:
                    return new DateOnly(2023, 9, r.Next(30) + 1);
                case 2:
                    return new DateOnly(2023, 10, r.Next(31) + 1);
                case 3:
                    return new DateOnly(2023, 11, r.Next(30) + 1);
                case 4:
                    return new DateOnly(2023, 12, r.Next(31)+1);
                default:
                    return DateOnly.FromDateTime(DateTime.Now);
            } 
        }
        public static void AddFechaAlquiler(DateTime fecha)
        {
            DateTime fechaMes = new DateTime(fecha.Year, fecha.Month, 1);
            if (ContadorPorFechasAlquileres.ContainsKey(fechaMes))
            {
                ContadorPorFechasAlquileres[fechaMes]++;
            }
            else
            {
                ContadorPorFechasAlquileres.Add((fechaMes), 1);
            }
        }
        public static void AddFechaVenta(DateTime fecha)
        {
            DateTime fechaMes = new DateTime(fecha.Year, fecha.Month, 1);
            if (ContadorPorFechasVentas.ContainsKey(fechaMes))
            {
                ContadorPorFechasVentas[fechaMes]++;
            }
            else
            {
                ContadorPorFechasVentas.Add(fechaMes, 1);
            }
        }
    }
}
