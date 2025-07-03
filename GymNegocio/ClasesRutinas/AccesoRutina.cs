using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using GymDatos;
using GymNegocio.ClasesRutinas;

namespace GymNegocio.ClasesRutinas
{
    public class AccesoRutina
    {
        public void InsertarRutina(Rutina rutina)
        {
            using (SqlConnection conn = new SqlConnection(ConexionDatos.Conexion))
            {
                conn.Open();
                string query = "INSERT INTO Rutinas (NombreRutina, Genero, AreaCuerpo,DuracionMinutos, IdEntrenador)" +
                    "VALUES(@NombreRutina,@Genero,@AreaCuerpo,@DuracionMinutos, @IdEntrenador ); " +
                    "SELECT SCOPE_IDENTITY();";
                using(SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@NombreRutina", rutina.NombreRutina);
                    cmd.Parameters.AddWithValue("@Genero", rutina.Genero);
                    cmd.Parameters.AddWithValue("@AreaCuerpo", rutina.AreaCuerpo);
                    cmd.Parameters.AddWithValue("@DuracionMinutos", rutina.DuracionMinutos);
                    cmd.Parameters.AddWithValue("@IdEntrenador", rutina.IdEntrenador);

                    rutina.Id = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        public void ActualizarRutina(Rutina rutina)
        {
            using (SqlConnection conn = new SqlConnection(ConexionDatos.Conexion))
            {
                conn.Open();
                string query = "UPDATE Rutinas SET NombreRutina = @NombreRutina, Genero =@Genero, AreaCuerpo = @AreaCuerpo" +
                    "DuracionMinutos = @DuracionMinutos, IdEntrenador = @IdEntrenador WHERE Id = @Id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", rutina.Id);
                    cmd.Parameters.AddWithValue("@NombreRutina", rutina.NombreRutina);
                    cmd.Parameters.AddWithValue("@Genero", rutina.Genero);
                    cmd.Parameters.AddWithValue("@AreaCuerpo",rutina.AreaCuerpo);
                    cmd.Parameters.AddWithValue("@DuracionMinutos", rutina.DuracionMinutos);
                    cmd.Parameters.AddWithValue("@IdEntrenador", rutina.IdEntrenador);

                    cmd.ExecuteNonQuery();
                }

            }
        }

        public void EliminarRutina(int idRutina)
        {
            using (SqlConnection conn = new SqlConnection(ConexionDatos.Conexion))
            {
                conn.Open();
                string query = "DELETE FROM Rutinas WHERE Id = @Id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", idRutina);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Rutina> ListarRutina()
        {
            List<Rutina> rutinas = new List<Rutina>();
            using (SqlConnection conn = new SqlConnection(ConexionDatos.Conexion))
            {
                string query = "SELECT Id, NombreRutina, Genero, AreaCuerpo, DuracionMinutos, IdEntrenador FROM Rutinas ORDER BY Id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Rutina rutina = new Rutina
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                NombreRutina = reader["NombreRutina"].ToString(),
                                Genero = reader["Genero"].ToString(),
                                AreaCuerpo = reader["AreaCuerpo"].ToString(),
                                DuracionMinutos = Convert.ToInt32(reader["DuracionMinutos"]),
                                IdEntrenador = Convert.ToInt32(reader["IdEntrenador"])
                            };

                            rutinas.Add(rutina);
                        }
                    }
                }
            }
            return rutinas;
        }
        
        public Rutina ObtenerRutinaPorId(int idRutina)
        {
            Rutina rutina = null;
            using (SqlConnection conn = new SqlConnection(ConexionDatos.Conexion))
            {
                string query = "SELECT Id, NombreRutina, Genero, AreaCuerpo, DuracionMinutos, IdEntrenador FROM Rutinas WHERE Id = @Id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", idRutina);
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            rutina = new Rutina
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                NombreRutina = reader["NombreRutina"].ToString(),
                                Genero = reader["Genero"].ToString(),
                                AreaCuerpo = reader["AreaCuerpo"].ToString(),
                                DuracionMinutos = Convert.ToInt32(reader["DuracionMinutos"]),
                                IdEntrenador = Convert.ToInt32(reader["IdEntrenador"])
                            };
                        }
                    }
                }
            }
            return rutina;
        }
    }
}
