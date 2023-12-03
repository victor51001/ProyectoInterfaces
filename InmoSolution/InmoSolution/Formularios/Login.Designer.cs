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
            bttnEntrar = new Button();
            pnlLogin = new Panel();
            pnlLogin.SuspendLayout();
            SuspendLayout();
            // 
            // lblSesion
            // 
            lblSesion.Anchor = AnchorStyles.Top;
            lblSesion.BackColor = Color.FromArgb(128, 245, 245, 245);
            lblSesion.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblSesion.ForeColor = SystemColors.ControlText;
            lblSesion.Location = new Point(17, 0);
            lblSesion.Name = "lblSesion";
            lblSesion.Size = new Size(167, 22);
            lblSesion.TabIndex = 0;
            lblSesion.Text = "Inicio de Sesión";
            lblSesion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtbxUsuario
            // 
            txtbxUsuario.Anchor = AnchorStyles.Top;
            txtbxUsuario.BackColor = SystemColors.ControlDark;
            txtbxUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtbxUsuario.ForeColor = SystemColors.ControlText;
            txtbxUsuario.Location = new Point(17, 57);
            txtbxUsuario.Name = "txtbxUsuario";
            txtbxUsuario.PlaceholderText = "Introduce tu usuario:";
            txtbxUsuario.Size = new Size(167, 23);
            txtbxUsuario.TabIndex = 1;
            // 
            // txtbxClave
            // 
            txtbxClave.Anchor = AnchorStyles.Bottom;
            txtbxClave.BackColor = SystemColors.ControlDark;
            txtbxClave.ForeColor = SystemColors.ControlText;
            txtbxClave.Location = new Point(17, 111);
            txtbxClave.Name = "txtbxClave";
            txtbxClave.PasswordChar = '*';
            txtbxClave.PlaceholderText = "Introduce tu clave:";
            txtbxClave.Size = new Size(167, 22);
            txtbxClave.TabIndex = 2;
            // 
            // bttnEntrar
            // 
            bttnEntrar.Anchor = AnchorStyles.Bottom;
            bttnEntrar.Cursor = Cursors.Hand;
            bttnEntrar.Location = new Point(52, 182);
            bttnEntrar.Name = "bttnEntrar";
            bttnEntrar.Size = new Size(89, 29);
            bttnEntrar.TabIndex = 5;
            bttnEntrar.Text = "Entrar";
            bttnEntrar.UseVisualStyleBackColor = true;
            bttnEntrar.Click += bttnEntrar_Click;
            // 
            // pnlLogin
            // 
            pnlLogin.Anchor = AnchorStyles.None;
            pnlLogin.BackColor = Color.Transparent;
            pnlLogin.Controls.Add(lblSesion);
            pnlLogin.Controls.Add(bttnEntrar);
            pnlLogin.Controls.Add(txtbxUsuario);
            pnlLogin.Controls.Add(txtbxClave);
            pnlLogin.Location = new Point(96, 48);
            pnlLogin.Margin = new Padding(50);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(200, 223);
            pnlLogin.TabIndex = 6;
            // 
            // Login
            // 
            AcceptButton = bttnEntrar;
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.Fondo_login;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(387, 334);
            Controls.Add(pnlLogin);
            Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Iniciar sesion";
            Load += Login_Load;
            pnlLogin.ResumeLayout(false);
            pnlLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblSesion;
        private TextBox txtbxUsuario;
        private TextBox txtbxClave;
        private Button bttnEntrar;
        private Panel pnlLogin;
    }
}
