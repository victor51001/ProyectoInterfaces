using InmoSolution.Clases;
using InmoSolution.Controladores;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;


namespace InmoSolution.Formularios.Clientes
{
    public partial class ListadoClientes : Form
    {
        public ListadoClientes()
        {
            InitializeComponent();
        }

        private void ListadoClientes_Load(object sender, EventArgs e)
        {
            CargarDatosEnDataGridView();
        }

        private void CargarDatosEnDataGridView()
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=F:\\Repos\\victor51001\\ProyectoInterfaces\\InmoSolution\\InmoSolution\\InmoDatabase.mdf;Integrated Security=True";
            string query = "SELECT * FROM Cliente";
            dgvClientes.Columns.Clear();
            dgvClientes.Columns.Add("Dni", "DNI");
            dgvClientes.Columns.Add("Nombre", "Nombre");
            dgvClientes.Columns.Add("Apellidos", "Apellidos");
            dgvClientes.Columns.Add("Telefono", "Telefono");
            dgvClientes.Columns.Add("Email", "Email");
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string dni = reader["Dni"].ToString();
                                string nombre = reader["Nombre"].ToString();
                                string apellidos = reader["Apellidos"].ToString();
                                string telefono = reader["Telefono"].ToString();
                                string email = reader["Email"].ToString();
                                dgvClientes.Rows.Add(dni, nombre, apellidos, telefono, email);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar datos: {ex.Message}\n{ex.StackTrace}");
                }
            }
        }

        private void bttnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bttnEliminar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow fila in dgvClientes.SelectedRows) 
            {
                if (!fila.IsNewRow)
                {
                    string dni = fila.Cells[0].Value.ToString();
                    ControladorCliente.eliminarCliente(dni);
                }
            }
            CargarDatosEnDataGridView();
        }

        private void rdbttnDni_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbttnDni.Checked)
            {
                dgvClientes.Sort(dgvClientes.Columns[0], ListSortDirection.Ascending);
            }
        }

        private void rdbttnNombre_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbttnNombre.Checked)
            {
                dgvClientes.Sort(dgvClientes.Columns[1], ListSortDirection.Ascending);
            }
        }

        private void rdbttnApellidos_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbttnApellidos.Checked)
            {
                dgvClientes.Sort(dgvClientes.Columns[2], ListSortDirection.Ascending);
            }
        }

        private void rdbttnTelefono_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbttnTelefono.Checked)
            {
                dgvClientes.Sort(dgvClientes.Columns[3], ListSortDirection.Ascending);
            }
        }

        private void rdbttnEmail_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbttnEmail.Checked)
            {
                dgvClientes.Sort(dgvClientes.Columns[4], ListSortDirection.Ascending);
            }
        }

        private void bttnModificar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count == 1)
            {
                Cliente cliente = sacarCliente();
                ModificarCliente modificarCliente = new ModificarCliente(cliente);
                modificarCliente.ShowDialog();
                CargarDatosEnDataGridView();
            }
            else
            {
                MessageBox.Show("Debe seleccionar solo un cliente para modificarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Cliente sacarCliente()
        {
            Cliente cliente = new Cliente();
            cliente.Dni = dgvClientes.SelectedRows[0].Cells[0].Value.ToString();
            cliente.Nombre = dgvClientes.SelectedRows[0].Cells[1].Value.ToString();
            cliente.Apellidos = dgvClientes.SelectedRows[0].Cells[2].Value.ToString();
            cliente.Telefono = Convert.ToInt32(dgvClientes.SelectedRows[0].Cells[3].Value);
            cliente.Email = dgvClientes.SelectedRows[0].Cells[4].Value.ToString();
            return cliente;
        }
    }
}
