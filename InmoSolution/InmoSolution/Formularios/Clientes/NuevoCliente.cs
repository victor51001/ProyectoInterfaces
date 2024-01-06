using InmoSolution.Clases;
using InmoSolution.Controladores;
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

namespace InmoSolution.Formularios.Clientes
{
    public partial class NuevoCliente : Form
    {
        public NuevoCliente()
        {
            InitializeComponent();
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
            if (!String.IsNullOrEmpty(txtbxNombre.Text))
            {
                string patron = "^[a-zA-Z]+$";
                Regex regex = new Regex(patron);
                return regex.IsMatch(txtbxNombre.Text);
            }
            return false;
        }
        private bool ValidarApellidos()
        {
            if (!String.IsNullOrEmpty(txtbxApellidos.Text))
            {
                string patron = "^[a-zA-Z]+$";
                Regex regex = new Regex(patron);
                return regex.IsMatch(txtbxApellidos.Text);
            }
            return false;
        }
        private bool ValidarEmail()
        {
            if (txtbxEmail.Text.Split("@").Length == 2 &&
                txtbxEmail.Text.Split("@")[1].Split(".").Length == 2)
            {
                return true;
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
                string dni = txtbxDni.Text;
                string nombre = txtbxNombre.Text;
                string apellidos = txtbxApellidos.Text;
                int telefono = Convert.ToInt32(nudTelefono.Value);
                string email = txtbxEmail.Text;
                Cliente cliente = new Cliente(dni, nombre, apellidos, telefono, email);
                ControladorCliente.ListaClientes.Add(cliente);
                ControladorCliente.Cambios = true;
                MessageBox.Show("Cliente creado correctamente", "Informacion");
                Close();
            }
        }
    }
}
