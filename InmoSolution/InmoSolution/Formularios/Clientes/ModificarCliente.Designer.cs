namespace InmoSolution.Formularios.Clientes
{
    partial class ModificarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarCliente));
            bttnCancelar = new Button();
            bttnAceptar = new Button();
            txtbxDni = new TextBox();
            lblDni = new Label();
            lblNombre = new Label();
            txtbxNombre = new TextBox();
            lblPerfil = new Label();
            lblApellidos = new Label();
            txtbxApellidos = new TextBox();
            lblEmail = new Label();
            txtbxEmail = new TextBox();
            lblTelefono = new Label();
            nudTelefono = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nudTelefono).BeginInit();
            SuspendLayout();
            // 
            // bttnCancelar
            // 
            bttnCancelar.Location = new Point(332, 386);
            bttnCancelar.Name = "bttnCancelar";
            bttnCancelar.Size = new Size(88, 30);
            bttnCancelar.TabIndex = 22;
            bttnCancelar.Text = "Cancelar";
            bttnCancelar.UseVisualStyleBackColor = true;
            bttnCancelar.Click += bttnCancelar_Click;
            // 
            // bttnAceptar
            // 
            bttnAceptar.Location = new Point(85, 386);
            bttnAceptar.Name = "bttnAceptar";
            bttnAceptar.Size = new Size(88, 30);
            bttnAceptar.TabIndex = 21;
            bttnAceptar.Text = "Aceptar";
            bttnAceptar.UseVisualStyleBackColor = true;
            bttnAceptar.Click += bttnAceptar_Click;
            // 
            // txtbxDni
            // 
            txtbxDni.BackColor = SystemColors.Window;
            txtbxDni.Enabled = false;
            txtbxDni.Location = new Point(280, 131);
            txtbxDni.Name = "txtbxDni";
            txtbxDni.Size = new Size(184, 23);
            txtbxDni.TabIndex = 20;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.BackColor = Color.FromArgb(158, 255, 255, 255);
            lblDni.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDni.Location = new Point(83, 133);
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
            lblNombre.Location = new Point(83, 188);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(71, 21);
            lblNombre.TabIndex = 18;
            lblNombre.Text = "Nombre:";
            // 
            // txtbxNombre
            // 
            txtbxNombre.Location = new Point(280, 186);
            txtbxNombre.Name = "txtbxNombre";
            txtbxNombre.Size = new Size(184, 23);
            txtbxNombre.TabIndex = 16;
            txtbxNombre.TextChanged += txtbxNombre_TextChanged;
            // 
            // lblPerfil
            // 
            lblPerfil.AutoSize = true;
            lblPerfil.BackColor = Color.FromArgb(148, 255, 228, 196);
            lblPerfil.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblPerfil.Location = new Point(175, 65);
            lblPerfil.Name = "lblPerfil";
            lblPerfil.Size = new Size(189, 32);
            lblPerfil.TabIndex = 15;
            lblPerfil.Text = "Perfil del Cliente";
            // 
            // lblApellidos
            // 
            lblApellidos.AutoSize = true;
            lblApellidos.BackColor = Color.FromArgb(158, 255, 255, 255);
            lblApellidos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblApellidos.Location = new Point(83, 238);
            lblApellidos.Name = "lblApellidos";
            lblApellidos.Size = new Size(77, 21);
            lblApellidos.TabIndex = 26;
            lblApellidos.Text = "Apellidos:";
            // 
            // txtbxApellidos
            // 
            txtbxApellidos.Location = new Point(280, 236);
            txtbxApellidos.Name = "txtbxApellidos";
            txtbxApellidos.Size = new Size(184, 23);
            txtbxApellidos.TabIndex = 25;
            txtbxApellidos.TextChanged += txtbxApellidos_TextChanged;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.FromArgb(158, 255, 255, 255);
            lblEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmail.Location = new Point(83, 328);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(51, 21);
            lblEmail.TabIndex = 30;
            lblEmail.Text = "Email:";
            // 
            // txtbxEmail
            // 
            txtbxEmail.Location = new Point(280, 326);
            txtbxEmail.Name = "txtbxEmail";
            txtbxEmail.Size = new Size(184, 23);
            txtbxEmail.TabIndex = 29;
            txtbxEmail.TextChanged += txtbxEmail_TextChanged;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.BackColor = Color.FromArgb(158, 255, 255, 255);
            lblTelefono.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTelefono.Location = new Point(83, 278);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(71, 21);
            lblTelefono.TabIndex = 28;
            lblTelefono.Text = "Telefono:";
            // 
            // nudTelefono
            // 
            nudTelefono.Location = new Point(280, 276);
            nudTelefono.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            nudTelefono.Name = "nudTelefono";
            nudTelefono.Size = new Size(184, 23);
            nudTelefono.TabIndex = 31;
            nudTelefono.ValueChanged += nudTelefono_ValueChanged;
            // 
            // ModificarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondo_Modificaciones;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(561, 494);
            Controls.Add(nudTelefono);
            Controls.Add(lblEmail);
            Controls.Add(txtbxEmail);
            Controls.Add(lblTelefono);
            Controls.Add(lblApellidos);
            Controls.Add(txtbxApellidos);
            Controls.Add(bttnCancelar);
            Controls.Add(bttnAceptar);
            Controls.Add(txtbxDni);
            Controls.Add(lblDni);
            Controls.Add(lblNombre);
            Controls.Add(txtbxNombre);
            Controls.Add(lblPerfil);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ModificarCliente";
            Text = "Perfil de Cliente";
            Load += ModificarCliente_Load;
            ((System.ComponentModel.ISupportInitialize)nudTelefono).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblClave;
        private Button bttnCambiarContraseña;
        private Button bttnCancelar;
        private Button bttnAceptar;
        private TextBox txtbxDni;
        private Label lblDni;
        private Label lblNombre;
        private TextBox txtbxClave;
        private TextBox txtbxNombre;
        private Label lblPerfil;
        private Label lblApellidos;
        private TextBox txtbxApellidos;
        private Label lblEmail;
        private TextBox txtbxEmail;
        private Label lblTelefono;
        private NumericUpDown nudTelefono;
    }
}