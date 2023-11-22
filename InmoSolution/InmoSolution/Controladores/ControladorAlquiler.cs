using InmoSolution.Clases;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class ControladorAlquiler
{
    public static List<Alquiler> ListaAlquileres = new List<Alquiler>();
    public static bool cambios;

    public static void LeerAlquileres()
    {
        try
        {
            string jsonString = File.ReadAllText("alquileres.json");
            ListaAlquileres = JsonSerializer.Deserialize<List<Alquiler>>(jsonString);
        }
        catch (Exception)
        { }
    }

    public static void EscribirAlquileres()
    {
        try
        {
            string jsonString = JsonSerializer.Serialize(ListaAlquileres);
            File.WriteAllText("alquileres.json", jsonString);
        }
        catch (Exception)
        { }
    }
}
