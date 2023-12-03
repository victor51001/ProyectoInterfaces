using InmoSolution.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Tomlyn;
using Tomlyn.Model;

namespace InmoSolution.Controladores
{
    public class ControladorVisita
    {
        public static List<Visita> ListaVisitas = new List<Visita>();
        public static bool cambios;
        public static bool Cambios { get => cambios; set => cambios = value; }
        public static void LeerVisitas()
        {
            try
            {
                var toml = File.ReadAllText("visitas.toml");

                var tablas = Toml.Parse(toml).ToModel();

                foreach (KeyValuePair<string, object> parVisitas in tablas)
                {
                    Visita visita = new Visita();
                    var tabla = (TomlTable)parVisitas.Value;
                    foreach (KeyValuePair<string, object> parVisita in tabla)
                    {
                        switch (parVisita.Key)
                        {
                            case "Id":
                                visita.Id = ((int)(long)parVisita.Value);
                                break;
                            case "FechaHora":
                                visita.FechaHora = ((TomlDateTime)parVisita.Value).DateTime.DateTime;
                                break;
                            case "Cliente":
                                var tablaCliente = (TomlTable)parVisita.Value;
                                Cliente cliente = new Cliente();
                                foreach (KeyValuePair<string, object> parCliente in tablaCliente)
                                {
                                    switch (parCliente.Key)
                                    {
                                        case "Dni":
                                            cliente.Dni = (string)parCliente.Value;
                                            break;
                                        case "Nombre":
                                            cliente.Nombre = (string)parCliente.Value;
                                            break;
                                        case "Apellidos":
                                            cliente.Apellidos = (string)parCliente.Value;
                                            break;
                                        case "Telefono":
                                            cliente.Telefono = (int)(long)parCliente.Value;
                                            break;
                                        case "Email":
                                            cliente.Email = (string)parCliente.Value;
                                            break;
                                    }
                                }
                                visita.Cliente = cliente;
                                break;
                            case "Inmueble":
                                var tablaInmueble = (TomlTable)parVisita.Value;
                                Inmueble inmueble = null;
                                if (tablaInmueble.ContainsKey("PrecioMensual"))
                                {
                                    inmueble = new Alquiler();
                                }
                                else
                                {
                                    inmueble = new EnVenta();
                                }
                                foreach (KeyValuePair<string, object> parInmueble in tablaInmueble)
                                {
                                    switch (parInmueble.Key)
                                    {
                                        case "Id":
                                            inmueble.Id = (int)(long)parInmueble.Value;
                                            break;
                                        case "Direccion":
                                            inmueble.Direccion = (string)parInmueble.Value;
                                            break;
                                        case "Habitaciones":
                                            inmueble.Habitaciones = (int)(long)parInmueble.Value;
                                            break;
                                        case "Baños":
                                            inmueble.Baños = (int)(long)parInmueble.Value;
                                            break;
                                        case "MetrosCuadrados":
                                            inmueble.MetrosCuadrados = (int)(long)parInmueble.Value;
                                            break;
                                        case "Antiguedad":
                                            inmueble.Antiguedad = (int)(long)parInmueble.Value;
                                            break;
                                        case "Disponible":
                                            inmueble.Disponible = (bool)parInmueble.Value;
                                            break;
                                        case "Localidad":
                                            inmueble.Localidad = (string)parInmueble.Value;
                                            break;
                                        case "PrecioMensual":
                                            ((Alquiler)inmueble).PrecioMensual = (int)(long)parInmueble.Value;
                                            break;
                                        case "PrecioMetroCuadrado":
                                            ((EnVenta)inmueble).PrecioMetroCuadrado = (int)(long)parInmueble.Value;
                                            break;
                                        case "Precio":
                                            ((EnVenta)inmueble).Precio = (int)(long)parInmueble.Value;
                                            break;
                                        case "Propietario":
                                            var tablaPropietario = (TomlTable)parInmueble.Value;
                                            Cliente propietario = new Cliente();
                                            foreach (KeyValuePair<string, object> parPropietario in tablaPropietario)
                                            {
                                                switch (parPropietario.Key)
                                                {
                                                    case "Dni":
                                                        propietario.Dni = (string)parPropietario.Value;
                                                        break;
                                                    case "Nombre":
                                                        propietario.Nombre = (string)parPropietario.Value;
                                                        break;
                                                    case "Apellidos":
                                                        propietario.Apellidos = (string)parPropietario.Value;
                                                        break;
                                                    case "Telefono":
                                                        propietario.Telefono = (int)(long)parPropietario.Value;
                                                        break;
                                                }
                                            }
                                            inmueble.Propietario = propietario;
                                            break;
                                    }
                                }
                                visita.Inmueble = inmueble;
                                break;
                            case "Empleado":
                                var tablaEmpleado = (TomlTable)parVisita.Value;
                                Empleado empleado = new Empleado();
                                foreach (KeyValuePair<string, object> parEmpleado in tablaEmpleado)
                                {
                                    switch (parEmpleado.Key)
                                    {
                                        case "Dni":
                                            empleado.Dni = (string)parEmpleado.Value;
                                            break;
                                        case "Nombre":
                                            empleado.Nombre = (string)parEmpleado.Value;
                                            break;
                                        case "Apellidos":
                                            empleado.Apellidos = (string)parEmpleado.Value;
                                            break;
                                        case "Telefono":
                                            empleado.Telefono = (int)(long)parEmpleado.Value;
                                            break;
                                        case "Email":
                                            empleado.Email = (string)parEmpleado.Value;
                                            break;
                                        case "Puesto":
                                            empleado.Puesto = ControladorEmpleado.ParseString((string)parEmpleado.Value);
                                            break;
                                        case "Sueldo":
                                            empleado.Sueldo = (double)parEmpleado.Value;
                                            break;
                                        case "Usuario":
                                            var tablaUsuario = (TomlTable)parEmpleado.Value;
                                            Usuario usuario = new Usuario();
                                            foreach (KeyValuePair<string, object> parUsuario in tablaUsuario)
                                            {
                                                switch (parUsuario.Key)
                                                {
                                                    case "Id":
                                                        usuario.Id = (int)(long)parUsuario.Value;
                                                        break;
                                                    case "Nombre":
                                                        usuario.Nombre = (string)parUsuario.Value;
                                                        break;
                                                }
                                            }
                                            empleado.Usuario = usuario;
                                            break;
                                    }
                                }
                                visita.Empleado = empleado;
                                break;
                        }
                    }
                    ListaVisitas.Add(visita);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al leer visitas: {ex.Message}");
            }
        }


        public static void EscribirVisitas()
        {
            try
            {
                var tabla = new TomlTable();
                var toml = "";

                TomlTable tablaInmueble = null;

                for (int i = 0; i < ListaVisitas.Count; i++)
                {
                    toml = "";
                    switch (ListaVisitas[i].Inmueble)
                    {
                        case Alquiler:
                            tablaInmueble = new TomlTable()
                            {
                                ["Id"] = ListaVisitas[i].Inmueble.Id,
                                ["Direccion"] = ListaVisitas[i].Inmueble.Direccion,
                                ["Habitaciones"] = ListaVisitas[i].Inmueble.Habitaciones,
                                ["Baños"] = ListaVisitas[i].Inmueble.Baños,
                                ["MetrosCuadrados"] = ListaVisitas[i].Inmueble.MetrosCuadrados,
                                ["Antiguedad"] = ListaVisitas[i].Inmueble.Antiguedad,
                                ["Disponible"] = ListaVisitas[i].Inmueble.Disponible,
                                ["Propietario"] = new TomlTable
                                {
                                    ["Dni"] = ListaVisitas[i].Inmueble.Propietario.Dni,
                                    ["Nombre"] = ListaVisitas[i].Inmueble.Propietario.Nombre,
                                    ["Apellidos"] = ListaVisitas[i].Inmueble.Propietario.Apellidos,
                                    ["Telefono"] = ListaVisitas[i].Inmueble.Propietario.Telefono,
                                    ["Email"] = ListaVisitas[i].Inmueble.Propietario.Email
                                },
                                ["Localidad"] = ListaVisitas[i].Inmueble.Localidad,
                                ["PrecioMensual"] = ((Alquiler)ListaVisitas[i].Inmueble).PrecioMensual
                            };
                            break;
                        case EnVenta:
                            tablaInmueble = new TomlTable()
                            {
                                ["Id"] = ListaVisitas[i].Inmueble.Id,
                                ["Direccion"] = ListaVisitas[i].Inmueble.Direccion,
                                ["Habitaciones"] = ListaVisitas[i].Inmueble.Habitaciones,
                                ["Baños"] = ListaVisitas[i].Inmueble.Baños,
                                ["MetrosCuadrados"] = ListaVisitas[i].Inmueble.MetrosCuadrados,
                                ["Antiguedad"] = ListaVisitas[i].Inmueble.Antiguedad,
                                ["Disponible"] = ListaVisitas[i].Inmueble.Disponible,
                                ["Propietario"] = new TomlTable
                                {
                                    ["Dni"] = ListaVisitas[i].Inmueble.Propietario.Dni,
                                    ["Nombre"] = ListaVisitas[i].Inmueble.Propietario.Nombre,
                                    ["Apellidos"] = ListaVisitas[i].Inmueble.Propietario.Apellidos,
                                    ["Telefono"] = ListaVisitas[i].Inmueble.Propietario.Telefono,
                                    ["Email"] = ListaVisitas[i].Inmueble.Propietario.Email
                                },
                                ["Localidad"] = ListaVisitas[i].Inmueble.Localidad,
                                ["PrecioMetroCuadrado"] = ((EnVenta)ListaVisitas[i].Inmueble).PrecioMetroCuadrado,
                                ["Precio"] = ((EnVenta)ListaVisitas[i].Inmueble).Precio
                            };
                            break;
                    }

                    tabla["Visita " + (i+1)] = new TomlTable()
                    {
                        ["Id"] = ListaVisitas[i].Id,
                        ["FechaHora"] = ListaVisitas[i].FechaHora,
                        ["Cliente"] = new TomlTable()
                        {
                            ["Dni"] = ListaVisitas[i].Cliente.Dni,
                            ["Nombre"] = ListaVisitas[i].Cliente.Nombre,
                            ["Apellidos"] = ListaVisitas[i].Cliente.Apellidos,
                            ["Telefono"] = ListaVisitas[i].Cliente.Telefono,
                            ["Email"] = ListaVisitas[i].Cliente.Email
                        },
                        ["Inmueble"] = tablaInmueble,
                        ["Empleado"] = new TomlTable()
                        {
                            ["Dni"] = ListaVisitas[i].Empleado.Dni,
                            ["Nombre"] = ListaVisitas[i].Empleado.Nombre,
                            ["Apellidos"] = ListaVisitas[i].Empleado.Apellidos,
                            ["Telefono"] = ListaVisitas[i].Empleado.Telefono,
                            ["Email"] = ListaVisitas[i].Empleado.Email,
                            ["Puesto"] = ListaVisitas[i].Empleado.Puesto,
                            ["Sueldo"] = ListaVisitas[i].Empleado.Sueldo,
                            ["Usuario"] = new TomlTable()
                            {
                                ["Id"] = ListaVisitas[i].Empleado.Usuario.Id,
                                ["Nombre"] = ListaVisitas[i].Empleado.Usuario.Nombre
                            }
                        }
                    };
                    toml += Toml.FromModel(tabla);
                }
                File.WriteAllText("visitas.toml", toml);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al escribir/visitas: {ex.Message}");
            }
        }

        public static bool ExisteFichero()
        {
            return File.Exists("visitas.toml");
        }
        public static Cliente GetNoPropietario(Inmueble inmueble)
        {
            Random r = new Random();
            Cliente c = ControladorCliente.ListaClientes[r.Next(ControladorCliente.ListaClientes.Count)];
            while (c==inmueble.Propietario)
            {
                c = ControladorCliente.ListaClientes[r.Next(ControladorCliente.ListaClientes.Count)];
            }
            return c;
        }

        public static Visita GenerarVisita()
        {
            Random r = new Random();
            DateTime fechaHora = DateTime.Now;
            Inmueble inmueble = ControladorInmueble.ListaInmuebles[r.Next(ControladorInmueble.ListaInmuebles.Count)];
            Cliente cliente = GetNoPropietario(inmueble);
            Empleado empleado = ControladorEmpleado.ListaEmpleados[r.Next(ControladorEmpleado.ListaEmpleados.Count)];
            return new Visita(fechaHora, cliente, inmueble, empleado);
        }
    }
}
