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

namespace InmoSolution.Formularios.Clientes
{
    public partial class ListadoClientes : Form
    {
        public ListadoClientes()
        {
            InitializeComponent();
        }

        private void ListadoClientes_Load(object sender, EventArgs e)
        {
            chklstbxClientes.DataSource = ControladorCliente.ListaClientes;
            chklstbxClientes.DisplayMember = "ToString";
        }

        private void bttnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bttnEliminar_Click(object sender, EventArgs e)
        {
            if (chklstbxClientes.CheckedItems.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("¿Está seguro de que desea eliminar los clientes seleccionados?", "Eliminar clientes", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    foreach (Cliente cliente in chklstbxClientes.CheckedItems)
                    {
                        ControladorCliente.ListaClientes.Remove(cliente);
                    }
                    chklstbxClientes.DataSource = null;
                    chklstbxClientes.DataSource = ControladorCliente.ListaClientes;
                    chklstbxClientes.DisplayMember = "ToString";
                    ControladorCliente.Cambios = true;
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar al menos un cliente para eliminarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rdbttnDni_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbttnDni.Checked)
            {
                ControladorCliente.ListaClientes.Sort((x, y) => x.Dni.CompareTo(y.Dni));
                chklstbxClientes.DataSource = null;
                chklstbxClientes.DataSource = ControladorCliente.ListaClientes;
                chklstbxClientes.DisplayMember = "ToString";
            }
        }

        private void rdbttnNombre_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbttnNombre.Checked)
            {
                ControladorCliente.ListaClientes.Sort((x, y) => x.Nombre.CompareTo(y.Nombre));
                chklstbxClientes.DataSource = null;
                chklstbxClientes.DataSource = ControladorCliente.ListaClientes;
                chklstbxClientes.DisplayMember = "ToString";
            }
        }

        private void rdbttnApellidos_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbttnApellidos.Checked)
            {
                ControladorCliente.ListaClientes.Sort((x, y) => x.Apellidos.CompareTo(y.Apellidos));
                chklstbxClientes.DataSource = null;
                chklstbxClientes.DataSource = ControladorCliente.ListaClientes;
                chklstbxClientes.DisplayMember = "ToString";
            }
        }

        private void rdbttnTelefono_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbttnTelefono.Checked)
            {
                ControladorCliente.ListaClientes.Sort((x, y) => x.Telefono.CompareTo(y.Telefono));
                chklstbxClientes.DataSource = null;
                chklstbxClientes.DataSource = ControladorCliente.ListaClientes;
                chklstbxClientes.DisplayMember = "ToString";
            }
        }

        private void rdbttnEmail_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbttnEmail.Checked)
            {
                ControladorCliente.ListaClientes.Sort((x, y) => x.Email.CompareTo(y.Email));
                chklstbxClientes.DataSource = null;
                chklstbxClientes.DataSource = ControladorCliente.ListaClientes;
                chklstbxClientes.DisplayMember = "ToString";
            }
        }

        private void bttnModificar_Click(object sender, EventArgs e)
        {
            if (chklstbxClientes.CheckedItems.Count == 1)
            {
                Cliente cliente = (Cliente)chklstbxClientes.CheckedItems[0];
                ModificarCliente modificarCliente = new ModificarCliente(cliente);
                modificarCliente.ShowDialog();
                if (ControladorCliente.Cambios)
                {
                    chklstbxClientes.DataSource = null;
                    chklstbxClientes.DataSource = ControladorCliente.ListaClientes;
                    chklstbxClientes.DisplayMember = "ToString";
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar solo un cliente para modificarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
