using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InmoSolution.Clases;
using InmoSolution.Controladores;

namespace InmoSolution.Formularios.Empleados
{
    public partial class NuevoEmpleado : Form
    {
        public NuevoEmpleado()
        {
            InitializeComponent();
        }

        private void NuevoEmpleado_Load(object sender, EventArgs e)
        {
            cmbxPuesto.DataSource = Enum.GetValues(typeof(Empleado.Puestos));
            nudTelefono.Controls[0].Visible = false;
            nudTelefono.Width = nudTelefono.Controls[1].Width;
        }

        private bool ValidarCampos()
        {
            bool validado = true;
            if (!ValidarDni())
            {
                validado = false;
                MessageBox.Show("Debes ingresar un DNI valido", "Error");
            }
            if (!ValidarNombre())
            {
                validado = false;
                MessageBox.Show("Debes ingresar un nombre valido", "Error");
            }
            if (txtbxApellidos.Text == "" || txtbxApellidos.Text.Any<char>(char.IsDigit))
            {
                validado = false;
                MessageBox.Show("Debes ingresar apellidos validos", "Error");
            }
            if (!ValidarEmail())
            {
                validado = false;
                MessageBox.Show("Debes ingresar un email valido", "Error");
            }
            if (nudTelefono.Value.ToString().Length != 9)
            {
                validado = false;
                MessageBox.Show("Debe introducir un numero de telefono valido", "Error");
            }
            if (cmbxPuesto.SelectedIndex == -1)
            {
                validado = false;
                MessageBox.Show("Debe seleccionar un puesto", "Error");
            }
            return validado;
        }

        private bool ValidarDni()
        {
            bool ok = false;
            if (txtbxDni.Text.Length == 9)
            {
                if (txtbxDni.Text.Substring(0, 8).All(char.IsDigit) &&
                    txtbxDni.Text.Substring(8, 1).All(char.IsLetter))
                {
                    if (txtbxDni.Text.Substring(8, 1).ToUpper() ==
                        CalcularLetraDni().ToString())
                    {
                        ok = true;
                    }
                }
            }
            return ok;
        }

        private bool ValidarNombre()
        {
            bool ok = false;
            if (ControladorUsuario.GetUsuario(txtbxNombre.Text) != null)
            {
                ok = true;
            }            
            return ok;
        }
        private bool ValidarEmail()
        {
            bool ok = false;
            if (txtbxEmail.Text.Contains("@") || txtbxEmail.Text.Contains("."))
            {
                if (txtbxEmail.Text.Split("@").Length == 2 &&
                    txtbxEmail.Text.Split("@")[1].Split(".").Length == 2)
                {
                    ok = true;
                }
            }
            return ok;
        }

        private char CalcularLetraDni()
        {
            string letras = "TRWAGMYFPDXBNJZSQVHLCKE";
            int dni = int.Parse(txtbxDni.Text.Substring(0, 8));
            return letras[dni % 23];
        }

        private void bttnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bttnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                Usuario user = ControladorUsuario.GetUsuario(txtbxNombre.Text);
                Empleado empleado = new Empleado(txtbxDni.Text, txtbxNombre.Text,
                    txtbxApellidos.Text, txtbxEmail.Text, (int)nudTelefono.Value,
                    user, (Empleado.Puestos)cmbxPuesto.SelectedItem);
            }
        }
    }
}
