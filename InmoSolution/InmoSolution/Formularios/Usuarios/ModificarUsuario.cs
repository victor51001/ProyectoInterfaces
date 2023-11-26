using InmoSolution.Clases;
using InmoSolution.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InmoSolution.Formularios.Usuarios
{
    public partial class ModificarUsuario : Form
    {
        private Boolean[] cambios = new Boolean[2];
        private Usuario user;
        public ModificarUsuario(Usuario usu)
        {
            InitializeComponent();
            user = usu;
        }

        private void ModificarUsuario_Load(object sender, EventArgs e)
        {
            txtId.Text = user.Id.ToString();
            txtbxNombre.Text = user.Nombre;
            txtbxClave.Text = user.Clave;
        }

        private bool ValidarNombre()
        {
            bool ok = false;
            if (ControladorUsuario.GetUsuario(txtbxNombre.Text) == null &&
                txtbxNombre.Text.Any<char>(char.IsDigit))
            {
                ok = true;
            }
            return ok;
        }

        private void txtbxNombre_TextChanged(object sender, EventArgs e)
        {
            if (ValidarNombre())
            {
                cambios[0] = true;
            }
            else
            {
                cambios[0] = false;
            }
        }

        private void bttnCambiarContraseña_Click(object sender, EventArgs e)
        {
            CambioDeContraseña frmCambio = new CambioDeContraseña(user);
            frmCambio.ShowDialog();
            if (CambioDeContraseña.contraseñaDevuelta != null)
            {
                txtbxClave.Text = CambioDeContraseña.contraseñaDevuelta;
                cambios[1] = true;
            }
            else
            {
                cambios[1] = false;
            }
        }

        private void bttnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bttnAceptar_Click(object sender, EventArgs e)
        {
            string nombre = null;
            string clave = null;
            int c = 0;
            c = cambios.Count(x => x == true);
            switch (c)
            {
                case 0:
                    MessageBox.Show("No se han realizado cambios", "Modificar usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 1:
                    nombre = txtbxNombre.Text;
                    break;
                case 2:
                    clave = txtbxClave.Text;
                    break;
            }
            ControladorUsuario.ModificarUsuario(user,nombre, clave);
        }
    }
}
