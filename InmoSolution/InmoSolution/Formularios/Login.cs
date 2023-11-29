using InmoSolution.Clases;
using InmoSolution.Controladores;
using InmoSolution.Formularios;
using InmoSolution.Formularios.Usuarios;

namespace InmoSolution
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            if (ControladorUsuario.ExisteFichero())
            {
                ControladorUsuario.LeerUsuarios();
            } 
            else
            {
                // Crear usuarios
                Usuario adminUser = new Usuario(0, "admin", "1234");
                Usuario usuario1 = new Usuario("Juan", "5678");
                Usuario usuario2 = new Usuario("Ana", "9012");
                Usuario usuario3 = new Usuario("Pedro", "3456");
                Usuario usuario4 = new Usuario("María", "7890");
                Usuario usuario5 = new Usuario("Carlos", "2345");
                ControladorUsuario.ListaUsuarios.AddRange(new List<Usuario> { adminUser, usuario1, usuario2, usuario3, usuario4, usuario5 });
                ControladorUsuario.EscribirUsuarios();
            }
        }

        private void lbllnkCrear_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NuevoUsuario frmNuevoUsuario = new NuevoUsuario();
            frmNuevoUsuario.ShowDialog();
        }

        private int vueltas = 0;
        private void bttnEntrar_Click(object sender, EventArgs e)
        {
            if (ControladorUsuario.ExisteUsuario(txtbxUsuario.Text, txtbxClave.Text))
            {
                Principal FrmP = new Principal(ControladorUsuario.GetUsuario(txtbxUsuario.Text));
                txtbxUsuario.Clear();
                txtbxClave.Clear();
                FrmP.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Usuario o clave incorrectos");
                txtbxUsuario.Clear();
                txtbxClave.Clear();
            }
            if (vueltas == 3)
            {
                Application.Exit();
            }
            vueltas++;
        }
    }
}
