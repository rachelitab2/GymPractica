using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymDatos;
using GymNegocio.ClasesMembresia;
using Microsoft.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace GymNegocio.ClasesMembresia
{
    public class Servicio_PagoMembresia
    {
        public void RegistrarPago(PagoMembresia pago)
        {
            using (SqlConnection conn = new SqlConnection(ConexionDatos.Conexion))
            {
                conn.Open();
                string query = "INSERT INTO PagoMembresia (MembresiaId, FechaPago, Monto, MetodoPago) " +
                               "VALUES (@MembresiaId, @FechaPago, @Monto, @MetodoPago); " +
                               "SELECT SCOPE_IDENTITY();";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MembresiaId", pago.MembresiaId);
                    cmd.Parameters.AddWithValue("@FechaPago", pago.FechaPago);
                    cmd.Parameters.AddWithValue("@Monto", pago.Monto);
                    cmd.Parameters.AddWithValue("@MetodoPago", pago.MetodoPago);

                    pago.Id = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        public void EliminarPago(int pagoId)
        {
            using (SqlConnection conn = new SqlConnection(ConexionDatos.Conexion))
            {
                conn.Open();
                string query = "DELETE FROM PagoMembresia WHERE Id = @Id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", pagoId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void ActualizarPago(PagoMembresia pago)
        {
            using (SqlConnection conn = new SqlConnection(ConexionDatos.Conexion))
            {
                conn.Open();
                string query = "UPDATE PagoMembresia SET FechaPago = @FechaPago, Monto = @Monto, MetodoPago = @MetodoPago WHERE Id = @Id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@FechaPago", pago.FechaPago);
                    cmd.Parameters.AddWithValue("@Monto", pago.Monto);
                    cmd.Parameters.AddWithValue("@MetodoPago", pago.MetodoPago);
                    cmd.Parameters.AddWithValue("@Id", pago.Id);

                    cmd.ExecuteNonQuery();
                }
            }
        }



        public List<PagoMembresia> ObtenerPagosPorMembresia(int membresiaId)
        {
            List<PagoMembresia> pagos = new List<PagoMembresia>();

            using (SqlConnection conn = new SqlConnection(ConexionDatos.Conexion))
            {
                conn.Open();
                string query = @"
                    SELECT p.Id, p.MembresiaId, p.FechaPago, p.Monto, p.MetodoPago, m.Nombre
                    FROM PagoMembresia p
                    INNER JOIN Membresia m ON p.MembresiaId = m.Id
                    WHERE p.MembresiaId = @MembresiaId";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MembresiaId", membresiaId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            PagoMembresia pago = new PagoMembresia
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                MembresiaId = Convert.ToInt32(reader["MembresiaId"]),
                                FechaPago = Convert.ToDateTime(reader["FechaPago"]),
                                Monto = Convert.ToDecimal(reader["Monto"]),
                                MetodoPago = reader["MetodoPago"].ToString(),
                                Nombre = reader["Nombre"].ToString(),
                            };
                            pagos.Add(pago);
                        }
                    }
                }
            }

            return pagos;
        }
        public List<PagoMembresia> ObtenerTodosLosPagos()
        {
            List<PagoMembresia> listaPagos = new List<PagoMembresia>();
            try
            {
                using (SqlConnection conn = new SqlConnection(ConexionDatos.Conexion))
                {
                    conn.Open();
                    string query = @"SELECT p.Id, p.MembresiaId, p.FechaPago, p.Monto, p.MetodoPago, m.NOMBRE
                           FROM PagoMembresia p
                           INNER JOIN Membresia m ON p.MembresiaId = m.Id
                           ORDER BY p.FechaPago DESC";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                PagoMembresia pago = new PagoMembresia();

                                pago.Id = Convert.ToInt32(reader["Id"]);
                                pago.MembresiaId = Convert.ToInt32(reader["MembresiaId"]);
                                pago.FechaPago = Convert.ToDateTime(reader["FechaPago"]);
                                pago.Monto = Convert.ToDecimal(reader["Monto"]);
                                pago.MetodoPago = reader["MetodoPago"].ToString();
                                pago.Nombre = reader["Nombre"].ToString();

                                listaPagos.Add(pago);
                            }
                            
                        }

                    }
                }
            }

            catch(Exception ex)
            {
                throw new Exception("Error al obtener todos los pagos: " + ex.Message);

            }
            return listaPagos;
        }
    }
}

