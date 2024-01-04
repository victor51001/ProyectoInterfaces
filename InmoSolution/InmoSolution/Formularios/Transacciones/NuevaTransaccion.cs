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
    public partial class NuevaTransaccion : Form
    {
        public NuevaTransaccion()
        {
            InitializeComponent();
        }

        private void NuevaTransaccion_Load(object sender, EventArgs e)
        {
            cmbxInmueble.DataSource = ControladorInmueble.ListaInmuebles;
            cmbxInmueble.DisplayMember = "Direccion";
            cmbxCliente.DataSource = ControladorCliente.ListaClientes;
            cmbxCliente.DisplayMember = "Dni";
            cmbxEmpleado.DataSource = ControladorEmpleado.ListaEmpleados;
            cmbxEmpleado.DisplayMember = "Dni";
        }

        private void bttnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bttnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                DateOnly dateOnly = new DateOnly(dtmpckrFecha.Value.Date.Year, dtmpckrFecha.Value.Date.Month, dtmpckrFecha.Value.Date.Day);
                Inmueble inmueble = (Inmueble)cmbxInmueble.SelectedItem;
                inmueble.Disponible = false;
                Transaccion transaccion = new Transaccion(dateOnly, inmueble, (Empleado)cmbxEmpleado.SelectedItem, (Cliente)cmbxCliente.SelectedItem);
                ControladorTransaccion.ListaTransacciones.Add(transaccion);
                ControladorTransaccion.Cambios = true;
                MessageBox.Show("Transaccion creada correctamente", "Info");
                Close();
            }
        }

        private bool ValidarDatos()
        {
            bool ok = true;
            if (cmbxInmueble.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un inmueble", "Error");
                ok = false;
            }
            if (cmbxCliente.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un cliente", "Error");
                ok = false;
            }
            if (cmbxEmpleado.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un empleado", "Error");
                ok = false;
            }
            return ok;
        }
    }
}
