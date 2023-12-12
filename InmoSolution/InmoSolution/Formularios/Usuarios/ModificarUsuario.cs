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
            txtDni.Text = user.Id.ToString();
            txtbxNombre.Text = user.Nombre;
            txtbxClave.Text = user.Clave;
        }

        private bool ValidarNombre()
        {
            bool ok = false;
            if (!txtbxNombre.Text.Any<char>(char.IsDigit))
            {                
                ok = true;
            }
            return ok;
        }

        private void txtbxNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtbxNombre.Text.Equals(user.Nombre))
            {
                cambios[0] = false;
            }
            else
            {
                cambios[0] = ValidarNombre();
            }
        }

        private void bttnCambiarContraseña_Click(object sender, EventArgs e)
        {
            CambioDeContraseña frmCambio = new CambioDeContraseña(user);
            frmCambio.ShowDialog();
            string clave = frmCambio.ContraseñaDevuelta;
            if (!String.IsNullOrEmpty(clave))
            {
                txtbxClave.Text = clave;
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
            if (cambios[0])
            {
                nombre = txtbxNombre.Text;
            }
            if (cambios[1])
            {
                clave = txtbxClave.Text;
            }
            if (nombre != null)
            {
                user.Nombre = nombre;
            }
            if (clave != null)
            {
                user.Clave = clave;
            }
            if (c > 0)
            {
                MessageBox.Show("Usuario modificado correctamente", "Modificar usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ControladorUsuario.Cambios = true;
                Close();
            } else
            {
                MessageBox.Show("No se ha modificado ningún campo", "Modificar usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
