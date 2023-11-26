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

namespace InmoSolution.Formularios.Usuarios
{
    public partial class ListadoUsuarios : Form
    {
        public ListadoUsuarios()
        {
            InitializeComponent();
        }

        private void ListadoUsuarios_Load(object sender, EventArgs e)
        {
            chklstbxUsuarios.DataSource = ControladorUsuario.ListaUsuarios;
            chklstbxUsuarios.DisplayMember = "Nombre";
        }

        private void OrdenarListBox()
        {
            chklstbxUsuarios.Sorted = true;
        }

        private void bttnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bttnOrdenar_Click(object sender, EventArgs e)
        {
            OrdenarListBox();
        }

        private void bttnEliminar_Click(object sender, EventArgs e)
        {
            if (chklstbxUsuarios.CheckedItems.Count > 0)
            {
                DialogResult respuesta = MessageBox.Show("¿Está seguro que desea eliminar los usuarios seleccionados?", "Eliminar usuarios", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    foreach (Usuario user in chklstbxUsuarios.CheckedItems)
                    {
                        ControladorUsuario.EliminarUsuario(user);
                    }
                    chklstbxUsuarios.DataSource = null;
                    chklstbxUsuarios.DataSource = ControladorUsuario.ListaUsuarios;
                    chklstbxUsuarios.DisplayMember = "Nombre";
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar al menos un usuario para eliminar", "Eliminar usuarios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bttnModificar_Click(object sender, EventArgs e)
        {
            if (chklstbxUsuarios.CheckedItems.Count == 1)
            {
                Usuario usuario = (Usuario)chklstbxUsuarios.SelectedItem;
                ModificarUsuario modificarUsuario = new ModificarUsuario(usuario);
                modificarUsuario.ShowDialog();
                chklstbxUsuarios.DataSource = null;
                chklstbxUsuarios.DataSource = ControladorUsuario.ListaUsuarios;
                chklstbxUsuarios.DisplayMember = "Nombre";
            }
            else
            {
                MessageBox.Show("Debe seleccionar un usuario para modificar", "Modificar usuario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
