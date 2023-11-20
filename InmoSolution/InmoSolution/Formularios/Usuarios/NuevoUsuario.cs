using Inicio_Y_Portal;
using InmoSolution.Clases;
using InmoSolution.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InmoSolution.Formularios.Usuarios
{
    public partial class NuevoUsuario : Form
    {
        public NuevoUsuario()
        {
            InitializeComponent();
        }
        private Boolean ValidarCampos()
        {
            Boolean validar = true;
            if (string.IsNullOrEmpty(txtbxUser.Text))
            {
                txtbxUser.BackColor = Color.Red;
                validar = false;
            }
            if (string.IsNullOrEmpty(txtbxPass1.Text))
            {
                txtbxPass1.BackColor = Color.Red;
                validar = false;
            }
            if (string.IsNullOrEmpty(txtbxPass2.Text))
            {
                txtbxPass2.BackColor = Color.Red;
                validar = false;
            }
            ControladorUsuario.ListaUsuarios.ForEach(u =>
            {
                if (u.Nombre.Equals(txtbxUser.Text))
                {
                    MessageBox.Show("El usuario ya existe");
                    validar = false;
                }
            });
            if (!(txtbxPass1.Text.Equals(txtbxPass2.Text)))
            {
                MessageBox.Show("Las contraseñas no coinciden");
                validar = false;
            }
            return validar;
        }
        private void LimpiarCampos()
        {
            txtbxUser.Clear();
            txtbxPass1.Clear();
            txtbxPass2.Clear();
        }
        private void bttnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                Usuario u = new Usuario(
                    txtbxUser.Text,
                    txtbxPass1.Text
                    );
                ControladorUsuario.ListaUsuarios.Add(u);
                ControladorUsuario.cambios = true;
                LimpiarCampos();
                TerminarAlta frmTAP = new TerminarAlta();
                frmTAP.ShowDialog();
                if (!frmTAP.valor)
                {
                    Close();
                }
            }
        }

        private void NuevoUsuario_Load(object sender, EventArgs e)
        {
            Color backColorLabel = Color.FromArgb(100, Color.Beige);
            lblUser.BackColor = backColorLabel;
            lblPassword1.BackColor = backColorLabel;
            lblPassword2.BackColor = backColorLabel;
        }

        private void bttnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (txtbxPass1.PasswordChar.Equals('*'))
            {
                txtbxPass1.PasswordChar = '\0';
                pbxPass1.Image = Properties.Resources.invisible;
            }
            else
            {
                txtbxPass1.PasswordChar = '*';
                pbxPass1.Image = Properties.Resources.visible;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (txtbxPass2.PasswordChar.Equals('*'))
            {
                txtbxPass2.PasswordChar = '\0';
                pbxPass2.Image = Properties.Resources.invisible;
            }
            else
            {
                txtbxPass2.PasswordChar = '*';
                pbxPass2.Image = Properties.Resources.visible;
            }
        }
    }
}
