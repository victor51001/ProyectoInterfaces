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

        public static void ModificarUsuario(int id, string nombre, string clave)
        {
            foreach (Usuario user in ListaUsuarios)
            {
                if (user.Id == id)
                {
                    if (!nombre.Equals(user.Nombre))
                    {
                        user.Nombre = nombre;
                    }
                    if (!clave.Equals(""))
                    {
                        user.Clave = clave;
                    }
                    return;
                }
            }
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
    }
}
