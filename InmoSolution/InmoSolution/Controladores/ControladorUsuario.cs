using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;
using InmoSolution.Clases;
using MessagePack;

namespace InmoSolution.Controladores
{
    public class ControladorUsuario
    {
        public static List<Usuario> ListaUsuarios = new List<Usuario>();
        public static bool cambios;
        public static void LeerUsuarios()
        {
            try
            {
                Stream OpenFileStream = File.OpenRead("usuarios.bin");
                ListaUsuarios = MessagePackSerializer.Deserialize<List<Usuario>>(OpenFileStream);
                OpenFileStream.Close();
            }
            catch (Exception)
            { }
        }
        public static void EscribirUsuarios()
        {
            try
            {
                Stream SaveFileStream = File.Create("usuarios.bin");
                MessagePackSerializer.Serialize(SaveFileStream, ListaUsuarios);
                SaveFileStream.Close();
            }
            catch (Exception)
            { }
        }
    }
}
