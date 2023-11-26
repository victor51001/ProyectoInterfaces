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
        public static int id = 10;
        public static bool cambios;
        public static void LeerUsuarios()
        {
            try
            {
                Stream OpenFileStream = File.OpenRead("usuarios.msgpack");
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
                Stream SaveFileStream = File.Create("usuarios.msgpack");
                MessagePackSerializer.Serialize(SaveFileStream, ListaUsuarios);
                SaveFileStream.Close();
            }
            catch (Exception)
            { }
        }

        public static void EliminarUsuario(Usuario usu)
        {
            foreach (Usuario user in ListaUsuarios)
            {
                if (user == usu)
                {
                    ListaUsuarios.Remove(user);
                    return;
                }
            }
        }

        public static Usuario GetUsuario(string nombre)
        {
            foreach (Usuario user in ListaUsuarios)
            {
                if (user.Nombre == nombre)
                {
                    return user;
                }
            }
            return null;
        }

        public static bool existeUsuario(string nombre, string clave)
        {
            foreach (Usuario user in ListaUsuarios)
            {
                if (user.Nombre == nombre && user.Clave == clave)
                {
                    return true;
                }
            }
            return false;
        }

        public static void ModificarUsuario(Usuario user, string nombre, string clave)
        {
            if (nombre != null)
            {
                user.Nombre = nombre;
            }
            if (clave != null)
            {
                user.Clave = clave;
            }
        }
    }
}
