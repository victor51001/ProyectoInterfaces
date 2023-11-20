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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            dataGridView1 = new DataGridView();
            lblUltima = new Label();
            lblInmuebles = new Label();
            txtbxInmuebles = new TextBox();
            groupBox1 = new GroupBox();
            lblAlquileres = new Label();
            txtbxAlquileres = new TextBox();
            lblEnVenta = new Label();
            txtbxEnVenta = new TextBox();
            inicioToolStripMenuItem = new ToolStripMenuItem();
            perfilToolStripMenuItem = new ToolStripMenuItem();
            cerrarSesionToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            listaDeClientesToolStripMenuItem = new ToolStripMenuItem();
            agregarClienteToolStripMenuItem = new ToolStripMenuItem();
            buscarClienteToolStripMenuItem = new ToolStripMenuItem();
            ofertasToolStripMenuItem = new ToolStripMenuItem();
            alquileresToolStripMenuItem = new ToolStripMenuItem();
            listaDeAlquileresToolStripMenuItem = new ToolStripMenuItem();
            nuevoAlquilerToolStripMenuItem = new ToolStripMenuItem();
            enVentaToolStripMenuItem = new ToolStripMenuItem();
            listaDeEnVentaToolStripMenuItem = new ToolStripMenuItem();
            nuevoEnVentaToolStripMenuItem = new ToolStripMenuItem();
            buscarInmuebleToolStripMenuItem = new ToolStripMenuItem();
            visitasToolStripMenuItem = new ToolStripMenuItem();
            listaDeVisitasToolStripMenuItem = new ToolStripMenuItem();
            nuevaVisitaToolStripMenuItem = new ToolStripMenuItem();
            buscarVisitaToolStripMenuItem = new ToolStripMenuItem();
            empleadosToolStripMenuItem = new ToolStripMenuItem();
            listaEmpleadosToolStripMenuItem = new ToolStripMenuItem();
            nuevoEmpleadoToolStripMenuItem = new ToolStripMenuItem();
            buscarEmpleadoToolStripMenuItem = new ToolStripMenuItem();
            usuariosToolStripMenuItem = new ToolStripMenuItem();
            configuracionToolStripMenuItem = new ToolStripMenuItem();
            ayudaToolStripMenuItem = new ToolStripMenuItem();
            documentaciónToolStripMenuItem = new ToolStripMenuItem();
            acercaDeToolStripMenuItem = new ToolStripMenuItem();
            msPrincipal = new MenuStrip();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            msPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(576, 254);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(240, 150);
            dataGridView1.TabIndex = 1;
            // 
            // lblUltima
            // 
            lblUltima.AutoSize = true;
            lblUltima.Location = new Point(619, 216);
            lblUltima.Name = "lblUltima";
            lblUltima.Size = new Size(123, 15);
            lblUltima.TabIndex = 2;
            lblUltima.Text = "Ultimas Transacciones";
            // 
            // lblInmuebles
            // 
            lblInmuebles.AutoSize = true;
            lblInmuebles.Location = new Point(0, 19);
            lblInmuebles.Name = "lblInmuebles";
            lblInmuebles.Size = new Size(93, 15);
            lblInmuebles.TabIndex = 3;
            lblInmuebles.Text = "Total Inmuebles:";
            // 
            // txtbxInmuebles
            // 
            txtbxInmuebles.Location = new Point(163, 16);
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
            groupBox1.Location = new Point(368, 64);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // lblAlquileres
            // 
            lblAlquileres.AutoSize = true;
            lblAlquileres.Location = new Point(0, 72);
            lblAlquileres.Name = "lblAlquileres";
            lblAlquileres.Size = new Size(90, 15);
            lblAlquileres.TabIndex = 7;
            lblAlquileres.Text = "Total Alquileres:";
            // 
            // txtbxAlquileres
            // 
            txtbxAlquileres.Location = new Point(163, 69);
            txtbxAlquileres.Name = "txtbxAlquileres";
            txtbxAlquileres.ReadOnly = true;
            txtbxAlquileres.Size = new Size(31, 23);
            txtbxAlquileres.TabIndex = 8;
            // 
            // lblEnVenta
            // 
            lblEnVenta.AutoSize = true;
            lblEnVenta.Location = new Point(0, 46);
            lblEnVenta.Name = "lblEnVenta";
            lblEnVenta.Size = new Size(83, 15);
            lblEnVenta.TabIndex = 5;
            lblEnVenta.Text = "Total en Venta:";
            // 
            // txtbxEnVenta
            // 
            txtbxEnVenta.Location = new Point(163, 43);
            txtbxEnVenta.Name = "txtbxEnVenta";
            txtbxEnVenta.ReadOnly = true;
            txtbxEnVenta.Size = new Size(31, 23);
            txtbxEnVenta.TabIndex = 6;
            // 
            // inicioToolStripMenuItem
            // 
            inicioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { perfilToolStripMenuItem, cerrarSesionToolStripMenuItem });
            inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            inicioToolStripMenuItem.Size = new Size(48, 20);
            inicioToolStripMenuItem.Text = "Inicio";
            // 
            // perfilToolStripMenuItem
            // 
            perfilToolStripMenuItem.Name = "perfilToolStripMenuItem";
            perfilToolStripMenuItem.Size = new Size(180, 22);
            perfilToolStripMenuItem.Text = "Perfil";
            // 
            // cerrarSesionToolStripMenuItem
            // 
            cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            cerrarSesionToolStripMenuItem.Size = new Size(180, 22);
            cerrarSesionToolStripMenuItem.Text = "Cerrar sesion";
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listaDeClientesToolStripMenuItem, agregarClienteToolStripMenuItem, buscarClienteToolStripMenuItem });
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(61, 20);
            clientesToolStripMenuItem.Text = "Clientes";
            // 
            // listaDeClientesToolStripMenuItem
            // 
            listaDeClientesToolStripMenuItem.Name = "listaDeClientesToolStripMenuItem";
            listaDeClientesToolStripMenuItem.Size = new Size(180, 22);
            listaDeClientesToolStripMenuItem.Text = "Lista de Clientes";
            // 
            // agregarClienteToolStripMenuItem
            // 
            agregarClienteToolStripMenuItem.Name = "agregarClienteToolStripMenuItem";
            agregarClienteToolStripMenuItem.Size = new Size(180, 22);
            agregarClienteToolStripMenuItem.Text = "Agregar Cliente";
            // 
            // buscarClienteToolStripMenuItem
            // 
            buscarClienteToolStripMenuItem.Name = "buscarClienteToolStripMenuItem";
            buscarClienteToolStripMenuItem.Size = new Size(180, 22);
            buscarClienteToolStripMenuItem.Text = "Buscar Cliente";
            // 
            // ofertasToolStripMenuItem
            // 
            ofertasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { alquileresToolStripMenuItem, enVentaToolStripMenuItem, buscarInmuebleToolStripMenuItem });
            ofertasToolStripMenuItem.Name = "ofertasToolStripMenuItem";
            ofertasToolStripMenuItem.Size = new Size(74, 20);
            ofertasToolStripMenuItem.Text = "Inmuebles";
            // 
            // alquileresToolStripMenuItem
            // 
            alquileresToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listaDeAlquileresToolStripMenuItem, nuevoAlquilerToolStripMenuItem });
            alquileresToolStripMenuItem.Name = "alquileresToolStripMenuItem";
            alquileresToolStripMenuItem.Size = new Size(162, 22);
            alquileresToolStripMenuItem.Text = "Alquileres";
            // 
            // listaDeAlquileresToolStripMenuItem
            // 
            listaDeAlquileresToolStripMenuItem.Name = "listaDeAlquileresToolStripMenuItem";
            listaDeAlquileresToolStripMenuItem.Size = new Size(169, 22);
            listaDeAlquileresToolStripMenuItem.Text = "Lista de Alquileres";
            // 
            // nuevoAlquilerToolStripMenuItem
            // 
            nuevoAlquilerToolStripMenuItem.Name = "nuevoAlquilerToolStripMenuItem";
            nuevoAlquilerToolStripMenuItem.Size = new Size(169, 22);
            nuevoAlquilerToolStripMenuItem.Text = "Nuevo Alquiler";
            // 
            // enVentaToolStripMenuItem
            // 
            enVentaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listaDeEnVentaToolStripMenuItem, nuevoEnVentaToolStripMenuItem });
            enVentaToolStripMenuItem.Name = "enVentaToolStripMenuItem";
            enVentaToolStripMenuItem.Size = new Size(162, 22);
            enVentaToolStripMenuItem.Text = "En venta";
            // 
            // listaDeEnVentaToolStripMenuItem
            // 
            listaDeEnVentaToolStripMenuItem.Name = "listaDeEnVentaToolStripMenuItem";
            listaDeEnVentaToolStripMenuItem.Size = new Size(157, 22);
            listaDeEnVentaToolStripMenuItem.Text = "Lista en Venta";
            // 
            // nuevoEnVentaToolStripMenuItem
            // 
            nuevoEnVentaToolStripMenuItem.Name = "nuevoEnVentaToolStripMenuItem";
            nuevoEnVentaToolStripMenuItem.Size = new Size(157, 22);
            nuevoEnVentaToolStripMenuItem.Text = "Nuevo en Venta";
            // 
            // buscarInmuebleToolStripMenuItem
            // 
            buscarInmuebleToolStripMenuItem.Name = "buscarInmuebleToolStripMenuItem";
            buscarInmuebleToolStripMenuItem.Size = new Size(162, 22);
            buscarInmuebleToolStripMenuItem.Text = "Buscar Inmueble";
            // 
            // visitasToolStripMenuItem
            // 
            visitasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listaDeVisitasToolStripMenuItem, nuevaVisitaToolStripMenuItem, buscarVisitaToolStripMenuItem });
            visitasToolStripMenuItem.Name = "visitasToolStripMenuItem";
            visitasToolStripMenuItem.Size = new Size(52, 20);
            visitasToolStripMenuItem.Text = "Visitas";
            // 
            // listaDeVisitasToolStripMenuItem
            // 
            listaDeVisitasToolStripMenuItem.Name = "listaDeVisitasToolStripMenuItem";
            listaDeVisitasToolStripMenuItem.Size = new Size(150, 22);
            listaDeVisitasToolStripMenuItem.Text = "Lista de Visitas";
            // 
            // nuevaVisitaToolStripMenuItem
            // 
            nuevaVisitaToolStripMenuItem.Name = "nuevaVisitaToolStripMenuItem";
            nuevaVisitaToolStripMenuItem.Size = new Size(150, 22);
            nuevaVisitaToolStripMenuItem.Text = "Nueva Visita";
            // 
            // buscarVisitaToolStripMenuItem
            // 
            buscarVisitaToolStripMenuItem.Name = "buscarVisitaToolStripMenuItem";
            buscarVisitaToolStripMenuItem.Size = new Size(150, 22);
            buscarVisitaToolStripMenuItem.Text = "Buscar Visita";
            // 
            // empleadosToolStripMenuItem
            // 
            empleadosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listaEmpleadosToolStripMenuItem, nuevoEmpleadoToolStripMenuItem, buscarEmpleadoToolStripMenuItem });
            empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            empleadosToolStripMenuItem.Size = new Size(77, 20);
            empleadosToolStripMenuItem.Text = "Empleados";
            // 
            // listaEmpleadosToolStripMenuItem
            // 
            listaEmpleadosToolStripMenuItem.Name = "listaEmpleadosToolStripMenuItem";
            listaEmpleadosToolStripMenuItem.Size = new Size(165, 22);
            listaEmpleadosToolStripMenuItem.Text = "Lista Empleados";
            // 
            // nuevoEmpleadoToolStripMenuItem
            // 
            nuevoEmpleadoToolStripMenuItem.Name = "nuevoEmpleadoToolStripMenuItem";
            nuevoEmpleadoToolStripMenuItem.Size = new Size(165, 22);
            nuevoEmpleadoToolStripMenuItem.Text = "Nuevo Empleado";
            // 
            // buscarEmpleadoToolStripMenuItem
            // 
            buscarEmpleadoToolStripMenuItem.Name = "buscarEmpleadoToolStripMenuItem";
            buscarEmpleadoToolStripMenuItem.Size = new Size(165, 22);
            buscarEmpleadoToolStripMenuItem.Text = "Buscar Empleado";
            // 
            // usuariosToolStripMenuItem
            // 
            usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            usuariosToolStripMenuItem.Size = new Size(64, 20);
            usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // configuracionToolStripMenuItem
            // 
            configuracionToolStripMenuItem.Name = "configuracionToolStripMenuItem";
            configuracionToolStripMenuItem.Size = new Size(95, 20);
            configuracionToolStripMenuItem.Text = "Configuracion";
            // 
            // ayudaToolStripMenuItem
            // 
            ayudaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { documentaciónToolStripMenuItem, acercaDeToolStripMenuItem });
            ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            ayudaToolStripMenuItem.Size = new Size(53, 20);
            ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // documentaciónToolStripMenuItem
            // 
            documentaciónToolStripMenuItem.Name = "documentaciónToolStripMenuItem";
            documentaciónToolStripMenuItem.Size = new Size(159, 22);
            documentaciónToolStripMenuItem.Text = "Documentación";
            // 
            // acercaDeToolStripMenuItem
            // 
            acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            acercaDeToolStripMenuItem.Size = new Size(159, 22);
            acercaDeToolStripMenuItem.Text = "Acerca de";
            // 
            // msPrincipal
            // 
            msPrincipal.Items.AddRange(new ToolStripItem[] { inicioToolStripMenuItem, clientesToolStripMenuItem, ofertasToolStripMenuItem, visitasToolStripMenuItem, empleadosToolStripMenuItem, usuariosToolStripMenuItem, configuracionToolStripMenuItem, ayudaToolStripMenuItem });
            msPrincipal.Location = new Point(0, 0);
            msPrincipal.Name = "msPrincipal";
            msPrincipal.Size = new Size(849, 24);
            msPrincipal.TabIndex = 6;
            msPrincipal.Text = "menuStrip1";
            msPrincipal.ItemClicked += msPrincipal_ItemClicked;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Principal;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(849, 543);
            Controls.Add(msPrincipal);
            Controls.Add(groupBox1);
            Controls.Add(lblUltima);
            Controls.Add(dataGridView1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Principal";
            Text = "Principal";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            msPrincipal.ResumeLayout(false);
            msPrincipal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private Label lblUltima;
        private Label lblInmuebles;
        private TextBox txtbxInmuebles;
        private GroupBox groupBox1;
        private Label lblEnVenta;
        private TextBox txtbxEnVenta;
        private Label lblAlquileres;
        private TextBox txtbxAlquileres;
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