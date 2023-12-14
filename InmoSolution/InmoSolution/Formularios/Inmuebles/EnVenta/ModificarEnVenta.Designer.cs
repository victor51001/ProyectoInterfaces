namespace InmoSolution.Formularios.Inmuebles.EnVenta
{
    partial class ModificarEnVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarEnVenta));
            cmbxPropietario = new ComboBox();
            txtbxLocalidad = new TextBox();
            lblLocalidad = new Label();
            lblPropietario = new Label();
            cmbxDisponible = new ComboBox();
            lblDisponible = new Label();
            nudAntiguedad = new NumericUpDown();
            nudBaños = new NumericUpDown();
            nudHabitaciones = new NumericUpDown();
            nudMetros = new NumericUpDown();
            lblAntiguedad = new Label();
            lblMetrosCuad = new Label();
            lblBaños = new Label();
            bttnCancelar = new Button();
            bttnAceptar = new Button();
            txtbxDireccion = new TextBox();
            lblDireccion = new Label();
            lblHabitaciones = new Label();
            lblEnVenta = new Label();
            nudPrecioMetro = new NumericUpDown();
            lblPrecioMetro = new Label();
            nudPrecio = new NumericUpDown();
            lblPrecio = new Label();
            ((System.ComponentModel.ISupportInitialize)nudAntiguedad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudBaños).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudHabitaciones).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMetros).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPrecioMetro).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPrecio).BeginInit();
            SuspendLayout();
            // 
            // cmbxPropietario
            // 
            cmbxPropietario.BackColor = SystemColors.Window;
            cmbxPropietario.Enabled = false;
            cmbxPropietario.FormattingEnabled = true;
            cmbxPropietario.Items.AddRange(new object[] { "Si", "No" });
            cmbxPropietario.Location = new Point(561, 146);
            cmbxPropietario.Name = "cmbxPropietario";
            cmbxPropietario.Size = new Size(184, 23);
            cmbxPropietario.TabIndex = 77;
            // 
            // txtbxLocalidad
            // 
            txtbxLocalidad.BackColor = SystemColors.Window;
            txtbxLocalidad.Enabled = false;
            txtbxLocalidad.Location = new Point(561, 183);
            txtbxLocalidad.Name = "txtbxLocalidad";
            txtbxLocalidad.Size = new Size(184, 23);
            txtbxLocalidad.TabIndex = 74;
            // 
            // lblLocalidad
            // 
            lblLocalidad.AutoSize = true;
            lblLocalidad.BackColor = Color.FromArgb(158, 255, 255, 255);
            lblLocalidad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblLocalidad.Location = new Point(432, 186);
            lblLocalidad.Name = "lblLocalidad";
            lblLocalidad.Size = new Size(79, 21);
            lblLocalidad.TabIndex = 73;
            lblLocalidad.Text = "Localidad:";
            // 
            // lblPropietario
            // 
            lblPropietario.AutoSize = true;
            lblPropietario.BackColor = Color.FromArgb(158, 255, 255, 255);
            lblPropietario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPropietario.Location = new Point(421, 148);
            lblPropietario.Name = "lblPropietario";
            lblPropietario.Size = new Size(90, 21);
            lblPropietario.TabIndex = 72;
            lblPropietario.Text = "Propietario:";
            // 
            // cmbxDisponible
            // 
            cmbxDisponible.Enabled = false;
            cmbxDisponible.FormattingEnabled = true;
            cmbxDisponible.Items.AddRange(new object[] { "Si", "No" });
            cmbxDisponible.Location = new Point(612, 97);
            cmbxDisponible.Name = "cmbxDisponible";
            cmbxDisponible.Size = new Size(77, 23);
            cmbxDisponible.TabIndex = 71;
            // 
            // lblDisponible
            // 
            lblDisponible.AutoSize = true;
            lblDisponible.BackColor = Color.FromArgb(158, 255, 255, 255);
            lblDisponible.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDisponible.Location = new Point(421, 99);
            lblDisponible.Name = "lblDisponible";
            lblDisponible.Size = new Size(87, 21);
            lblDisponible.TabIndex = 70;
            lblDisponible.Text = "Disponible:";
            // 
            // nudAntiguedad
            // 
            nudAntiguedad.BackColor = SystemColors.Window;
            nudAntiguedad.Enabled = false;
            nudAntiguedad.Location = new Point(253, 286);
            nudAntiguedad.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            nudAntiguedad.Name = "nudAntiguedad";
            nudAntiguedad.Size = new Size(77, 23);
            nudAntiguedad.TabIndex = 69;
            // 
            // nudBaños
            // 
            nudBaños.Location = new Point(253, 200);
            nudBaños.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudBaños.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudBaños.Name = "nudBaños";
            nudBaños.Size = new Size(77, 23);
            nudBaños.TabIndex = 68;
            nudBaños.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nudBaños.ValueChanged += nudBaños_ValueChanged;
            // 
            // nudHabitaciones
            // 
            nudHabitaciones.Location = new Point(253, 148);
            nudHabitaciones.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudHabitaciones.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudHabitaciones.Name = "nudHabitaciones";
            nudHabitaciones.Size = new Size(77, 23);
            nudHabitaciones.TabIndex = 67;
            nudHabitaciones.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nudHabitaciones.ValueChanged += nudHabitaciones_ValueChanged;
            // 
            // nudMetros
            // 
            nudMetros.BackColor = SystemColors.Window;
            nudMetros.Enabled = false;
            nudMetros.ForeColor = SystemColors.WindowText;
            nudMetros.Location = new Point(253, 238);
            nudMetros.Maximum = new decimal(new int[] { 20000, 0, 0, 0 });
            nudMetros.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudMetros.Name = "nudMetros";
            nudMetros.Size = new Size(77, 23);
            nudMetros.TabIndex = 66;
            nudMetros.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblAntiguedad
            // 
            lblAntiguedad.AutoSize = true;
            lblAntiguedad.BackColor = Color.FromArgb(158, 255, 255, 255);
            lblAntiguedad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblAntiguedad.Location = new Point(56, 286);
            lblAntiguedad.Name = "lblAntiguedad";
            lblAntiguedad.Size = new Size(93, 21);
            lblAntiguedad.TabIndex = 65;
            lblAntiguedad.Text = "Antigüedad:";
            // 
            // lblMetrosCuad
            // 
            lblMetrosCuad.AutoSize = true;
            lblMetrosCuad.BackColor = Color.FromArgb(158, 255, 255, 255);
            lblMetrosCuad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMetrosCuad.Location = new Point(56, 240);
            lblMetrosCuad.Name = "lblMetrosCuad";
            lblMetrosCuad.Size = new Size(137, 21);
            lblMetrosCuad.TabIndex = 64;
            lblMetrosCuad.Text = "MetrosCuadrados:";
            // 
            // lblBaños
            // 
            lblBaños.AutoSize = true;
            lblBaños.BackColor = Color.FromArgb(158, 255, 255, 255);
            lblBaños.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblBaños.Location = new Point(56, 200);
            lblBaños.Name = "lblBaños";
            lblBaños.Size = new Size(138, 21);
            lblBaños.TabIndex = 63;
            lblBaños.Text = "Numero de Baños:";
            // 
            // bttnCancelar
            // 
            bttnCancelar.Location = new Point(492, 389);
            bttnCancelar.Name = "bttnCancelar";
            bttnCancelar.Size = new Size(88, 30);
            bttnCancelar.TabIndex = 62;
            bttnCancelar.Text = "Cancelar";
            bttnCancelar.UseVisualStyleBackColor = true;
            bttnCancelar.Click += bttnCancelar_Click;
            // 
            // bttnAceptar
            // 
            bttnAceptar.Location = new Point(245, 389);
            bttnAceptar.Name = "bttnAceptar";
            bttnAceptar.Size = new Size(88, 30);
            bttnAceptar.TabIndex = 61;
            bttnAceptar.Text = "Aceptar";
            bttnAceptar.UseVisualStyleBackColor = true;
            bttnAceptar.Click += bttnAceptar_Click;
            // 
            // txtbxDireccion
            // 
            txtbxDireccion.BackColor = SystemColors.Window;
            txtbxDireccion.Enabled = false;
            txtbxDireccion.Location = new Point(172, 97);
            txtbxDireccion.Name = "txtbxDireccion";
            txtbxDireccion.Size = new Size(184, 23);
            txtbxDireccion.TabIndex = 60;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.BackColor = Color.FromArgb(158, 255, 255, 255);
            lblDireccion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDireccion.Location = new Point(56, 95);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(78, 21);
            lblDireccion.TabIndex = 59;
            lblDireccion.Text = "Direccion:";
            // 
            // lblHabitaciones
            // 
            lblHabitaciones.AutoSize = true;
            lblHabitaciones.BackColor = Color.FromArgb(158, 255, 255, 255);
            lblHabitaciones.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblHabitaciones.Location = new Point(56, 150);
            lblHabitaciones.Name = "lblHabitaciones";
            lblHabitaciones.Size = new Size(185, 21);
            lblHabitaciones.TabIndex = 58;
            lblHabitaciones.Text = "Numero de Habitaciones:";
            // 
            // lblEnVenta
            // 
            lblEnVenta.AutoSize = true;
            lblEnVenta.BackColor = Color.FromArgb(148, 255, 228, 196);
            lblEnVenta.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblEnVenta.Location = new Point(313, 31);
            lblEnVenta.Name = "lblEnVenta";
            lblEnVenta.Size = new Size(168, 32);
            lblEnVenta.TabIndex = 57;
            lblEnVenta.Text = "Datos EnVenta";
            // 
            // nudPrecioMetro
            // 
            nudPrecioMetro.BackColor = SystemColors.Window;
            nudPrecioMetro.Location = new Point(561, 241);
            nudPrecioMetro.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudPrecioMetro.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            nudPrecioMetro.Name = "nudPrecioMetro";
            nudPrecioMetro.Size = new Size(91, 23);
            nudPrecioMetro.TabIndex = 81;
            nudPrecioMetro.Value = new decimal(new int[] { 10, 0, 0, 0 });
            nudPrecioMetro.ValueChanged += nudPrecioMetro_ValueChanged;
            // 
            // lblPrecioMetro
            // 
            lblPrecioMetro.AutoSize = true;
            lblPrecioMetro.BackColor = Color.FromArgb(158, 255, 255, 255);
            lblPrecioMetro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrecioMetro.Location = new Point(432, 238);
            lblPrecioMetro.Name = "lblPrecioMetro";
            lblPrecioMetro.Size = new Size(106, 21);
            lblPrecioMetro.TabIndex = 80;
            lblPrecioMetro.Text = "Precio Metro :";
            // 
            // nudPrecio
            // 
            nudPrecio.BackColor = SystemColors.Window;
            nudPrecio.Enabled = false;
            nudPrecio.Location = new Point(561, 290);
            nudPrecio.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            nudPrecio.Name = "nudPrecio";
            nudPrecio.Size = new Size(91, 23);
            nudPrecio.TabIndex = 79;
            nudPrecio.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.BackColor = Color.FromArgb(158, 255, 255, 255);
            lblPrecio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrecio.Location = new Point(432, 287);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(56, 21);
            lblPrecio.TabIndex = 78;
            lblPrecio.Text = "Precio:";
            // 
            // ModificarEnVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondo_Modificaciones;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(nudPrecioMetro);
            Controls.Add(lblPrecioMetro);
            Controls.Add(nudPrecio);
            Controls.Add(lblPrecio);
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
            Controls.Add(lblEnVenta);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ModificarEnVenta";
            Text = "ModificarEnVenta";
            Load += ModificarEnVenta_Load;
            ((System.ComponentModel.ISupportInitialize)nudAntiguedad).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudBaños).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudHabitaciones).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMetros).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPrecioMetro).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPrecio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbxPropietario;
        private TextBox txtbxLocalidad;
        private Label lblLocalidad;
        private Label lblPropietario;
        private ComboBox cmbxDisponible;
        private Label lblDisponible;
        private NumericUpDown nudAntiguedad;
        private NumericUpDown nudBaños;
        private NumericUpDown nudHabitaciones;
        private NumericUpDown nudMetros;
        private Label lblAntiguedad;
        private Label lblMetrosCuad;
        private Label lblBaños;
        private Button bttnCancelar;
        private Button bttnAceptar;
        private TextBox txtbxDireccion;
        private Label lblDireccion;
        private Label lblHabitaciones;
        private Label lblEnVenta;
        private NumericUpDown nudPrecioMetro;
        private Label lblPrecioMetro;
        private NumericUpDown nudPrecio;
        private Label lblPrecio;
    }
}