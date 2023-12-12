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

namespace InmoSolution.Formularios.Transacciones
{
    public partial class ListadoTransacciones : Form
    {
        public ListadoTransacciones()
        {
            InitializeComponent();
        }

        private void bttnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ListadoTransacciones_Load(object sender, EventArgs e)
        {
            chklstbxTransacciones.DataSource = ControladorTransaccion.ListaTransacciones;
            chklstbxTransacciones.DisplayMember = "ToString";
        }

        private void bttnEliminar_Click(object sender, EventArgs e)
        {
            if (chklstbxTransacciones.CheckedItems.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("¿Está seguro de que desea eliminar las transacciones seleccionadas?", "Eliminar transaccion", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    foreach (Transaccion transaccion in chklstbxTransacciones.CheckedItems)
                    {
                        ControladorTransaccion.ListaTransacciones.Remove(transaccion);
                    }
                    ControladorTransaccion.Cambios = true;
                    chklstbxTransacciones.DataSource = null;
                    chklstbxTransacciones.DataSource = ControladorTransaccion.ListaTransacciones;
                    chklstbxTransacciones.DisplayMember = "ToString";
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar al menos una transaccion para eliminarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            /*
            if (chklstbxAlquileres.CheckedItems.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("¿Está seguro de que desea eliminar los alquileres seleccionados?", "Eliminar alquileres", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    foreach (Alquiler alquiler in chklstbxAlquileres.CheckedItems)
                    {
                        ControladorAlquiler.ListaAlquileres.Remove(alquiler);
                    }
                    ControladorAlquiler.Cambios = true;
                    chklstbxAlquileres.DataSource = null;
                    chklstbxAlquileres.DataSource = ControladorAlquiler.ListaAlquileres;
                    chklstbxAlquileres.DisplayMember = "ToString";
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar al menos un alquiler para eliminarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }

        private void rdbttnFecha_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbttnFecha.Checked)
            {
                ControladorTransaccion.ListaTransacciones = ControladorTransaccion.ListaTransacciones.OrderBy(t => t.Fecha).ToList();
                chklstbxTransacciones.DataSource = null;
                chklstbxTransacciones.DataSource = ControladorTransaccion.ListaTransacciones.OrderBy(t => t.Fecha).ToList();
                chklstbxTransacciones.DisplayMember = "ToString";
            }
        }

        private void rdbttnBeneficio_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbttnBeneficio.Checked)
            {
                ControladorTransaccion.ListaTransacciones = ControladorTransaccion.ListaTransacciones.OrderBy(t => t.Beneficio).ToList();
                chklstbxTransacciones.DataSource = null;
                chklstbxTransacciones.DataSource = ControladorTransaccion.ListaTransacciones.OrderBy(t => t.Beneficio).ToList();
                chklstbxTransacciones.DisplayMember = "ToString";
            }
        }
    }
}
