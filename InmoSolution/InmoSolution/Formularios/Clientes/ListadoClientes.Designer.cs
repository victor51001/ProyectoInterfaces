namespace InmoSolution.Formularios.Clientes
{
    partial class ListadoClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListadoClientes));
            bttnEliminar = new Button();
            bttnCancelar = new Button();
            bttnModificar = new Button();
            lblClientes = new Label();
            grpbxOrdenar = new GroupBox();
            rdbttnEmail = new RadioButton();
            rdbttnTelefono = new RadioButton();
            rdbttnNombre = new RadioButton();
            rdbttnApellidos = new RadioButton();
            rdbttnDni = new RadioButton();
            dgvClientes = new DataGridView();
            grpbxOrdenar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // bttnEliminar
            // 
            bttnEliminar.ImeMode = ImeMode.NoControl;
            bttnEliminar.Location = new Point(351, 467);
            bttnEliminar.Name = "bttnEliminar";
            bttnEliminar.Size = new Size(106, 37);
            bttnEliminar.TabIndex = 16;
            bttnEliminar.Text = "Eliminar";
            bttnEliminar.UseVisualStyleBackColor = true;
            bttnEliminar.Click += bttnEliminar_Click;
            // 
            // bttnCancelar
            // 
            bttnCancelar.ImeMode = ImeMode.NoControl;
            bttnCancelar.Location = new Point(553, 467);
            bttnCancelar.Name = "bttnCancelar";
            bttnCancelar.Size = new Size(106, 37);
            bttnCancelar.TabIndex = 14;
            bttnCancelar.Text = "Cancelar";
            bttnCancelar.UseVisualStyleBackColor = true;
            bttnCancelar.Click += bttnCancelar_Click;
            // 
            // bttnModificar
            // 
            bttnModificar.ImeMode = ImeMode.NoControl;
            bttnModificar.Location = new Point(156, 467);
            bttnModificar.Name = "bttnModificar";
            bttnModificar.Size = new Size(106, 37);
            bttnModificar.TabIndex = 13;
            bttnModificar.Text = "Modificar";
            bttnModificar.UseVisualStyleBackColor = true;
            bttnModificar.Click += bttnModificar_Click;
            // 
            // lblClientes
            // 
            lblClientes.AutoSize = true;
            lblClientes.BackColor = Color.FromArgb(138, 70, 130, 180);
            lblClientes.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblClientes.Location = new Point(315, 73);
            lblClientes.Name = "lblClientes";
            lblClientes.Size = new Size(111, 37);
            lblClientes.TabIndex = 12;
            lblClientes.Text = "Clientes";
            // 
            // grpbxOrdenar
            // 
            grpbxOrdenar.Controls.Add(rdbttnEmail);
            grpbxOrdenar.Controls.Add(rdbttnTelefono);
            grpbxOrdenar.Controls.Add(rdbttnNombre);
            grpbxOrdenar.Controls.Add(rdbttnApellidos);
            grpbxOrdenar.Controls.Add(rdbttnDni);
            grpbxOrdenar.Location = new Point(648, 140);
            grpbxOrdenar.Name = "grpbxOrdenar";
            grpbxOrdenar.Size = new Size(76, 144);
            grpbxOrdenar.TabIndex = 17;
            grpbxOrdenar.TabStop = false;
            grpbxOrdenar.Text = "Ordenar";
            // 
            // rdbttnEmail
            // 
            rdbttnEmail.AutoSize = true;
            rdbttnEmail.ImeMode = ImeMode.NoControl;
            rdbttnEmail.Location = new Point(0, 119);
            rdbttnEmail.Name = "rdbttnEmail";
            rdbttnEmail.Size = new Size(54, 19);
            rdbttnEmail.TabIndex = 4;
            rdbttnEmail.TabStop = true;
            rdbttnEmail.Text = "Email";
            rdbttnEmail.UseVisualStyleBackColor = true;
            rdbttnEmail.CheckedChanged += rdbttnEmail_CheckedChanged;
            // 
            // rdbttnTelefono
            // 
            rdbttnTelefono.AutoSize = true;
            rdbttnTelefono.ImeMode = ImeMode.NoControl;
            rdbttnTelefono.Location = new Point(0, 97);
            rdbttnTelefono.Name = "rdbttnTelefono";
            rdbttnTelefono.Size = new Size(70, 19);
            rdbttnTelefono.TabIndex = 3;
            rdbttnTelefono.TabStop = true;
            rdbttnTelefono.Text = "Telefono";
            rdbttnTelefono.UseVisualStyleBackColor = true;
            rdbttnTelefono.CheckedChanged += rdbttnTelefono_CheckedChanged;
            // 
            // rdbttnNombre
            // 
            rdbttnNombre.AutoSize = true;
            rdbttnNombre.ImeMode = ImeMode.NoControl;
            rdbttnNombre.Location = new Point(0, 47);
            rdbttnNombre.Name = "rdbttnNombre";
            rdbttnNombre.Size = new Size(69, 19);
            rdbttnNombre.TabIndex = 2;
            rdbttnNombre.TabStop = true;
            rdbttnNombre.Text = "Nombre";
            rdbttnNombre.UseVisualStyleBackColor = true;
            rdbttnNombre.CheckedChanged += rdbttnNombre_CheckedChanged;
            // 
            // rdbttnApellidos
            // 
            rdbttnApellidos.AutoSize = true;
            rdbttnApellidos.ImeMode = ImeMode.NoControl;
            rdbttnApellidos.Location = new Point(0, 72);
            rdbttnApellidos.Name = "rdbttnApellidos";
            rdbttnApellidos.Size = new Size(74, 19);
            rdbttnApellidos.TabIndex = 1;
            rdbttnApellidos.TabStop = true;
            rdbttnApellidos.Text = "Apellidos";
            rdbttnApellidos.UseVisualStyleBackColor = true;
            rdbttnApellidos.CheckedChanged += rdbttnApellidos_CheckedChanged;
            // 
            // rdbttnDni
            // 
            rdbttnDni.AutoSize = true;
            rdbttnDni.ImeMode = ImeMode.NoControl;
            rdbttnDni.Location = new Point(0, 22);
            rdbttnDni.Name = "rdbttnDni";
            rdbttnDni.Size = new Size(43, 19);
            rdbttnDni.TabIndex = 0;
            rdbttnDni.TabStop = true;
            rdbttnDni.Text = "Dni";
            rdbttnDni.UseVisualStyleBackColor = true;
            rdbttnDni.CheckedChanged += rdbttnDni_CheckedChanged;
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(136, 140);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowTemplate.Height = 25;
            dgvClientes.Size = new Size(462, 272);
            dgvClientes.TabIndex = 18;
            // 
            // ListadoClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondo_Listas;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(781, 647);
            Controls.Add(dgvClientes);
            Controls.Add(grpbxOrdenar);
            Controls.Add(bttnEliminar);
            Controls.Add(bttnCancelar);
            Controls.Add(bttnModificar);
            Controls.Add(lblClientes);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ListadoClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ListadoClientes";
            Load += ListadoClientes_Load;
            grpbxOrdenar.ResumeLayout(false);
            grpbxOrdenar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bttnEliminar;
        private Button bttnCancelar;
        private Button bttnModificar;
        private Label lblClientes;
        private GroupBox grpbxOrdenar;
        private RadioButton rdbttnNombre;
        private RadioButton rdbttnApellidos;
        private RadioButton rdbttnDni;
        private RadioButton rdbttnEmail;
        private RadioButton rdbttnTelefono;
        private DataGridView dgvClientes;
    }
}