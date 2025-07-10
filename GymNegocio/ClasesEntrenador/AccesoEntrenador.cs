using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymDatos;
using Microsoft.Data.SqlClient;

namespace GymNegocio.ClasesEntrenador
{
    public class AccesoEntrenador // clase acceso datos para la gestion de entrenadores , aqui vamos a poner los metodos 
    {
        //Usaremos ahora esto para insertar, actualizar y eliminar y listar nueva etapa del codigo
        public void InsertarEntrenador (Entrenador entrenador) //Insertar 
        {
            using (SqlConnection conn = new SqlConnection(ConexionDatos.Conexion))
            {
                conn.Open();// abre la conexion 

                //Consulta SQL para insertar. Esto tiene que ver con la conexion SQL y demas 
                string query = "INSERT INTO Entrenador (Nombre, Genero, Area, Telefono, FechaIngreso,Duracion, Activo, Salario) " +
                    "VALUES (@Nombre, @Genero, @Area, @Telefono, @FechaIngreso, @Duracion, @Activo,@Salario)"+
                    "SELECT SCOPE_IDENTITY();";//Para obtener el Id que se genera automaticamente desde la Base de Datos

                using (SqlCommand cmd = new SqlCommand(query, conn)) //Crea el comando SQL
                {
                    cmd.Parameters.AddWithValue("@Nombre", entrenador.Nombre);
                    cmd.Parameters.AddWithValue("@Genero", entrenador.Genero);
                    cmd.Parameters.AddWithValue("@Area", entrenador.Area); // area esta definida por la clase hija 
                    cmd.Parameters.AddWithValue("@Telefono", entrenador.Telefono);
                    cmd.Parameters.AddWithValue("@FechaIngreso", entrenador.FechaIngreso);
                    cmd.Parameters.AddWithValue("@Duracion", entrenador.Duracion);
                    cmd.Parameters.AddWithValue("@Activo",entrenador.Activo);
                    cmd.Parameters.AddWithValue("@Salario", entrenador.Salario);
                   entrenador.Id = Convert.ToInt32(cmd.ExecuteScalar());//Ejecuta el comando y obtiene el Id generado
                }
            }
        }
         
        public void ActualizarEntrenador(Entrenador entrenador) //ACTUALIZAR
        {
            using (SqlConnection conn = new SqlConnection(ConexionDatos.Conexion)) // se debe repetir este paso una y otra vez para lla, r la conexion para actualizar
            {
                {
                    conn.Open();

                    //Consulta SQL para actualizar.
                    string query = "UPDATE Entrenador SET Nombre = @Nombre, Genero = @Genero, Area = @Area," +
                    "Telefono = @Telefono, FechaIngreso = @FechaIngreso, Duracion = @Duracion, Activo = @Activo, Salario = @Salario " +
                    "WHERE Id = @Id";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", entrenador.Id);
                        cmd.Parameters.AddWithValue("@Nombre", entrenador.Nombre);
                        cmd.Parameters.AddWithValue("@Genero", entrenador.Genero);
                        cmd.Parameters.AddWithValue("@Area", entrenador.Area);
                        cmd.Parameters.AddWithValue("@Telefono", entrenador.Telefono);
                        cmd.Parameters.AddWithValue("@FechaIngreso", entrenador.FechaIngreso);
                        cmd.Parameters.AddWithValue("@Duracion", entrenador.Duracion);
                        cmd.Parameters.AddWithValue("@Activo", entrenador.Activo);
                        cmd.Parameters.AddWithValue("@Salario", entrenador.Salario);

                        cmd.ExecuteNonQuery(); //Ejecuta el comando de actualización


                    }
                }
            }
        }

        public void EliminarEntrenador (int idEntrenador) //Eliminar 
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

        public List<Entrenador> ListarEntrenadores() // Aqui estamos listando los entrenadores de la base de datos 
        {
            List<Entrenador> entrenadores = new List<Entrenador>(); // creamos lista vacia para guardar los entrenadores encontrados
            using (SqlConnection conn = new SqlConnection(ConexionDatos.Conexion))
            {
                string query = "SELECT Id, Nombre, Genero, Area , Telefono, FechaIngreso, Duracion, Activo, Salario FROM Entrenador ORDER BY Id ";
                //Consultamos los registros de la tabla 

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Entrenador entrenador;
                            string area = reader["Area"].ToString(); // lee el tipo de entrenador 
                            // polimorfismo buena practica
                            if (area == "Pesas")
                                entrenador = new EntrenadorPesas();
                            else if (area == "Cardio")
                                entrenador = new EntrenadorCardio();
                            else if (area == "Pilates")
                                entrenador = new EntrenadorPilates();
                            else if (area == "Yoga")
                                entrenador = new EntrenadorYoga();
                            else continue;

                            // Convertir cada campo de la Base de Datos a correctos

                            entrenador.Id = Convert.ToInt32(reader["Id"]);
                            entrenador.Nombre = reader["Nombre"].ToString();
                            entrenador.Genero = reader["Genero"].ToString();
                            entrenador.Telefono = reader["Telefono"].ToString();
                            entrenador.FechaIngreso = Convert.ToDateTime(reader["FechaIngreso"]);
                            entrenador.Duracion = Convert.ToInt32(reader["Duracion"]);
                            entrenador.Activo = Convert.ToBoolean(reader["Activo"]);
                            entrenador.Salario = reader["Salario"] == DBNull.Value ? 0 : Convert.ToDecimal(reader["Salario"]);

                            entrenadores.Add(entrenador); //Agregar lista 
                        }
                    }
                }
            }
            return entrenadores; // devolver lsita de entrenadores 

        }

        public Entrenador ObtenerPorId(int idEntrenador) //lectura por Id
           
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
                                return null; //  por si no se encontra del tipo valido o para tipo desconocido o si no encuentra nada

                            entrenador.Id = Convert.ToInt32(reader["Id"]);
                            entrenador.Nombre = reader["Nombre"].ToString();
                            entrenador.Genero = reader["Genero"].ToString();
                            entrenador.Telefono = reader["Telefono"].ToString();
                            entrenador.FechaIngreso = Convert.ToDateTime(reader["FechaIngreso"]);
                            entrenador.Duracion = Convert.ToInt32(reader["Duracion"]);
                            entrenador.Activo = Convert.ToBoolean(reader["Activo"]);
                            entrenador.Salario = reader["Salario"] == DBNull.Value ? 0 : Convert.ToDecimal(reader["Salario"]);
                        }
                    }
                }
            }
                return entrenador;
            }

        }
    }

    

