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
            nudBaños.Width += nudBaños.Controls[0].Width;
            nudBaños.Minimum = 1;
            nudBaños.Maximum = 10;
            nudHabitaciones.Controls[0].Visible = false;
            nudHabitaciones.Width += nudHabitaciones.Controls[0].Width;
            nudHabitaciones.Minimum = 1;
            nudHabitaciones.Maximum = 10;
            nudMetros.Controls[0].Visible = false;
            nudMetros.Width += nudMetros.Controls[0].Width;
            nudAntiguedad.Controls[0].Visible = false;
            nudAntiguedad.Width += nudAntiguedad.Controls[0].Width;
            nudPrecioMetro.Controls[0].Visible = false;
            nudPrecioMetro.Width += nudPrecioMetro.Controls[0].Width;
            nudPrecio.Controls[0].Visible = false;
            nudPrecio.Width += nudPrecio.Controls[0].Width;

            txtbxDireccion.Text = enVenta.Direccion;
            nudMetros.Value = enVenta.MetrosCuadrados;
            nudHabitaciones.Value = enVenta.Habitaciones;
            nudBaños.Value = enVenta.Baños;
            nudAntiguedad.Value = enVenta.Antiguedad;
            txtbxLocalidad.Text = enVenta.Localidad;
            nudMetros.Value = enVenta.MetrosCuadrados;
            nudPrecioMetro.Value = enVenta.PrecioMetroCuadrado;
            nudPrecio.Value = enVenta.Precio;
            cmbxPropietario.DataSource = ControladorCliente.ListaClientes;
            cmbxPropietario.DisplayMember = "dni";
            cmbxPropietario.SelectedItem = enVenta.Propietario;
            cmbxDisponible.SelectedIndex = Convert.ToInt32(enVenta.Disponible);
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

        private void nudPrecioMetro_ValueChanged(object sender, EventArgs e)
        {
            if (nudPrecioMetro.Value != enVenta.PrecioMetroCuadrado)
            {
                cambios[4] = true;
                nudPrecio.Value = nudPrecioMetro.Value * nudMetros.Value;
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
                    for (int i = 0; i < cambios.Length; i++)
                    {
                        switch (i)
                        {
                            case 0:
                                if (cambios[i])
                                {
                                    enVenta.Habitaciones = Convert.ToInt32(nudHabitaciones.Value);
                                }
                                break;
                            case 1:
                                if (cambios[i])
                                {
                                    enVenta.Baños = Convert.ToInt32(nudBaños.Value);
                                }
                                break;
                            case 2:
                                if (cambios[i])
                                {
                                    enVenta.Antiguedad = Convert.ToInt32(nudAntiguedad.Value);
                                }
                                break;
                            case 3:
                                if (cambios[i])
                                {
                                    enVenta.Disponible = Convert.ToBoolean(cmbxDisponible.SelectedIndex);
                                }
                                break;
                            case 4:
                                if (cambios[i])
                                {
                                    enVenta.PrecioMetroCuadrado = Convert.ToInt32(nudPrecioMetro.Value);
                                }
                                break;
                        }
                    }
                    ControladorEnVenta.Cambios = true;
                    Close();
                }
            }
            else
            {
                MessageBox.Show("No se han realizado cambios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bttnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
