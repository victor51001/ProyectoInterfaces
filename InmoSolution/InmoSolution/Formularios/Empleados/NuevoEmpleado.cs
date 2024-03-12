using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using InmoSolution.Clases;
using InmoSolution.Controladores;
using InmoSolution.Formularios.Usuarios;

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
            if (!ValidarApellidos())
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
            if (txtbxDni.Text.Length == 9)
            {
                if (txtbxDni.Text.Substring(0, 8).All(char.IsDigit) &&
                    txtbxDni.Text.Substring(8, 1).All(char.IsLetter))
                {
                    if (txtbxDni.Text.Substring(8, 1).ToUpper() ==
                        CalcularLetraDni().ToString())
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private bool ValidarNombre()
        {
            if (ControladorUsuario.GetUsuario(txtbxNombre.Text) == null)
            {
                if (!String.IsNullOrEmpty(txtbxNombre.Text))
                {
                    string patron = "^[a-zA-Z\\s]+$";
                    Regex regex = new Regex(patron);
                    return regex.IsMatch(txtbxNombre.Text);
                }
            }
            return false;
        }
        private bool ValidarApellidos()
        {
            if (!String.IsNullOrEmpty(txtbxApellidos.Text) && txtbxApellidos.Text.Length>4)
            {
                string patron = "^[a-zA-Z\\s]+$";
                Regex regex = new Regex(patron);
                return regex.IsMatch(txtbxApellidos.Text);
            }
            return false;
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
                int id = ControladorUsuario.ListaUsuarios.Count + 10;
                string login = txtbxNombre.Text.ElementAt(0) + txtbxApellidos.Text.Substring(0, 4);
                Usuario user = new Usuario(id, login, txtbxNombre.Text, "clave$1");
                user.iniciado = false;
                ControladorUsuario.ListaUsuarios.Add(user);
                ControladorUsuario.Cambios = true;
                Empleado empleado = new Empleado(txtbxDni.Text, txtbxNombre.Text,
                    txtbxApellidos.Text, txtbxEmail.Text, (int)nudTelefono.Value,
                    user, (Empleado.Puestos)cmbxPuesto.SelectedItem);
                ControladorEmpleado.ListaEmpleados.Add(empleado);
                ControladorEmpleado.Cambios = true;
                MessageBox.Show("Empleado creado correctamente", "Info");
                Close();
            }
        }
    }
}
