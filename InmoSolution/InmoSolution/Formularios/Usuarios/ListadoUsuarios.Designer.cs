namespace InmoSolution.Formularios.Usuarios
{
    partial class ListadoUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListadoUsuarios));
            lblUsuarios = new Label();
            bttnModificar = new Button();
            bttnCancelar = new Button();
            grpbxOrdenar = new GroupBox();
            rdbttnNombre = new RadioButton();
            rdbttnLogin = new RadioButton();
            rdbttnId = new RadioButton();
            pnlUsuarios = new Panel();
            grpbxOrdenar.SuspendLayout();
            SuspendLayout();
            // 
            // lblUsuarios
            // 
            resources.ApplyResources(lblUsuarios, "lblUsuarios");
            lblUsuarios.BackColor = Color.FromArgb(138, 70, 130, 180);
            lblUsuarios.Name = "lblUsuarios";
            // 
            // bttnModificar
            // 
            resources.ApplyResources(bttnModificar, "bttnModificar");
            bttnModificar.Name = "bttnModificar";
            bttnModificar.UseVisualStyleBackColor = true;
            bttnModificar.Click += bttnModificar_Click;
            // 
            // bttnCancelar
            // 
            resources.ApplyResources(bttnCancelar, "bttnCancelar");
            bttnCancelar.Name = "bttnCancelar";
            bttnCancelar.UseVisualStyleBackColor = true;
            bttnCancelar.Click += bttnCancelar_Click;
            // 
            // grpbxOrdenar
            // 
            grpbxOrdenar.Controls.Add(rdbttnNombre);
            grpbxOrdenar.Controls.Add(rdbttnLogin);
            grpbxOrdenar.Controls.Add(rdbttnId);
            resources.ApplyResources(grpbxOrdenar, "grpbxOrdenar");
            grpbxOrdenar.Name = "grpbxOrdenar";
            grpbxOrdenar.TabStop = false;
            // 
            // rdbttnNombre
            // 
            resources.ApplyResources(rdbttnNombre, "rdbttnNombre");
            rdbttnNombre.Name = "rdbttnNombre";
            rdbttnNombre.TabStop = true;
            rdbttnNombre.UseVisualStyleBackColor = true;
            rdbttnNombre.CheckedChanged += rdbttnNombre_CheckedChanged;
            // 
            // rdbttnLogin
            // 
            resources.ApplyResources(rdbttnLogin, "rdbttnLogin");
            rdbttnLogin.Name = "rdbttnLogin";
            rdbttnLogin.TabStop = true;
            rdbttnLogin.UseVisualStyleBackColor = true;
            rdbttnLogin.CheckedChanged += rdbttnLogin_CheckedChanged;
            // 
            // rdbttnId
            // 
            resources.ApplyResources(rdbttnId, "rdbttnId");
            rdbttnId.Name = "rdbttnId";
            rdbttnId.TabStop = true;
            rdbttnId.UseVisualStyleBackColor = true;
            rdbttnId.CheckedChanged += rdbttnId_CheckedChanged;
            // 
            // pnlUsuarios
            // 
            resources.ApplyResources(pnlUsuarios, "pnlUsuarios");
            pnlUsuarios.Name = "pnlUsuarios";
            // 
            // ListadoUsuarios
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondo_Listas;
            CancelButton = bttnCancelar;
            Controls.Add(pnlUsuarios);
            Controls.Add(grpbxOrdenar);
            Controls.Add(bttnCancelar);
            Controls.Add(bttnModificar);
            Controls.Add(lblUsuarios);
            Name = "ListadoUsuarios";
            Load += ListadoUsuarios_Load;
            grpbxOrdenar.ResumeLayout(false);
            grpbxOrdenar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblUsuarios;
        private Button bttnModificar;
        private Button bttnCancelar;
        private GroupBox grpbxOrdenar;
        private RadioButton rdbttnId;
        private RadioButton rdbttnNombre;
        private RadioButton rdbttnLogin;
        private Panel pnlUsuarios;
    }
}