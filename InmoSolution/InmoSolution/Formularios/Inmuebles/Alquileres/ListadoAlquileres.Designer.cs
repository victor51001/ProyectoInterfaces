namespace InmoSolution.Formularios.Inmuebles.Alquileres
{
    partial class ListadoAlquileres
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListadoAlquileres));
            grpbxOrdenar = new GroupBox();
            rdbttnLocalidad = new RadioButton();
            rdbttnPrecio = new RadioButton();
            rdbttnDireccion = new RadioButton();
            bttnEliminar = new Button();
            bttnCancelar = new Button();
            bttnModificar = new Button();
            lblAlquileres = new Label();
            chklstbxAlquileres = new CheckedListBox();
            grpbxOrdenar.SuspendLayout();
            SuspendLayout();
            // 
            // grpbxOrdenar
            // 
            grpbxOrdenar.Controls.Add(rdbttnLocalidad);
            grpbxOrdenar.Controls.Add(rdbttnPrecio);
            grpbxOrdenar.Controls.Add(rdbttnDireccion);
            grpbxOrdenar.Location = new Point(635, 142);
            grpbxOrdenar.Name = "grpbxOrdenar";
            grpbxOrdenar.Size = new Size(76, 100);
            grpbxOrdenar.TabIndex = 23;
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
            bttnEliminar.Location = new Point(338, 469);
            bttnEliminar.Name = "bttnEliminar";
            bttnEliminar.Size = new Size(106, 37);
            bttnEliminar.TabIndex = 22;
            bttnEliminar.Text = "Eliminar";
            bttnEliminar.UseVisualStyleBackColor = true;
            bttnEliminar.Click += bttnEliminar_Click;
            // 
            // bttnCancelar
            // 
            bttnCancelar.ImeMode = ImeMode.NoControl;
            bttnCancelar.Location = new Point(540, 469);
            bttnCancelar.Name = "bttnCancelar";
            bttnCancelar.Size = new Size(106, 37);
            bttnCancelar.TabIndex = 21;
            bttnCancelar.Text = "Cancelar";
            bttnCancelar.UseVisualStyleBackColor = true;
            bttnCancelar.Click += bttnCancelar_Click;
            // 
            // bttnModificar
            // 
            bttnModificar.ImeMode = ImeMode.NoControl;
            bttnModificar.Location = new Point(143, 469);
            bttnModificar.Name = "bttnModificar";
            bttnModificar.Size = new Size(106, 37);
            bttnModificar.TabIndex = 20;
            bttnModificar.Text = "Modificar";
            bttnModificar.UseVisualStyleBackColor = true;
            bttnModificar.Click += bttnModificar_Click;
            // 
            // lblAlquileres
            // 
            lblAlquileres.AutoSize = true;
            lblAlquileres.BackColor = Color.FromArgb(138, 70, 130, 180);
            lblAlquileres.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblAlquileres.Location = new Point(302, 75);
            lblAlquileres.Name = "lblAlquileres";
            lblAlquileres.Size = new Size(134, 37);
            lblAlquileres.TabIndex = 19;
            lblAlquileres.Text = "Alquileres";
            // 
            // chklstbxAlquileres
            // 
            chklstbxAlquileres.FormattingEnabled = true;
            chklstbxAlquileres.Location = new Point(129, 142);
            chklstbxAlquileres.Name = "chklstbxAlquileres";
            chklstbxAlquileres.ScrollAlwaysVisible = true;
            chklstbxAlquileres.Size = new Size(500, 256);
            chklstbxAlquileres.TabIndex = 18;
            // 
            // ListadoAlquileres
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
            Controls.Add(lblAlquileres);
            Controls.Add(chklstbxAlquileres);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ListadoAlquileres";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ListadoAlquileres";
            Load += ListadoAlquileres_Load;
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
        private Label lblAlquileres;
        private CheckedListBox chklstbxAlquileres;
    }
}