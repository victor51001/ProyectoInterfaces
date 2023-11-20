using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inicio_Y_Portal
{
    public partial class TerminarAlta : Form
    {
        public TerminarAlta()
        {
            InitializeComponent();
        }
        public Boolean valor { get; set; }

        private void bttnSi_Click(object sender, EventArgs e)
        {
            valor = true;
            Close();
        }

        private void bttnNo_Click(object sender, EventArgs e)
        {
            valor = false;
            Close();
        }

        private void TerminarAlta_Load(object sender, EventArgs e)
        {
            Color backColorLabel = Color.FromArgb(100, Color.Lavender);
            lblPregunta.BackColor = backColorLabel;
        }
    }
}
