namespace InmoSolution.Formularios.Usuarios
{
    partial class ModificarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarUsuario));
            lblPerfil = new Label();
            txtbxNombre = new TextBox();
            txtbxClave = new TextBox();
            lblNombre = new Label();
            lblDni = new Label();
            txtDni = new TextBox();
            bttnAceptar = new Button();
            bttnCancelar = new Button();
            bttnCambiarContraseña = new Button();
            lblClave = new Label();
            SuspendLayout();
            // 
            // lblPerfil
            // 
            lblPerfil.AutoSize = true;
            lblPerfil.BackColor = Color.FromArgb(148, 255, 228, 196);
            lblPerfil.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblPerfil.Location = new Point(253, 79);
            lblPerfil.Name = "lblPerfil";
            lblPerfil.Size = new Size(67, 32);
            lblPerfil.TabIndex = 0;
            lblPerfil.Text = "Perfil";
            // 
            // txtbxNombre
            // 
            txtbxNombre.Location = new Point(284, 197);
            txtbxNombre.Name = "txtbxNombre";
            txtbxNombre.PlaceholderText = "Introduce el nombre de usuario:";
            txtbxNombre.Size = new Size(184, 23);
            txtbxNombre.TabIndex = 1;
            txtbxNombre.TextChanged += txtbxNombre_TextChanged;
            // 
            // txtbxClave
            // 
            txtbxClave.BackColor = SystemColors.ScrollBar;
            txtbxClave.Enabled = false;
            txtbxClave.Location = new Point(284, 259);
            txtbxClave.Name = "txtbxClave";
            txtbxClave.PasswordChar = '*';
            txtbxClave.Size = new Size(184, 23);
            txtbxClave.TabIndex = 2;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.FromArgb(158, 255, 255, 255);
            lblNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.Location = new Point(87, 199);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(148, 21);
            lblNombre.TabIndex = 5;
            lblNombre.Text = "Nombre de usuario:";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.BackColor = Color.FromArgb(158, 255, 255, 255);
            lblDni.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDni.Location = new Point(87, 144);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(37, 21);
            lblDni.TabIndex = 6;
            lblDni.Text = "Dni:";
            // 
            // txtDni
            // 
            txtDni.BackColor = SystemColors.ScrollBar;
            txtDni.Enabled = false;
            txtDni.Location = new Point(284, 142);
            txtDni.Name = "txtDni";
            txtDni.PlaceholderText = "Introduce el DNI:";
            txtDni.Size = new Size(184, 23);
            txtDni.TabIndex = 7;
            // 
            // bttnAceptar
            // 
            bttnAceptar.Location = new Point(81, 364);
            bttnAceptar.Name = "bttnAceptar";
            bttnAceptar.Size = new Size(88, 30);
            bttnAceptar.TabIndex = 8;
            bttnAceptar.Text = "Aceptar";
            bttnAceptar.UseVisualStyleBackColor = true;
            bttnAceptar.Click += bttnAceptar_Click;
            // 
            // bttnCancelar
            // 
            bttnCancelar.Location = new Point(400, 364);
            bttnCancelar.Name = "bttnCancelar";
            bttnCancelar.Size = new Size(88, 30);
            bttnCancelar.TabIndex = 9;
            bttnCancelar.Text = "Cancelar";
            bttnCancelar.UseVisualStyleBackColor = true;
            bttnCancelar.Click += bttnCancelar_Click;
            // 
            // bttnCambiarContraseña
            // 
            bttnCambiarContraseña.Location = new Point(239, 354);
            bttnCambiarContraseña.Name = "bttnCambiarContraseña";
            bttnCambiarContraseña.Size = new Size(88, 40);
            bttnCambiarContraseña.TabIndex = 13;
            bttnCambiarContraseña.Text = "Cambiar Contraseña";
            bttnCambiarContraseña.UseVisualStyleBackColor = true;
            bttnCambiarContraseña.Click += bttnCambiarContraseña_Click;
            // 
            // lblClave
            // 
            lblClave.AutoSize = true;
            lblClave.BackColor = Color.FromArgb(158, 255, 255, 255);
            lblClave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblClave.Location = new Point(87, 261);
            lblClave.Name = "lblClave";
            lblClave.Size = new Size(92, 21);
            lblClave.TabIndex = 14;
            lblClave.Text = "Contraseña:";
            // 
            // ModificarUsuario
            // 
            AcceptButton = bttnAceptar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondo_Modificaciones;
            BackgroundImageLayout = ImageLayout.Stretch;
            CancelButton = bttnCancelar;
            ClientSize = new Size(561, 445);
            Controls.Add(lblClave);
            Controls.Add(bttnCambiarContraseña);
            Controls.Add(bttnCancelar);
            Controls.Add(bttnAceptar);
            Controls.Add(txtDni);
            Controls.Add(lblDni);
            Controls.Add(lblNombre);
            Controls.Add(txtbxClave);
            Controls.Add(txtbxNombre);
            Controls.Add(lblPerfil);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ModificarUsuario";
            Text = "Perfil";
            Load += ModificarUsuario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPerfil;
        private TextBox txtbxNombre;
        private TextBox txtbxClave;
        private Label lblNombre;
        private Label lblDni;
        private TextBox txtDni;
        private Button bttnAceptar;
        private Button bttnCancelar;
        private Button bttnCambiarContraseña;
        private Label lblClave;
    }
}