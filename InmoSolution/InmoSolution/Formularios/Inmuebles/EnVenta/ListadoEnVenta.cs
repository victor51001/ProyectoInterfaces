using InmoSolution.Controladores;
using InmoSolution.Clases;
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
    public partial class ListadoEnVenta : Form
    {
        public ListadoEnVenta()
        {
            InitializeComponent();
        }

        private void bttnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ListadoEnVenta_Load(object sender, EventArgs e)
        {
            chklstbxEnVenta.DataSource = ControladorEnVenta.ListaEnVenta;
            chklstbxEnVenta.DisplayMember = "ToString";
        }

        private void bttnEliminar_Click(object sender, EventArgs e)
        {
            if (chklstbxEnVenta.CheckedItems.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("¿Está seguro de que desea eliminar los inmuebles seleccionados?", "Eliminar inmuebles", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    foreach (Clases.EnVenta enVenta in chklstbxEnVenta.CheckedItems)
                    {
                        ControladorEnVenta.ListaEnVenta.Remove(enVenta);
                        ControladorInmueble.ListaInmuebles.Remove(enVenta);
                    }
                    ControladorEnVenta.Cambios = true;
                    chklstbxEnVenta.DataSource = null;
                    chklstbxEnVenta.DataSource = ControladorEnVenta.ListaEnVenta;
                    chklstbxEnVenta.DisplayMember = "ToString";
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar al menos un inmueble para eliminarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rdbttnDireccion_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbttnDireccion.Checked)
            {
                chklstbxEnVenta.DataSource = null;
                chklstbxEnVenta.DataSource = ControladorEnVenta.ListaEnVenta.OrderBy(enVenta => enVenta.Direccion).ToList();
                chklstbxEnVenta.DisplayMember = "ToString";
            }
        }

        private void rdbttnLocalidad_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbttnLocalidad.Checked)
            {
                chklstbxEnVenta.DataSource = null;
                chklstbxEnVenta.DataSource = ControladorEnVenta.ListaEnVenta.OrderBy(enVenta => enVenta.Localidad).ToList();
                chklstbxEnVenta.DisplayMember = "ToString";
            }
        }

        private void rdbttnPrecio_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbttnPrecio.Checked)
            {
                chklstbxEnVenta.DataSource = null;
                chklstbxEnVenta.DataSource = ControladorEnVenta.ListaEnVenta.OrderBy(enVenta => enVenta.Precio).ToList();
                chklstbxEnVenta.DisplayMember = "ToString";
            }
        }

        private void bttnModificar_Click(object sender, EventArgs e)
        {
            if (chklstbxEnVenta.CheckedItems.Count == 1)
            {
                Clases.EnVenta enVenta = (Clases.EnVenta)chklstbxEnVenta.CheckedItems[0];
                ModificarEnVenta formularioEnVenta = new ModificarEnVenta(enVenta);
                formularioEnVenta.ShowDialog();
                if (ControladorEnVenta.Cambios)
                {
                    chklstbxEnVenta.DataSource = null;
                    chklstbxEnVenta.DataSource = ControladorEnVenta.ListaEnVenta;
                    chklstbxEnVenta.DisplayMember = "ToString";
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar solo un inmueble para modificarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
