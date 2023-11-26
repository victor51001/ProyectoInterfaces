using InmoSolution.Clases;
using System;
using System.Collections.Generic;
using System.IO;
using MessagePack;

namespace InmoSolution.Controladores
{
    public class ControladorTransaccion
    {
        public static List<Transaccion> ListaTransacciones = new List<Transaccion>();
        public static bool cambios;

        public static void LeerTransacciones()
        {
            try
            {
                using (FileStream fs = new FileStream("transacciones.dat", FileMode.Open))
                {
                    ListaTransacciones = MessagePackSerializer.Deserialize<List<Transaccion>>(fs);
                }
            }
            catch (Exception)
            { }
        }

        public static void EscribirTransacciones()
        {
            try
            {
                using (FileStream fs = new FileStream("transacciones.dat", FileMode.Create))
                {
                    MessagePackSerializer.Serialize(fs, ListaTransacciones);
                }
            }
            catch (Exception)
            { }
        }
    }
}
