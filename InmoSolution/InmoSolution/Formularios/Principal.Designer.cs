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
            this.lblUltima = new System.Windows.Forms.Label();
            this.lblInmuebles = new System.Windows.Forms.Label();
            this.txtbxInmuebles = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAlquileres = new System.Windows.Forms.Label();
            this.txtbxAlquileres = new System.Windows.Forms.TextBox();
            this.lblEnVenta = new System.Windows.Forms.Label();
            this.txtbxEnVenta = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ofertasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alquileresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeAlquileresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoAlquilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeEnVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoEnVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarInmuebleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visitasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeVisitasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaVisitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarVisitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msPrincipal = new System.Windows.Forms.MenuStrip();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.msPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUltima
            // 
            this.lblUltima.AutoSize = true;
            this.lblUltima.Location = new System.Drawing.Point(707, 230);
            this.lblUltima.Name = "lblUltima";
            this.lblUltima.Size = new System.Drawing.Size(145, 16);
            this.lblUltima.TabIndex = 2;
            this.lblUltima.Text = "Ultimas Transacciones";
            // 
            // lblInmuebles
            // 
            this.lblInmuebles.AutoSize = true;
            this.lblInmuebles.Location = new System.Drawing.Point(0, 20);
            this.lblInmuebles.Name = "lblInmuebles";
            this.lblInmuebles.Size = new System.Drawing.Size(106, 16);
            this.lblInmuebles.TabIndex = 3;
            this.lblInmuebles.Text = "Total Inmuebles:";
            // 
            // txtbxInmuebles
            // 
            this.txtbxInmuebles.Location = new System.Drawing.Point(186, 17);
            this.txtbxInmuebles.Name = "txtbxInmuebles";
            this.txtbxInmuebles.ReadOnly = true;
            this.txtbxInmuebles.Size = new System.Drawing.Size(35, 22);
            this.txtbxInmuebles.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.YellowGreen;
            this.groupBox1.Controls.Add(this.lblAlquileres);
            this.groupBox1.Controls.Add(this.txtbxAlquileres);
            this.groupBox1.Controls.Add(this.lblEnVenta);
            this.groupBox1.Controls.Add(this.txtbxEnVenta);
            this.groupBox1.Controls.Add(this.lblInmuebles);
            this.groupBox1.Controls.Add(this.txtbxInmuebles);
            this.groupBox1.Location = new System.Drawing.Point(421, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 107);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // lblAlquileres
            // 
            this.lblAlquileres.AutoSize = true;
            this.lblAlquileres.Location = new System.Drawing.Point(0, 77);
            this.lblAlquileres.Name = "lblAlquileres";
            this.lblAlquileres.Size = new System.Drawing.Size(104, 16);
            this.lblAlquileres.TabIndex = 7;
            this.lblAlquileres.Text = "Total Alquileres:";
            // 
            // txtbxAlquileres
            // 
            this.txtbxAlquileres.Location = new System.Drawing.Point(186, 74);
            this.txtbxAlquileres.Name = "txtbxAlquileres";
            this.txtbxAlquileres.ReadOnly = true;
            this.txtbxAlquileres.Size = new System.Drawing.Size(35, 22);
            this.txtbxAlquileres.TabIndex = 8;
            // 
            // lblEnVenta
            // 
            this.lblEnVenta.AutoSize = true;
            this.lblEnVenta.Location = new System.Drawing.Point(0, 49);
            this.lblEnVenta.Name = "lblEnVenta";
            this.lblEnVenta.Size = new System.Drawing.Size(97, 16);
            this.lblEnVenta.TabIndex = 5;
            this.lblEnVenta.Text = "Total en Venta:";
            // 
            // txtbxEnVenta
            // 
            this.txtbxEnVenta.Location = new System.Drawing.Point(186, 46);
            this.txtbxEnVenta.Name = "txtbxEnVenta";
            this.txtbxEnVenta.ReadOnly = true;
            this.txtbxEnVenta.Size = new System.Drawing.Size(35, 22);
            this.txtbxEnVenta.TabIndex = 6;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(143, 252);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(300, 300);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "chart1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(683, 278);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 8;
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.perfilToolStripMenuItem,
            this.cerrarSesionToolStripMenuItem});
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // perfilToolStripMenuItem
            // 
            this.perfilToolStripMenuItem.Name = "perfilToolStripMenuItem";
            this.perfilToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.perfilToolStripMenuItem.Text = "Perfil";
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar sesion";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaDeClientesToolStripMenuItem,
            this.agregarClienteToolStripMenuItem,
            this.buscarClienteToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // listaDeClientesToolStripMenuItem
            // 
            this.listaDeClientesToolStripMenuItem.Name = "listaDeClientesToolStripMenuItem";
            this.listaDeClientesToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.listaDeClientesToolStripMenuItem.Text = "Lista de Clientes";
            // 
            // agregarClienteToolStripMenuItem
            // 
            this.agregarClienteToolStripMenuItem.Name = "agregarClienteToolStripMenuItem";
            this.agregarClienteToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.agregarClienteToolStripMenuItem.Text = "Agregar Cliente";
            // 
            // buscarClienteToolStripMenuItem
            // 
            this.buscarClienteToolStripMenuItem.Name = "buscarClienteToolStripMenuItem";
            this.buscarClienteToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.buscarClienteToolStripMenuItem.Text = "Buscar Cliente";
            // 
            // ofertasToolStripMenuItem
            // 
            this.ofertasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alquileresToolStripMenuItem,
            this.enVentaToolStripMenuItem,
            this.buscarInmuebleToolStripMenuItem});
            this.ofertasToolStripMenuItem.Name = "ofertasToolStripMenuItem";
            this.ofertasToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.ofertasToolStripMenuItem.Text = "Inmuebles";
            // 
            // alquileresToolStripMenuItem
            // 
            this.alquileresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaDeAlquileresToolStripMenuItem,
            this.nuevoAlquilerToolStripMenuItem});
            this.alquileresToolStripMenuItem.Name = "alquileresToolStripMenuItem";
            this.alquileresToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.alquileresToolStripMenuItem.Text = "Alquileres";
            // 
            // listaDeAlquileresToolStripMenuItem
            // 
            this.listaDeAlquileresToolStripMenuItem.Name = "listaDeAlquileresToolStripMenuItem";
            this.listaDeAlquileresToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.listaDeAlquileresToolStripMenuItem.Text = "Lista de Alquileres";
            // 
            // nuevoAlquilerToolStripMenuItem
            // 
            this.nuevoAlquilerToolStripMenuItem.Name = "nuevoAlquilerToolStripMenuItem";
            this.nuevoAlquilerToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.nuevoAlquilerToolStripMenuItem.Text = "Nuevo Alquiler";
            // 
            // enVentaToolStripMenuItem
            // 
            this.enVentaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaDeEnVentaToolStripMenuItem,
            this.nuevoEnVentaToolStripMenuItem});
            this.enVentaToolStripMenuItem.Name = "enVentaToolStripMenuItem";
            this.enVentaToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.enVentaToolStripMenuItem.Text = "En venta";
            // 
            // listaDeEnVentaToolStripMenuItem
            // 
            this.listaDeEnVentaToolStripMenuItem.Name = "listaDeEnVentaToolStripMenuItem";
            this.listaDeEnVentaToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.listaDeEnVentaToolStripMenuItem.Text = "Lista en Venta";
            // 
            // nuevoEnVentaToolStripMenuItem
            // 
            this.nuevoEnVentaToolStripMenuItem.Name = "nuevoEnVentaToolStripMenuItem";
            this.nuevoEnVentaToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.nuevoEnVentaToolStripMenuItem.Text = "Nuevo en Venta";
            // 
            // buscarInmuebleToolStripMenuItem
            // 
            this.buscarInmuebleToolStripMenuItem.Name = "buscarInmuebleToolStripMenuItem";
            this.buscarInmuebleToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.buscarInmuebleToolStripMenuItem.Text = "Buscar Inmueble";
            // 
            // visitasToolStripMenuItem
            // 
            this.visitasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaDeVisitasToolStripMenuItem,
            this.nuevaVisitaToolStripMenuItem,
            this.buscarVisitaToolStripMenuItem});
            this.visitasToolStripMenuItem.Name = "visitasToolStripMenuItem";
            this.visitasToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.visitasToolStripMenuItem.Text = "Visitas";
            // 
            // listaDeVisitasToolStripMenuItem
            // 
            this.listaDeVisitasToolStripMenuItem.Name = "listaDeVisitasToolStripMenuItem";
            this.listaDeVisitasToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.listaDeVisitasToolStripMenuItem.Text = "Lista de Visitas";
            // 
            // nuevaVisitaToolStripMenuItem
            // 
            this.nuevaVisitaToolStripMenuItem.Name = "nuevaVisitaToolStripMenuItem";
            this.nuevaVisitaToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.nuevaVisitaToolStripMenuItem.Text = "Nueva Visita";
            // 
            // buscarVisitaToolStripMenuItem
            // 
            this.buscarVisitaToolStripMenuItem.Name = "buscarVisitaToolStripMenuItem";
            this.buscarVisitaToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.buscarVisitaToolStripMenuItem.Text = "Buscar Visita";
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaEmpleadosToolStripMenuItem,
            this.nuevoEmpleadoToolStripMenuItem,
            this.buscarEmpleadoToolStripMenuItem});
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            // 
            // listaEmpleadosToolStripMenuItem
            // 
            this.listaEmpleadosToolStripMenuItem.Name = "listaEmpleadosToolStripMenuItem";
            this.listaEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.listaEmpleadosToolStripMenuItem.Text = "Lista Empleados";
            // 
            // nuevoEmpleadoToolStripMenuItem
            // 
            this.nuevoEmpleadoToolStripMenuItem.Name = "nuevoEmpleadoToolStripMenuItem";
            this.nuevoEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.nuevoEmpleadoToolStripMenuItem.Text = "Nuevo Empleado";
            // 
            // buscarEmpleadoToolStripMenuItem
            // 
            this.buscarEmpleadoToolStripMenuItem.Name = "buscarEmpleadoToolStripMenuItem";
            this.buscarEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.buscarEmpleadoToolStripMenuItem.Text = "Buscar Empleado";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // configuracionToolStripMenuItem
            // 
            this.configuracionToolStripMenuItem.Name = "configuracionToolStripMenuItem";
            this.configuracionToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.configuracionToolStripMenuItem.Text = "Configuracion";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.documentaciónToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // documentaciónToolStripMenuItem
            // 
            this.documentaciónToolStripMenuItem.Name = "documentaciónToolStripMenuItem";
            this.documentaciónToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.documentaciónToolStripMenuItem.Text = "Documentación";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            // 
            // msPrincipal
            // 
            this.msPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.ofertasToolStripMenuItem,
            this.visitasToolStripMenuItem,
            this.empleadosToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.configuracionToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.msPrincipal.Location = new System.Drawing.Point(0, 0);
            this.msPrincipal.Name = "msPrincipal";
            this.msPrincipal.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.msPrincipal.Size = new System.Drawing.Size(970, 24);
            this.msPrincipal.TabIndex = 6;
            this.msPrincipal.Text = "menuStrip1";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::InmoSolution.Properties.Resources.Principal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(970, 579);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.msPrincipal);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblUltima);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Principal";
            this.Text = "Principal";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.msPrincipal.ResumeLayout(false);
            this.msPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private ToolStripMenuItem inicioToolStripMenuItem;
        private ToolStripMenuItem perfilToolStripMenuItem;
        private ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem listaDeClientesToolStripMenuItem;
        private ToolStripMenuItem agregarClienteToolStripMenuItem;
        private ToolStripMenuItem buscarClienteToolStripMenuItem;
        private ToolStripMenuItem ofertasToolStripMenuItem;
        private ToolStripMenuItem alquileresToolStripMenuItem;
        private ToolStripMenuItem listaDeAlquileresToolStripMenuItem;
        private ToolStripMenuItem nuevoAlquilerToolStripMenuItem;
        private ToolStripMenuItem enVentaToolStripMenuItem;
        private ToolStripMenuItem listaDeEnVentaToolStripMenuItem;
        private ToolStripMenuItem nuevoEnVentaToolStripMenuItem;
        private ToolStripMenuItem buscarInmuebleToolStripMenuItem;
        private ToolStripMenuItem visitasToolStripMenuItem;
        private ToolStripMenuItem listaDeVisitasToolStripMenuItem;
        private ToolStripMenuItem nuevaVisitaToolStripMenuItem;
        private ToolStripMenuItem buscarVisitaToolStripMenuItem;
        private ToolStripMenuItem empleadosToolStripMenuItem;
        private ToolStripMenuItem listaEmpleadosToolStripMenuItem;
        private ToolStripMenuItem nuevoEmpleadoToolStripMenuItem;
        private ToolStripMenuItem buscarEmpleadoToolStripMenuItem;
        private ToolStripMenuItem usuariosToolStripMenuItem;
        private ToolStripMenuItem configuracionToolStripMenuItem;
        private ToolStripMenuItem ayudaToolStripMenuItem;
        private ToolStripMenuItem documentaciónToolStripMenuItem;
        private ToolStripMenuItem acercaDeToolStripMenuItem;
        private MenuStrip msPrincipal;
    }
}