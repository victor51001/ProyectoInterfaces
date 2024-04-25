namespace InmoSolution.Formularios.Usuarios
{
    partial class ModificarEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarEmpleado));
            lblApellidos = new Label();
            bttnCancelar = new Button();
            bttnAceptar = new Button();
            txtDni = new TextBox();
            lblDni = new Label();
            lblNombre = new Label();
            txtbxApellidos = new TextBox();
            txtbxNombre = new TextBox();
            lblEmpleado = new Label();
            lblPuesto = new Label();
            lblTelefono = new Label();
            lblEmail = new Label();
            txtbxEmail = new TextBox();
            nudTelefono = new NumericUpDown();
            cmbxPuesto = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)nudTelefono).BeginInit();
            SuspendLayout();
            // 
            // lblApellidos
            // 
            lblApellidos.AutoSize = true;
            lblApellidos.BackColor = Color.FromArgb(158, 255, 255, 255);
            lblApellidos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblApellidos.Location = new Point(60, 324);
            lblApellidos.Name = "lblApellidos";
            lblApellidos.Size = new Size(74, 21);
            lblApellidos.TabIndex = 24;
            lblApellidos.Text = "Apellidos";
            // 
            // bttnCancelar
            // 
            bttnCancelar.Location = new Point(527, 442);
            bttnCancelar.Name = "bttnCancelar";
            bttnCancelar.Size = new Size(88, 30);
            bttnCancelar.TabIndex = 22;
            bttnCancelar.Text = "Cancelar";
            bttnCancelar.UseVisualStyleBackColor = true;
            bttnCancelar.Click += bttnCancelar_Click;
            // 
            // bttnAceptar
            // 
            bttnAceptar.Location = new Point(208, 442);
            bttnAceptar.Name = "bttnAceptar";
            bttnAceptar.Size = new Size(88, 30);
            bttnAceptar.TabIndex = 21;
            bttnAceptar.Text = "Aceptar";
            bttnAceptar.UseVisualStyleBackColor = true;
            bttnAceptar.Click += bttnAceptar_Click;
            // 
            // txtDni
            // 
            txtDni.BackColor = SystemColors.ScrollBar;
            txtDni.Enabled = false;
            txtDni.Location = new Point(175, 205);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(184, 23);
            txtDni.TabIndex = 20;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.BackColor = Color.FromArgb(158, 255, 255, 255);
            lblDni.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDni.Location = new Point(60, 207);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(37, 21);
            lblDni.TabIndex = 19;
            lblDni.Text = "Dni:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.FromArgb(158, 255, 255, 255);
            lblNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.Location = new Point(60, 262);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(71, 21);
            lblNombre.TabIndex = 18;
            lblNombre.Text = "Nombre:";
            // 
            // txtbxApellidos
            // 
            txtbxApellidos.BackColor = SystemColors.ScrollBar;
            txtbxApellidos.Enabled = false;
            txtbxApellidos.Location = new Point(175, 322);
            txtbxApellidos.Name = "txtbxApellidos";
            txtbxApellidos.Size = new Size(184, 23);
            txtbxApellidos.TabIndex = 17;
            // 
            // txtbxNombre
            // 
            txtbxNombre.BackColor = SystemColors.ScrollBar;
            txtbxNombre.Enabled = false;
            txtbxNombre.Location = new Point(175, 260);
            txtbxNombre.Name = "txtbxNombre";
            txtbxNombre.Size = new Size(184, 23);
            txtbxNombre.TabIndex = 16;
            // 
            // lblEmpleado
            // 
            lblEmpleado.AutoSize = true;
            lblEmpleado.BackColor = Color.FromArgb(148, 255, 228, 196);
            lblEmpleado.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmpleado.Location = new Point(344, 90);
            lblEmpleado.Name = "lblEmpleado";
            lblEmpleado.Size = new Size(120, 32);
            lblEmpleado.TabIndex = 15;
            lblEmpleado.Text = "Empleado";
            // 
            // lblPuesto
            // 
            lblPuesto.AutoSize = true;
            lblPuesto.BackColor = Color.FromArgb(158, 255, 255, 255);
            lblPuesto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPuesto.Location = new Point(446, 324);
            lblPuesto.Name = "lblPuesto";
            lblPuesto.Size = new Size(57, 21);
            lblPuesto.TabIndex = 30;
            lblPuesto.Text = "Puesto";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.BackColor = Color.FromArgb(158, 255, 255, 255);
            lblTelefono.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTelefono.Location = new Point(446, 207);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(71, 21);
            lblTelefono.TabIndex = 28;
            lblTelefono.Text = "Telefono:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.FromArgb(158, 255, 255, 255);
            lblEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmail.Location = new Point(446, 262);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(51, 21);
            lblEmail.TabIndex = 27;
            lblEmail.Text = "Email:";
            // 
            // txtbxEmail
            // 
            txtbxEmail.BackColor = SystemColors.Window;
            txtbxEmail.Location = new Point(561, 260);
            txtbxEmail.Name = "txtbxEmail";
            txtbxEmail.Size = new Size(184, 23);
            txtbxEmail.TabIndex = 25;
            txtbxEmail.TextChanged += txtbxEmail_TextChanged;
            // 
            // nudTelefono
            // 
            nudTelefono.InterceptArrowKeys = false;
            nudTelefono.Location = new Point(561, 205);
            nudTelefono.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            nudTelefono.Name = "nudTelefono";
            nudTelefono.Size = new Size(184, 23);
            nudTelefono.TabIndex = 31;
            nudTelefono.ValueChanged += nudTelefono_ValueChanged;
            // 
            // cmbxPuesto
            // 
            cmbxPuesto.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbxPuesto.FormattingEnabled = true;
            cmbxPuesto.Location = new Point(561, 322);
            cmbxPuesto.Name = "cmbxPuesto";
            cmbxPuesto.Size = new Size(184, 23);
            cmbxPuesto.TabIndex = 32;
            cmbxPuesto.SelectedValueChanged += cmbxPuesto_SelectedValueChanged;
            // 
            // ModificarEmpleado
            // 
            AcceptButton = bttnAceptar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondo_Modificaciones;
            BackgroundImageLayout = ImageLayout.Stretch;
            CancelButton = bttnCancelar;
            ClientSize = new Size(800, 579);
            Controls.Add(cmbxPuesto);
            Controls.Add(nudTelefono);
            Controls.Add(lblPuesto);
            Controls.Add(lblTelefono);
            Controls.Add(lblEmail);
            Controls.Add(txtbxEmail);
            Controls.Add(lblApellidos);
            Controls.Add(bttnCancelar);
            Controls.Add(bttnAceptar);
            Controls.Add(txtDni);
            Controls.Add(lblDni);
            Controls.Add(lblNombre);
            Controls.Add(txtbxApellidos);
            Controls.Add(txtbxNombre);
            Controls.Add(lblEmpleado);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ModificarEmpleado";
            Text = "ModificarEmpleado";
            Load += ModificarEmpleado_Load;
            ((System.ComponentModel.ISupportInitialize)nudTelefono).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblApellidos;
        private Button bttnCancelar;
        private Button bttnAceptar;
        private TextBox txtDni;
        private Label lblDni;
        private Label lblNombre;
        private TextBox txtbxApellidos;
        private TextBox txtbxNombre;
        private Label lblEmpleado;
        private Label lblPuesto;
        private Label lblTelefono;
        private Label lblEmail;
        private TextBox txtbxEmail;
        private NumericUpDown nudTelefono;
        private ComboBox cmbxPuesto;
    }
}