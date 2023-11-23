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

namespace InmoSolution.Formularios
{
    public partial class Principal : Form
    {
        private Usuario user;
        public Principal(Usuario usu)
        {
            InitializeComponent();
            user = usu;
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            if (user.Id == 0)
            {
                tsmiUsuarios.Visible = true;
                tsmiEmpleados.Visible = true;
            }
            else if (ControladorEmpleado.EsAdministrativo(user) || ControladorEmpleado.EsJefe(user))
            {
                tsmiEmpleados.Visible = true;
            }
        }

        private void tsmiPerfil_Click(object sender, EventArgs e)
        {
            Usuarios.ModificarUsuario frmPerfil = new Usuarios.ModificarUsuario(user);
        }

        private void tsmiCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listadoDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuarios.ListadoUsuarios frmListado = new Usuarios.ListadoUsuarios();
            frmListado.ShowDialog();
        }

        private void nuevoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuarios.NuevoUsuario frmNuevoUsuario = new Usuarios.NuevoUsuario();
            frmNuevoUsuario.ShowDialog();
        }

        private void tsmiNuevoEmpleado_Click(object sender, EventArgs e)
        {
            Empleados.NuevoEmpleado frmNuevoEmpleado = new Empleados.NuevoEmpleado();
            frmNuevoEmpleado.ShowDialog();
        }
    }
}
