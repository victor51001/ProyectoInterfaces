namespace InmoSolution.Formularios.Clientes
{
    partial class ListadoClientes
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
            bttnEliminar = new Button();
            bttnOrdenar = new Button();
            bttnCancelar = new Button();
            bttnModificar = new Button();
            lblEmpleados = new Label();
            chklstbxEmpleados = new CheckedListBox();
            SuspendLayout();
            // 
            // bttnEliminar
            // 
            bttnEliminar.ImeMode = ImeMode.NoControl;
            bttnEliminar.Location = new Point(425, 404);
            bttnEliminar.Name = "bttnEliminar";
            bttnEliminar.Size = new Size(106, 37);
            bttnEliminar.TabIndex = 16;
            bttnEliminar.Text = "Eliminar";
            bttnEliminar.UseVisualStyleBackColor = true;
            // 
            // bttnOrdenar
            // 
            bttnOrdenar.ImeMode = ImeMode.NoControl;
            bttnOrdenar.Location = new Point(270, 404);
            bttnOrdenar.Name = "bttnOrdenar";
            bttnOrdenar.Size = new Size(106, 37);
            bttnOrdenar.TabIndex = 15;
            bttnOrdenar.Text = "Ordenar";
            bttnOrdenar.UseVisualStyleBackColor = true;
            // 
            // bttnCancelar
            // 
            bttnCancelar.ImeMode = ImeMode.NoControl;
            bttnCancelar.Location = new Point(568, 404);
            bttnCancelar.Name = "bttnCancelar";
            bttnCancelar.Size = new Size(106, 37);
            bttnCancelar.TabIndex = 14;
            bttnCancelar.Text = "Cancelar";
            bttnCancelar.UseVisualStyleBackColor = true;
            // 
            // bttnModificar
            // 
            bttnModificar.ImeMode = ImeMode.NoControl;
            bttnModificar.Location = new Point(126, 404);
            bttnModificar.Name = "bttnModificar";
            bttnModificar.Size = new Size(106, 37);
            bttnModificar.TabIndex = 13;
            bttnModificar.Text = "Modificar";
            bttnModificar.UseVisualStyleBackColor = true;
            // 
            // lblEmpleados
            // 
            lblEmpleados.AutoSize = true;
            lblEmpleados.BackColor = Color.FromArgb(138, 70, 130, 180);
            lblEmpleados.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmpleados.Location = new Point(330, 10);
            lblEmpleados.Name = "lblEmpleados";
            lblEmpleados.Size = new Size(148, 37);
            lblEmpleados.TabIndex = 12;
            lblEmpleados.Text = "Empleados";
            // 
            // chklstbxEmpleados
            // 
            chklstbxEmpleados.FormattingEnabled = true;
            chklstbxEmpleados.Location = new Point(179, 77);
            chklstbxEmpleados.Name = "chklstbxEmpleados";
            chklstbxEmpleados.ScrollAlwaysVisible = true;
            chklstbxEmpleados.Size = new Size(445, 256);
            chklstbxEmpleados.TabIndex = 11;
            // 
            // ListadoClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(781, 647);
            Controls.Add(bttnEliminar);
            Controls.Add(bttnOrdenar);
            Controls.Add(bttnCancelar);
            Controls.Add(bttnModificar);
            Controls.Add(lblEmpleados);
            Controls.Add(chklstbxEmpleados);
            Name = "ListadoClientes";
            Text = "ListadoClientes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bttnEliminar;
        private Button bttnOrdenar;
        private Button bttnCancelar;
        private Button bttnModificar;
        private Label lblEmpleados;
        private CheckedListBox chklstbxEmpleados;
    }
}