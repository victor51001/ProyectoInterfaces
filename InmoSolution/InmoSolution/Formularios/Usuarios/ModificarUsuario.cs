using InmoSolution.Clases;
using InmoSolution.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InmoSolution.Formularios.Usuarios
{
    public partial class ModificarUsuario : Form
    {
        private Boolean cambios = false;
        private Usuario user;
        public ModificarUsuario(Usuario usu)
        {
            InitializeComponent();
            txtId.Text = usu.Id.ToString();
            txtbxNombre.Text = usu.Nombre;
            txtbxClave.Text = usu.Clave;
            user = usu;
        }

        private void txtbxNombre_TextChanged(object sender, EventArgs e)
        {
            if (!txtbxNombre.Text.Equals(user.Nombre))
            {
                cambios = true;
            } 
            else 
            { 
                cambios = false;
            }
        }

        private void bttnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bttnAceptar_Click(object sender, EventArgs e)
        {
            if (cambios)
            {                
                ControladorUsuario.ModificarUsuario(
                    Int32.Parse(txtId.Text.ToString()),
                    txtbxNombre.Text.ToString(),
                    CambioDeContraseña.contraseñaDevuelta
                    );
                Close();                
            }
        }

        private void bttnCambiarContraseña_Click(object sender, EventArgs e)
        {
            CambioDeContraseña frmCambio = new CambioDeContraseña(user);
            frmCambio.ShowDialog();
        }
    }
}
