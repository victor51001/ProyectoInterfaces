using ProtoBuf;

namespace InmoSolution.Clases
{
    [ProtoContract]
    public class Cliente
    {
        //atributos
        [ProtoMember(1)]
        private string dni;
        [ProtoMember(2)]
        private string nombre;
        [ProtoMember(3)]
        private string apellidos;
        [ProtoMember(4)]
        private int telefono;
        [ProtoMember(5)]
        private string email;
        
        //constructores
        public Cliente(string dni, string nombre, string apellidos, int telefono, string email)
        {
            this.Dni = dni;
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.Telefono = telefono;
            this.Email = email;
        }
        public Cliente() { }

        //getters y setters
        public string Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public string Email { get => email; set => email = value; }

        //metodos
        public override string ToString()
        {
            return $"{Dni}     {Nombre,-15}     {Apellidos,-15}     {Telefono} {Email,-15}";

        }
    }
}
