namespace InmoSolution.Formularios.Inmuebles.EnVenta
{
    partial class ListadoEnVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListadoEnVenta));
            grpbxOrdenar = new GroupBox();
            rdbttnLocalidad = new RadioButton();
            rdbttnPrecio = new RadioButton();
            rdbttnDireccion = new RadioButton();
            bttnEliminar = new Button();
            bttnCancelar = new Button();
            bttnModificar = new Button();
            lblEnVenta = new Label();
            chklstbxEnVenta = new CheckedListBox();
            grpbxOrdenar.SuspendLayout();
            SuspendLayout();
            // 
            // grpbxOrdenar
            // 
            grpbxOrdenar.Controls.Add(rdbttnLocalidad);
            grpbxOrdenar.Controls.Add(rdbttnPrecio);
            grpbxOrdenar.Controls.Add(rdbttnDireccion);
            grpbxOrdenar.Location = new Point(605, 175);
            grpbxOrdenar.Name = "grpbxOrdenar";
            grpbxOrdenar.Size = new Size(76, 100);
            grpbxOrdenar.TabIndex = 29;
            grpbxOrdenar.TabStop = false;
            grpbxOrdenar.Text = "Ordenar";
            // 
            // rdbttnLocalidad
            // 
            rdbttnLocalidad.AutoSize = true;
            rdbttnLocalidad.ImeMode = ImeMode.NoControl;
            rdbttnLocalidad.Location = new Point(0, 47);
            rdbttnLocalidad.Name = "rdbttnLocalidad";
            rdbttnLocalidad.Size = new Size(76, 19);
            rdbttnLocalidad.TabIndex = 2;
            rdbttnLocalidad.TabStop = true;
            rdbttnLocalidad.Text = "Localidad";
            rdbttnLocalidad.UseVisualStyleBackColor = true;
            rdbttnLocalidad.CheckedChanged += rdbttnLocalidad_CheckedChanged;
            // 
            // rdbttnPrecio
            // 
            rdbttnPrecio.AutoSize = true;
            rdbttnPrecio.ImeMode = ImeMode.NoControl;
            rdbttnPrecio.Location = new Point(0, 72);
            rdbttnPrecio.Name = "rdbttnPrecio";
            rdbttnPrecio.Size = new Size(58, 19);
            rdbttnPrecio.TabIndex = 1;
            rdbttnPrecio.TabStop = true;
            rdbttnPrecio.Text = "Precio";
            rdbttnPrecio.UseVisualStyleBackColor = true;
            rdbttnPrecio.CheckedChanged += rdbttnPrecio_CheckedChanged;
            // 
            // rdbttnDireccion
            // 
            rdbttnDireccion.AutoSize = true;
            rdbttnDireccion.ImeMode = ImeMode.NoControl;
            rdbttnDireccion.Location = new Point(0, 22);
            rdbttnDireccion.Name = "rdbttnDireccion";
            rdbttnDireccion.Size = new Size(75, 19);
            rdbttnDireccion.TabIndex = 0;
            rdbttnDireccion.TabStop = true;
            rdbttnDireccion.Text = "Direccion";
            rdbttnDireccion.UseVisualStyleBackColor = true;
            rdbttnDireccion.CheckedChanged += rdbttnDireccion_CheckedChanged;
            // 
            // bttnEliminar
            // 
            bttnEliminar.ImeMode = ImeMode.NoControl;
            bttnEliminar.Location = new Point(308, 502);
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
            bttnCancelar.Location = new Point(510, 502);
            bttnCancelar.Name = "bttnCancelar";
            bttnCancelar.Size = new Size(106, 37);
            bttnCancelar.TabIndex = 27;
            bttnCancelar.Text = "Cancelar";
            bttnCancelar.UseVisualStyleBackColor = true;
            bttnCancelar.Click += bttnCancelar_Click;
            // 
            // bttnModificar
            // 
            bttnModificar.ImeMode = ImeMode.NoControl;
            bttnModificar.Location = new Point(113, 502);
            bttnModificar.Name = "bttnModificar";
            bttnModificar.Size = new Size(106, 37);
            bttnModificar.TabIndex = 26;
            bttnModificar.Text = "Modificar";
            bttnModificar.UseVisualStyleBackColor = true;
            bttnModificar.Click += bttnModificar_Click;
            // 
            // lblEnVenta
            // 
            lblEnVenta.AutoSize = true;
            lblEnVenta.BackColor = Color.FromArgb(138, 70, 130, 180);
            lblEnVenta.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblEnVenta.Location = new Point(272, 108);
            lblEnVenta.Name = "lblEnVenta";
            lblEnVenta.Size = new Size(120, 37);
            lblEnVenta.TabIndex = 25;
            lblEnVenta.Text = "En Venta";
            // 
            // chklstbxEnVenta
            // 
            chklstbxEnVenta.FormattingEnabled = true;
            chklstbxEnVenta.Location = new Point(99, 175);
            chklstbxEnVenta.Name = "chklstbxEnVenta";
            chklstbxEnVenta.ScrollAlwaysVisible = true;
            chklstbxEnVenta.Size = new Size(500, 256);
            chklstbxEnVenta.TabIndex = 24;
            // 
            // ListadoEnVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondo_Listas;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(781, 647);
            Controls.Add(grpbxOrdenar);
            Controls.Add(bttnEliminar);
            Controls.Add(bttnCancelar);
            Controls.Add(bttnModificar);
            Controls.Add(lblEnVenta);
            Controls.Add(chklstbxEnVenta);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ListadoEnVenta";
            Text = "ListadoEnVenta";
            Load += ListadoEnVenta_Load;
            grpbxOrdenar.ResumeLayout(false);
            grpbxOrdenar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpbxOrdenar;
        private RadioButton rdbttnLocalidad;
        private RadioButton rdbttnPrecio;
        private RadioButton rdbttnDireccion;
        private Button bttnEliminar;
        private Button bttnCancelar;
        private Button bttnModificar;
        private Label lblEnVenta;
        private CheckedListBox chklstbxEnVenta;
    }
}