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
                    List<Transaccion> transacciones = new List<Transaccion>();
                    for (int i=0; i<chklstbxTransacciones.CheckedItems.Count;i++)
                    {
                        transacciones.Add((Transaccion)chklstbxTransacciones.CheckedItems[i]);
                    }
                    foreach (Transaccion transaccion in transacciones)
                    {
                        ControladorTransaccion.ListaTransacciones.Remove(transaccion);
                        if (transaccion.Inmueble is Alquiler)
                        {
                            ControladorTransaccion.MinusFechaAlquiler(transaccion.Fecha);
                        }
                        else
                        {
                            ControladorTransaccion.MinusFechaVenta(transaccion.Fecha);
                        }
                    }
                    chklstbxTransacciones.DataSource = null;
                    chklstbxTransacciones.DataSource = ControladorTransaccion.ListaTransacciones;
                    chklstbxTransacciones.DisplayMember = "ToString";
                    ControladorTransaccion.Cambios = true;
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar al menos una transaccion para eliminarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rdbttnFecha_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbttnFecha.Checked)
            {
                chklstbxTransacciones.DataSource = null;
                chklstbxTransacciones.DataSource = ControladorTransaccion.ListaTransacciones.OrderBy(t => t.Fecha).ToList();
                chklstbxTransacciones.DisplayMember = "ToString";
            }
        }

        private void rdbttnBeneficio_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbttnBeneficio.Checked)
            {
                chklstbxTransacciones.DataSource = null;
                chklstbxTransacciones.DataSource = ControladorTransaccion.ListaTransacciones.OrderBy(t => t.Beneficio).ToList();
                chklstbxTransacciones.DisplayMember = "ToString";
            }
        }
    }
}
