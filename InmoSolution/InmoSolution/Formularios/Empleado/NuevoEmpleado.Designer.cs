namespace InmoSolution.Formularios.Empleado
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
            lblErrorDNI = new Label();
            lblErrorNombre = new Label();
            txtbxNombre = new TextBox();
            lblNombre = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            lblApellidos = new Label();
            lblErrorTelefono = new Label();
            txtbxTelefono = new TextBox();
            lblTelefono = new Label();
            lblPuesto = new Label();
            lblErrorEmail = new Label();
            txtbxEmail = new TextBox();
            lblEmail = new Label();
            cmbxPuesto = new ComboBox();
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
            // lblErrorDNI
            // 
            lblErrorDNI.AutoSize = true;
            lblErrorDNI.BackColor = Color.FromArgb(158, 0, 0, 0);
            lblErrorDNI.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblErrorDNI.ForeColor = Color.Red;
            lblErrorDNI.Location = new Point(199, 160);
            lblErrorDNI.Name = "lblErrorDNI";
            lblErrorDNI.Size = new Size(143, 15);
            lblErrorDNI.TabIndex = 6;
            lblErrorDNI.Text = "Introduce un DNI valido.";
            lblErrorDNI.Visible = false;
            // 
            // lblErrorNombre
            // 
            lblErrorNombre.AutoSize = true;
            lblErrorNombre.BackColor = Color.FromArgb(158, 0, 0, 0);
            lblErrorNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblErrorNombre.ForeColor = Color.Red;
            lblErrorNombre.Location = new Point(185, 224);
            lblErrorNombre.Name = "lblErrorNombre";
            lblErrorNombre.Size = new Size(165, 15);
            lblErrorNombre.TabIndex = 9;
            lblErrorNombre.Text = "Introduce un nombre valido.";
            lblErrorNombre.Visible = false;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(158, 0, 0, 0);
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(185, 304);
            label3.Name = "label3";
            label3.Size = new Size(157, 15);
            label3.TabIndex = 12;
            label3.Text = "Introduce apellidos validos.";
            label3.Visible = false;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Window;
            textBox2.Location = new Point(182, 261);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(170, 40);
            textBox2.TabIndex = 11;
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
            // lblErrorTelefono
            // 
            lblErrorTelefono.AutoSize = true;
            lblErrorTelefono.BackColor = Color.FromArgb(158, 0, 0, 0);
            lblErrorTelefono.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblErrorTelefono.ForeColor = Color.Red;
            lblErrorTelefono.Location = new Point(526, 160);
            lblErrorTelefono.Name = "lblErrorTelefono";
            lblErrorTelefono.Size = new Size(169, 15);
            lblErrorTelefono.TabIndex = 15;
            lblErrorTelefono.Text = "Introduce un telefono valido.";
            lblErrorTelefono.Visible = false;
            // 
            // txtbxTelefono
            // 
            txtbxTelefono.BackColor = SystemColors.Window;
            txtbxTelefono.Location = new Point(525, 134);
            txtbxTelefono.Name = "txtbxTelefono";
            txtbxTelefono.Size = new Size(170, 23);
            txtbxTelefono.TabIndex = 14;
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
            // lblErrorEmail
            // 
            lblErrorEmail.AutoSize = true;
            lblErrorEmail.BackColor = Color.FromArgb(158, 0, 0, 0);
            lblErrorEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblErrorEmail.ForeColor = Color.Red;
            lblErrorEmail.Location = new Point(537, 224);
            lblErrorEmail.Name = "lblErrorEmail";
            lblErrorEmail.Size = new Size(158, 15);
            lblErrorEmail.TabIndex = 18;
            lblErrorEmail.Text = "Introduce un correo valido.";
            lblErrorEmail.Visible = false;
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
            // NuevoEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondo_Altas;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(726, 450);
            Controls.Add(cmbxPuesto);
            Controls.Add(lblPuesto);
            Controls.Add(lblErrorEmail);
            Controls.Add(txtbxEmail);
            Controls.Add(lblEmail);
            Controls.Add(lblErrorTelefono);
            Controls.Add(txtbxTelefono);
            Controls.Add(lblTelefono);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(lblApellidos);
            Controls.Add(lblErrorNombre);
            Controls.Add(txtbxNombre);
            Controls.Add(lblNombre);
            Controls.Add(lblErrorDNI);
            Controls.Add(txtbxDni);
            Controls.Add(lblDni);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "NuevoEmpleado";
            Text = "Alta Empleado";
            Load += NuevoEmpleado_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtbxDni;
        private Label lblDni;
        private Label lblErrorDNI;
        private Label lblErrorNombre;
        private TextBox txtbxNombre;
        private Label lblNombre;
        private Label label3;
        private TextBox textBox2;
        private Label lblApellidos;
        private Label lblErrorTelefono;
        private TextBox txtbxTelefono;
        private Label lblTelefono;
        private Label lblPuesto;
        private Label lblErrorEmail;
        private TextBox txtbxEmail;
        private Label lblEmail;
        private ComboBox cmbxPuesto;
    }
}