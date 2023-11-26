using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;
using System.Runtime.Serialization.Formatters.Binary;
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
                using (FileStream fs = new FileStream("usuarios.bin", FileMode.Open))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
#pragma warning disable SYSLIB0011 // El tipo o el miembro están obsoletos
                    ListaUsuarios = (List<Usuario>)formatter.Deserialize(fs);
#pragma warning restore SYSLIB0011 // El tipo o el miembro están obsoletos
                }
            }
            catch (Exception)
            { }
        }
        public static void EscribirUsuarios()
        {
            try
            {
                FileStream fs = new FileStream("usuarios.bin", FileMode.Create);
                BinaryFormatter formatter = new BinaryFormatter();
#pragma warning disable SYSLIB0011 // El tipo o el miembro están obsoletos
                formatter.Serialize(fs, ListaUsuarios);
#pragma warning restore SYSLIB0011 // El tipo o el miembro están obsoletos
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

        public static Usuario GetUsuario(int id)
        {
            foreach (Usuario user in ListaUsuarios)
            {
                if (user.Id == id)
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
