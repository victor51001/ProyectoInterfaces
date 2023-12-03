using InmoSolution.Controladores;
using InmoSolution.Formularios.Empleados;
using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

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
        private string login;
        [ProtoMember(3)]
        private string nombre;
        [ProtoMember(4)]
        private string clave;
        [XmlIgnore]
        [ProtoIgnore]
        public bool iniciado = false;

        //constructores
        public Usuario(int id,string login, string nombre, string clave)
        {
            Id = id;
            Login = login;
            Nombre = nombre;
            Clave = clave;
        }
        public Usuario() { }

        //getters y setters
        public int Id { get => id; set => id = value; }
        public string Login { get => login; set => login = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Clave { get => clave; set => clave = value; }

        //metodos
        public override string ToString()
        {
            return Id + " " + Login ;
        }

        public string GetPuesto()
        {
            foreach (Empleado emp in ControladorEmpleado.ListaEmpleados)
            {
                if (emp.Usuario.Id == this.Id)
                {
                    return emp.Puesto.ToString();
                }
            }
            return "nulo";
        }
        public bool ShouldSerializeClave()
        {
            return false;
        }
    }
}
