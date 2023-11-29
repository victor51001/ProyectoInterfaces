using InmoSolution.Controladores;
using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InmoSolution.Clases
{
    [Serializable]
    [ProtoContract]
    public class Usuario
    {
        //atributos
        [ProtoMember(1)]
        private int id;
        [ProtoMember(2)]
        private string nombre;
        [ProtoMember(3)]
        private string clave;

        //constructor
        public Usuario(string nombre, string clave)
        {
            Id = ControladorUsuario.id++;
            Nombre = nombre;
            Clave = clave;
        }
        public Usuario(int id, string nombre, string clave)
        {
            Id = id;
            Nombre = nombre;
            Clave = clave;
        }
        public Usuario() { }

        //getters y setters
        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Clave { get => clave; set => clave = value; }

        //metodos
        public override string ToString()
        {
            return Id + " " + Nombre;
        }
    }
}
