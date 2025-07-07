using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymDatos;
using Microsoft.Data.SqlClient;

namespace GymNegocio.ClasesEntrenador
{
    public class AccesoEntrenador
    {
        public void InsertarEntrenador (Entrenador entrenador)
        {
            using (SqlConnection conn = new SqlConnection(ConexionDatos.Conexion))
            {
                conn.Open();
                string query = "INSERT INTO Entrenador (Nombre, Genero, Area, Telefono, FechaIngreso,Duracion, Activo, Salario) " +
                    "VALUES (@Nombre, @Genero, @Area, @Telefono, @FechaIngreso, @Duracion, @Activo,@Salario)"+
 "SELECT SCOPE_IDENTITY();";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Nombre", entrenador.Nombre);
                    cmd.Parameters.AddWithValue("@Genero", entrenador.Genero);
                    cmd.Parameters.AddWithValue("@Area", entrenador.Area); // area esta definida por la clase hija 
                    cmd.Parameters.AddWithValue("@Telefono", entrenador.Telefono);
                    cmd.Parameters.AddWithValue("@FechaIngreso", entrenador.FechaIngreso);
                    cmd.Parameters.AddWithValue("@Duracion", entrenador.Duracion);
                    cmd.Parameters.AddWithValue("@Activo",entrenador.Activo);
                    cmd.Parameters.AddWithValue("@Salario", entrenador.Salario);
                   entrenador.Id = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }
         
        public void ActualizarEntrenador(Entrenador entrenador)
        {
            using (SqlConnection conn = new SqlConnection(ConexionDatos.Conexion))
            {
                conn.Open();

                string query = "UPDATE Entrenador SET Nombre = @Nombre, Genero = @Genero, Area = @Area" +
                    "Telefono = @Telefono, FechaIngreso = @FechaIngreso, Duracion = @Duracion, Activo = @Activo, Salario = @Salario" +
                    "WHERE Id = @Id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", entrenador.Id);
                    cmd.Parameters.AddWithValue("@Nombre", entrenador.Nombre);
                    cmd.Parameters.AddWithValue("@Genero", entrenador.Genero);
                    cmd.Parameters.AddWithValue("@Area", entrenador.Area);
                    cmd.Parameters.AddWithValue("Telefono", entrenador.Telefono);
                    cmd.Parameters.AddWithValue("FechaIngreso", entrenador.FechaIngreso);
                    cmd.Parameters.AddWithValue("Duracion", entrenador.Duracion);
                    cmd.Parameters.AddWithValue("Activo", entrenador.Activo);
                    cmd.Parameters.AddWithValue("Salario", entrenador.Salario);

                    cmd.ExecuteNonQuery();


                }
            }
        }

        public void EliminarEntrenador (int idEntrenador)
        {
            using (SqlConnection conn = new SqlConnection(ConexionDatos.Conexion))
            {
                conn.Open();
                string query = "DELETE FROM Entrenador WHERE Id = @Id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", idEntrenador);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Entrenador> ListarEntrenadores()
        {
            List<Entrenador> entrenadores = new List<Entrenador>();
            using (SqlConnection conn = new SqlConnection(ConexionDatos.Conexion))
            {
                string query = "SELECT Id, Nombre, Genero, Area , Telefono, FechaIngreso, Duracion, Activo, Salario FROM Entrenador ORDER BY Id ";
              
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Entrenador entrenador;
                            string area = reader["Area"].ToString();

                            if (area == "Pesas")
                                entrenador = new EntrenadorPesas();
                            else if (area == "Cardio")
                                entrenador = new EntrenadorCardio();
                            else if (area == "Pilates")
                                entrenador = new EntrenadorPilates();
                            else if (area == "Yoga")
                                entrenador = new EntrenadorYoga();
                            else continue;

                            entrenador.Id = Convert.ToInt32(reader["Id"]);
                            entrenador.Nombre = reader["Nombre"].ToString();
                            entrenador.Genero = reader["Genero"].ToString();
                            entrenador.Telefono = reader["Telefono"].ToString();
                            entrenador.FechaIngreso = Convert.ToDateTime(reader["FechaIngreso"]);
                            entrenador.Duracion = Convert.ToInt32(reader["Duracion"]);
                            entrenador.Activo = Convert.ToBoolean(reader["Activo"]);
                            entrenador.Salario = Convert.ToDecimal(reader["Salario"]);

                            entrenadores.Add(entrenador);
                        }
                    }
                }
            }
            return entrenadores;

        }

        public Entrenador ObtenerPorId(int idEntrenador)
           
        {
            Entrenador entrenador = null;
         
            using (SqlConnection conn = new SqlConnection(ConexionDatos.Conexion))
            {
                conn.Open();
                string query = "SELECT Id, Nombre, Genero, Area, Telefono, FechaIngreso, Duracion, Activo, Salario FROM Entrenador WHERE Id = @Id";
                using(SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", idEntrenador); 
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string area = reader["Area"].ToString();

                            if (area == "Pesas")
                                entrenador = new EntrenadorPesas();
                            else if (area == "Cardio")
                                entrenador = new EntrenadorCardio();
                            else if (area == "Pilates")
                                entrenador = new EntrenadorPilates();
                            else if (area == "Yoga")
                                entrenador = new EntrenadorYoga();
                            else
                                return null; // No se encontro del tipo valido

                            entrenador.Id = Convert.ToInt32(reader["Id"]);
                            entrenador.Nombre = reader["Nombre"].ToString();
                            entrenador.Genero = reader["Genero"].ToString();
                            entrenador.Telefono = reader["Telefono"].ToString();
                            entrenador.FechaIngreso = Convert.ToDateTime(reader["FechaIngreso"]);
                            entrenador.Duracion = Convert.ToInt32(reader["Duracion"]);
                            entrenador.Activo = Convert.ToBoolean(reader["Activo"]);
                            entrenador.Salario = Convert.ToDecimal(reader["Salario"]);
                        }
                    }
                }
            }
                return entrenador;
            }

        }
    }

    

