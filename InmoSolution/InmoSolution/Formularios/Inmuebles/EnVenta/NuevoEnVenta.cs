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

namespace InmoSolution.Formularios.Inmuebles.EnVenta
{
    public partial class NuevoEnVenta : Form
    {
        public NuevoEnVenta()
        {
            InitializeComponent();
        }

        private void bttnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NuevoEnVenta_Load(object sender, EventArgs e)
        {
            cmbxPropietario.DataSource = ControladorCliente.ListaClientes;
            cmbxPropietario.DisplayMember = "dni";
            nudAntiguedad.Controls[0].Visible = false;
            nudAntiguedad.Minimum = 0;
            nudAntiguedad.Maximum = 100;
            nudBaños.Controls[0].Visible = false;
            nudBaños.Minimum = 1;
            nudBaños.Maximum = 10;
            nudHabitaciones.Controls[0].Visible = false;
            nudHabitaciones.Minimum = 1;
            nudHabitaciones.Maximum = 10;
            nudMetros.Controls[0].Visible = false;
            nudMetros.Minimum = 1;
            nudMetros.Maximum = 2000;
            nudPrecioMetro.Controls[0].Visible = false;
            nudPrecioMetro.Minimum = 1000;
            nudPrecioMetro.Maximum = 5000;
        }
        private bool ValidarCampos()
        {
            bool validado = true;
            if (txtbxDireccion.Text == "")
            {
                validado = false;
                MessageBox.Show("Debes ingresar una direccion valida", "Error");
            }
            if (txtbxLocalidad.Text == "")
            {
                validado = false;
                MessageBox.Show("Debes ingresar una localidad valida", "Error");
            }
            return validado;
        }

        private void bttnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                string direccion = txtbxDireccion.Text;
                string localidad = txtbxLocalidad.Text;
                int antiguedad = Convert.ToInt32(nudAntiguedad.Value);
                int baños = Convert.ToInt32(nudBaños.Value);
                int habitaciones = Convert.ToInt32(nudHabitaciones.Value);
                int metros = Convert.ToInt32(nudMetros.Value);
                int precioMetro = Convert.ToInt32(nudPrecioMetro.Value);
                bool disponible = false;
                if (cmbxDisponible.SelectedItem.ToString() == "Si")
                {
                    disponible = true;
                }
                Cliente propietario = (Cliente)cmbxPropietario.SelectedItem;
                Clases.EnVenta enVenta = new Clases.EnVenta(direccion, baños, habitaciones, metros, antiguedad, disponible, propietario, localidad, precioMetro);
                ControladorEnVenta.ListaEnVenta.Add(enVenta);
                MessageBox.Show("En Venta creado correctamente", "Informacion");
                Close();
            }
        }
    }
}
