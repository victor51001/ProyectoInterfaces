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
            bttnOrdenar = new Button();
            chkLstbxUsuarios = new CheckedListBox();
            bttnEliminar = new Button();
            SuspendLayout();
            // 
            // lblUsuarios
            // 
            resources.ApplyResources(lblUsuarios, "lblUsuarios");
            lblUsuarios.BackColor = Color.FromArgb(158, 70, 130, 180);
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
            // bttnOrdenar
            // 
            resources.ApplyResources(bttnOrdenar, "bttnOrdenar");
            bttnOrdenar.Name = "bttnOrdenar";
            bttnOrdenar.UseVisualStyleBackColor = true;
            bttnOrdenar.Click += bttnOrdenar_Click;
            // 
            // chkLstbxUsuarios
            // 
            chkLstbxUsuarios.BackColor = SystemColors.Menu;
            chkLstbxUsuarios.FormattingEnabled = true;
            resources.ApplyResources(chkLstbxUsuarios, "chkLstbxUsuarios");
            chkLstbxUsuarios.Name = "chkLstbxUsuarios";
            // 
            // bttnEliminar
            // 
            resources.ApplyResources(bttnEliminar, "bttnEliminar");
            bttnEliminar.Name = "bttnEliminar";
            bttnEliminar.UseVisualStyleBackColor = true;
            bttnEliminar.Click += bttnEliminar_Click;
            // 
            // ListadoUsuarios
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Lista_usuarios;
            CancelButton = bttnCancelar;
            Controls.Add(bttnEliminar);
            Controls.Add(chkLstbxUsuarios);
            Controls.Add(bttnOrdenar);
            Controls.Add(bttnCancelar);
            Controls.Add(bttnModificar);
            Controls.Add(lblUsuarios);
            Name = "ListadoUsuarios";
            Load += ListadoUsuarios_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblUsuarios;
        private Button bttnModificar;
        private Button bttnCancelar;
        private Button bttnOrdenar;
        private CheckedListBox chkLstbxUsuarios;
        private Button bttnEliminar;
    }
}