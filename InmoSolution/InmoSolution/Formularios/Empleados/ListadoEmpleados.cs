using InmoSolution.Clases;
using InmoSolution.Controladores;
using InmoSolution.Formularios.Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InmoSolution.Formularios.Empleados
{
    public partial class ListadoEmpleados : Form
    {
        public ListadoEmpleados()
        {
            InitializeComponent();
        }

        private void ListadoEmpleados_Load(object sender, EventArgs e)
        {
            chklstbxEmpleados.DataSource = ControladorEmpleado.ListaEmpleados;
            chklstbxEmpleados.DisplayMember = "ToString";
        }        

        private void bttnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bttnEliminar_Click(object sender, EventArgs e)
        {
            if (chklstbxEmpleados.CheckedItems.Count > 0)
            {
                DialogResult respuesta = MessageBox.Show("¿Está seguro que desea eliminar los empleados seleccionados?", "Eliminar empleados", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    foreach (Empleado empleado in chklstbxEmpleados.CheckedItems)
                    {
                        ControladorEmpleado.ListaEmpleados.Remove(empleado);
                        ControladorUsuario.ListaUsuarios.Remove(empleado.Usuario);
                    }                    
                    chklstbxEmpleados.DataSource = null;
                    chklstbxEmpleados.DataSource = ControladorEmpleado.ListaEmpleados;
                    ControladorEmpleado.Cambios = true;
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar al menos un empleado para eliminar", "Eliminar empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bttnModificar_Click(object sender, EventArgs e)
        {
            if (chklstbxEmpleados.CheckedItems.Count == 1)
            {
                Empleado empleado = (Empleado)chklstbxEmpleados.SelectedItem;
                ModificarEmpleado modificarEmpleado = new ModificarEmpleado(empleado);
                modificarEmpleado.ShowDialog();
                if (ControladorEmpleado.Cambios)
                {
                    chklstbxEmpleados.DataSource = null;
                    chklstbxEmpleados.DataSource = ControladorEmpleado.ListaEmpleados;
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un solo empleado para modificar", "Modificar empleado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
