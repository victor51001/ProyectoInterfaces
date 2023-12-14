using InmoSolution.Clases;
using InmoSolution.Controladores;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InmoSolution.Formularios.Clientes
{
    public partial class ModificarCliente : Form
    {
        private Boolean[] cambios = new Boolean[4];
        private Cliente cliente;
        public ModificarCliente(Cliente cl)
        {
            InitializeComponent();
            cliente = cl;
        }

        private void txtbxNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtbxNombre.Text.Equals(cliente.Nombre))
            {
                cambios[0] = false;
            }
            else
            {
                cambios[0] = ValidarNombre();
            }
        }

        private void txtbxApellidos_TextChanged(object sender, EventArgs e)
        {
            if (txtbxApellidos.Text.Equals(cliente.Apellidos))
            {
                cambios[1] = false;
            }
            else
            {
                cambios[1] = ValidarApellidos();
            }
        }

        private void nudTelefono_ValueChanged(object sender, EventArgs e)
        {
            if (nudTelefono.Value.Equals(cliente.Telefono))
            {
                cambios[2] = false;
            }
            else
            {
                cambios[2] = ValidarTelefono();
            }
        }

        private void txtbxEmail_TextChanged(object sender, EventArgs e)
        {
            if (txtbxEmail.Text.Equals(cliente.Email))
            {
                cambios[3] = false;
            }
            else
            {
                cambios[3] = ValidarEmail();
            }
        }
        private bool ValidarNombre()
        {
            bool ok = false;
            if (!txtbxNombre.Text.Any<char>(char.IsDigit) && !string.IsNullOrEmpty(txtbxNombre.Text))
            {
                ok = true;
            }
            return ok;
        }

        private bool ValidarApellidos()
        {
            bool ok = false;
            if (!txtbxApellidos.Text.Any<char>(char.IsDigit) && !string.IsNullOrEmpty(txtbxApellidos.Text))
            {
                ok = true;
            }
            return ok;
        }

        private bool ValidarTelefono()
        {
            bool ok = false;
            if (nudTelefono.Value.ToString().Length == 9)
            {
                ok = true;
            }
            return ok;
        }

        private bool ValidarEmail()
        {
            bool ok = false;
            if (txtbxEmail.Text.Split("@").Length == 2 && txtbxEmail.Text.Split("@")[1].Split(".").Length == 2)
            {
                ok = true;
            }
            return ok;
        }

        private void bttnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bttnAceptar_Click(object sender, EventArgs e)
        {
            string nombre = null;
            string apellidos = null;
            int telefono = 0;
            string email = null;
            int c = 0;
            c = cambios.Count(x => x == true);
            if (c > 0)
            {
                if (cambios[0])
                {
                    cliente.Nombre = txtbxNombre.Text;
                }
                if (cambios[1])
                {
                    cliente.Apellidos = txtbxApellidos.Text;
                }
                if (cambios[2])
                {
                    cliente.Telefono = Convert.ToInt32(nudTelefono.Value);
                }
                if (cambios[3])
                {
                    cliente.Email = txtbxEmail.Text;
                }
                MessageBox.Show("Cliente modificado correctamente", "Modificar cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ControladorCliente.Cambios = true;
                Close();
            }
            else
            {
                MessageBox.Show("No se ha modificado ningún campo", "Modificar cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ModificarCliente_Load(object sender, EventArgs e)
        {
            txtbxDni.Text = cliente.Dni;
            txtbxNombre.Text = cliente.Nombre;
            txtbxApellidos.Text = cliente.Apellidos;
            nudTelefono.Value = cliente.Telefono;
            txtbxEmail.Text = cliente.Email;
            nudTelefono.Controls[0].Visible = false;
            nudTelefono.Width += nudTelefono.Controls[0].Width;
        }
    }
}
