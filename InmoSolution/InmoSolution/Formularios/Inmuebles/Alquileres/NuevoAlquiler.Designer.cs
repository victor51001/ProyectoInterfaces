namespace InmoSolution.Formularios.Inmuebles.Alquileres
{
    partial class NuevoAlquiler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevoAlquiler));
            bttnCancelar = new Button();
            bttnAceptar = new Button();
            nudAntiguedad = new NumericUpDown();
            lblDisponible = new Label();
            lblAntiguedad = new Label();
            lblBaños = new Label();
            lblHabitaciones = new Label();
            txtbxDireccion = new TextBox();
            lblDireccion = new Label();
            lblMetros = new Label();
            nudHabitaciones = new NumericUpDown();
            nudBaños = new NumericUpDown();
            nudMetros = new NumericUpDown();
            cmbxDisponible = new ComboBox();
            cmbxPropietario = new ComboBox();
            lblPropietario = new Label();
            txtbxLocalidad = new TextBox();
            lblLocalidad = new Label();
            ((System.ComponentModel.ISupportInitialize)nudAntiguedad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudHabitaciones).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudBaños).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMetros).BeginInit();
            SuspendLayout();
            // 
            // bttnCancelar
            // 
            bttnCancelar.Location = new Point(452, 374);
            bttnCancelar.Name = "bttnCancelar";
            bttnCancelar.Size = new Size(95, 31);
            bttnCancelar.TabIndex = 49;
            bttnCancelar.Text = "Cancelar";
            bttnCancelar.UseVisualStyleBackColor = true;
            bttnCancelar.Click += bttnCancelar_Click;
            // 
            // bttnAceptar
            // 
            bttnAceptar.Location = new Point(155, 374);
            bttnAceptar.Name = "bttnAceptar";
            bttnAceptar.Size = new Size(95, 31);
            bttnAceptar.TabIndex = 48;
            bttnAceptar.Text = "Aceptar";
            bttnAceptar.UseVisualStyleBackColor = true;
            bttnAceptar.Click += bttnAceptar_Click;
            // 
            // nudAntiguedad
            // 
            nudAntiguedad.InterceptArrowKeys = false;
            nudAntiguedad.Location = new Point(507, 92);
            nudAntiguedad.Name = "nudAntiguedad";
            nudAntiguedad.Size = new Size(64, 23);
            nudAntiguedad.TabIndex = 47;
            // 
            // lblDisponible
            // 
            lblDisponible.AutoSize = true;
            lblDisponible.BackColor = Color.FromArgb(128, 139, 69, 19);
            lblDisponible.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblDisponible.ForeColor = SystemColors.ControlText;
            lblDisponible.Location = new Point(394, 161);
            lblDisponible.Name = "lblDisponible";
            lblDisponible.Size = new Size(92, 18);
            lblDisponible.TabIndex = 45;
            lblDisponible.Text = "Disponible: ";
            // 
            // lblAntiguedad
            // 
            lblAntiguedad.AutoSize = true;
            lblAntiguedad.BackColor = Color.FromArgb(128, 139, 69, 19);
            lblAntiguedad.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblAntiguedad.ForeColor = SystemColors.ControlText;
            lblAntiguedad.Location = new Point(394, 97);
            lblAntiguedad.Name = "lblAntiguedad";
            lblAntiguedad.Size = new Size(96, 18);
            lblAntiguedad.TabIndex = 44;
            lblAntiguedad.Text = "Antigüedad: ";
            // 
            // lblBaños
            // 
            lblBaños.AutoSize = true;
            lblBaños.BackColor = Color.FromArgb(128, 139, 69, 19);
            lblBaños.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblBaños.ForeColor = SystemColors.ControlText;
            lblBaños.Location = new Point(51, 232);
            lblBaños.Name = "lblBaños";
            lblBaños.Size = new Size(61, 18);
            lblBaños.TabIndex = 42;
            lblBaños.Text = "Baños: ";
            // 
            // lblHabitaciones
            // 
            lblHabitaciones.AutoSize = true;
            lblHabitaciones.BackColor = Color.FromArgb(128, 139, 69, 19);
            lblHabitaciones.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblHabitaciones.ForeColor = SystemColors.ControlText;
            lblHabitaciones.Location = new Point(51, 161);
            lblHabitaciones.Name = "lblHabitaciones";
            lblHabitaciones.Size = new Size(104, 18);
            lblHabitaciones.TabIndex = 40;
            lblHabitaciones.Text = "Habitaciones:";
            // 
            // txtbxDireccion
            // 
            txtbxDireccion.BackColor = SystemColors.Window;
            txtbxDireccion.Location = new Point(163, 92);
            txtbxDireccion.Name = "txtbxDireccion";
            txtbxDireccion.Size = new Size(170, 23);
            txtbxDireccion.TabIndex = 39;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.BackColor = Color.FromArgb(128, 139, 69, 19);
            lblDireccion.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblDireccion.ForeColor = SystemColors.ControlText;
            lblDireccion.Location = new Point(51, 97);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(84, 18);
            lblDireccion.TabIndex = 38;
            lblDireccion.Text = "Direccion: ";
            // 
            // lblMetros
            // 
            lblMetros.AutoSize = true;
            lblMetros.BackColor = Color.FromArgb(128, 139, 69, 19);
            lblMetros.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblMetros.ForeColor = SystemColors.ControlText;
            lblMetros.Location = new Point(51, 290);
            lblMetros.Name = "lblMetros";
            lblMetros.Size = new Size(139, 18);
            lblMetros.TabIndex = 50;
            lblMetros.Text = "Metros Cudrados: ";
            // 
            // nudHabitaciones
            // 
            nudHabitaciones.InterceptArrowKeys = false;
            nudHabitaciones.Location = new Point(232, 156);
            nudHabitaciones.Name = "nudHabitaciones";
            nudHabitaciones.Size = new Size(64, 23);
            nudHabitaciones.TabIndex = 51;
            // 
            // nudBaños
            // 
            nudBaños.InterceptArrowKeys = false;
            nudBaños.Location = new Point(232, 227);
            nudBaños.Name = "nudBaños";
            nudBaños.Size = new Size(64, 23);
            nudBaños.TabIndex = 52;
            // 
            // nudMetros
            // 
            nudMetros.InterceptArrowKeys = false;
            nudMetros.Location = new Point(232, 285);
            nudMetros.Maximum = new decimal(new int[] { 20000, 0, 0, 0 });
            nudMetros.Name = "nudMetros";
            nudMetros.Size = new Size(64, 23);
            nudMetros.TabIndex = 53;
            // 
            // cmbxDisponible
            // 
            cmbxDisponible.FormattingEnabled = true;
            cmbxDisponible.Items.AddRange(new object[] { "Si", "No" });
            cmbxDisponible.Location = new Point(507, 155);
            cmbxDisponible.Name = "cmbxDisponible";
            cmbxDisponible.Size = new Size(77, 23);
            cmbxDisponible.TabIndex = 54;
            // 
            // cmbxPropietario
            // 
            cmbxPropietario.FormattingEnabled = true;
            cmbxPropietario.Items.AddRange(new object[] { "Si", "No" });
            cmbxPropietario.Location = new Point(507, 226);
            cmbxPropietario.Name = "cmbxPropietario";
            cmbxPropietario.Size = new Size(115, 23);
            cmbxPropietario.TabIndex = 56;
            // 
            // lblPropietario
            // 
            lblPropietario.AutoSize = true;
            lblPropietario.BackColor = Color.FromArgb(128, 139, 69, 19);
            lblPropietario.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblPropietario.ForeColor = SystemColors.ControlText;
            lblPropietario.Location = new Point(394, 232);
            lblPropietario.Name = "lblPropietario";
            lblPropietario.Size = new Size(95, 18);
            lblPropietario.TabIndex = 55;
            lblPropietario.Text = "Propietario: ";
            // 
            // txtbxLocalidad
            // 
            txtbxLocalidad.BackColor = SystemColors.Window;
            txtbxLocalidad.Location = new Point(507, 284);
            txtbxLocalidad.Name = "txtbxLocalidad";
            txtbxLocalidad.Size = new Size(170, 23);
            txtbxLocalidad.TabIndex = 58;
            // 
            // lblLocalidad
            // 
            lblLocalidad.AutoSize = true;
            lblLocalidad.BackColor = Color.FromArgb(128, 139, 69, 19);
            lblLocalidad.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblLocalidad.ForeColor = SystemColors.ControlText;
            lblLocalidad.Location = new Point(395, 289);
            lblLocalidad.Name = "lblLocalidad";
            lblLocalidad.Size = new Size(84, 18);
            lblLocalidad.TabIndex = 57;
            lblLocalidad.Text = "Localidad: ";
            // 
            // NuevoAlquiler
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondo_Altas;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(726, 481);
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
            Name = "NuevoAlquiler";
            Text = "NuevoAlquiler";
            Load += NuevoAlquiler_Load;
            ((System.ComponentModel.ISupportInitialize)nudAntiguedad).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudHabitaciones).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudBaños).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMetros).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bttnCancelar;
        private Button bttnAceptar;
        private NumericUpDown nudAntiguedad;
        private Label lblDisponible;
        private Label lblAntiguedad;
        private Label lblBaños;
        private Label lblHabitaciones;
        private TextBox txtbxDireccion;
        private Label lblDireccion;
        private Label lblMetros;
        private NumericUpDown nudHabitaciones;
        private NumericUpDown nudBaños;
        private NumericUpDown nudMetros;
        private ComboBox cmbxDisponible;
        private ComboBox cmbxPropietario;
        private Label lblPropietario;
        private TextBox txtbxLocalidad;
        private Label lblLocalidad;
    }
}