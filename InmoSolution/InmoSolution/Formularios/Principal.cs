﻿using InmoSolution.Clases;
using InmoSolution.Controladores;
using InmoSolution.Formularios.Clientes;
using InmoSolution.Formularios.Inmuebles.Alquileres;
using InmoSolution.Formularios.Inmuebles.EnVenta;
using InmoSolution.Formularios.Transacciones;
using System.Data;
using System.Data.SqlClient;
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
            ficherosExist.Add(ControladorEmpleado.ExisteFichero());
            ficherosExist.Add(ControladorAlquiler.ExisteFichero());
            ficherosExist.Add(ControladorEnVenta.ExisteFichero());
            ficherosExist.Add(ControladorTransaccion.ExisteFichero());
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            if (TablaEstaVacia("Cliente"))
            {
                CargarClientes();
            } else
            {
                ControladorCliente.rellenarListaClientes();
            }
            for (int i = 0; i < ficherosExist.Count; i++)
            {
                if (i == 3)
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
                            ControladorAlquiler.LeerAlquileres();
                        }
                        else
                        {
                            CargarAlquileres();
                            ControladorAlquiler.EscribirAlquileres();
                        }
                        break;
                    case 2:
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
                    case 3:
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
            GenerarColumnas();
            AjustarGrid();
        }
        private bool TablaEstaVacia(string nombreTabla)
        {
            string connectionString = ControladorCliente.construirCadenaConexión();
            string query = $"SELECT COUNT(*) FROM {nombreTabla}";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        int rowCount = (int)command.ExecuteScalar();
                        return rowCount == 0;
                    }
                }
                catch (Exception ex)
                {   
                    string mensajeError = $"Error: {ex.Message}\n{ex.StackTrace}";
                    DialogResult result = MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (result == DialogResult.OK)
                    {
                        Clipboard.SetText(mensajeError);
                    }
                    return false;
                }
            }
        }

        private void GenerarColumnas()
        {
            dgvUltiTransacc.DataSource = ControladorTransaccion.ListaTransacciones.OrderByDescending(t => t.Fecha).Take(5).ToList();
            dgvUltiTransacc.Columns.Clear();
            dgvUltiTransacc.RowHeadersVisible = false;
            DataGridViewTextBoxColumn colId = new DataGridViewTextBoxColumn();
            colId.DataPropertyName = "Id";
            colId.HeaderText = "Id";
            colId.Width = 50;
            colId.ReadOnly = true;
            DataGridViewTextBoxColumn colTipo = new DataGridViewTextBoxColumn();
            colTipo.DataPropertyName = "Inmueble";
            colTipo.HeaderText = "Tipo";
            colTipo.Width = 50;
            colTipo.ReadOnly = true;
            dgvUltiTransacc.CellFormatting += (s, e) =>
            {
                if (e.Value is Alquiler)
                {
                    e.Value = "Alquiler";
                }
                else if (e.Value is EnVenta)
                {
                    e.Value = "EnVenta";
                }
            };
            DataGridViewTextBoxColumn colFecha = new DataGridViewTextBoxColumn();
            colFecha.DataPropertyName = "Fecha";
            colFecha.HeaderText = "Fecha";
            colFecha.Width = 125;
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
            dgvUltiTransacc.Columns.AddRange(new DataGridViewColumn[] { colId, colTipo, colFecha, colPrecio, colBeneficio });
        }
        private void AjustarGrid()
        {
            int altura = 0;
            foreach (DataGridViewRow row in dgvUltiTransacc.Rows)
            {
                altura += row.Height;
            }
            dgvUltiTransacc.Height = altura + 2 + dgvUltiTransacc.ColumnHeadersHeight;
            int ancho = 0;
            foreach (DataGridViewColumn col in dgvUltiTransacc.Columns)
            {
                ancho += col.Width;
            }
            dgvUltiTransacc.Width = ancho + 3;
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

            serieAlquiler.Points.Clear();
            foreach (KeyValuePair<DateTime, int> par in ControladorTransaccion.ContadorPorFechasAlquileres)
            {
                serieAlquiler.Points.AddXY(par.Key, par.Value);
            }
            serieEnVenta.Points.Clear();
            foreach (KeyValuePair<DateTime, int> par in ControladorTransaccion.ContadorPorFechasVentas)
            {
                serieEnVenta.Points.AddXY(par.Key, par.Value);
            }
            serieAlquiler.Color = Color.Green;
            serieEnVenta.Color = Color.Red;

            chrtEstadistica.DataBind();
        }
        private void ActualizarTotales()
        {
            txtbxInmuebles.Text = ControladorInmueble.ListaInmuebles.Count.ToString();
            txtbxAlquileres.Text = ControladorAlquiler.ListaAlquileres.Count.ToString();
            txtbxEnVenta.Text = ControladorEnVenta.ListaEnVenta.Count.ToString();
        }

        private void CargarClientes()
        {
            // Crear clientes
            for (int i = 0; i < 20; i++)
            {
                Cliente cliente = ControladorCliente.GenerarCliente();
                ControladorCliente.insertarCliente(cliente);
                ControladorCliente.ListaClientes.Add(cliente);
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
            frmPerfil.ShowDialog();
        }
        private void tsmiCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            cambios.Add("Usuario", ControladorUsuario.Cambios);
            cambios.Add("Empleado", ControladorEmpleado.Cambios);
            cambios.Add("Alquiler", ControladorAlquiler.Cambios);
            cambios.Add("EnVenta", ControladorEnVenta.Cambios);
            cambios.Add("Transaccion", ControladorTransaccion.Cambios);
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
            NuevoCliente frmNuevoCliente = new NuevoCliente();
            frmNuevoCliente.ShowDialog();
        }

        private void tsmiListaAlquileres_Click(object sender, EventArgs e)
        {
            ListadoAlquileres frmListado = new ListadoAlquileres();
            frmListado.ShowDialog();
            ActualizarTotales();
        }

        private void tsmiNuevoAlquiler_Click(object sender, EventArgs e)
        {
            NuevoAlquiler frmNuevoAlquiler = new NuevoAlquiler();
            frmNuevoAlquiler.ShowDialog();
            ActualizarTotales();
        }

        private void tsmiListaEnVenta_Click(object sender, EventArgs e)
        {
            ListadoEnVenta frmListado = new ListadoEnVenta();
            frmListado.ShowDialog();
            ActualizarTotales();
        }

        private void tsmiNuevoEnVenta_Click(object sender, EventArgs e)
        {
            NuevoEnVenta frmNuevoEnVenta = new NuevoEnVenta();
            frmNuevoEnVenta.ShowDialog();
            ActualizarTotales();
        }

        private void tsmiListaTransacciones_Click(object sender, EventArgs e)
        {
            ListadoTransacciones frmListado = new ListadoTransacciones();
            frmListado.ShowDialog();
            InicializarGrafico();
            CargarDataGrid();
        }

        private void tsmiNuevaTransaccion_Click(object sender, EventArgs e)
        {
            NuevaTransaccion frmNuevaTransaccion = new NuevaTransaccion();
            frmNuevaTransaccion.ShowDialog();
            InicializarGrafico();
            CargarDataGrid();
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
    }
}
