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
    public partial class ListadoAlquileres : Form
    {
        public ListadoAlquileres()
        {
            InitializeComponent();
        }

        private void ListadoAlquileres_Load(object sender, EventArgs e)
        {
            chklstbxAlquileres.DataSource = ControladorAlquiler.ListaAlquileres;
            chklstbxAlquileres.DisplayMember = "ToString";
        }

        private void bttnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bttnEliminar_Click(object sender, EventArgs e)
        {
            if (chklstbxAlquileres.CheckedItems.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("¿Está seguro de que desea eliminar los alquileres seleccionados?", "Eliminar alquileres", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    foreach (Alquiler alquiler in chklstbxAlquileres.CheckedItems)
                    {
                        ControladorAlquiler.ListaAlquileres.Remove(alquiler);
                        ControladorInmueble.ListaInmuebles.Remove(alquiler);
                    }
                    chklstbxAlquileres.DataSource = null;
                    chklstbxAlquileres.DataSource = ControladorAlquiler.ListaAlquileres;
                    chklstbxAlquileres.DisplayMember = "ToString";
                    ControladorAlquiler.Cambios = true;
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar al menos un alquiler para eliminarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bttnModificar_Click(object sender, EventArgs e)
        {
            if (chklstbxAlquileres.CheckedItems.Count == 1)
            {
                Alquiler alquiler = (Alquiler)chklstbxAlquileres.CheckedItems[0];/*
                ModificarAlquiler formularioAlquiler = new ModificarAlquiler(alquiler);
                formularioAlquiler.ShowDialog();*/
                if (ControladorAlquiler.Cambios)
                {
                    chklstbxAlquileres.DataSource = null;
                    chklstbxAlquileres.DataSource = ControladorAlquiler.ListaAlquileres;
                    chklstbxAlquileres.DisplayMember = "ToString";
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar solo un alquiler para modificarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rdbttnDireccion_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbttnDireccion.Checked)
            {
                ControladorAlquiler.ListaAlquileres.Sort((x, y) => x.Direccion.CompareTo(y.Direccion));
                chklstbxAlquileres.DataSource = null;
                chklstbxAlquileres.DataSource = ControladorAlquiler.ListaAlquileres;
                chklstbxAlquileres.DisplayMember = "ToString";
            }
        }

        private void rdbttnLocalidad_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbttnLocalidad.Checked)
            {
                ControladorAlquiler.ListaAlquileres.Sort((x, y) => x.Localidad.CompareTo(y.Localidad));
                chklstbxAlquileres.DataSource = null;
                chklstbxAlquileres.DataSource = ControladorAlquiler.ListaAlquileres;
                chklstbxAlquileres.DisplayMember = "ToString";
            }
        }

        private void rdbttnPrecio_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbttnPrecio.Checked)
            {
                ControladorAlquiler.ListaAlquileres.Sort((x, y) => x.PrecioMensual.CompareTo(y.PrecioMensual));
                chklstbxAlquileres.DataSource = null;
                chklstbxAlquileres.DataSource = ControladorAlquiler.ListaAlquileres;
                chklstbxAlquileres.DisplayMember = "ToString";
            }
        }
    }
}
