using InmoSolution.Clases;
using InmoSolution.Controladores;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

public class ControladorAlquiler
{
    public static List<Alquiler> ListaAlquileres = new List<Alquiler>();
    public static bool cambios;
    public static bool Cambios { get => cambios; set => cambios = value; }

    public static void LeerAlquileres()
    {
        try
        {
            string jsonString = File.ReadAllText("alquileres.json");
            ListaAlquileres = JsonSerializer.Deserialize<List<Alquiler>>(jsonString);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error al leer alquileres: {ex.Message}");
        }
    }

    public static void EscribirAlquileres()
    {
        try
        {
            string jsonString = JsonSerializer.Serialize(ListaAlquileres);
            File.WriteAllText("alquileres.json", jsonString, Encoding.UTF8);
        }
        catch (Exception ex)
        { 
            MessageBox.Show($"Error al escribir alquileres: {ex.Message}");
        }
    }
    public static bool ExisteFichero()
    {
        return File.Exists("alquileres.json");
    }

    public static Alquiler GenerarAlquiler()
    {   
        Random r = new Random();
        KeyValuePair<string, string> dirLoc = ControladorInmueble.GenerarDireccionLocalidad();
        string direccion = dirLoc.Value;
        int habitaciones = r.Next(1, 6);
        int baños = r.Next(1, 4);
        int metrosCuadrados = r.Next(40, 201);
        int antiguedad = r.Next(0, 11);
        Cliente propietario = ControladorCliente.ListaClientes[r.Next(ControladorCliente.ListaClientes.Count)];
        string localidad = dirLoc.Key;
        bool disponible = true;
        return new Alquiler(direccion, habitaciones, baños, metrosCuadrados, antiguedad, disponible, propietario, localidad);
    }
}
