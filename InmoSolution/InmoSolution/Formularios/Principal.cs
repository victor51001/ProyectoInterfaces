using InmoSolution.Clases;
using InmoSolution.Controladores;
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
            ficherosExist.Add(ControladorTransaccion.ExisteFichero());
            ficherosExist.Add(ControladorVisita.ExisteFichero());
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            switch (ControladorEmpleado.GetPuesto(user))
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
            //CargarClases();
            for (int i = 0; i < ficherosExist.Count; i++)
            {
                switch (i)
                {
                    case 0:
                        if (ficherosExist[i])
                        {
                            ControladorEmpleado.LeerEmpleados();
                        }
                        else
                        {
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
                            ControladorEnVenta.EscribirEnVentas();
                        }
                        break;
                    case 4:
                        if (ficherosExist[i])
                        {
                            ControladorTransaccion.LeerTransacciones();
                        }
                        else
                        {
                            ControladorTransaccion.EscribirTransacciones();
                        }
                        break;
                    case 5:
                        if (ficherosExist[i])
                        {
                            ControladorVisita.LeerVisitas();
                        }
                        else
                        {
                            ControladorVisita.EscribirVisitas();
                        }
                        break;
                }
            }
            ControladorInmueble.RellenarListaInmuebles();
            txtbxInmuebles.Text = ControladorInmueble.ListaInmuebles.Count.ToString();
            txtbxAlquileres.Text = ControladorAlquiler.ListaAlquileres.Count.ToString();
            txtbxEnVenta.Text = ControladorEnVenta.ListaEnVenta.Count.ToString();
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
        }

        private void CargarClases()
        {
            // Crear clientes
            Cliente cliente1 = new Cliente("11111111A", "Antonio", "Gómez", 123456789, "antonio@gmail.com");
            Cliente cliente2 = new Cliente("22222222B", "Elena", "Fernández", 987654321, "elena@gmail.com");
            Cliente cliente3 = new Cliente("33333333C", "Javier", "Martínez", 654321987, "javier@gmail.com");
            Cliente cliente4 = new Cliente("44444444D", "Carmen", "Rodríguez", 321654987, "carmen@gmail.com");
            Cliente cliente5 = new Cliente("55555555E", "Alberto", "Sánchez", 789456123, "alberto@gmail.com");

            // Crear empleados
            Empleado empleado1 = new Empleado("12345678X", "Juan", "González", "juan@gmail.com", 987654321, ControladorUsuario.GetUsuario("Juan"), Empleado.Puestos.Administrativo);
            Empleado empleado2 = new Empleado("23456789Y", "Ana", "López", "ana@gmail.com", 654321987, ControladorUsuario.GetUsuario("Ana"), Empleado.Puestos.Agente);
            Empleado empleado3 = new Empleado("34567890Z", "Pedro", "Pérez", "pedro@gmail.com", 321654987, ControladorUsuario.GetUsuario("Pedro"), Empleado.Puestos.Administrador);
            Empleado empleado4 = new Empleado("45678901A", "María", "Ruiz", "maria@gmail.com", 789456123, ControladorUsuario.GetUsuario("María"), Empleado.Puestos.Jefe);
            Empleado empleado5 = new Empleado("56789012B", "Carlos", "Díaz", "carlos@gmail.com", 456123789, ControladorUsuario.GetUsuario("Carlos"), Empleado.Puestos.Agente);

            // Crear inmuebles
            Alquiler alquiler1 = new Alquiler(1, "Calle Gran Vía, 123", 3, 2, 120, 10, true, cliente1, "Alcalá de Henares", 1000);
            Alquiler alquiler2 = new Alquiler(2, "Calle Princesa, 45", 2, 1, 80, 5, true, cliente2, "Getafe", 800);
            Alquiler alquiler3 = new Alquiler(3, "Calle Alcalá, 67", 4, 3, 150, 15, true, cliente3, "Alcobendas", 1200);
            Alquiler alquiler4 = new Alquiler(4, "Calle Mayor, 10", 1, 1, 50, 3, true, cliente4, "Leganes", 600);
            Alquiler alquiler5 = new Alquiler(5, "Calle Serrano, 30", 3, 2, 110, 8, true, cliente5, "Las Rozas", 950);

            EnVenta venta1 = new EnVenta(6, "Paseo del Prado, 20", 4, 2, 180, 12, true, cliente1, "Madrid", 3000);
            EnVenta venta2 = new EnVenta(7, "Calle Fuencarral, 80", 2, 1, 75, 6, true, cliente2, "Majadahonda", 1200);
            EnVenta venta3 = new EnVenta(8, "Calle Toledo, 15", 3, 2, 100, 10, true, cliente3, "Pozuelo de Alarcón", 2000);
            EnVenta venta4 = new EnVenta(9, "Calle Atocha, 55", 1, 1, 60, 4, true, cliente4, "Boadilla del Monte", 900);
            EnVenta venta5 = new EnVenta(10, "Calle Gran Vía, 200", 5, 3, 220, 15, true, cliente5, "Torrejón de Ardoz", 3500);

            // Crear visitas
            Visita visita1 = new Visita(1, new DateTime(2023, 11, 25, 14, 30, 0), cliente1, alquiler1, empleado1);
            Visita visita2 = new Visita(2, new DateTime(2023, 11, 24, 16, 0, 0), cliente2, venta2, empleado2);
            Visita visita3 = new Visita(3, new DateTime(2023, 11, 23, 10, 45, 0), cliente3, alquiler3, empleado3);
            Visita visita4 = new Visita(4, new DateTime(2023, 11, 22, 12, 15, 0), cliente4, venta4, empleado4);
            Visita visita5 = new Visita(5, new DateTime(2023, 11, 21, 15, 45, 0), cliente5, alquiler5, empleado5);

            // Crear transacciones
            Transaccion transaccion1 = new Transaccion(1, new DateTime(2023, 11, 25, 15, 0, 0), new Visita[] { visita1 }, empleado1, cliente1, alquiler1, 1000, 200);
            Transaccion transaccion2 = new Transaccion(2, new DateTime(2023, 11, 24, 17, 30, 0), new Visita[] { visita2 }, empleado2, cliente2, venta2, 1200, 400);
            Transaccion transaccion3 = new Transaccion(3, new DateTime(2023, 11, 23, 11, 0, 0), new Visita[] { visita3 }, empleado3, cliente3, alquiler3, 1500, 300);
            Transaccion transaccion4 = new Transaccion(4, new DateTime(2023, 11, 22, 12, 45, 0), new Visita[] { visita4 }, empleado4, cliente4, venta4, 800, 150);
            Transaccion transaccion5 = new Transaccion(5, new DateTime(2023, 11, 21, 16, 15, 0), new Visita[] { visita5 }, empleado5, cliente5, alquiler5, 1100, 250);

            ControladorEmpleado.ListaEmpleados.AddRange(new List<Empleado> { empleado1, empleado2, empleado3, empleado4, empleado5 });
            ControladorCliente.ListaClientes.AddRange(new List<Cliente> { cliente1, cliente2, cliente3, cliente4, cliente5 });
            ControladorAlquiler.ListaAlquileres.AddRange(new List<Alquiler> { alquiler1, alquiler2, alquiler3, alquiler4, alquiler5 });
            ControladorEnVenta.ListaEnVenta.AddRange(new List<EnVenta> { venta1, venta2, venta3, venta4, venta5 });
            ControladorVisita.ListaVisitas.AddRange(new List<Visita> { visita1, visita2, visita3, visita4, visita5 });
            ControladorTransaccion.ListaTransacciones.AddRange(new List<Transaccion> { transaccion1, transaccion2, transaccion3, transaccion4, transaccion5 });
        }

        private void tsmiPerfil_Click(object sender, EventArgs e)
        {
            Usuarios.ModificarUsuario frmPerfil = new Usuarios.ModificarUsuario(user);
        }
        private void tsmiCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void listadoDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuarios.ListadoUsuarios frmListado = new Usuarios.ListadoUsuarios();
            frmListado.ShowDialog();
        }

        private void nuevoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuarios.NuevoUsuario frmNuevoUsuario = new Usuarios.NuevoUsuario();
            frmNuevoUsuario.ShowDialog();
        }

        private void tsmiNuevoEmpleado_Click(object sender, EventArgs e)
        {
            Empleados.NuevoEmpleado frmNuevoEmpleado = new Empleados.NuevoEmpleado();
            frmNuevoEmpleado.ShowDialog();
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

        private void listaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
