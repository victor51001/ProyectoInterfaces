namespace InmoSolution.Formularios.Transacciones
{
    partial class ListadoTransacciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListadoTransacciones));
            grpbxOrdenar = new GroupBox();
            rdbttnBeneficio = new RadioButton();
            rdbttnFecha = new RadioButton();
            bttnEliminar = new Button();
            bttnCancelar = new Button();
            lblTransacciones = new Label();
            chklstbxTransacciones = new CheckedListBox();
            grpbxOrdenar.SuspendLayout();
            SuspendLayout();
            // 
            // grpbxOrdenar
            // 
            grpbxOrdenar.Controls.Add(rdbttnBeneficio);
            grpbxOrdenar.Controls.Add(rdbttnFecha);
            grpbxOrdenar.Location = new Point(661, 175);
            grpbxOrdenar.Name = "grpbxOrdenar";
            grpbxOrdenar.Size = new Size(76, 73);
            grpbxOrdenar.TabIndex = 29;
            grpbxOrdenar.TabStop = false;
            grpbxOrdenar.Text = "Ordenar";
            // 
            // rdbttnBeneficio
            // 
            rdbttnBeneficio.AutoSize = true;
            rdbttnBeneficio.ImeMode = ImeMode.NoControl;
            rdbttnBeneficio.Location = new Point(0, 47);
            rdbttnBeneficio.Name = "rdbttnBeneficio";
            rdbttnBeneficio.Size = new Size(74, 19);
            rdbttnBeneficio.TabIndex = 2;
            rdbttnBeneficio.TabStop = true;
            rdbttnBeneficio.Text = "Beneficio";
            rdbttnBeneficio.UseVisualStyleBackColor = true;
            rdbttnBeneficio.CheckedChanged += rdbttnBeneficio_CheckedChanged;
            // 
            // rdbttnFecha
            // 
            rdbttnFecha.AutoSize = true;
            rdbttnFecha.ImeMode = ImeMode.NoControl;
            rdbttnFecha.Location = new Point(0, 22);
            rdbttnFecha.Name = "rdbttnFecha";
            rdbttnFecha.Size = new Size(56, 19);
            rdbttnFecha.TabIndex = 0;
            rdbttnFecha.TabStop = true;
            rdbttnFecha.Text = "Fecha";
            rdbttnFecha.UseVisualStyleBackColor = true;
            rdbttnFecha.CheckedChanged += rdbttnFecha_CheckedChanged;
            // 
            // bttnEliminar
            // 
            bttnEliminar.ImeMode = ImeMode.NoControl;
            bttnEliminar.Location = new Point(217, 502);
            bttnEliminar.Name = "bttnEliminar";
            bttnEliminar.Size = new Size(106, 37);
            bttnEliminar.TabIndex = 28;
            bttnEliminar.Text = "Eliminar";
            bttnEliminar.UseVisualStyleBackColor = true;
            bttnEliminar.Click += bttnEliminar_Click;
            // 
            // bttnCancelar
            // 
            bttnCancelar.ImeMode = ImeMode.NoControl;
            bttnCancelar.Location = new Point(419, 502);
            bttnCancelar.Name = "bttnCancelar";
            bttnCancelar.Size = new Size(106, 37);
            bttnCancelar.TabIndex = 27;
            bttnCancelar.Text = "Cancelar";
            bttnCancelar.UseVisualStyleBackColor = true;
            bttnCancelar.Click += bttnCancelar_Click;
            // 
            // lblTransacciones
            // 
            lblTransacciones.AutoSize = true;
            lblTransacciones.BackColor = Color.FromArgb(138, 70, 130, 180);
            lblTransacciones.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblTransacciones.Location = new Point(272, 108);
            lblTransacciones.Name = "lblTransacciones";
            lblTransacciones.Size = new Size(179, 37);
            lblTransacciones.TabIndex = 25;
            lblTransacciones.Text = "Transacciones";
            // 
            // chklstbxTransacciones
            // 
            chklstbxTransacciones.FormattingEnabled = true;
            chklstbxTransacciones.HorizontalScrollbar = true;
            chklstbxTransacciones.Location = new Point(72, 175);
            chklstbxTransacciones.Name = "chklstbxTransacciones";
            chklstbxTransacciones.ScrollAlwaysVisible = true;
            chklstbxTransacciones.Size = new Size(583, 256);
            chklstbxTransacciones.TabIndex = 24;
            // 
            // ListadoTransacciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondo_Listas;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(781, 647);
            Controls.Add(grpbxOrdenar);
            Controls.Add(bttnEliminar);
            Controls.Add(bttnCancelar);
            Controls.Add(lblTransacciones);
            Controls.Add(chklstbxTransacciones);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ListadoTransacciones";
            Text = "ListadoTransacciones";
            Load += ListadoTransacciones_Load;
            grpbxOrdenar.ResumeLayout(false);
            grpbxOrdenar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpbxOrdenar;
        private RadioButton rdbttnBeneficio;
        private RadioButton rdbttnFecha;
        private Button bttnEliminar;
        private Button bttnCancelar;
        private Label lblTransacciones;
        private CheckedListBox chklstbxTransacciones;
    }
}