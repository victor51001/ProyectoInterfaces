using InmoSolution.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
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

        public static bool ModificarCliente(Cliente cliente, Dictionary<string, object> campos)
        {
            bool resultado = true;
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=F:\\Repos\\victor51001\\ProyectoInterfaces\\InmoSolution\\InmoSolution\\InmoDatabase.mdf;Integrated Security=True";

            try
            {
                using (SqlConnection cnn = new SqlConnection(connectionString))
                {
                    cnn.Open();
                    SqlCommand comando = cnn.CreateCommand();
                    comando.CommandType = CommandType.Text;

                    StringBuilder setClause = new StringBuilder("SET ");

                    foreach (var campo in campos)
                    {
                        setClause.Append($"{campo.Key}=@{campo.Key}, ");
                        comando.Parameters.AddWithValue($"@{campo.Key}", campo.Value);
                    }

                    if (campos.Count > 0)
                    {
                        setClause.Length -= 2;
                    }

                    comando.CommandText = $"UPDATE cliente {setClause.ToString()} WHERE dni=@dni";
                    comando.Parameters.AddWithValue("@dni", cliente.Dni);

                    SqlDataAdapter adaptador = new SqlDataAdapter();
                    adaptador.UpdateCommand = comando;

                    if (adaptador.UpdateCommand.ExecuteNonQuery() == 0)
                    {
                        resultado = false;
                    }
                    adaptador.Dispose();
                    comando.Dispose();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al actualizar " + e.Message);
                resultado = false;
            }

            return resultado;
        }

        public static void insertarCliente(Cliente cliente)
        {
            string dni = cliente.Dni;
            string nombre = cliente.Nombre;
            string apellidos = cliente.Apellidos;
            int telefono = cliente.Telefono;
            string email = cliente.Email;
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=F:\\Repos\\victor51001\\ProyectoInterfaces\\InmoSolution\\InmoSolution\\InmoDatabase.mdf;Integrated Security=True";
            string query = "INSERT INTO Cliente (Dni, Nombre, Apellidos, Telefono, Email) VALUES (@Dni, @Nombre, @Apellidos, @Telefono, @Email)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Dni", dni);
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@Apellidos", apellidos);
                    command.Parameters.AddWithValue("@Telefono", telefono);
                    command.Parameters.AddWithValue("@Email", email);
                    try
                    {
                        int registrosAfectados = command.ExecuteNonQuery();
                        MessageBox.Show($"Se insertó correctamente el registro. Registros afectados: {registrosAfectados}");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al insertar el registro: {ex.Message}");
                    }
                }
            }
        }
    }
}
