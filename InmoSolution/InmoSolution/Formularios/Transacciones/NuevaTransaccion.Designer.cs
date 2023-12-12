namespace InmoSolution.Formularios.Transacciones
{
    partial class NuevaTransaccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevaTransaccion));
            bttnCancelar = new Button();
            bttnAceptar = new Button();
            lblCliente = new Label();
            lblEmpleado = new Label();
            lblInmueble = new Label();
            lblFecha = new Label();
            dtmpckrFecha = new DateTimePicker();
            cmbxInmueble = new ComboBox();
            cmbxEmpleado = new ComboBox();
            cmbxCliente = new ComboBox();
            SuspendLayout();
            // 
            // bttnCancelar
            // 
            bttnCancelar.Location = new Point(447, 323);
            bttnCancelar.Name = "bttnCancelar";
            bttnCancelar.Size = new Size(95, 31);
            bttnCancelar.TabIndex = 37;
            bttnCancelar.Text = "Cancelar";
            bttnCancelar.UseVisualStyleBackColor = true;
            bttnCancelar.Click += bttnCancelar_Click;
            // 
            // bttnAceptar
            // 
            bttnAceptar.Location = new Point(150, 323);
            bttnAceptar.Name = "bttnAceptar";
            bttnAceptar.Size = new Size(95, 31);
            bttnAceptar.TabIndex = 36;
            bttnAceptar.Text = "Aceptar";
            bttnAceptar.UseVisualStyleBackColor = true;
            bttnAceptar.Click += bttnAceptar_Click;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.BackColor = Color.FromArgb(128, 139, 69, 19);
            lblCliente.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblCliente.ForeColor = SystemColors.ControlText;
            lblCliente.Location = new Point(394, 192);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(67, 18);
            lblCliente.TabIndex = 31;
            lblCliente.Text = "Cliente: ";
            // 
            // lblEmpleado
            // 
            lblEmpleado.AutoSize = true;
            lblEmpleado.BackColor = Color.FromArgb(128, 139, 69, 19);
            lblEmpleado.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmpleado.ForeColor = SystemColors.ControlText;
            lblEmpleado.Location = new Point(394, 128);
            lblEmpleado.Name = "lblEmpleado";
            lblEmpleado.Size = new Size(86, 18);
            lblEmpleado.TabIndex = 30;
            lblEmpleado.Text = "Empleado: ";
            // 
            // lblInmueble
            // 
            lblInmueble.AutoSize = true;
            lblInmueble.BackColor = Color.FromArgb(128, 139, 69, 19);
            lblInmueble.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblInmueble.ForeColor = SystemColors.ControlText;
            lblInmueble.Location = new Point(51, 192);
            lblInmueble.Name = "lblInmueble";
            lblInmueble.Size = new Size(77, 18);
            lblInmueble.TabIndex = 26;
            lblInmueble.Text = "Inmueble:";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.BackColor = Color.FromArgb(128, 139, 69, 19);
            lblFecha.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblFecha.ForeColor = SystemColors.ControlText;
            lblFecha.Location = new Point(51, 128);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(59, 18);
            lblFecha.TabIndex = 24;
            lblFecha.Text = "Fecha: ";
            // 
            // dtmpckrFecha
            // 
            dtmpckrFecha.Location = new Point(151, 128);
            dtmpckrFecha.Name = "dtmpckrFecha";
            dtmpckrFecha.Size = new Size(216, 23);
            dtmpckrFecha.TabIndex = 38;
            // 
            // cmbxInmueble
            // 
            cmbxInmueble.FormattingEnabled = true;
            cmbxInmueble.Location = new Point(151, 187);
            cmbxInmueble.Name = "cmbxInmueble";
            cmbxInmueble.Size = new Size(178, 23);
            cmbxInmueble.TabIndex = 39;
            // 
            // cmbxEmpleado
            // 
            cmbxEmpleado.FormattingEnabled = true;
            cmbxEmpleado.Location = new Point(524, 123);
            cmbxEmpleado.Name = "cmbxEmpleado";
            cmbxEmpleado.Size = new Size(178, 23);
            cmbxEmpleado.TabIndex = 40;
            // 
            // cmbxCliente
            // 
            cmbxCliente.FormattingEnabled = true;
            cmbxCliente.Location = new Point(524, 192);
            cmbxCliente.Name = "cmbxCliente";
            cmbxCliente.Size = new Size(178, 23);
            cmbxCliente.TabIndex = 41;
            // 
            // NuevaTransaccion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondo_Altas;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(726, 450);
            Controls.Add(cmbxCliente);
            Controls.Add(cmbxEmpleado);
            Controls.Add(cmbxInmueble);
            Controls.Add(dtmpckrFecha);
            Controls.Add(bttnCancelar);
            Controls.Add(bttnAceptar);
            Controls.Add(lblCliente);
            Controls.Add(lblEmpleado);
            Controls.Add(lblInmueble);
            Controls.Add(lblFecha);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "NuevaTransaccion";
            Text = "NuevaTransaccion";
            Load += NuevaTransaccion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bttnCancelar;
        private Button bttnAceptar;
        private ComboBox cmbxPuesto;
        private Label lblPuesto;
        private Label lblCliente;
        private Label lblEmpleado;
        private TextBox txtbxApellidos;
        private Label lblApellidos;
        private Label lblInmueble;
        private TextBox txtbxDni;
        private Label lblFecha;
        private DateTimePicker dtmpckrFecha;
        private ComboBox cmbxInmueble;
        private ComboBox cmbxEmpleado;
        private ComboBox cmbxCliente;
    }
}