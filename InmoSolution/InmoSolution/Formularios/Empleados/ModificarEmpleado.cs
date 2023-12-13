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
    public partial class ModificarEmpleado : Form
    {
        private Boolean[] cambios = new Boolean[3];
        private Empleado empleado;
        public ModificarEmpleado(Empleado emp)
        {
            InitializeComponent();
            empleado = emp;
        }

        private void ModificarEmpleado_Load(object sender, EventArgs e)
        {
            txtDni.Text = empleado.Dni.ToString();
            txtbxNombre.Text = empleado.Nombre;
            txtbxApellidos.Text = empleado.Apellidos;
            nudTelefono.Value = empleado.Telefono;
            txtbxEmail.Text = empleado.Email.ToString();
            cmbxPuesto.DataSource = Enum.GetValues(typeof(Empleado.Puestos));
            cmbxPuesto.SelectedItem = empleado.Puesto;
        }

        private void nudTelefono_ValueChanged(object sender, EventArgs e)
        {
            if (ValidarTelefono())
            {
                cambios[0] = true;
            }
            else
            {
                cambios[0] = false;
            }
        }

        private void txtbxEmail_TextChanged(object sender, EventArgs e)
        {
            if (ValidarEmail())
            {
                cambios[1] = true;
            }
            else
            {
                cambios[1] = false;
            }
        }

        private void cmbxPuesto_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!cmbxPuesto.SelectedItem.Equals(empleado.Puesto))
            {
                cambios[2] = true;
            } else
            {
                cambios[2] = false;
            }
        }

        private bool ValidarTelefono()
        {
            if (nudTelefono.Value.ToString().Length != 9)
            {
                MessageBox.Show("El teléfono debe tener 9 dígitos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool ValidarEmail()
        {
            if (txtbxEmail.Text.Contains("@") || txtbxEmail.Text.Contains("."))
            {
                if (txtbxEmail.Text.Split("@").Length == 2 &&
                    txtbxEmail.Text.Split("@")[1].Split(".").Length == 2)
                {
                    return true;
                }
            }
            return false;
        }

        private void bttnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bttnAceptar_Click(object sender, EventArgs e)
        {
            int telefono = 0;
            string email = null;
            Empleado.Puestos puesto = Empleado.Puestos.nulo;

            int c = 0;
            c += cambios.Count(b => b == true);
            if (c > 0)
            {
                switch (c)
                {
                    case 1:
                        telefono = (int)nudTelefono.Value;
                        break;
                    case 2:
                        email = txtbxEmail.Text;
                        break;
                    case 3:
                        puesto = (Empleado.Puestos)cmbxPuesto.SelectedItem;
                        break;
                }
                ControladorEmpleado.ModificarEmpleado(
                    empleado,
                    telefono,
                    email,
                    puesto
                    );
                ControladorEmpleado.Cambios = true;
                Close();
            } else
            {
                MessageBox.Show("No se ha modificado ningún campo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
