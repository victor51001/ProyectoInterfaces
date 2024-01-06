using InmoSolution.Clases;
using System.Drawing;

namespace InmoSolution.Formularios.Empleados
{
    partial class ListadoEmpleados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListadoEmpleados));
            chklstbxEmpleados = new CheckedListBox();
            lblEmpleados = new Label();
            bttnEliminar = new Button();
            bttnCancelar = new Button();
            bttnModificar = new Button();
            SuspendLayout();
            // 
            // chklstbxEmpleados
            // 
            chklstbxEmpleados.FormattingEnabled = true;
            chklstbxEmpleados.HorizontalScrollbar = true;
            chklstbxEmpleados.Location = new Point(169, 165);
            chklstbxEmpleados.Name = "chklstbxEmpleados";
            chklstbxEmpleados.ScrollAlwaysVisible = true;
            chklstbxEmpleados.Size = new Size(445, 256);
            chklstbxEmpleados.TabIndex = 0;
            chklstbxEmpleados.DrawItem += chklstbxEmpleados_DrawItem;
            // 
            // lblEmpleados
            // 
            lblEmpleados.AutoSize = true;
            lblEmpleados.BackColor = Color.FromArgb(138, 70, 130, 180);
            lblEmpleados.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmpleados.Location = new Point(317, 93);
            lblEmpleados.Name = "lblEmpleados";
            lblEmpleados.Size = new Size(148, 37);
            lblEmpleados.TabIndex = 1;
            lblEmpleados.Text = "Empleados";
            // 
            // bttnEliminar
            // 
            bttnEliminar.ImeMode = ImeMode.NoControl;
            bttnEliminar.Location = new Point(342, 482);
            bttnEliminar.Name = "bttnEliminar";
            bttnEliminar.Size = new Size(106, 37);
            bttnEliminar.TabIndex = 10;
            bttnEliminar.Text = "Eliminar";
            bttnEliminar.UseVisualStyleBackColor = true;
            bttnEliminar.Click += bttnEliminar_Click;
            // 
            // bttnCancelar
            // 
            bttnCancelar.ImeMode = ImeMode.NoControl;
            bttnCancelar.Location = new Point(491, 482);
            bttnCancelar.Name = "bttnCancelar";
            bttnCancelar.Size = new Size(106, 37);
            bttnCancelar.TabIndex = 8;
            bttnCancelar.Text = "Cancelar";
            bttnCancelar.UseVisualStyleBackColor = true;
            bttnCancelar.Click += bttnCancelar_Click;
            // 
            // bttnModificar
            // 
            bttnModificar.ImeMode = ImeMode.NoControl;
            bttnModificar.Location = new Point(194, 482);
            bttnModificar.Name = "bttnModificar";
            bttnModificar.Size = new Size(106, 37);
            bttnModificar.TabIndex = 7;
            bttnModificar.Text = "Modificar";
            bttnModificar.UseVisualStyleBackColor = true;
            bttnModificar.Click += bttnModificar_Click;
            // 
            // ListadoEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondo_Listas;
            BackgroundImageLayout = ImageLayout.Stretch;
            CancelButton = bttnCancelar;
            ClientSize = new Size(781, 647);
            Controls.Add(chklstbxEmpleados);
            Controls.Add(bttnEliminar);
            Controls.Add(bttnCancelar);
            Controls.Add(bttnModificar);
            Controls.Add(lblEmpleados);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ListadoEmpleados";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ListadoEmpleados";
            Load += ListadoEmpleados_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void chklstbxEmpleados_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index >= 0)
            {
                Empleado empleado = (Empleado)chklstbxEmpleados.Items[e.Index];
                Brush brocha = new SolidBrush(e.ForeColor);
                string cadena = empleado.Dni + " " + empleado.Nombre + " " + empleado.Apellidos + " " + empleado.Puesto.ToString();
                e.Graphics.DrawString(cadena, e.Font, brocha, e.Bounds.Left, e.Bounds.Top);
            }
        }

        #endregion

        private CheckedListBox chklstbxEmpleados;
        private Label lblEmpleados;
        private Button bttnEliminar;
        private Button bttnCancelar;
        private Button bttnModificar;
    }
}