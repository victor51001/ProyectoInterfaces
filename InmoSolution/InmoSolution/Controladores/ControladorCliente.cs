using InmoSolution.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace InmoSolution.Controladores
{
    public class ControladorCliente
    {
        public static List<Cliente> ListaClientes = new List<Cliente>();
        public static bool cambios;
        public static bool Cambios { get => cambios; set => cambios = value; }
        public static void LeerClientes()
        {
            try
            {
                string yamlString = File.ReadAllText("clientes.yml");
                var deserializer = new DeserializerBuilder()
                .WithNamingConvention(CamelCaseNamingConvention.Instance)
                .Build();
                ListaClientes = deserializer.Deserialize<List<Cliente>>(yamlString);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al leer clientes: {ex.Message}");
            }
        }
        public static void EscribirClientes()
        {
            try
            {
                var serializer = new SerializerBuilder()
                .WithNamingConvention(CamelCaseNamingConvention.Instance)
                .Build();
                var yamlString = serializer.Serialize(ListaClientes);
                File.WriteAllText("clientes.yml", yamlString);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al escribir clientes: {ex.Message}");
            }
        }
        public static bool ExisteFichero()
        {
            return File.Exists("clientes.yml");
        }
        public static char CalcularLetraDNI(int numerosDNI)
        {
            char[] letrasDNI = { 'T', 'R', 'W', 'A', 'G', 'M', 'Y', 'F', 'P', 'D', 'X', 'B', 'N', 'J', 'Z', 'S', 'Q', 'V', 'H', 'L', 'C', 'K', 'E' };

            int resto = numerosDNI % 23;

            return letrasDNI[resto];
        }
        public static Cliente GenerarCliente()
        {
            string[] nombres = { "Antonio", "Elena", "Javier", "Carmen", "Alberto", "María", "Pedro", "Isabel", "Luis", "Ana" };
            string[] apelli2 = { "Gómez", "Fernández", "Martínez", "Rodríguez", "Sánchez", "López", "García", "Pérez", "Martín", "Ruiz" };
            string[] dominiosEmail = { "gmail.com", "hotmail.com", "yahoo.com", "outlook.com" };
            Random rand = new Random();

            int numerosDNI = rand.Next(10000000, 99999999);
            string dni = numerosDNI.ToString() + CalcularLetraDNI(numerosDNI);
            string nombre = nombres[rand.Next(nombres.Length)];
            string apellidos = $"{apelli2[rand.Next(apelli2.Length)]} {apelli2[rand.Next(apelli2.Length)]}";
            int telefono = (int)rand.Next(600000000, 799999999);
            string email = $"{nombre.ToLower()}@{dominiosEmail[rand.Next(dominiosEmail.Length)]}";

            return new Cliente(dni, nombre, apellidos, telefono, email);
        }
    }
}
