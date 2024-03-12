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

namespace InmoSolution.Formularios.Inmuebles.Alquileres
{
    public partial class ModificarAlquiler : Form
    {
        private Boolean[] cambios = new Boolean[4];
        private Alquiler alquiler;
        public ModificarAlquiler(Alquiler alquiler)
        {
            InitializeComponent();
            this.alquiler = alquiler;
        }

        private void bttnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ModificarAlquiler_Load(object sender, EventArgs e)
        {
            nudBaños.Controls[0].Visible = false;
            nudBaños.Minimum = 1;
            nudBaños.Maximum = 10;
            nudHabitaciones.Controls[0].Visible = false;
            nudHabitaciones.Minimum = 1;
            nudHabitaciones.Maximum = 10;
            nudMetros.Controls[0].Visible = false;
            nudAntiguedad.Controls[0].Visible = false;
            txtbxDireccion.Text = alquiler.Direccion;
            nudMetros.Value = alquiler.MetrosCuadrados;
            nudHabitaciones.Value = alquiler.Habitaciones;
            nudBaños.Value = alquiler.Baños;
            nudAntiguedad.Value = alquiler.Antiguedad;
            txtbxLocalidad.Text = alquiler.Localidad;
            txtbxPrecioMensual.Text = alquiler.PrecioMensual.ToString();
            if (alquiler.Disponible)
            {
                cmbxDisponible.SelectedIndex = 0;
            }
            else
            {
                cmbxDisponible.SelectedIndex = 1;
            }
            cmbxPropietario.DataSource = ControladorCliente.ListaClientes;
            cmbxPropietario.DisplayMember = "dni";
            cmbxPropietario.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void nudHabitaciones_ValueChanged(object sender, EventArgs e)
        {
            if (nudHabitaciones.Value == alquiler.Habitaciones)
            {
                cambios[0] = false;
            }
            else
            {
                cambios[0] = true;
            }
        }

        private void nudBaños_ValueChanged(object sender, EventArgs e)
        {
            if (nudBaños.Value == alquiler.Baños)
            {
                cambios[1] = false;
            }
            else
            {
                cambios[1] = true;
            }
        }

        private void cmbxDisponible_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(cmbxDisponible.DropDownStyle.ToString());
            if (cmbxDisponible.SelectedValue == "Si")
            {
                if (alquiler.Disponible)
                {
                    cambios[2] = false;
                }
                else
                {
                    cambios[2] = true;
                }
            }
            else
            {
                if (alquiler.Disponible)
                {
                    cambios[2] = true;
                }
                else
                {
                    cambios[2] = false;
                }
            }
        }

        private void cmbxPropietario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbxPropietario.SelectedValue == alquiler.Propietario)
            {
                cambios[3] = false;
            }
            else
            {
                cambios[3] = true;
            }
        }

        private void bttnAceptar_Click(object sender, EventArgs e)
        {
            int c = 0;
            c = cambios.Count(x => x == true);
            if (c > 0)
            {
                if (cambios[0])
                {
                    alquiler.Habitaciones = Convert.ToInt32(nudHabitaciones.Value);
                }
                if (cambios[1])
                {
                    alquiler.Baños = Convert.ToInt32(nudBaños.Value);
                }
                if (cambios[2])
                {
                    if (cmbxDisponible.SelectedValue == "Si")
                    {
                        alquiler.Disponible = true;
                    }
                    else
                    {
                        alquiler.Disponible = false;
                    }
                }
                if (cambios[3])
                {
                    alquiler.Propietario = (Cliente)cmbxPropietario.SelectedValue;
                 
                }
                ControladorAlquiler.Cambios = true;
                MessageBox.Show("Alquiler modificado correctamente", "Modificar alquiler", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show("No se ha modificado ningún dato", "Modificar alquiler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
