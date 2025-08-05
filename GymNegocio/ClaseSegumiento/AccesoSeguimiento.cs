using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymDatos;
using GymNegocio.ClasesRutinas;
using Microsoft.Data.SqlClient;

namespace GymNegocio.ClaseSegumiento
{
    public class AccesoSeguimiento
    {

    }
        public class ClientesGym
        {
            public List<Cliente> Listar()
            {
                List<Cliente> clientes = new List<Cliente>();


                using (SqlConnection conn = new SqlConnection(ConexionDatos.Conexion))
                {
                string query = "SELECT Id, Nombre, Peso, Altura, Grasa, FechaRegistro FROM Clientes ORDER BY Id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Cliente c = new Cliente
                                {
                                    Id = Convert.ToInt32(reader["Id"]),
                                    Nombre = reader["Nombre"].ToString(),
                                    Peso = Convert.ToDecimal(reader["Peso"]),
                                    Altura = Convert.ToDecimal(reader["Altura"]),
                                    Grasa = Convert.ToDecimal(reader["Grasa"]),
                                    FechaRegistro = Convert.ToDateTime(reader["FechaRegistro"])
                                };
                                clientes.Add(c);
                            }
                        }
                    }
                }
                return clientes;
            }


            public bool Insertar(Cliente cliente)
            {
                using (SqlConnection conn = new SqlConnection(ConexionDatos.Conexion))
                {
                    string query = "INSERT INTO Clientes (Nombre, Peso, Altura, Grasa, FechaRegistro) " +
                          "VALUES (@Nombre, @Peso, @Altura, @Grasa, @FechaRegistro)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                        cmd.Parameters.AddWithValue("@Peso", cliente.Peso);
                        cmd.Parameters.AddWithValue("@Altura", cliente.Altura);
                        cmd.Parameters.AddWithValue("@Grasa", cliente.Grasa);
                        cmd.Parameters.AddWithValue("@FechaRegistro", cliente.FechaRegistro);

                        conn.Open();
                        int filasAfectadas = cmd.ExecuteNonQuery();
                        return filasAfectadas > 0;
                    }
                }
            }

            public bool Eliminar(int id)
            {
                using (SqlConnection conn = new SqlConnection(ConexionDatos.Conexion))
                {
                    string query = "DELETE FROM Clientes WHERE Id = @Id";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);
                        conn.Open();
                        int filasAfectadas = cmd.ExecuteNonQuery();
                        return filasAfectadas > 0;
                    }
                }
            }


        }

    }


