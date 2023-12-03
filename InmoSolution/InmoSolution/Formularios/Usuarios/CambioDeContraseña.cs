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
    public partial class CambioDeContraseña : Form
    {
        private Usuario user;
        public static string contraseñaDevuelta;
        public CambioDeContraseña(Usuario usu)
        {
            InitializeComponent();
            user = usu;
            contraseñaDevuelta = null;
            if (!usu.iniciado)
            {
                bttnCancelar.Enabled = false;
            }
        }

        private void bttnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bttnAceptar_Click(object sender, EventArgs e)
        {
            if (txtbxClave1.Text.Equals(txtbxClave2.Text))
            {
                contraseñaDevuelta = txtbxClave1.Text.ToString();
                Close();
            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pbxClave1_Click(object sender, EventArgs e)
        {
            if (txtbxClave1.PasswordChar.Equals('*'))
            {
                txtbxClave1.PasswordChar = '\0';
                pbxClave1.Image = Properties.Resources.invisible;
            }
            else
            {
                txtbxClave1.PasswordChar = '*';
                pbxClave1.Image = Properties.Resources.visible;
            }
        }

        private void pbxClave2_Click(object sender, EventArgs e)
        {
            if (txtbxClave2.PasswordChar.Equals('*'))
            {
                txtbxClave2.PasswordChar = '\0';
                pbxClave2.Image = Properties.Resources.invisible;
            }
            else
            {
                txtbxClave2.PasswordChar = '*';
                pbxClave2.Image = Properties.Resources.visible;
            }
        }
    }
}
