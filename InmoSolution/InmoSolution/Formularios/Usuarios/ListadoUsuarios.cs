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

        private void OrdenarListBox()
        {
            chkLstbxUsuarios.Sorted = true;
        }

        private void ListadoUsuarios_Load(object sender, EventArgs e)
        {
            chkLstbxUsuarios.DataSource = ControladorUsuario.ListaUsuarios;
            chkLstbxUsuarios.DisplayMember = "Nombre";
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
            if (chkLstbxUsuarios.CheckedItems.Count > 0)
            {
                DialogResult respuesta = MessageBox.Show("¿Está seguro que desea eliminar los usuarios seleccionados?", "Eliminar usuarios", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    foreach (Usuario user in chkLstbxUsuarios.CheckedItems)
                    {
                        ControladorUsuario.EliminarUsuario(user);
                    }
                    chkLstbxUsuarios.DataSource = null;
                    chkLstbxUsuarios.DataSource = ControladorUsuario.ListaUsuarios;
                    chkLstbxUsuarios.DisplayMember = "Nombre";
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar al menos un usuario para eliminar", "Eliminar usuarios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bttnModificar_Click(object sender, EventArgs e)
        {
            if (chkLstbxUsuarios.CheckedItems.Count == 1)
            {
                Usuario usuario = (Usuario)chkLstbxUsuarios.SelectedItem;
                ModificarUsuario modificarUsuario = new ModificarUsuario(usuario);
                modificarUsuario.ShowDialog();
                chkLstbxUsuarios.DataSource = null;
                chkLstbxUsuarios.DataSource = ControladorUsuario.ListaUsuarios;
                chkLstbxUsuarios.DisplayMember = "Nombre";
            }
            else
            {
                MessageBox.Show("Debe seleccionar un usuario para modificar", "Modificar usuario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
