using InmoSolution.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

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
                using (FileStream fs = new FileStream("transacciones.bin", FileMode.Open))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
#pragma warning disable SYSLIB0011 // El tipo o el miembro están obsoletos
                    ListaTransacciones = (List<Transaccion>)formatter.Deserialize(fs);
#pragma warning restore SYSLIB0011 // El tipo o el miembro están obsoletos
                }
            }
            catch (Exception)
            { }
            
        }

        public static void EscribirTransacciones()
        {
            try
            {
                FileStream fs = new FileStream("transacciones.bin", FileMode.Create);                
                BinaryFormatter formatter = new BinaryFormatter();
#pragma warning disable SYSLIB0011 // El tipo o el miembro están obsoletos
                formatter.Serialize(fs, ListaTransacciones);
#pragma warning restore SYSLIB0011 // El tipo o el miembro están obsoletos
                
            }
            catch (Exception)
            { }
        }
    }
}
