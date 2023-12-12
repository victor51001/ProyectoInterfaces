namespace InmoSolution.Formularios.Inmuebles.EnVenta
{
    partial class NuevoEnVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevoEnVenta));
            txtbxLocalidad = new TextBox();
            lblLocalidad = new Label();
            cmbxPropietario = new ComboBox();
            lblPropietario = new Label();
            cmbxDisponible = new ComboBox();
            nudMetros = new NumericUpDown();
            nudBaños = new NumericUpDown();
            nudHabitaciones = new NumericUpDown();
            lblMetros = new Label();
            bttnCancelar = new Button();
            bttnAceptar = new Button();
            nudAntiguedad = new NumericUpDown();
            lblDisponible = new Label();
            lblAntiguedad = new Label();
            lblBaños = new Label();
            lblHabitaciones = new Label();
            txtbxDireccion = new TextBox();
            lblDireccion = new Label();
            nudPrecioMetro = new NumericUpDown();
            lblPrecioMetro = new Label();
            ((System.ComponentModel.ISupportInitialize)nudMetros).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudBaños).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudHabitaciones).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudAntiguedad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPrecioMetro).BeginInit();
            SuspendLayout();
            // 
            // txtbxLocalidad
            // 
            txtbxLocalidad.BackColor = SystemColors.Window;
            txtbxLocalidad.Location = new Point(506, 276);
            txtbxLocalidad.Name = "txtbxLocalidad";
            txtbxLocalidad.Size = new Size(170, 23);
            txtbxLocalidad.TabIndex = 76;
            // 
            // lblLocalidad
            // 
            lblLocalidad.AutoSize = true;
            lblLocalidad.BackColor = Color.FromArgb(128, 139, 69, 19);
            lblLocalidad.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblLocalidad.ForeColor = SystemColors.ControlText;
            lblLocalidad.Location = new Point(394, 281);
            lblLocalidad.Name = "lblLocalidad";
            lblLocalidad.Size = new Size(84, 18);
            lblLocalidad.TabIndex = 75;
            lblLocalidad.Text = "Localidad: ";
            // 
            // cmbxPropietario
            // 
            cmbxPropietario.FormattingEnabled = true;
            cmbxPropietario.Items.AddRange(new object[] { "Si", "No" });
            cmbxPropietario.Location = new Point(506, 218);
            cmbxPropietario.Name = "cmbxPropietario";
            cmbxPropietario.Size = new Size(115, 23);
            cmbxPropietario.TabIndex = 74;
            // 
            // lblPropietario
            // 
            lblPropietario.AutoSize = true;
            lblPropietario.BackColor = Color.FromArgb(128, 139, 69, 19);
            lblPropietario.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblPropietario.ForeColor = SystemColors.ControlText;
            lblPropietario.Location = new Point(393, 224);
            lblPropietario.Name = "lblPropietario";
            lblPropietario.Size = new Size(95, 18);
            lblPropietario.TabIndex = 73;
            lblPropietario.Text = "Propietario: ";
            // 
            // cmbxDisponible
            // 
            cmbxDisponible.FormattingEnabled = true;
            cmbxDisponible.Items.AddRange(new object[] { "Si", "No" });
            cmbxDisponible.Location = new Point(506, 147);
            cmbxDisponible.Name = "cmbxDisponible";
            cmbxDisponible.Size = new Size(77, 23);
            cmbxDisponible.TabIndex = 72;
            // 
            // nudMetros
            // 
            nudMetros.InterceptArrowKeys = false;
            nudMetros.Location = new Point(231, 277);
            nudMetros.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudMetros.Name = "nudMetros";
            nudMetros.Size = new Size(64, 23);
            nudMetros.TabIndex = 71;
            // 
            // nudBaños
            // 
            nudBaños.InterceptArrowKeys = false;
            nudBaños.Location = new Point(231, 219);
            nudBaños.Name = "nudBaños";
            nudBaños.Size = new Size(64, 23);
            nudBaños.TabIndex = 70;
            // 
            // nudHabitaciones
            // 
            nudHabitaciones.InterceptArrowKeys = false;
            nudHabitaciones.Location = new Point(231, 148);
            nudHabitaciones.Name = "nudHabitaciones";
            nudHabitaciones.Size = new Size(64, 23);
            nudHabitaciones.TabIndex = 69;
            // 
            // lblMetros
            // 
            lblMetros.AutoSize = true;
            lblMetros.BackColor = Color.FromArgb(128, 139, 69, 19);
            lblMetros.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblMetros.ForeColor = SystemColors.ControlText;
            lblMetros.Location = new Point(50, 282);
            lblMetros.Name = "lblMetros";
            lblMetros.Size = new Size(139, 18);
            lblMetros.TabIndex = 68;
            lblMetros.Text = "Metros Cudrados: ";
            // 
            // bttnCancelar
            // 
            bttnCancelar.Location = new Point(444, 404);
            bttnCancelar.Name = "bttnCancelar";
            bttnCancelar.Size = new Size(95, 31);
            bttnCancelar.TabIndex = 67;
            bttnCancelar.Text = "Cancelar";
            bttnCancelar.UseVisualStyleBackColor = true;
            bttnCancelar.Click += bttnCancelar_Click;
            // 
            // bttnAceptar
            // 
            bttnAceptar.Location = new Point(147, 404);
            bttnAceptar.Name = "bttnAceptar";
            bttnAceptar.Size = new Size(95, 31);
            bttnAceptar.TabIndex = 66;
            bttnAceptar.Text = "Aceptar";
            bttnAceptar.UseVisualStyleBackColor = true;
            bttnAceptar.Click += bttnAceptar_Click;
            // 
            // nudAntiguedad
            // 
            nudAntiguedad.InterceptArrowKeys = false;
            nudAntiguedad.Location = new Point(506, 84);
            nudAntiguedad.Name = "nudAntiguedad";
            nudAntiguedad.Size = new Size(64, 23);
            nudAntiguedad.TabIndex = 65;
            // 
            // lblDisponible
            // 
            lblDisponible.AutoSize = true;
            lblDisponible.BackColor = Color.FromArgb(128, 139, 69, 19);
            lblDisponible.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblDisponible.ForeColor = SystemColors.ControlText;
            lblDisponible.Location = new Point(393, 153);
            lblDisponible.Name = "lblDisponible";
            lblDisponible.Size = new Size(92, 18);
            lblDisponible.TabIndex = 64;
            lblDisponible.Text = "Disponible: ";
            // 
            // lblAntiguedad
            // 
            lblAntiguedad.AutoSize = true;
            lblAntiguedad.BackColor = Color.FromArgb(128, 139, 69, 19);
            lblAntiguedad.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblAntiguedad.ForeColor = SystemColors.ControlText;
            lblAntiguedad.Location = new Point(393, 89);
            lblAntiguedad.Name = "lblAntiguedad";
            lblAntiguedad.Size = new Size(96, 18);
            lblAntiguedad.TabIndex = 63;
            lblAntiguedad.Text = "Antigüedad: ";
            // 
            // lblBaños
            // 
            lblBaños.AutoSize = true;
            lblBaños.BackColor = Color.FromArgb(128, 139, 69, 19);
            lblBaños.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblBaños.ForeColor = SystemColors.ControlText;
            lblBaños.Location = new Point(50, 224);
            lblBaños.Name = "lblBaños";
            lblBaños.Size = new Size(61, 18);
            lblBaños.TabIndex = 62;
            lblBaños.Text = "Baños: ";
            // 
            // lblHabitaciones
            // 
            lblHabitaciones.AutoSize = true;
            lblHabitaciones.BackColor = Color.FromArgb(128, 139, 69, 19);
            lblHabitaciones.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblHabitaciones.ForeColor = SystemColors.ControlText;
            lblHabitaciones.Location = new Point(50, 153);
            lblHabitaciones.Name = "lblHabitaciones";
            lblHabitaciones.Size = new Size(104, 18);
            lblHabitaciones.TabIndex = 61;
            lblHabitaciones.Text = "Habitaciones:";
            // 
            // txtbxDireccion
            // 
            txtbxDireccion.BackColor = SystemColors.Window;
            txtbxDireccion.Location = new Point(162, 84);
            txtbxDireccion.Name = "txtbxDireccion";
            txtbxDireccion.Size = new Size(170, 23);
            txtbxDireccion.TabIndex = 60;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.BackColor = Color.FromArgb(128, 139, 69, 19);
            lblDireccion.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblDireccion.ForeColor = SystemColors.ControlText;
            lblDireccion.Location = new Point(50, 89);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(84, 18);
            lblDireccion.TabIndex = 59;
            lblDireccion.Text = "Direccion: ";
            // 
            // nudPrecioMetro
            // 
            nudPrecioMetro.InterceptArrowKeys = false;
            nudPrecioMetro.Location = new Point(231, 338);
            nudPrecioMetro.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudPrecioMetro.Name = "nudPrecioMetro";
            nudPrecioMetro.Size = new Size(64, 23);
            nudPrecioMetro.TabIndex = 78;
            // 
            // lblPrecioMetro
            // 
            lblPrecioMetro.AutoSize = true;
            lblPrecioMetro.BackColor = Color.FromArgb(128, 139, 69, 19);
            lblPrecioMetro.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrecioMetro.ForeColor = SystemColors.ControlText;
            lblPrecioMetro.Location = new Point(50, 343);
            lblPrecioMetro.Name = "lblPrecioMetro";
            lblPrecioMetro.Size = new Size(108, 18);
            lblPrecioMetro.TabIndex = 77;
            lblPrecioMetro.Text = "Precio Metro: ";
            // 
            // NuevoEnVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondo_Altas;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(726, 481);
            Controls.Add(nudPrecioMetro);
            Controls.Add(lblPrecioMetro);
            Controls.Add(txtbxLocalidad);
            Controls.Add(lblLocalidad);
            Controls.Add(cmbxPropietario);
            Controls.Add(lblPropietario);
            Controls.Add(cmbxDisponible);
            Controls.Add(nudMetros);
            Controls.Add(nudBaños);
            Controls.Add(nudHabitaciones);
            Controls.Add(lblMetros);
            Controls.Add(bttnCancelar);
            Controls.Add(bttnAceptar);
            Controls.Add(nudAntiguedad);
            Controls.Add(lblDisponible);
            Controls.Add(lblAntiguedad);
            Controls.Add(lblBaños);
            Controls.Add(lblHabitaciones);
            Controls.Add(txtbxDireccion);
            Controls.Add(lblDireccion);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "NuevoEnVenta";
            Text = "NuevoEnVenta";
            Load += NuevoEnVenta_Load;
            ((System.ComponentModel.ISupportInitialize)nudMetros).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudBaños).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudHabitaciones).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudAntiguedad).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPrecioMetro).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtbxLocalidad;
        private Label lblLocalidad;
        private ComboBox cmbxPropietario;
        private Label lblPropietario;
        private ComboBox cmbxDisponible;
        private NumericUpDown nudMetros;
        private NumericUpDown nudBaños;
        private NumericUpDown nudHabitaciones;
        private Label lblMetros;
        private Button bttnCancelar;
        private Button bttnAceptar;
        private NumericUpDown nudAntiguedad;
        private Label lblDisponible;
        private Label lblAntiguedad;
        private Label lblBaños;
        private Label lblHabitaciones;
        private TextBox txtbxDireccion;
        private Label lblDireccion;
        private NumericUpDown nudPrecioMetro;
        private Label lblPrecioMetro;
    }
}