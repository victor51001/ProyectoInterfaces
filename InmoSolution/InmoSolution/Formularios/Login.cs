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
            Color backColorSesion = Color.FromArgb(128, Color.WhiteSmoke);
            lblSesion.BackColor = backColorSesion;
            Color backColorLink = Color.FromArgb(156, Color.LightGoldenrodYellow);
            lbllnkCrear.BackColor = backColorLink;
        }
        private Boolean ValidaUsuario()
        {
            int posicion = ControladorUsuario.ListaUsuarios.FindIndex(x => x.Nombre == txtbxUsuario.Text.ToLower());
            if (posicion != -1 && ControladorUsuario.ListaUsuarios[posicion].Clave == txtbxClave.Text)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void lbllnkCrear_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NuevoUsuario frmNU = new NuevoUsuario();
            frmNU.ShowDialog();
        }

        private int vueltas = 0;
        private void bttnEntrar_Click(object sender, EventArgs e)
        {
            if (ValidaUsuario())
            {
                txtbxUsuario.Clear();
                txtbxClave.Clear();
                Principal FrmP = new Principal();
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
        }
    }
}
