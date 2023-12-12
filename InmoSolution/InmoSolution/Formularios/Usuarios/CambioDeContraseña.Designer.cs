namespace InmoSolution.Formularios.Usuarios
{
    partial class CambioDeContraseña
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
            pbxClave2 = new PictureBox();
            pbxClave1 = new PictureBox();
            txtbxClave2 = new TextBox();
            txtbxClave1 = new TextBox();
            bttnAceptar = new Button();
            bttnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)pbxClave2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxClave1).BeginInit();
            SuspendLayout();
            // 
            // pbxClave2
            // 
            pbxClave2.BackColor = Color.FromArgb(58, 0, 0, 0);
            pbxClave2.BackgroundImageLayout = ImageLayout.None;
            pbxClave2.Image = Properties.Resources.visible;
            pbxClave2.Location = new Point(267, 134);
            pbxClave2.Name = "pbxClave2";
            pbxClave2.Size = new Size(28, 23);
            pbxClave2.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxClave2.TabIndex = 16;
            pbxClave2.TabStop = false;
            pbxClave2.Click += pbxClave2_Click;
            // 
            // pbxClave1
            // 
            pbxClave1.BackColor = Color.FromArgb(58, 0, 0, 0);
            pbxClave1.BackgroundImageLayout = ImageLayout.None;
            pbxClave1.Image = Properties.Resources.visible;
            pbxClave1.Location = new Point(267, 88);
            pbxClave1.Name = "pbxClave1";
            pbxClave1.Size = new Size(28, 23);
            pbxClave1.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxClave1.TabIndex = 15;
            pbxClave1.TabStop = false;
            pbxClave1.Click += pbxClave1_Click;
            // 
            // txtbxClave2
            // 
            txtbxClave2.Location = new Point(64, 134);
            txtbxClave2.Name = "txtbxClave2";
            txtbxClave2.PasswordChar = '*';
            txtbxClave2.PlaceholderText = "Reintroduce la nueva contraseña:";
            txtbxClave2.Size = new Size(184, 23);
            txtbxClave2.TabIndex = 14;
            // 
            // txtbxClave1
            // 
            txtbxClave1.Location = new Point(64, 88);
            txtbxClave1.Name = "txtbxClave1";
            txtbxClave1.PasswordChar = '*';
            txtbxClave1.PlaceholderText = "Introduce la nueva contraseña:";
            txtbxClave1.Size = new Size(184, 23);
            txtbxClave1.TabIndex = 13;
            // 
            // bttnAceptar
            // 
            bttnAceptar.Location = new Point(81, 193);
            bttnAceptar.Name = "bttnAceptar";
            bttnAceptar.Size = new Size(83, 27);
            bttnAceptar.TabIndex = 17;
            bttnAceptar.Text = "Aceptar";
            bttnAceptar.UseVisualStyleBackColor = true;
            bttnAceptar.Click += bttnAceptar_Click;
            // 
            // bttnCancelar
            // 
            bttnCancelar.Location = new Point(199, 193);
            bttnCancelar.Name = "bttnCancelar";
            bttnCancelar.Size = new Size(83, 27);
            bttnCancelar.TabIndex = 18;
            bttnCancelar.Text = "Cancelar";
            bttnCancelar.UseVisualStyleBackColor = true;
            bttnCancelar.Click += bttnCancelar_Click;
            // 
            // CambioDeContraseña
            // 
            AcceptButton = bttnAceptar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Cambiar_contraseña;
            BackgroundImageLayout = ImageLayout.Stretch;
            CancelButton = bttnCancelar;
            ClientSize = new Size(356, 250);
            Controls.Add(bttnCancelar);
            Controls.Add(bttnAceptar);
            Controls.Add(pbxClave2);
            Controls.Add(pbxClave1);
            Controls.Add(txtbxClave2);
            Controls.Add(txtbxClave1);
            Name = "CambioDeContraseña";
            Text = "CambioDeContraseña";
            ((System.ComponentModel.ISupportInitialize)pbxClave2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxClave1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbxClave2;
        private PictureBox pbxClave1;
        private TextBox txtbxClave2;
        private TextBox txtbxClave1;
        private Button bttnAceptar;
        private Button bttnCancelar;
    }
}