namespace InmoSolution.Formularios.Usuarios
{
    partial class NuevoUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevoUsuario));
            lblUser = new Label();
            lblPassword1 = new Label();
            lblPassword2 = new Label();
            txtbxUser = new TextBox();
            txtbxPass1 = new TextBox();
            txtbxPass2 = new TextBox();
            bttnAceptar = new Button();
            bttnCancelar = new Button();
            pbxPass1 = new PictureBox();
            pbxPass2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbxPass1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxPass2).BeginInit();
            SuspendLayout();
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.BackColor = Color.Moccasin;
            lblUser.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            lblUser.ForeColor = SystemColors.ControlText;
            lblUser.Location = new Point(146, 88);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(153, 18);
            lblUser.TabIndex = 0;
            lblUser.Text = "Nombre de Usuario: ";
            // 
            // lblPassword1
            // 
            lblPassword1.AutoSize = true;
            lblPassword1.BackColor = Color.Moccasin;
            lblPassword1.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            lblPassword1.Location = new Point(146, 197);
            lblPassword1.Name = "lblPassword1";
            lblPassword1.Size = new Size(94, 18);
            lblPassword1.TabIndex = 1;
            lblPassword1.Text = "Contraseña:";
            // 
            // lblPassword2
            // 
            lblPassword2.AutoSize = true;
            lblPassword2.BackColor = Color.Moccasin;
            lblPassword2.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            lblPassword2.Location = new Point(148, 280);
            lblPassword2.Name = "lblPassword2";
            lblPassword2.Size = new Size(151, 18);
            lblPassword2.TabIndex = 2;
            lblPassword2.Text = "Repetir Contraseña:";
            // 
            // txtbxUser
            // 
            txtbxUser.BackColor = Color.Silver;
            txtbxUser.Location = new Point(146, 124);
            txtbxUser.Name = "txtbxUser";
            txtbxUser.Size = new Size(170, 23);
            txtbxUser.TabIndex = 3;
            // 
            // txtbxPass1
            // 
            txtbxPass1.BackColor = Color.Silver;
            txtbxPass1.Location = new Point(146, 229);
            txtbxPass1.Name = "txtbxPass1";
            txtbxPass1.PasswordChar = '*';
            txtbxPass1.Size = new Size(202, 23);
            txtbxPass1.TabIndex = 4;
            // 
            // txtbxPass2
            // 
            txtbxPass2.BackColor = Color.Silver;
            txtbxPass2.Location = new Point(148, 325);
            txtbxPass2.Name = "txtbxPass2";
            txtbxPass2.PasswordChar = '*';
            txtbxPass2.Size = new Size(200, 23);
            txtbxPass2.TabIndex = 5;
            // 
            // bttnAceptar
            // 
            bttnAceptar.Cursor = Cursors.Hand;
            bttnAceptar.Location = new Point(89, 398);
            bttnAceptar.Name = "bttnAceptar";
            bttnAceptar.Size = new Size(124, 31);
            bttnAceptar.TabIndex = 6;
            bttnAceptar.Text = "Aceptar";
            bttnAceptar.UseVisualStyleBackColor = true;
            bttnAceptar.Click += bttnAceptar_Click;
            // 
            // bttnCancelar
            // 
            bttnCancelar.Cursor = Cursors.Hand;
            bttnCancelar.Location = new Point(289, 398);
            bttnCancelar.Name = "bttnCancelar";
            bttnCancelar.Size = new Size(124, 31);
            bttnCancelar.TabIndex = 7;
            bttnCancelar.Text = "Cancelar";
            bttnCancelar.UseVisualStyleBackColor = true;
            bttnCancelar.Click += bttnCancelar_Click;
            // 
            // pbxPass1
            // 
            pbxPass1.BackColor = Color.Transparent;
            pbxPass1.Cursor = Cursors.Hand;
            pbxPass1.Image = Properties.Resources.visible;
            pbxPass1.Location = new Point(354, 229);
            pbxPass1.Name = "pbxPass1";
            pbxPass1.Size = new Size(27, 23);
            pbxPass1.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxPass1.TabIndex = 8;
            pbxPass1.TabStop = false;
            pbxPass1.Click += pictureBox1_Click;
            // 
            // pbxPass2
            // 
            pbxPass2.BackColor = Color.Transparent;
            pbxPass2.Cursor = Cursors.Hand;
            pbxPass2.Image = Properties.Resources.visible;
            pbxPass2.Location = new Point(354, 325);
            pbxPass2.Name = "pbxPass2";
            pbxPass2.Size = new Size(27, 23);
            pbxPass2.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxPass2.TabIndex = 9;
            pbxPass2.TabStop = false;
            pbxPass2.Click += pictureBox2_Click;
            // 
            // NuevoUsuario
            // 
            AcceptButton = bttnAceptar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Crear_usuario;
            BackgroundImageLayout = ImageLayout.Stretch;
            CancelButton = bttnCancelar;
            ClientSize = new Size(560, 471);
            Controls.Add(pbxPass2);
            Controls.Add(pbxPass1);
            Controls.Add(bttnCancelar);
            Controls.Add(bttnAceptar);
            Controls.Add(txtbxPass2);
            Controls.Add(txtbxPass1);
            Controls.Add(txtbxUser);
            Controls.Add(lblPassword2);
            Controls.Add(lblPassword1);
            Controls.Add(lblUser);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "NuevoUsuario";
            Text = "Crear Usuario";
            Load += NuevoUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)pbxPass1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxPass2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUser;
        private Label lblPassword1;
        private Label lblPassword2;
        private TextBox txtbxUser;
        private TextBox txtbxPass1;
        private TextBox txtbxPass2;
        private Button bttnAceptar;
        private Button bttnCancelar;
        private PictureBox pbxPass1;
        private PictureBox pbxPass2;
    }
}