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
            cmbxCliente.DataSource = ControladorCliente.ListaClientes;
            cmbxEmpleado.DataSource = ControladorEmpleado.ListaEmpleados;
        }

        private void bttnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bttnAceptar_Click(object sender, EventArgs e)
        {
            DateOnly dateOnly = new DateOnly(dtmpckrFecha.Value.Date.Year, dtmpckrFecha.Value.Date.Month, dtmpckrFecha.Value.Date.Day);
            Transaccion transaccion = new Transaccion(dateOnly, (Inmueble)cmbxInmueble.SelectedItem, (Empleado)cmbxEmpleado.SelectedItem, (Cliente)cmbxCliente.SelectedItem);
            ControladorTransaccion.ListaTransacciones.Add(transaccion);
            MessageBox.Show("Transaccion creada correctamente", "Info");
            Close();
        }
    }
}
