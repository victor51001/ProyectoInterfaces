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
            catch (Exception)
            { }
        }
        public static void EscribirClientes()
        {
            try
            {
                var serializer = new SerializerBuilder()
                .WithNamingConvention(CamelCaseNamingConvention.Instance)
                .Build();
                var yamlString = serializer.Serialize(ListaClientes);
                MessageBox.Show("Escribiendo clientes... {}" + yamlString);
                File.WriteAllText("clientes.yml", yamlString);
            }
            catch (Exception)
            { }
        }
        public static bool ExisteFichero()
        {
            return File.Exists("clientes.yml");
        }
    }
}
