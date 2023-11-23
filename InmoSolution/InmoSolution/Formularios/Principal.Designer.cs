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
            groupBox1 = new GroupBox();
            lblAlquileres = new Label();
            txtbxAlquileres = new TextBox();
            lblEnVenta = new Label();
            txtbxEnVenta = new TextBox();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridView1 = new DataGridView();
            tsmiInicio = new ToolStripMenuItem();
            tsmiPerfil = new ToolStripMenuItem();
            tsmiCerrar = new ToolStripMenuItem();
            tsmiClientes = new ToolStripMenuItem();
            tsmiListaClientes = new ToolStripMenuItem();
            tsmiNuevoCliente = new ToolStripMenuItem();
            tsmiBuscarCliente = new ToolStripMenuItem();
            tsmiInmuebles = new ToolStripMenuItem();
            tsmiAlquileres = new ToolStripMenuItem();
            tsmiListaAlquileres = new ToolStripMenuItem();
            tsmiNuevoAlquiler = new ToolStripMenuItem();
            tsmiEnVenta = new ToolStripMenuItem();
            tsmiListaEnVenta = new ToolStripMenuItem();
            tsmiNuevoEnVenta = new ToolStripMenuItem();
            tsmiBuscarInmuebles = new ToolStripMenuItem();
            tsmiListaVisitas = new ToolStripMenuItem();
            listaDeVisitasToolStripMenuItem = new ToolStripMenuItem();
            tsmiNuevaVisita = new ToolStripMenuItem();
            tsmiBuscarVisita = new ToolStripMenuItem();
            tsmiEmpleados = new ToolStripMenuItem();
            tsmiListaEmpleados = new ToolStripMenuItem();
            tsmiNuevoEmpleado = new ToolStripMenuItem();
            tsmiBuscarEmpleado = new ToolStripMenuItem();
            tsmiUsuarios = new ToolStripMenuItem();
            listadoDeUsuariosToolStripMenuItem = new ToolStripMenuItem();
            nuevoUsuarioToolStripMenuItem = new ToolStripMenuItem();
            tsmiConfiguracion = new ToolStripMenuItem();
            tsmiAyuda = new ToolStripMenuItem();
            tsmiDocumentacion = new ToolStripMenuItem();
            tsmiAcercaDe = new ToolStripMenuItem();
            msPrincipal = new MenuStrip();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            msPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // lblUltima
            // 
            lblUltima.AutoSize = true;
            lblUltima.Location = new Point(576, 332);
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
            txtbxInmuebles.Location = new Point(163, 16);
            txtbxInmuebles.Margin = new Padding(2);
            txtbxInmuebles.Name = "txtbxInmuebles";
            txtbxInmuebles.ReadOnly = true;
            txtbxInmuebles.Size = new Size(31, 23);
            txtbxInmuebles.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.YellowGreen;
            groupBox1.Controls.Add(lblAlquileres);
            groupBox1.Controls.Add(txtbxAlquileres);
            groupBox1.Controls.Add(lblEnVenta);
            groupBox1.Controls.Add(txtbxEnVenta);
            groupBox1.Controls.Add(lblInmuebles);
            groupBox1.Controls.Add(txtbxInmuebles);
            groupBox1.Location = new Point(514, 75);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(201, 100);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
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
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(555, 377);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.Size = new Size(210, 141);
            dataGridView1.TabIndex = 8;
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
            tsmiClientes.DropDownItems.AddRange(new ToolStripItem[] { tsmiListaClientes, tsmiNuevoCliente, tsmiBuscarCliente });
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
            // tsmiBuscarCliente
            // 
            tsmiBuscarCliente.Name = "tsmiBuscarCliente";
            tsmiBuscarCliente.Size = new Size(159, 22);
            tsmiBuscarCliente.Text = "Buscar Cliente";
            // 
            // tsmiInmuebles
            // 
            tsmiInmuebles.DropDownItems.AddRange(new ToolStripItem[] { tsmiAlquileres, tsmiEnVenta, tsmiBuscarInmuebles });
            tsmiInmuebles.Name = "tsmiInmuebles";
            tsmiInmuebles.Size = new Size(74, 20);
            tsmiInmuebles.Text = "Inmuebles";
            // 
            // tsmiAlquileres
            // 
            tsmiAlquileres.DropDownItems.AddRange(new ToolStripItem[] { tsmiListaAlquileres, tsmiNuevoAlquiler });
            tsmiAlquileres.Name = "tsmiAlquileres";
            tsmiAlquileres.Size = new Size(162, 22);
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
            tsmiEnVenta.Size = new Size(162, 22);
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
            // tsmiBuscarInmuebles
            // 
            tsmiBuscarInmuebles.Name = "tsmiBuscarInmuebles";
            tsmiBuscarInmuebles.Size = new Size(162, 22);
            tsmiBuscarInmuebles.Text = "Buscar Inmueble";
            // 
            // tsmiListaVisitas
            // 
            tsmiListaVisitas.DropDownItems.AddRange(new ToolStripItem[] { listaDeVisitasToolStripMenuItem, tsmiNuevaVisita, tsmiBuscarVisita });
            tsmiListaVisitas.Name = "tsmiListaVisitas";
            tsmiListaVisitas.Size = new Size(52, 20);
            tsmiListaVisitas.Text = "Visitas";
            // 
            // listaDeVisitasToolStripMenuItem
            // 
            listaDeVisitasToolStripMenuItem.Name = "listaDeVisitasToolStripMenuItem";
            listaDeVisitasToolStripMenuItem.Size = new Size(150, 22);
            listaDeVisitasToolStripMenuItem.Text = "Lista de Visitas";
            // 
            // tsmiNuevaVisita
            // 
            tsmiNuevaVisita.Name = "tsmiNuevaVisita";
            tsmiNuevaVisita.Size = new Size(150, 22);
            tsmiNuevaVisita.Text = "Nueva Visita";
            // 
            // tsmiBuscarVisita
            // 
            tsmiBuscarVisita.Name = "tsmiBuscarVisita";
            tsmiBuscarVisita.Size = new Size(150, 22);
            tsmiBuscarVisita.Text = "Buscar Visita";
            // 
            // tsmiEmpleados
            // 
            tsmiEmpleados.DropDownItems.AddRange(new ToolStripItem[] { tsmiListaEmpleados, tsmiNuevoEmpleado, tsmiBuscarEmpleado });
            tsmiEmpleados.Name = "tsmiEmpleados";
            tsmiEmpleados.Size = new Size(77, 20);
            tsmiEmpleados.Text = "Empleados";
            tsmiEmpleados.Visible = false;
            // 
            // tsmiListaEmpleados
            // 
            tsmiListaEmpleados.Name = "tsmiListaEmpleados";
            tsmiListaEmpleados.Size = new Size(180, 22);
            tsmiListaEmpleados.Text = "Lista Empleados";
            // 
            // tsmiNuevoEmpleado
            // 
            tsmiNuevoEmpleado.Name = "tsmiNuevoEmpleado";
            tsmiNuevoEmpleado.Size = new Size(180, 22);
            tsmiNuevoEmpleado.Text = "Nuevo Empleado";
            tsmiNuevoEmpleado.Click += tsmiNuevoEmpleado_Click;
            // 
            // tsmiBuscarEmpleado
            // 
            tsmiBuscarEmpleado.Name = "tsmiBuscarEmpleado";
            tsmiBuscarEmpleado.Size = new Size(180, 22);
            tsmiBuscarEmpleado.Text = "Buscar Empleado";
            // 
            // tsmiUsuarios
            // 
            tsmiUsuarios.DropDownItems.AddRange(new ToolStripItem[] { listadoDeUsuariosToolStripMenuItem, nuevoUsuarioToolStripMenuItem });
            tsmiUsuarios.Name = "tsmiUsuarios";
            tsmiUsuarios.Size = new Size(64, 20);
            tsmiUsuarios.Text = "Usuarios";
            tsmiUsuarios.Visible = false;
            // 
            // listadoDeUsuariosToolStripMenuItem
            // 
            listadoDeUsuariosToolStripMenuItem.Name = "listadoDeUsuariosToolStripMenuItem";
            listadoDeUsuariosToolStripMenuItem.Size = new Size(180, 22);
            listadoDeUsuariosToolStripMenuItem.Text = "Listado de Usuarios";
            listadoDeUsuariosToolStripMenuItem.Click += listadoDeUsuariosToolStripMenuItem_Click;
            // 
            // nuevoUsuarioToolStripMenuItem
            // 
            nuevoUsuarioToolStripMenuItem.Name = "nuevoUsuarioToolStripMenuItem";
            nuevoUsuarioToolStripMenuItem.Size = new Size(180, 22);
            nuevoUsuarioToolStripMenuItem.Text = "Nuevo Usuario";
            nuevoUsuarioToolStripMenuItem.Click += nuevoUsuarioToolStripMenuItem_Click;
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
            msPrincipal.Items.AddRange(new ToolStripItem[] { tsmiInicio, tsmiClientes, tsmiInmuebles, tsmiListaVisitas, tsmiEmpleados, tsmiUsuarios, tsmiConfiguracion, tsmiAyuda });
            msPrincipal.Location = new Point(0, 0);
            msPrincipal.Name = "msPrincipal";
            msPrincipal.Size = new Size(778, 24);
            msPrincipal.TabIndex = 6;
            msPrincipal.Text = "menuStrip1";
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fondo_Principal;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(778, 614);
            Controls.Add(dataGridView1);
            Controls.Add(chart1);
            Controls.Add(msPrincipal);
            Controls.Add(groupBox1);
            Controls.Add(lblUltima);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "Principal";
            Text = "Principal";
            Load += Principal_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            msPrincipal.ResumeLayout(false);
            msPrincipal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblUltima;
        private Label lblInmuebles;
        private TextBox txtbxInmuebles;
        private GroupBox groupBox1;
        private Label lblEnVenta;
        private TextBox txtbxEnVenta;
        private Label lblAlquileres;
        private TextBox txtbxAlquileres;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private DataGridView dataGridView1;
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
        private ToolStripMenuItem tsmiListaVisitas;
        private ToolStripMenuItem listaDeVisitasToolStripMenuItem;
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
        private ToolStripMenuItem listadoDeUsuariosToolStripMenuItem;
        private ToolStripMenuItem nuevoUsuarioToolStripMenuItem;
    }
}