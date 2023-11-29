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
    }
}
