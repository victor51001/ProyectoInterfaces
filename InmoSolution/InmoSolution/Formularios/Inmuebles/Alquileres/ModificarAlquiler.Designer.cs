namespace InmoSolution.Formularios.Inmuebles.Alquileres
{
    partial class ModificarAlquiler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarAlquiler));
            nudMetros = new NumericUpDown();
            lblAntiguedad = new Label();
            lblMetrosCuad = new Label();
            lblBaños = new Label();
            bttnCancelar = new Button();
            bttnAceptar = new Button();
            txtbxDireccion = new TextBox();
            lblDireccion = new Label();
            lblHabitaciones = new Label();
            lblAlquiler = new Label();
            nudHabitaciones = new NumericUpDown();
            nudBaños = new NumericUpDown();
            nudAntiguedad = new NumericUpDown();
            lblDisponible = new Label();
            cmbxDisponible = new ComboBox();
            lblPropietario = new Label();
            txtbxLocalidad = new TextBox();
            lblLocalidad = new Label();
            cmbxPropietario = new ComboBox();
            txtbxPrecioMensual = new TextBox();
            lblPrecioMensual = new Label();
            ((System.ComponentModel.ISupportInitialize)nudMetros).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudHabitaciones).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudBaños).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudAntiguedad).BeginInit();
            SuspendLayout();
            // 
            // nudMetros
            // 
            nudMetros.BackColor = SystemColors.ScrollBar;
            nudMetros.Enabled = false;
            nudMetros.ForeColor = SystemColors.WindowText;
            nudMetros.Location = new Point(242, 257);
            nudMetros.Maximum = new decimal(new int[] { 20000, 0, 0, 0 });
            nudMetros.Name = "nudMetros";
            nudMetros.Size = new Size(77, 23);
            nudMetros.TabIndex = 44;
            // 
            // lblAntiguedad
            // 
            lblAntiguedad.AutoSize = true;
            lblAntiguedad.BackColor = Color.FromArgb(158, 255, 255, 255);
            lblAntiguedad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblAntiguedad.Location = new Point(45, 305);
            lblAntiguedad.Name = "lblAntiguedad";
            lblAntiguedad.Size = new Size(93, 21);
            lblAntiguedad.TabIndex = 43;
            lblAntiguedad.Text = "Antigüedad:";
            // 
            // lblMetrosCuad
            // 
            lblMetrosCuad.AutoSize = true;
            lblMetrosCuad.BackColor = Color.FromArgb(158, 255, 255, 255);
            lblMetrosCuad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMetrosCuad.Location = new Point(45, 259);
            lblMetrosCuad.Name = "lblMetrosCuad";
            lblMetrosCuad.Size = new Size(137, 21);
            lblMetrosCuad.TabIndex = 41;
            lblMetrosCuad.Text = "MetrosCuadrados:";
            // 
            // lblBaños
            // 
            lblBaños.AutoSize = true;
            lblBaños.BackColor = Color.FromArgb(158, 255, 255, 255);
            lblBaños.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblBaños.Location = new Point(45, 219);
            lblBaños.Name = "lblBaños";
            lblBaños.Size = new Size(138, 21);
            lblBaños.TabIndex = 40;
            lblBaños.Text = "Numero de Baños:";
            // 
            // bttnCancelar
            // 
            bttnCancelar.Location = new Point(481, 408);
            bttnCancelar.Name = "bttnCancelar";
            bttnCancelar.Size = new Size(88, 30);
            bttnCancelar.TabIndex = 38;
            bttnCancelar.Text = "Cancelar";
            bttnCancelar.UseVisualStyleBackColor = true;
            bttnCancelar.Click += bttnCancelar_Click;
            // 
            // bttnAceptar
            // 
            bttnAceptar.Location = new Point(234, 408);
            bttnAceptar.Name = "bttnAceptar";
            bttnAceptar.Size = new Size(88, 30);
            bttnAceptar.TabIndex = 37;
            bttnAceptar.Text = "Aceptar";
            bttnAceptar.UseVisualStyleBackColor = true;
            bttnAceptar.Click += bttnAceptar_Click;
            // 
            // txtbxDireccion
            // 
            txtbxDireccion.BackColor = SystemColors.ScrollBar;
            txtbxDireccion.Enabled = false;
            txtbxDireccion.Location = new Point(161, 116);
            txtbxDireccion.Name = "txtbxDireccion";
            txtbxDireccion.Size = new Size(184, 23);
            txtbxDireccion.TabIndex = 36;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.BackColor = Color.FromArgb(158, 255, 255, 255);
            lblDireccion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDireccion.Location = new Point(45, 114);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(78, 21);
            lblDireccion.TabIndex = 35;
            lblDireccion.Text = "Direccion:";
            // 
            // lblHabitaciones
            // 
            lblHabitaciones.AutoSize = true;
            lblHabitaciones.BackColor = Color.FromArgb(158, 255, 255, 255);
            lblHabitaciones.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblHabitaciones.Location = new Point(45, 169);
            lblHabitaciones.Name = "lblHabitaciones";
            lblHabitaciones.Size = new Size(185, 21);
            lblHabitaciones.TabIndex = 34;
            lblHabitaciones.Text = "Numero de Habitaciones:";
            // 
            // lblAlquiler
            // 
            lblAlquiler.AutoSize = true;
            lblAlquiler.BackColor = Color.FromArgb(148, 255, 228, 196);
            lblAlquiler.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblAlquiler.Location = new Point(302, 50);
            lblAlquiler.Name = "lblAlquiler";
            lblAlquiler.Size = new Size(164, 32);
            lblAlquiler.TabIndex = 32;
            lblAlquiler.Text = "Datos Alquiler";
            // 
            // nudHabitaciones
            // 
            nudHabitaciones.Location = new Point(242, 167);
            nudHabitaciones.Name = "nudHabitaciones";
            nudHabitaciones.Size = new Size(77, 23);
            nudHabitaciones.TabIndex = 45;
            nudHabitaciones.ValueChanged += nudHabitaciones_ValueChanged;
            // 
            // nudBaños
            // 
            nudBaños.Location = new Point(242, 219);
            nudBaños.Name = "nudBaños";
            nudBaños.Size = new Size(77, 23);
            nudBaños.TabIndex = 46;
            nudBaños.ValueChanged += nudBaños_ValueChanged;
            // 
            // nudAntiguedad
            // 
            nudAntiguedad.BackColor = SystemColors.ScrollBar;
            nudAntiguedad.Enabled = false;
            nudAntiguedad.Location = new Point(242, 305);
            nudAntiguedad.Name = "nudAntiguedad";
            nudAntiguedad.Size = new Size(77, 23);
            nudAntiguedad.TabIndex = 47;
            // 
            // lblDisponible
            // 
            lblDisponible.AutoSize = true;
            lblDisponible.BackColor = Color.FromArgb(158, 255, 255, 255);
            lblDisponible.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDisponible.Location = new Point(410, 118);
            lblDisponible.Name = "lblDisponible";
            lblDisponible.Size = new Size(87, 21);
            lblDisponible.TabIndex = 48;
            lblDisponible.Text = "Disponible:";
            // 
            // cmbxDisponible
            // 
            cmbxDisponible.FormattingEnabled = true;
            cmbxDisponible.Items.AddRange(new object[] { "Si", "No" });
            cmbxDisponible.Location = new Point(601, 116);
            cmbxDisponible.Name = "cmbxDisponible";
            cmbxDisponible.Size = new Size(77, 23);
            cmbxDisponible.TabIndex = 49;
            cmbxDisponible.SelectedIndexChanged += cmbxDisponible_SelectedIndexChanged;
            // 
            // lblPropietario
            // 
            lblPropietario.AutoSize = true;
            lblPropietario.BackColor = Color.FromArgb(158, 255, 255, 255);
            lblPropietario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPropietario.Location = new Point(410, 167);
            lblPropietario.Name = "lblPropietario";
            lblPropietario.Size = new Size(90, 21);
            lblPropietario.TabIndex = 50;
            lblPropietario.Text = "Propietario:";
            // 
            // txtbxLocalidad
            // 
            txtbxLocalidad.BackColor = SystemColors.ScrollBar;
            txtbxLocalidad.Enabled = false;
            txtbxLocalidad.Location = new Point(550, 202);
            txtbxLocalidad.Name = "txtbxLocalidad";
            txtbxLocalidad.Size = new Size(184, 23);
            txtbxLocalidad.TabIndex = 53;
            // 
            // lblLocalidad
            // 
            lblLocalidad.AutoSize = true;
            lblLocalidad.BackColor = Color.FromArgb(158, 255, 255, 255);
            lblLocalidad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblLocalidad.Location = new Point(421, 205);
            lblLocalidad.Name = "lblLocalidad";
            lblLocalidad.Size = new Size(79, 21);
            lblLocalidad.TabIndex = 52;
            lblLocalidad.Text = "Localidad:";
            // 
            // cmbxPropietario
            // 
            cmbxPropietario.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbxPropietario.FormattingEnabled = true;
            cmbxPropietario.Location = new Point(550, 165);
            cmbxPropietario.Name = "cmbxPropietario";
            cmbxPropietario.Size = new Size(184, 23);
            cmbxPropietario.TabIndex = 56;
            cmbxPropietario.SelectedIndexChanged += cmbxPropietario_SelectedIndexChanged;
            // 
            // txtbxPrecioMensual
            // 
            txtbxPrecioMensual.BackColor = SystemColors.ScrollBar;
            txtbxPrecioMensual.Enabled = false;
            txtbxPrecioMensual.Location = new Point(550, 252);
            txtbxPrecioMensual.Name = "txtbxPrecioMensual";
            txtbxPrecioMensual.Size = new Size(184, 23);
            txtbxPrecioMensual.TabIndex = 78;
            // 
            // lblPrecioMensual
            // 
            lblPrecioMensual.AutoSize = true;
            lblPrecioMensual.BackColor = Color.FromArgb(158, 255, 255, 255);
            lblPrecioMensual.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrecioMensual.Location = new Point(410, 254);
            lblPrecioMensual.Name = "lblPrecioMensual";
            lblPrecioMensual.Size = new Size(119, 21);
            lblPrecioMensual.TabIndex = 77;
            lblPrecioMensual.Text = "Precio Mensual:";
            // 
            // ModificarAlquiler
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondo_Modificaciones;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(txtbxPrecioMensual);
            Controls.Add(lblPrecioMensual);
            Controls.Add(cmbxPropietario);
            Controls.Add(txtbxLocalidad);
            Controls.Add(lblLocalidad);
            Controls.Add(lblPropietario);
            Controls.Add(cmbxDisponible);
            Controls.Add(lblDisponible);
            Controls.Add(nudAntiguedad);
            Controls.Add(nudBaños);
            Controls.Add(nudHabitaciones);
            Controls.Add(nudMetros);
            Controls.Add(lblAntiguedad);
            Controls.Add(lblMetrosCuad);
            Controls.Add(lblBaños);
            Controls.Add(bttnCancelar);
            Controls.Add(bttnAceptar);
            Controls.Add(txtbxDireccion);
            Controls.Add(lblDireccion);
            Controls.Add(lblHabitaciones);
            Controls.Add(lblAlquiler);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ModificarAlquiler";
            Text = "ModificarAlquiler";
            Load += ModificarAlquiler_Load;
            ((System.ComponentModel.ISupportInitialize)nudMetros).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudHabitaciones).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudBaños).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudAntiguedad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown nudMetros;
        private Label lblAntiguedad;
        private Label lblMetrosCuad;
        private Label lblBaños;
        private Button bttnCancelar;
        private Button bttnAceptar;
        private TextBox txtbxDireccion;
        private Label lblDireccion;
        private Label lblHabitaciones;
        private Label lblAlquiler;
        private NumericUpDown nudHabitaciones;
        private NumericUpDown nudBaños;
        private NumericUpDown nudAntiguedad;
        private Label lblDisponible;
        private ComboBox cmbxDisponible;
        private Label lblPropietario;
        private TextBox txtbxLocalidad;
        private Label lblLocalidad;
        private ComboBox cmbxPropietario;
        private TextBox txtbxPrecioMensual;
        private Label lblPrecioMensual;
    }
}