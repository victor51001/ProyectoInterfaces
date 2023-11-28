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
        public static void LeerVisitas()
        {
            try
            {
                var toml = File.ReadAllText("visitas.toml");

                var tabla = Toml.ToModel(toml);

                for (int i=0; i<tabla.Count; i++)
                {

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
                                ["Precio"] = ((EnVenta)ListaVisitas[i].Inmueble).Precio
                            };
                            break;
                    }

                    tabla["Visita"] = new TomlTable()
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
    }
}
