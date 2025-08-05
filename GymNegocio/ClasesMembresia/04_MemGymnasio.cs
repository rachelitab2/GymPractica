using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymDatos;
using GymNegocio.ClasesMembresia;
using GymNegocio.ClasesRutinas;
using Microsoft.Data.SqlClient;


namespace GymNegocio.ClasesMembresia

{
    //Clase Acceso
    //Usaremos ahora esto para insertar, actualizar y eliminar y listar nueva etapa del codigo
    public class MemGymnasio //Nombre de la clase 
    {
        public virtual void InsertarMembresia(Membresia membresia)  // INSERTA
                                                                    //metodo normal para insertar 

        {
            using (SqlConnection conn = new SqlConnection(ConexionDatos.Conexion))
            {
                conn.Open(); //Abre la conexion, esto abre la conexion para hacer lo que falta de la conexion de la CapaConexionDatos
                //a esta capa

                //Consulta SQL para insertar. Esto tiene que ver con la conexion SQL y demas 
                string query = "INSERT INTO Membresia (NOMBRE, TELEFONO, TIPO, FECHAINICIO, FECHAFIN, COSTOTOTAL, Activa) " +
                               " VALUES(@Nombre, @Telefono, @Tipo,  @FechaInicio, @FechaFin, @CostoTotal, @Activa); " +
                               "SELECT SCOPE_IDENTITY();";//Para obtener el Id que se genera automaticamente desde la Base de Datos 

                using (SqlCommand cmd = new SqlCommand(query, conn))//Crea el comando SQL 
                {
                    cmd.Parameters.AddWithValue("@Nombre", membresia.Nombre);
                    cmd.Parameters.AddWithValue("@Telefono", membresia.Telefono);
                    cmd.Parameters.AddWithValue("@Tipo", membresia.TipoMembresia);
                    cmd.Parameters.AddWithValue("@FechaInicio", membresia.FechaInicio);
                    cmd.Parameters.AddWithValue("@FechaFin", membresia.FechaFin);
                    cmd.Parameters.AddWithValue("@CostoTotal", membresia.CostoTotal);
                    cmd.Parameters.AddWithValue("@Activa", membresia.Activa);

                    var result = cmd.ExecuteNonQuery();
                    if (result != null)
                    {
                        membresia.Id = Convert.ToInt32(result);
                    }
                    membresia.Id = Convert.ToInt32(cmd.ExecuteScalar()); //Ejecuta el comando y obtiene el Id generado
                }
            }
        }

        public virtual void Actualizar(Membresia membresia) //ACTUALIZAR
        {
            using (SqlConnection conn = new SqlConnection(ConexionDatos.Conexion))// se debe repetir este paso una y otra vez para lla,r la conexion para actualizar 
            {
                conn.Open(); //Abre la conexion 
                //Consulta SQL para actualizar. 
                string query = "UPDATE Membresia SET NOMBRE = @Nombre, TELEFONO = @Telefono, TIPO = @Tipo, " +
                               "FECHAINICIO = @FechaInicio, FECHAFIN = @FechaFin, COSTOTOTAL = @CostoTotal, Activa = @Activa " +
                               "WHERE Id = @Id";
                using (SqlCommand cmd = new SqlCommand(query, conn))//Crea el comando SQL 
                {
                    cmd.Parameters.AddWithValue("@Id", membresia.Id);
                    cmd.Parameters.AddWithValue("@Nombre", membresia.Nombre);
                    cmd.Parameters.AddWithValue("@Telefono", membresia.Telefono);
                    cmd.Parameters.AddWithValue("@Tipo", membresia.TipoMembresia);
                    cmd.Parameters.AddWithValue("@FechaInicio", membresia.FechaInicio);
                    cmd.Parameters.AddWithValue("@FechaFin", membresia.FechaFin);
                    cmd.Parameters.AddWithValue("@CostoTotal", membresia.CostoTotal);
                    cmd.Parameters.AddWithValue("@Activa", membresia.Activa);
                    cmd.ExecuteNonQuery(); //Ejecuta el comando de actualización
                }
            }
        }

        public void Eliminar(int IdMembresia) //Eliminar 
        {
            using (SqlConnection conn = new SqlConnection(ConexionDatos.Conexion))//SAME
            {
                conn.Open();
                string query = "DELETE FROM Membresia WHERE Id = @IdMembresia";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IdMembresia", IdMembresia);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Membresia> Listar() // Aqui estamos listando las membresias de la base de datos 
        {
            List<Membresia> membresias = new List<Membresia>();// creamos lista vacia para guardar memebresias encontadas
            using (SqlConnection conn = new SqlConnection(ConexionDatos.Conexion)) // conexion nuevamente
            {
                string query = "SELECT Id, NOMBRE, TELEFONO, TIPO, FECHAINICIO, FECHAFIN, COSTOTOTAL, Activa FROM Membresia ORDER BY Id";
                //Consultamos los registros de la tabla 
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Membresia membresia;
                            string tipo = reader["TIPO"].ToString(); // lee el tipo de membresia 

                            // polimorfismo buena practica
                            if (tipo == "Mensual")
                                membresia = new Mensual();
                            else if (tipo == "Anual")
                                membresia = new Anual();
                            else
                                continue;

                            // Convertir cada campo de la Base de Datos a correctos

                            membresia.Id = Convert.ToInt32(reader["Id"]);
                            membresia.Nombre = reader["NOMBRE"].ToString();
                            membresia.Telefono = reader["TELEFONO"].ToString();
                            membresia.FechaInicio = Convert.ToDateTime(reader["FECHAINICIO"]);
                            membresia.FechaFin = Convert.ToDateTime(reader["FECHAFIN"]);
                            membresia.CostoTotal = Convert.ToDecimal(reader["COSTOTOTAL"]);
                            membresia.Activa = Convert.ToBoolean(reader["Activa"]);

                            membresias.Add(membresia);//Agregar lista 
                        }
                    }
                }
            }
            return membresias;//devolver lista de membresias 
        }

        public Membresia ObtenerPorId(int IdMembresia)//Lectura por Id
        {
            Membresia membresia = null;
            using (SqlConnection conn = new SqlConnection(ConexionDatos.Conexion))
            {
                string query = "SELECT Id, NOMBRE, TELEFONO, TIPO, FECHAINICIO, FECHAFIN, COSTOTOTAL, Activa FROM Membresia WHERE Id = @IdMembresia";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IdMembresia", IdMembresia);
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string tipo = reader["TIPO"].ToString();
                            if (tipo == "Mensual")
                                membresia = new Mensual();
                            else if (tipo == "Anual")
                                membresia = new Anual();
                            else
                                return null; // para tipo desconocido o si no encuentra nada

                            membresia.Id = Convert.ToInt32(reader["Id"]);
                            membresia.Nombre = reader["NOMBRE"].ToString();
                            membresia.Telefono = reader["TELEFONO"].ToString();
                            membresia.FechaInicio = Convert.ToDateTime(reader["FECHAINICIO"]);
                            membresia.FechaFin = Convert.ToDateTime(reader["FECHAFIN"]);
                            membresia.CostoTotal = Convert.ToDecimal(reader["COSTOTOTAL"]);
                            membresia.Activa = Convert.ToBoolean(reader["Activa"]);
                        }
                    }
                }
            }
            return membresia;
        }
    }
}


       