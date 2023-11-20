namespace InmoSolution
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            lblSesion = new Label();
            txtbxUsuario = new TextBox();
            txtbxClave = new TextBox();
            lbllnkCrear = new LinkLabel();
            bttnEntrar = new Button();
            SuspendLayout();
            // 
            // lblSesion
            // 
            lblSesion.BackColor = Color.WhiteSmoke;
            lblSesion.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            lblSesion.ForeColor = SystemColors.ControlText;
            lblSesion.Location = new Point(113, 74);
            lblSesion.Name = "lblSesion";
            lblSesion.Size = new Size(167, 22);
            lblSesion.TabIndex = 0;
            lblSesion.Text = "Inicio de Sesión";
            lblSesion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtbxUsuario
            // 
            txtbxUsuario.BackColor = SystemColors.ControlDark;
            txtbxUsuario.Font = new Font("Segoe UI", 9F);
            txtbxUsuario.ForeColor = SystemColors.ControlText;
            txtbxUsuario.Location = new Point(113, 144);
            txtbxUsuario.Name = "txtbxUsuario";
            txtbxUsuario.PlaceholderText = "Introduce tu usuario:";
            txtbxUsuario.Size = new Size(167, 23);
            txtbxUsuario.TabIndex = 1;
            // 
            // txtbxClave
            // 
            txtbxClave.BackColor = SystemColors.ControlDark;
            txtbxClave.ForeColor = SystemColors.ControlText;
            txtbxClave.Location = new Point(113, 192);
            txtbxClave.Name = "txtbxClave";
            txtbxClave.PasswordChar = '*';
            txtbxClave.PlaceholderText = "Introduce tu clave:";
            txtbxClave.Size = new Size(167, 22);
            txtbxClave.TabIndex = 2;
            // 
            // lbllnkCrear
            // 
            lbllnkCrear.AutoSize = true;
            lbllnkCrear.BackColor = Color.IndianRed;
            lbllnkCrear.Cursor = Cursors.Hand;
            lbllnkCrear.ForeColor = SystemColors.ControlText;
            lbllnkCrear.Location = new Point(12, 311);
            lbllnkCrear.Name = "lbllnkCrear";
            lbllnkCrear.Size = new Size(98, 13);
            lbllnkCrear.TabIndex = 4;
            lbllnkCrear.TabStop = true;
            lbllnkCrear.Text = "No tengo usuario";
            lbllnkCrear.LinkClicked += lbllnkCrear_LinkClicked;
            // 
            // bttnEntrar
            // 
            bttnEntrar.Cursor = Cursors.Hand;
            bttnEntrar.Location = new Point(152, 266);
            bttnEntrar.Name = "bttnEntrar";
            bttnEntrar.Size = new Size(89, 29);
            bttnEntrar.TabIndex = 5;
            bttnEntrar.Text = "Entrar";
            bttnEntrar.UseVisualStyleBackColor = true;
            bttnEntrar.Click += bttnEntrar_Click;
            // 
            // Login
            // 
            AcceptButton = bttnEntrar;
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.Login;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(387, 334);
            Controls.Add(bttnEntrar);
            Controls.Add(lbllnkCrear);
            Controls.Add(txtbxClave);
            Controls.Add(txtbxUsuario);
            Controls.Add(lblSesion);
            Font = new Font("Segoe UI", 8F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Iniciar sesion";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSesion;
        private TextBox txtbxUsuario;
        private TextBox txtbxClave;
        private LinkLabel lbllnkCrear;
        private Button bttnEntrar;
    }
}
