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
    public partial class ModificarEnVenta : Form
    {
        private Boolean[] cambios = new Boolean[5];
        private Clases.EnVenta enVenta;
        public ModificarEnVenta(Clases.EnVenta enVenta)
        {
            InitializeComponent();
            this.enVenta = enVenta;
        }

        private void ModificarEnVenta_Load(object sender, EventArgs e)
        {
            nudBaños.Controls[0].Visible = false;
            nudBaños.Minimum = 1;
            nudBaños.Maximum = 10;
            nudHabitaciones.Controls[0].Visible = false;
            nudHabitaciones.Minimum = 1;
            nudHabitaciones.Maximum = 10;
            nudMetros.Controls[0].Visible = false;
            nudAntiguedad.Controls[0].Visible = false;
            txtbxDireccion.Text = enVenta.Direccion;
            nudMetros.Value = enVenta.MetrosCuadrados;
            nudHabitaciones.Value = enVenta.Habitaciones;
            nudBaños.Value = enVenta.Baños;
            nudAntiguedad.Value = enVenta.Antiguedad;
            txtbxLocalidad.Text = enVenta.Localidad;
            nudMetros.Value = enVenta.MetrosCuadrados;
            nudPrecio.Value = enVenta.Precio;
            cmbxPropietario.DataSource = ControladorCliente.ListaClientes;
            cmbxPropietario.DisplayMember = "dni";
            cmbxPropietario.SelectedItem = enVenta.Propietario;
            cmbxPropietario.Enabled = false;
            cmbxDisponible.Enabled = false;
            if (enVenta.Disponible)
            {
                cmbxDisponible.SelectedIndex = 0;
            }
            else
            {
                cmbxDisponible.SelectedIndex = 1;
            }
        }

        private void nudHabitaciones_ValueChanged(object sender, EventArgs e)
        {
            if (nudHabitaciones.Value != enVenta.Habitaciones)
            {
                cambios[0] = true;
            }
            else
            {
                cambios[0] = false;
            }
        }

        private void nudBaños_ValueChanged(object sender, EventArgs e)
        {
            if (nudBaños.Value != enVenta.Baños)
            {
                cambios[1] = true;
            }
            else
            {
                cambios[1] = false;
            }
        }

        private void cmbxDisponible_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbxDisponible.SelectedValue == "Si")
            {
                cambios[2] = true;
            }
            else
            {
                cambios[2] = false;
            }
        }

        private void cmbxPropietario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbxPropietario.SelectedValue != enVenta.Propietario)
            {
                cambios[3] = true;
            }
            else
            {
                cambios[3] = false;
            }
        }

        private void nudPrecioMetro_ValueChanged(object sender, EventArgs e)
        {
            if (nudPrecioMetro.Value != enVenta.PrecioMetroCuadrado)
            {
                cambios[4] = true;
            }
            else
            {
                cambios[4] = false;
            }
        }

        private void bttnAceptar_Click(object sender, EventArgs e)
        {
            if (cambios.Contains(true))
            {
                DialogResult resultado = MessageBox.Show("¿Está seguro que desea modificar el inmueble?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    enVenta.Habitaciones = Convert.ToInt32(nudHabitaciones.Value);
                    enVenta.Baños = Convert.ToInt32(nudBaños.Value);
                    enVenta.Disponible = Convert.ToBoolean(cmbxDisponible.SelectedValue);
                    enVenta.Propietario = (Clases.Cliente)cmbxPropietario.SelectedValue;
                    enVenta.PrecioMetroCuadrado = Convert.ToInt32(nudPrecioMetro.Value);
                    enVenta.Precio = Convert.ToInt32(nudPrecio.Value);
                    enVenta.Direccion = txtbxDireccion.Text;
                    enVenta.Localidad = txtbxLocalidad.Text;
                    enVenta.MetrosCuadrados = Convert.ToInt32(nudMetros.Value);
                    enVenta.Antiguedad = Convert.ToInt32(nudAntiguedad.Value);
                    ControladorEnVenta.Cambios = true;
                    MessageBox.Show("Inmueble modificado correctamente", "Modificar inmueble", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
            else
            {
                MessageBox.Show("No se han realizado cambios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
