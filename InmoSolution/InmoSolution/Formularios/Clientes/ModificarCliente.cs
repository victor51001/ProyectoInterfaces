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
            if (txtbxNombre.Text.Equals(cliente.Nombre))
            {
                cambios[0] = false;
            }
            else
            {
                cambios[0] = ValidarNombre();
            }
        }

        private bool ValidarApellidos()
        {
            bool ok = false;
            if (!txtbxApellidos.Text.Any<char>(char.IsDigit))
            {
                ok = true;
            }
            return ok;
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
            if (cambios[0])
            {
                nombre = txtbxNombre.Text;
            }
            if (cambios[1])
            {
                apellidos = txtbxApellidos.Text;
            }
            if (cambios[2])
            {
                telefono = Convert.ToInt32(nudTelefono.Value);
            }
            if (cambios[3])
            {
                email = txtbxEmail.Text;
            }
            if (nombre!=null)
            {
                cliente.Nombre = nombre;
            }
            if (apellidos!=null)
            {
                cliente.Apellidos = apellidos;
            }
            if (telefono!=0)
            {
                cliente.Telefono = telefono;
            }
            if (email!=null)
            {
                cliente.Email = email;
            }
            if (c > 0)
            {
                MessageBox.Show("Cliente modificado correctamente", "Modificar cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ControladorUsuario.Cambios = true;
                Close();
            } else
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

        private bool ValidarTelefono()
        {
            bool ok = false;
            if (nudTelefono.Value.ToString().Length == 9)
            {
                ok = true;
            }
            return ok;
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

        private bool ValidarEmail()
        {
            bool ok = false;
            if (txtbxEmail.Text.Split("@").Length == 2 && txtbxEmail.Text.Split("@")[1].Split(".").Length == 2)
            {
                ok = true;
            }
            return ok;
        }
    }
}
