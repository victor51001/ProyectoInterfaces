using InmoSolution.Controladores;

namespace InmoSolution.Formularios
{
    partial class Principal
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            lblUltima = new Label();
            lblInmuebles = new Label();
            txtbxInmuebles = new TextBox();
            grpbxTotales = new GroupBox();
            lblAlquileres = new Label();
            txtbxAlquileres = new TextBox();
            lblEnVenta = new Label();
            txtbxEnVenta = new TextBox();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dgvUltiTransacc = new DataGridView();
            tsmiInicio = new ToolStripMenuItem();
            tsmiPerfil = new ToolStripMenuItem();
            tsmiCerrar = new ToolStripMenuItem();
            tsmiClientes = new ToolStripMenuItem();
            tsmiListaClientes = new ToolStripMenuItem();
            tsmiNuevoCliente = new ToolStripMenuItem();
            tsmiInmuebles = new ToolStripMenuItem();
            tsmiAlquileres = new ToolStripMenuItem();
            tsmiListaAlquileres = new ToolStripMenuItem();
            tsmiNuevoAlquiler = new ToolStripMenuItem();
            tsmiEnVenta = new ToolStripMenuItem();
            tsmiListaEnVenta = new ToolStripMenuItem();
            tsmiNuevoEnVenta = new ToolStripMenuItem();
            tsmiVisitas = new ToolStripMenuItem();
            tsmiListaVisitas = new ToolStripMenuItem();
            tsmiNuevaVisita = new ToolStripMenuItem();
            tsmiEmpleados = new ToolStripMenuItem();
            tsmiListaEmpleados = new ToolStripMenuItem();
            tsmiNuevoEmpleado = new ToolStripMenuItem();
            tsmiUsuarios = new ToolStripMenuItem();
            tsmiListaUsuarios = new ToolStripMenuItem();
            tsmiNuevoUsuario = new ToolStripMenuItem();
            tsmiConfiguracion = new ToolStripMenuItem();
            tsmiAyuda = new ToolStripMenuItem();
            tsmiDocumentacion = new ToolStripMenuItem();
            tsmiAcercaDe = new ToolStripMenuItem();
            msPrincipal = new MenuStrip();
            tsmiTransacciones = new ToolStripMenuItem();
            tsmiListaTransacciones = new ToolStripMenuItem();
            tsmiNuevaTransaccion = new ToolStripMenuItem();
            grpbxTotales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvUltiTransacc).BeginInit();
            msPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // lblUltima
            // 
            lblUltima.AutoSize = true;
            lblUltima.Location = new Point(514, 332);
            lblUltima.Margin = new Padding(2, 0, 2, 0);
            lblUltima.Name = "lblUltima";
            lblUltima.Size = new Size(123, 15);
            lblUltima.TabIndex = 2;
            lblUltima.Text = "Ultimas Transacciones";
            // 
            // lblInmuebles
            // 
            lblInmuebles.AutoSize = true;
            lblInmuebles.Location = new Point(0, 18);
            lblInmuebles.Margin = new Padding(2, 0, 2, 0);
            lblInmuebles.Name = "lblInmuebles";
            lblInmuebles.Size = new Size(93, 15);
            lblInmuebles.TabIndex = 3;
            lblInmuebles.Text = "Total Inmuebles:";
            // 
            // txtbxInmuebles
            // 
            txtbxInmuebles.Enabled = false;
            txtbxInmuebles.Location = new Point(163, 16);
            txtbxInmuebles.Margin = new Padding(2);
            txtbxInmuebles.Name = "txtbxInmuebles";
            txtbxInmuebles.ReadOnly = true;
            txtbxInmuebles.Size = new Size(31, 23);
            txtbxInmuebles.TabIndex = 4;
            // 
            // grpbxTotales
            // 
            grpbxTotales.BackColor = Color.FromArgb(148, 224, 255, 255);
            grpbxTotales.Controls.Add(lblAlquileres);
            grpbxTotales.Controls.Add(txtbxAlquileres);
            grpbxTotales.Controls.Add(lblEnVenta);
            grpbxTotales.Controls.Add(txtbxEnVenta);
            grpbxTotales.Controls.Add(lblInmuebles);
            grpbxTotales.Controls.Add(txtbxInmuebles);
            grpbxTotales.Location = new Point(514, 75);
            grpbxTotales.Margin = new Padding(2);
            grpbxTotales.Name = "grpbxTotales";
            grpbxTotales.Padding = new Padding(2);
            grpbxTotales.Size = new Size(201, 100);
            grpbxTotales.TabIndex = 5;
            grpbxTotales.TabStop = false;
            grpbxTotales.Text = "Totales";
            // 
            // lblAlquileres
            // 
            lblAlquileres.AutoSize = true;
            lblAlquileres.Location = new Point(0, 73);
            lblAlquileres.Margin = new Padding(2, 0, 2, 0);
            lblAlquileres.Name = "lblAlquileres";
            lblAlquileres.Size = new Size(90, 15);
            lblAlquileres.TabIndex = 7;
            lblAlquileres.Text = "Total Alquileres:";
            // 
            // txtbxAlquileres
            // 
            txtbxAlquileres.Enabled = false;
            txtbxAlquileres.Location = new Point(163, 69);
            txtbxAlquileres.Margin = new Padding(2);
            txtbxAlquileres.Name = "txtbxAlquileres";
            txtbxAlquileres.ReadOnly = true;
            txtbxAlquileres.Size = new Size(31, 23);
            txtbxAlquileres.TabIndex = 8;
            // 
            // lblEnVenta
            // 
            lblEnVenta.AutoSize = true;
            lblEnVenta.Location = new Point(0, 46);
            lblEnVenta.Margin = new Padding(2, 0, 2, 0);
            lblEnVenta.Name = "lblEnVenta";
            lblEnVenta.Size = new Size(83, 15);
            lblEnVenta.TabIndex = 5;
            lblEnVenta.Text = "Total en Venta:";
            // 
            // txtbxEnVenta
            // 
            txtbxEnVenta.Enabled = false;
            txtbxEnVenta.Location = new Point(163, 43);
            txtbxEnVenta.Margin = new Padding(2);
            txtbxEnVenta.Name = "txtbxEnVenta";
            txtbxEnVenta.ReadOnly = true;
            txtbxEnVenta.Size = new Size(31, 23);
            txtbxEnVenta.TabIndex = 6;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(21, 310);
            chart1.Margin = new Padding(2);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(262, 282);
            chart1.TabIndex = 7;
            chart1.Text = "chart1";
            // 
            // dgvUltiTransacc
            // 
            dgvUltiTransacc.AllowUserToAddRows = false;
            dgvUltiTransacc.AllowUserToDeleteRows = false;
            dgvUltiTransacc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUltiTransacc.Location = new Point(370, 363);
            dgvUltiTransacc.Margin = new Padding(2);
            dgvUltiTransacc.Name = "dgvUltiTransacc";
            dgvUltiTransacc.ReadOnly = true;
            dgvUltiTransacc.RowTemplate.Height = 24;
            dgvUltiTransacc.Size = new Size(393, 145);
            dgvUltiTransacc.TabIndex = 8;
            // 
            // tsmiInicio
            // 
            tsmiInicio.DropDownItems.AddRange(new ToolStripItem[] { tsmiPerfil, tsmiCerrar });
            tsmiInicio.Name = "tsmiInicio";
            tsmiInicio.Size = new Size(48, 20);
            tsmiInicio.Text = "Inicio";
            // 
            // tsmiPerfil
            // 
            tsmiPerfil.Name = "tsmiPerfil";
            tsmiPerfil.Size = new Size(142, 22);
            tsmiPerfil.Text = "Perfil";
            tsmiPerfil.Click += tsmiPerfil_Click;
            // 
            // tsmiCerrar
            // 
            tsmiCerrar.Name = "tsmiCerrar";
            tsmiCerrar.Size = new Size(142, 22);
            tsmiCerrar.Text = "Cerrar sesion";
            tsmiCerrar.Click += tsmiCerrar_Click;
            // 
            // tsmiClientes
            // 
            tsmiClientes.DropDownItems.AddRange(new ToolStripItem[] { tsmiListaClientes, tsmiNuevoCliente });
            tsmiClientes.Name = "tsmiClientes";
            tsmiClientes.Size = new Size(61, 20);
            tsmiClientes.Text = "Clientes";
            // 
            // tsmiListaClientes
            // 
            tsmiListaClientes.Name = "tsmiListaClientes";
            tsmiListaClientes.Size = new Size(159, 22);
            tsmiListaClientes.Text = "Lista de Clientes";
            // 
            // tsmiNuevoCliente
            // 
            tsmiNuevoCliente.Name = "tsmiNuevoCliente";
            tsmiNuevoCliente.Size = new Size(159, 22);
            tsmiNuevoCliente.Text = "Nuevo Cliente";
            // 
            // tsmiInmuebles
            // 
            tsmiInmuebles.DropDownItems.AddRange(new ToolStripItem[] { tsmiAlquileres, tsmiEnVenta });
            tsmiInmuebles.Name = "tsmiInmuebles";
            tsmiInmuebles.Size = new Size(74, 20);
            tsmiInmuebles.Text = "Inmuebles";
            // 
            // tsmiAlquileres
            // 
            tsmiAlquileres.DropDownItems.AddRange(new ToolStripItem[] { tsmiListaAlquileres, tsmiNuevoAlquiler });
            tsmiAlquileres.Name = "tsmiAlquileres";
            tsmiAlquileres.Size = new Size(126, 22);
            tsmiAlquileres.Text = "Alquileres";
            // 
            // tsmiListaAlquileres
            // 
            tsmiListaAlquileres.Name = "tsmiListaAlquileres";
            tsmiListaAlquileres.Size = new Size(169, 22);
            tsmiListaAlquileres.Text = "Lista de Alquileres";
            // 
            // tsmiNuevoAlquiler
            // 
            tsmiNuevoAlquiler.Name = "tsmiNuevoAlquiler";
            tsmiNuevoAlquiler.Size = new Size(169, 22);
            tsmiNuevoAlquiler.Text = "Nuevo Alquiler";
            // 
            // tsmiEnVenta
            // 
            tsmiEnVenta.DropDownItems.AddRange(new ToolStripItem[] { tsmiListaEnVenta, tsmiNuevoEnVenta });
            tsmiEnVenta.Name = "tsmiEnVenta";
            tsmiEnVenta.Size = new Size(126, 22);
            tsmiEnVenta.Text = "En venta";
            // 
            // tsmiListaEnVenta
            // 
            tsmiListaEnVenta.Name = "tsmiListaEnVenta";
            tsmiListaEnVenta.Size = new Size(157, 22);
            tsmiListaEnVenta.Text = "Lista en Venta";
            // 
            // tsmiNuevoEnVenta
            // 
            tsmiNuevoEnVenta.Name = "tsmiNuevoEnVenta";
            tsmiNuevoEnVenta.Size = new Size(157, 22);
            tsmiNuevoEnVenta.Text = "Nuevo en Venta";
            // 
            // tsmiVisitas
            // 
            tsmiVisitas.DropDownItems.AddRange(new ToolStripItem[] { tsmiListaVisitas, tsmiNuevaVisita });
            tsmiVisitas.Name = "tsmiVisitas";
            tsmiVisitas.Size = new Size(52, 20);
            tsmiVisitas.Text = "Visitas";
            // 
            // tsmiListaVisitas
            // 
            tsmiListaVisitas.Name = "tsmiListaVisitas";
            tsmiListaVisitas.Size = new Size(150, 22);
            tsmiListaVisitas.Text = "Lista de Visitas";
            // 
            // tsmiNuevaVisita
            // 
            tsmiNuevaVisita.Name = "tsmiNuevaVisita";
            tsmiNuevaVisita.Size = new Size(150, 22);
            tsmiNuevaVisita.Text = "Nueva Visita";
            // 
            // tsmiEmpleados
            // 
            tsmiEmpleados.DropDownItems.AddRange(new ToolStripItem[] { tsmiListaEmpleados, tsmiNuevoEmpleado });
            tsmiEmpleados.Name = "tsmiEmpleados";
            tsmiEmpleados.Size = new Size(77, 20);
            tsmiEmpleados.Text = "Empleados";
            tsmiEmpleados.Visible = false;
            // 
            // tsmiListaEmpleados
            // 
            tsmiListaEmpleados.Name = "tsmiListaEmpleados";
            tsmiListaEmpleados.Size = new Size(165, 22);
            tsmiListaEmpleados.Text = "Lista Empleados";
            // 
            // tsmiNuevoEmpleado
            // 
            tsmiNuevoEmpleado.Name = "tsmiNuevoEmpleado";
            tsmiNuevoEmpleado.Size = new Size(165, 22);
            tsmiNuevoEmpleado.Text = "Nuevo Empleado";
            tsmiNuevoEmpleado.Click += tsmiNuevoEmpleado_Click;
            // 
            // tsmiUsuarios
            // 
            tsmiUsuarios.DropDownItems.AddRange(new ToolStripItem[] { tsmiListaUsuarios, tsmiNuevoUsuario });
            tsmiUsuarios.Name = "tsmiUsuarios";
            tsmiUsuarios.Size = new Size(64, 20);
            tsmiUsuarios.Text = "Usuarios";
            tsmiUsuarios.Visible = false;
            // 
            // tsmiListaUsuarios
            // 
            tsmiListaUsuarios.Name = "tsmiListaUsuarios";
            tsmiListaUsuarios.Size = new Size(176, 22);
            tsmiListaUsuarios.Text = "Listado de Usuarios";
            tsmiListaUsuarios.Click += listadoDeUsuariosToolStripMenuItem_Click;
            // 
            // tsmiNuevoUsuario
            // 
            tsmiNuevoUsuario.Name = "tsmiNuevoUsuario";
            tsmiNuevoUsuario.Size = new Size(176, 22);
            tsmiNuevoUsuario.Text = "Nuevo Usuario";
            tsmiNuevoUsuario.Click += nuevoUsuarioToolStripMenuItem_Click;
            // 
            // tsmiConfiguracion
            // 
            tsmiConfiguracion.Name = "tsmiConfiguracion";
            tsmiConfiguracion.Size = new Size(95, 20);
            tsmiConfiguracion.Text = "Configuracion";
            // 
            // tsmiAyuda
            // 
            tsmiAyuda.DropDownItems.AddRange(new ToolStripItem[] { tsmiDocumentacion, tsmiAcercaDe });
            tsmiAyuda.Name = "tsmiAyuda";
            tsmiAyuda.Size = new Size(53, 20);
            tsmiAyuda.Text = "Ayuda";
            // 
            // tsmiDocumentacion
            // 
            tsmiDocumentacion.Name = "tsmiDocumentacion";
            tsmiDocumentacion.Size = new Size(159, 22);
            tsmiDocumentacion.Text = "Documentación";
            // 
            // tsmiAcercaDe
            // 
            tsmiAcercaDe.Name = "tsmiAcercaDe";
            tsmiAcercaDe.Size = new Size(159, 22);
            tsmiAcercaDe.Text = "Acerca de";
            // 
            // msPrincipal
            // 
            msPrincipal.Items.AddRange(new ToolStripItem[] { tsmiInicio, tsmiClientes, tsmiInmuebles, tsmiTransacciones, tsmiVisitas, tsmiEmpleados, tsmiUsuarios, tsmiConfiguracion, tsmiAyuda });
            msPrincipal.Location = new Point(0, 0);
            msPrincipal.Name = "msPrincipal";
            msPrincipal.Size = new Size(778, 24);
            msPrincipal.TabIndex = 6;
            msPrincipal.Text = "menuStrip1";
            // 
            // tsmiTransacciones
            // 
            tsmiTransacciones.DropDownItems.AddRange(new ToolStripItem[] { tsmiListaTransacciones, tsmiNuevaTransaccion });
            tsmiTransacciones.Name = "tsmiTransacciones";
            tsmiTransacciones.Size = new Size(92, 20);
            tsmiTransacciones.Text = "Transacciones";
            // 
            // tsmiListaTransacciones
            // 
            tsmiListaTransacciones.Name = "tsmiListaTransacciones";
            tsmiListaTransacciones.Size = new Size(190, 22);
            tsmiListaTransacciones.Text = "Lista de Transacciones";
            // 
            // tsmiNuevaTransaccion
            // 
            tsmiNuevaTransaccion.Name = "tsmiNuevaTransaccion";
            tsmiNuevaTransaccion.Size = new Size(190, 22);
            tsmiNuevaTransaccion.Text = "Nueva Transaccion";
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fondo_Principal;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(778, 614);
            Controls.Add(dgvUltiTransacc);
            Controls.Add(chart1);
            Controls.Add(msPrincipal);
            Controls.Add(grpbxTotales);
            Controls.Add(lblUltima);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "Principal";
            Text = "Principal";
            FormClosing += Principal_FormClosing;
            Load += Principal_Load;
            grpbxTotales.ResumeLayout(false);
            grpbxTotales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvUltiTransacc).EndInit();
            msPrincipal.ResumeLayout(false);
            msPrincipal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblUltima;
        private Label lblInmuebles;
        private TextBox txtbxInmuebles;
        private GroupBox grpbxTotales;
        private Label lblEnVenta;
        private TextBox txtbxEnVenta;
        private Label lblAlquileres;
        private TextBox txtbxAlquileres;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private DataGridView dgvUltiTransacc;
        private ToolStripMenuItem tsmiInicio;
        private ToolStripMenuItem tsmiPerfil;
        private ToolStripMenuItem tsmiCerrar;
        private ToolStripMenuItem tsmiClientes;
        private ToolStripMenuItem tsmiListaClientes;
        private ToolStripMenuItem tsmiNuevoCliente;
        private ToolStripMenuItem tsmiBuscarCliente;
        private ToolStripMenuItem tsmiInmuebles;
        private ToolStripMenuItem tsmiAlquileres;
        private ToolStripMenuItem tsmiListaAlquileres;
        private ToolStripMenuItem tsmiNuevoAlquiler;
        private ToolStripMenuItem tsmiEnVenta;
        private ToolStripMenuItem tsmiListaEnVenta;
        private ToolStripMenuItem tsmiNuevoEnVenta;
        private ToolStripMenuItem tsmiBuscarInmuebles;
        private ToolStripMenuItem tsmiVisitas;
        private ToolStripMenuItem tsmiListaVisitas;
        private ToolStripMenuItem tsmiNuevaVisita;
        private ToolStripMenuItem tsmiBuscarVisita;
        private ToolStripMenuItem tsmiEmpleados;
        private ToolStripMenuItem tsmiListaEmpleados;
        private ToolStripMenuItem tsmiNuevoEmpleado;
        private ToolStripMenuItem tsmiBuscarEmpleado;
        private ToolStripMenuItem tsmiUsuarios;
        private ToolStripMenuItem tsmiConfiguracion;
        private ToolStripMenuItem tsmiAyuda;
        private ToolStripMenuItem tsmiDocumentacion;
        private ToolStripMenuItem tsmiAcercaDe;
        private MenuStrip msPrincipal;
        private ToolStripMenuItem tsmiListaUsuarios;
        private ToolStripMenuItem tsmiNuevoUsuario;
        private ToolStripMenuItem tsmiTransacciones;
        private ToolStripMenuItem tsmiListaTransacciones;
        private ToolStripMenuItem tsmiNuevaTransaccion;
    }
}