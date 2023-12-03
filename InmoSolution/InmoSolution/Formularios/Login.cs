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
                Usuario adminUser = new Usuario(0, "admin", "Juan", "1234");
                adminUser.iniciado = true;
                ControladorUsuario.ListaUsuarios.Add(adminUser);
                ControladorUsuario.EscribirUsuarios();
            }
        }

        private int vueltas = 0;
        private void bttnEntrar_Click(object sender, EventArgs e)
        {
            if (ControladorUsuario.ExisteUsuario(txtbxUsuario.Text, txtbxClave.Text))
            {
                Usuario usuario = ControladorUsuario.GetUsuario(txtbxUsuario.Text);
                if (!usuario.iniciado)
                {
                    MessageBox.Show("Es la primera vez que inicia sesión, debe cambiar la contraseña", "Cambio de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CambioDeContraseña FrmCambio = new CambioDeContraseña(usuario);                    
                    FrmCambio.ShowDialog();
                    usuario.iniciado = true;
                }
                Principal FrmP = new Principal(usuario);
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
