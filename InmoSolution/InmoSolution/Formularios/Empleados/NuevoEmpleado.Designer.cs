namespace InmoSolution.Formularios.Empleados
{
    partial class NuevoEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevoEmpleado));
            txtbxDni = new TextBox();
            lblDni = new Label();
            txtbxNombre = new TextBox();
            lblNombre = new Label();
            txtbxApellidos = new TextBox();
            lblApellidos = new Label();
            lblTelefono = new Label();
            lblPuesto = new Label();
            txtbxEmail = new TextBox();
            lblEmail = new Label();
            cmbxPuesto = new ComboBox();
            nudTelefono = new NumericUpDown();
            bttnAceptar = new Button();
            bttnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)nudTelefono).BeginInit();
            SuspendLayout();
            // 
            // txtbxDni
            // 
            txtbxDni.BackColor = SystemColors.Window;
            txtbxDni.Location = new Point(182, 134);
            txtbxDni.Name = "txtbxDni";
            txtbxDni.Size = new Size(170, 23);
            txtbxDni.TabIndex = 5;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.BackColor = Color.FromArgb(128, 139, 69, 19);
            lblDni.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblDni.ForeColor = SystemColors.ControlText;
            lblDni.Location = new Point(70, 139);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(40, 18);
            lblDni.TabIndex = 4;
            lblDni.Text = "Dni: ";
            // 
            // txtbxNombre
            // 
            txtbxNombre.BackColor = SystemColors.Window;
            txtbxNombre.Location = new Point(182, 198);
            txtbxNombre.Name = "txtbxNombre";
            txtbxNombre.Size = new Size(170, 23);
            txtbxNombre.TabIndex = 8;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.FromArgb(128, 139, 69, 19);
            lblNombre.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.ForeColor = SystemColors.ControlText;
            lblNombre.Location = new Point(70, 203);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(68, 18);
            lblNombre.TabIndex = 7;
            lblNombre.Text = "Nombre:";
            // 
            // txtbxApellidos
            // 
            txtbxApellidos.BackColor = SystemColors.Window;
            txtbxApellidos.Location = new Point(182, 261);
            txtbxApellidos.Multiline = true;
            txtbxApellidos.Name = "txtbxApellidos";
            txtbxApellidos.Size = new Size(170, 40);
            txtbxApellidos.TabIndex = 11;
            // 
            // lblApellidos
            // 
            lblApellidos.AutoSize = true;
            lblApellidos.BackColor = Color.FromArgb(128, 139, 69, 19);
            lblApellidos.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblApellidos.ForeColor = SystemColors.ControlText;
            lblApellidos.Location = new Point(70, 274);
            lblApellidos.Name = "lblApellidos";
            lblApellidos.Size = new Size(81, 18);
            lblApellidos.TabIndex = 10;
            lblApellidos.Text = "Apellidos: ";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.BackColor = Color.FromArgb(128, 139, 69, 19);
            lblTelefono.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTelefono.ForeColor = SystemColors.ControlText;
            lblTelefono.Location = new Point(413, 139);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(79, 18);
            lblTelefono.TabIndex = 13;
            lblTelefono.Text = "Telefono: ";
            // 
            // lblPuesto
            // 
            lblPuesto.AutoSize = true;
            lblPuesto.BackColor = Color.FromArgb(128, 139, 69, 19);
            lblPuesto.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblPuesto.ForeColor = SystemColors.ControlText;
            lblPuesto.Location = new Point(413, 274);
            lblPuesto.Name = "lblPuesto";
            lblPuesto.Size = new Size(66, 18);
            lblPuesto.TabIndex = 19;
            lblPuesto.Text = "Puesto: ";
            // 
            // txtbxEmail
            // 
            txtbxEmail.BackColor = SystemColors.Window;
            txtbxEmail.Location = new Point(525, 198);
            txtbxEmail.Name = "txtbxEmail";
            txtbxEmail.Size = new Size(170, 23);
            txtbxEmail.TabIndex = 17;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.FromArgb(128, 139, 69, 19);
            lblEmail.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmail.ForeColor = SystemColors.ControlText;
            lblEmail.Location = new Point(413, 203);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(54, 18);
            lblEmail.TabIndex = 16;
            lblEmail.Text = "Email: ";
            // 
            // cmbxPuesto
            // 
            cmbxPuesto.FormattingEnabled = true;
            cmbxPuesto.Location = new Point(526, 274);
            cmbxPuesto.Name = "cmbxPuesto";
            cmbxPuesto.Size = new Size(169, 23);
            cmbxPuesto.TabIndex = 20;
            // 
            // nudTelefono
            // 
            nudTelefono.InterceptArrowKeys = false;
            nudTelefono.Location = new Point(526, 134);
            nudTelefono.Name = "nudTelefono";
            nudTelefono.Size = new Size(169, 23);
            nudTelefono.TabIndex = 21;
            // 
            // bttnAceptar
            // 
            bttnAceptar.Location = new Point(170, 369);
            bttnAceptar.Name = "bttnAceptar";
            bttnAceptar.Size = new Size(95, 31);
            bttnAceptar.TabIndex = 22;
            bttnAceptar.Text = "Aceptar";
            bttnAceptar.UseVisualStyleBackColor = true;
            bttnAceptar.Click += bttnAceptar_Click;
            // 
            // bttnCancelar
            // 
            bttnCancelar.Location = new Point(467, 369);
            bttnCancelar.Name = "bttnCancelar";
            bttnCancelar.Size = new Size(95, 31);
            bttnCancelar.TabIndex = 23;
            bttnCancelar.Text = "Cancelar";
            bttnCancelar.UseVisualStyleBackColor = true;
            bttnCancelar.Click += bttnCancelar_Click;
            // 
            // NuevoEmpleado
            // 
            AcceptButton = bttnAceptar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondo_Altas;
            BackgroundImageLayout = ImageLayout.Stretch;
            CancelButton = bttnCancelar;
            ClientSize = new Size(726, 450);
            Controls.Add(bttnCancelar);
            Controls.Add(bttnAceptar);
            Controls.Add(nudTelefono);
            Controls.Add(cmbxPuesto);
            Controls.Add(lblPuesto);
            Controls.Add(txtbxEmail);
            Controls.Add(lblEmail);
            Controls.Add(lblTelefono);
            Controls.Add(txtbxApellidos);
            Controls.Add(lblApellidos);
            Controls.Add(txtbxNombre);
            Controls.Add(lblNombre);
            Controls.Add(txtbxDni);
            Controls.Add(lblDni);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "NuevoEmpleado";
            Text = "Alta Empleado";
            Load += NuevoEmpleado_Load;
            ((System.ComponentModel.ISupportInitialize)nudTelefono).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtbxDni;
        private Label lblDni;
        private TextBox txtbxNombre;
        private Label lblNombre;
        private TextBox txtbxApellidos;
        private Label lblApellidos;
        private Label lblTelefono;
        private Label lblPuesto;
        private TextBox txtbxEmail;
        private Label lblEmail;
        private ComboBox cmbxPuesto;
        private NumericUpDown nudTelefono;
        private Button bttnAceptar;
        private Button bttnCancelar;
    }
}