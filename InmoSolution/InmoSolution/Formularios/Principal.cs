using InmoSolution.Clases;
using InmoSolution.Controladores;
using InmoSolution.Formularios.Clientes;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace InmoSolution.Formularios
{
    public partial class Principal : Form
    {
        private Usuario user;
        Dictionary<string, bool> cambios = new Dictionary<string, bool>();
        List<bool> ficherosExist = new List<bool>();
        public Principal(Usuario usu)
        {
            InitializeComponent();
            user = usu;
            cambios.Add("Usuario", ControladorUsuario.Cambios);
            cambios.Add("Empleado", ControladorEmpleado.Cambios);
            cambios.Add("Cliente", ControladorCliente.Cambios);
            cambios.Add("Alquiler", ControladorAlquiler.Cambios);
            cambios.Add("EnVenta", ControladorEnVenta.Cambios);
            cambios.Add("Transaccion", ControladorTransaccion.Cambios);
            cambios.Add("Visita", ControladorVisita.Cambios);
            ficherosExist.Add(ControladorEmpleado.ExisteFichero());
            ficherosExist.Add(ControladorCliente.ExisteFichero());
            ficherosExist.Add(ControladorAlquiler.ExisteFichero());
            ficherosExist.Add(ControladorEnVenta.ExisteFichero());
            ficherosExist.Add(ControladorVisita.ExisteFichero());
            ficherosExist.Add(ControladorTransaccion.ExisteFichero());
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < ficherosExist.Count; i++)
            {
                if (i==4)
                {
                    ControladorInmueble.RellenarListaInmuebles();
                }
                switch (i)
                {
                    case 0:
                        if (ficherosExist[i])
                        {
                            ControladorEmpleado.LeerEmpleados();
                        }
                        else
                        {
                            CargarEmpleados();
                            ControladorEmpleado.EscribirEmpleados();
                        }
                        break;
                    case 1:
                        if (ficherosExist[i])
                        {
                            ControladorCliente.LeerClientes();
                        }
                        else
                        {
                            CargarClientes();
                            ControladorCliente.EscribirClientes();
                        }
                        break;
                    case 2:
                        if (ficherosExist[i])
                        {
                            ControladorAlquiler.LeerAlquileres();
                        }
                        else
                        {
                            CargarAlquileres();
                            ControladorAlquiler.EscribirAlquileres();
                        }
                        break;
                    case 3:
                        if (ficherosExist[i])
                        {
                            ControladorEnVenta.LeerEnVentas();
                        }
                        else
                        {
                            CargarEnVenta();
                            ControladorEnVenta.EscribirEnVentas();
                        }
                        break;
                    case 4:
                        if (ficherosExist[i])
                        {
                            ControladorVisita.LeerVisitas();
                        }
                        else
                        {
                            CargarVisitas();
                            ControladorVisita.EscribirVisitas();
                        }
                        break;
                    case 5:
                        if (ficherosExist[i])
                        {
                            ControladorTransaccion.LeerTransacciones();
                        }
                        else
                        {
                            CargarTransacciones();
                            ControladorTransaccion.EscribirTransacciones();
                        }
                        break;
                }
            }
            switch (user.GetPuesto())
            {
                case "Administrador":
                    tsmiEmpleados.Visible = true;
                    tsmiUsuarios.Visible = true;
                    break;
                case "Administrativo":
                case "Jefe":
                    tsmiEmpleados.Visible = true;
                    break;
            }

            txtbxInmuebles.Text = ControladorInmueble.ListaInmuebles.Count.ToString();
            txtbxAlquileres.Text = ControladorAlquiler.ListaAlquileres.Count.ToString();
            txtbxEnVenta.Text = ControladorEnVenta.ListaEnVenta.Count.ToString();
            CargarDataGrid();
            InicializarGrafico();
        }
        private void CargarDataGrid()
        {
            dgvUltiTransacc.DataSource = ControladorTransaccion.ListaTransacciones.OrderByDescending(t => t.Fecha).Take(5).ToList();
            dgvUltiTransacc.Columns.Clear();
            DataGridViewTextBoxColumn colId = new DataGridViewTextBoxColumn();
            colId.DataPropertyName = "Id";
            colId.HeaderText = "Id";
            colId.Width = 50;
            colId.ReadOnly = true;
            DataGridViewTextBoxColumn colFecha = new DataGridViewTextBoxColumn();
            colFecha.DataPropertyName = "Fecha";
            colFecha.HeaderText = "Fecha";
            colFecha.Width = 150;
            colFecha.ReadOnly = true;
            DataGridViewTextBoxColumn colPrecio = new DataGridViewTextBoxColumn();
            colPrecio.DataPropertyName = "Precio";
            colPrecio.HeaderText = "Precio";
            colPrecio.Width = 75;
            colPrecio.ReadOnly = true;
            DataGridViewTextBoxColumn colBeneficio = new DataGridViewTextBoxColumn();
            colBeneficio.DataPropertyName = "Beneficio";
            colBeneficio.HeaderText = "Beneficio";
            colBeneficio.Width = 75;
            colBeneficio.ReadOnly = true;
            dgvUltiTransacc.Columns.AddRange(new DataGridViewColumn[] { colId, colFecha, colPrecio, colBeneficio });
            dgvUltiTransacc.Invalidate();
            dgvUltiTransacc.Update();
        }
        private void ActualizarDataGrid()
        {
            dgvUltiTransacc.DataSource = ControladorTransaccion.ListaTransacciones.OrderByDescending(t => t.Fecha).Take(5).ToList();
            dgvUltiTransacc.Invalidate();
            dgvUltiTransacc.Update();
        }
        private void InicializarGrafico()
        {
            chrtEstadistica.ChartAreas[0].AxisX.Title = "Fecha";
            chrtEstadistica.ChartAreas[0].AxisY.Title = "Transacciones";
            chrtEstadistica.ChartAreas[0].AxisX.LabelStyle.Format = "yyyy-MM";
            chrtEstadistica.ChartAreas[0].AxisX.Interval = 1;
            chrtEstadistica.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Months;
            chrtEstadistica.ChartAreas[0].AxisX.Minimum = ControladorTransaccion.ContadorPorFechasAlquileres.Keys.Min().ToOADate();
            chrtEstadistica.ChartAreas[0].AxisX.Maximum = ControladorTransaccion.ContadorPorFechasAlquileres.Keys.Max().ToOADate();

            Series serieAlquiler = chrtEstadistica.Series[0];
            serieAlquiler.Name = "Alquileres";
            serieAlquiler.ChartType = SeriesChartType.Line;
            serieAlquiler.XValueMember = "Key"; 
            serieAlquiler.YValueMembers = "Value";

            Series serieEnVenta = chrtEstadistica.Series[1];
            serieEnVenta.Name = "Ventas";
            serieEnVenta.ChartType = SeriesChartType.Line;
            serieEnVenta.XValueMember = "Key";
            serieEnVenta.YValueMembers = "Value";
            ControladorTransaccion.ContadorPorFechasAlquileres = ControladorTransaccion.ContadorPorFechasAlquileres.OrderBy(t => t.Key).ToDictionary(t => t.Key, t => t.Value);
            ControladorTransaccion.ContadorPorFechasVentas = ControladorTransaccion.ContadorPorFechasVentas.OrderBy(t => t.Key).ToDictionary(t => t.Key, t => t.Value);
            foreach (KeyValuePair<DateTime, int> par in ControladorTransaccion.ContadorPorFechasAlquileres)
            {
                serieAlquiler.Points.AddXY(par.Key, par.Value);
            }
            foreach (KeyValuePair<DateTime, int> par in ControladorTransaccion.ContadorPorFechasVentas)
            {
                serieEnVenta.Points.AddXY(par.Key, par.Value);
            }
            serieAlquiler.Color = Color.Green;
            serieEnVenta.Color = Color.Red;

            chrtEstadistica.DataBind();
        }
        private void ActualizarGrafico()
        {
            chrtEstadistica.DataBind();
        }

        private void CargarClientes()
        {
            // Crear clientes
            for (int i = 0; i < 400; i++)
            {
                ControladorCliente.ListaClientes.Add(ControladorCliente.GenerarCliente());
            }
        }
        private void CargarEmpleados()
        {
            ControladorEmpleado.ListaEmpleados.Add(new Empleado("54750696R", "Juan", "Perez", "admin@admin.com", 611546200, user, Empleado.Puestos.Administrador));
            // Crear empleados
            for (int i = 0; i < 20; i++)
            {
                ControladorEmpleado.ListaEmpleados.Add(ControladorEmpleado.GenerarEmpleado());
            }
            ControladorUsuario.EscribirUsuarios();
        }
        private void CargarAlquileres()
        {
            // Crear alquileres
            for (int i = 0; i < 150; i++)
            {
                ControladorAlquiler.ListaAlquileres.Add(ControladorAlquiler.GenerarAlquiler());
            }
        }
        private void CargarEnVenta()
        {
            // Crear en venta
            for (int i = 0; i < 150; i++)
            {
                ControladorEnVenta.ListaEnVenta.Add(ControladorEnVenta.GenerarEnVenta());
            }
        }
        private void CargarVisitas()
        {
            // Crear visitas
            for (int i = 0; i < 500; i++)
            {
                ControladorVisita.ListaVisitas.Add(ControladorVisita.GenerarVisita());
            }
        }
        private void CargarTransacciones()
        {
            // Crear transacciones
            for (int i = 0; i < 70; i++)
            {
                ControladorTransaccion.ListaTransacciones.Add(ControladorTransaccion.GenerarTransaccion());
            }
        }

        private void tsmiPerfil_Click(object sender, EventArgs e)
        {
            Usuarios.ModificarUsuario frmPerfil = new Usuarios.ModificarUsuario(user);
        }
        private void tsmiCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            bool ok = false;
            foreach (KeyValuePair<string, bool> par in cambios)
            {
                if (par.Value)
                {
                    ok = true;
                    break;
                }
            }
            if (ok)
            {
                DialogResult dr = MessageBox.Show("Hay cambios sin guardar, ¿desea guardarlos?", "Cambios sin guardar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    foreach (KeyValuePair<string, bool> par in cambios)
                    {
                        bool cambio = par.Value;
                        string clase = par.Key;
                        switch (clase)
                        {
                            case "Usuario":
                                if (cambio)
                                {
                                    ControladorUsuario.EscribirUsuarios();
                                }
                                break;
                            case "Empleado":
                                if (cambio)
                                {
                                    ControladorEmpleado.EscribirEmpleados();
                                }
                                break;
                            case "Cliente":
                                if (cambio)
                                {
                                    ControladorCliente.EscribirClientes();
                                }
                                break;
                            case "Alquiler":
                                if (cambio)
                                {
                                    ControladorAlquiler.EscribirAlquileres();
                                }
                                break;
                            case "EnVenta":
                                if (cambio)
                                {
                                    ControladorEnVenta.EscribirEnVentas();
                                }
                                break;
                            case "Transaccion":
                                if (cambio)
                                {
                                    ControladorTransaccion.EscribirTransacciones();
                                }
                                break;
                            case "Visita":
                                if (cambio)
                                {
                                    ControladorVisita.EscribirVisitas();
                                }
                                break;
                        }
                    }
                }
            }
        }

        private void tsmiListaClientes_Click(object sender, EventArgs e)
        {
            ListadoClientes frmListado = new ListadoClientes();
            frmListado.ShowDialog();
        }

        private void tsmiNuevoCliente_Click(object sender, EventArgs e)
        {

        }

        private void tsmiListaAlquileres_Click(object sender, EventArgs e)
        {

        }

        private void tsmiNuevoAlquiler_Click(object sender, EventArgs e)
        {

        }

        private void tsmiListaEnVenta_Click(object sender, EventArgs e)
        {

        }

        private void tsmiNuevoEnVenta_Click(object sender, EventArgs e)
        {

        }

        private void tsmiListaTransacciones_Click(object sender, EventArgs e)
        {

        }

        private void tsmiNuevaTransaccion_Click(object sender, EventArgs e)
        {

            ActualizarGrafico();
        }

        private void tsmiListaVisitas_Click(object sender, EventArgs e)
        {

        }

        private void tsmiNuevaVisita_Click(object sender, EventArgs e)
        {

        }

        private void tsmiListaEmpleados_Click(object sender, EventArgs e)
        {
            Empleados.ListadoEmpleados frmListado = new Empleados.ListadoEmpleados();
            frmListado.ShowDialog();
        }

        private void tsmiNuevoEmpleado_Click(object sender, EventArgs e)
        {
            Empleados.NuevoEmpleado frmNuevoEmpleado = new Empleados.NuevoEmpleado();
            frmNuevoEmpleado.ShowDialog();
        }
        private void listadoDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuarios.ListadoUsuarios frmListado = new Usuarios.ListadoUsuarios();
            frmListado.ShowDialog();
        }

        private void nuevoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void tsmiConfiguracion_Click(object sender, EventArgs e)
        {

        }

        private void tsmiDocumentacion_Click(object sender, EventArgs e)
        {

        }

        private void tsmiAcercaDe_Click(object sender, EventArgs e)
        {

        }
    }
}
