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
            ImprimirUsuarios();
        }

        private void bttnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bttnModificar_Click(object sender, EventArgs e)
        {
            RadioButton rdbttn = null;
            for (int i = 0; i < pnlUsuarios.Controls.Count; i++)
            {
                if (pnlUsuarios.Controls[i] is RadioButton)
                {
                    if (((RadioButton)pnlUsuarios.Controls[i]).Checked)
                    {
                        rdbttn = (RadioButton)pnlUsuarios.Controls[i];
                    }
                }
            }
            if (rdbttn == null)
            {
                MessageBox.Show("Debe seleccionar un usuario para modificar", "Modificar usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Usuario usuario = (Usuario)rdbttn.Tag;
            ModificarUsuario modificarUsuario = new ModificarUsuario(usuario);
            modificarUsuario.ShowDialog();
            ImprimirUsuarios();
        }
        private void ImprimirUsuarios()
        {
            pnlUsuarios.Controls.Clear();
            int posicion = 40, contador = 1;
            for (int i = 0; i < ControladorUsuario.ListaUsuarios.Count; i++)
            {
                CrearRadioButton(ControladorUsuario.ListaUsuarios[i], posicion, contador);
                posicion += 40;
                contador++;
            }
        }
        private void CrearRadioButton(Usuario usuario, int posicion, int contador)
        {
            RadioButton rdbttn = new RadioButton();
            rdbttn.Name = "rdbttn" + contador;
            rdbttn.Font = new Font("Microsoft Sans Serif", 8);
            rdbttn.Location = new Point(30, posicion);
            rdbttn.Size = new Size(200, 30);
            rdbttn.Text = usuario.ToString();
            rdbttn.Tag = usuario;
            rdbttn.TabIndex = 1;
            pnlUsuarios.Controls.Add(rdbttn);
        }

        private void rdbttnId_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbttnId.Checked)
            {
                ControladorUsuario.ListaUsuarios.Sort((x, y) => x.Id.CompareTo(y.Id));
                ImprimirUsuarios();
            }
        }

        private void rdbttnLogin_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbttnLogin.Checked)
            {
                ControladorUsuario.ListaUsuarios.Sort((x, y) => x.Login.CompareTo(y.Login));
                ImprimirUsuarios();
            }
        }

        private void rdbttnNombre_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbttnNombre.Checked)
            {
                ControladorUsuario.ListaUsuarios.Sort((x, y) => x.Nombre.CompareTo(y.Nombre));
                ImprimirUsuarios();
            }
        }
    }
}
