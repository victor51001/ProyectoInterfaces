namespace InmoSolution.Formularios.Clientes
{
    partial class NuevoCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevoCliente));
            bttnCancelar = new Button();
            bttnAceptar = new Button();
            nudTelefono = new NumericUpDown();
            txtbxEmail = new TextBox();
            lblEmail = new Label();
            lblTelefono = new Label();
            txtbxApellidos = new TextBox();
            lblApellidos = new Label();
            txtbxNombre = new TextBox();
            lblNombre = new Label();
            txtbxDni = new TextBox();
            lblDni = new Label();
            ((System.ComponentModel.ISupportInitialize)nudTelefono).BeginInit();
            SuspendLayout();
            // 
            // bttnCancelar
            // 
            bttnCancelar.Location = new Point(448, 327);
            bttnCancelar.Name = "bttnCancelar";
            bttnCancelar.Size = new Size(95, 31);
            bttnCancelar.TabIndex = 37;
            bttnCancelar.Text = "Cancelar";
            bttnCancelar.UseVisualStyleBackColor = true;
            bttnCancelar.Click += bttnCancelar_Click;
            // 
            // bttnAceptar
            // 
            bttnAceptar.Location = new Point(151, 327);
            bttnAceptar.Name = "bttnAceptar";
            bttnAceptar.Size = new Size(95, 31);
            bttnAceptar.TabIndex = 36;
            bttnAceptar.Text = "Aceptar";
            bttnAceptar.UseVisualStyleBackColor = true;
            bttnAceptar.Click += bttnAceptar_Click;
            // 
            // nudTelefono
            // 
            nudTelefono.InterceptArrowKeys = false;
            nudTelefono.Location = new Point(507, 92);
            nudTelefono.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            nudTelefono.Name = "nudTelefono";
            nudTelefono.Size = new Size(169, 23);
            nudTelefono.TabIndex = 35;
            // 
            // txtbxEmail
            // 
            txtbxEmail.BackColor = SystemColors.Window;
            txtbxEmail.Location = new Point(506, 156);
            txtbxEmail.Name = "txtbxEmail";
            txtbxEmail.Size = new Size(170, 23);
            txtbxEmail.TabIndex = 32;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.FromArgb(128, 139, 69, 19);
            lblEmail.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmail.ForeColor = SystemColors.ControlText;
            lblEmail.Location = new Point(394, 161);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(54, 18);
            lblEmail.TabIndex = 31;
            lblEmail.Text = "Email: ";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.BackColor = Color.FromArgb(128, 139, 69, 19);
            lblTelefono.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTelefono.ForeColor = SystemColors.ControlText;
            lblTelefono.Location = new Point(394, 97);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(79, 18);
            lblTelefono.TabIndex = 30;
            lblTelefono.Text = "Telefono: ";
            // 
            // txtbxApellidos
            // 
            txtbxApellidos.BackColor = SystemColors.Window;
            txtbxApellidos.Location = new Point(163, 219);
            txtbxApellidos.Multiline = true;
            txtbxApellidos.Name = "txtbxApellidos";
            txtbxApellidos.Size = new Size(170, 40);
            txtbxApellidos.TabIndex = 29;
            // 
            // lblApellidos
            // 
            lblApellidos.AutoSize = true;
            lblApellidos.BackColor = Color.FromArgb(128, 139, 69, 19);
            lblApellidos.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblApellidos.ForeColor = SystemColors.ControlText;
            lblApellidos.Location = new Point(51, 232);
            lblApellidos.Name = "lblApellidos";
            lblApellidos.Size = new Size(81, 18);
            lblApellidos.TabIndex = 28;
            lblApellidos.Text = "Apellidos: ";
            // 
            // txtbxNombre
            // 
            txtbxNombre.BackColor = SystemColors.Window;
            txtbxNombre.Location = new Point(163, 156);
            txtbxNombre.Name = "txtbxNombre";
            txtbxNombre.Size = new Size(170, 23);
            txtbxNombre.TabIndex = 27;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.FromArgb(128, 139, 69, 19);
            lblNombre.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.ForeColor = SystemColors.ControlText;
            lblNombre.Location = new Point(51, 161);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(68, 18);
            lblNombre.TabIndex = 26;
            lblNombre.Text = "Nombre:";
            // 
            // txtbxDni
            // 
            txtbxDni.BackColor = SystemColors.Window;
            txtbxDni.Location = new Point(163, 92);
            txtbxDni.Name = "txtbxDni";
            txtbxDni.Size = new Size(170, 23);
            txtbxDni.TabIndex = 25;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.BackColor = Color.FromArgb(128, 139, 69, 19);
            lblDni.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblDni.ForeColor = SystemColors.ControlText;
            lblDni.Location = new Point(51, 97);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(40, 18);
            lblDni.TabIndex = 24;
            lblDni.Text = "Dni: ";
            // 
            // NuevoCliente
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
            Name = "NuevoCliente";
            Text = "NuevoCliente";
            ((System.ComponentModel.ISupportInitialize)nudTelefono).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bttnCancelar;
        private Button bttnAceptar;
        private NumericUpDown nudTelefono;
        private TextBox txtbxEmail;
        private Label lblEmail;
        private Label lblTelefono;
        private TextBox txtbxApellidos;
        private Label lblApellidos;
        private TextBox txtbxNombre;
        private Label lblNombre;
        private TextBox txtbxDni;
        private Label lblDni;
    }
}