using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymDatos;
using Microsoft.Data.SqlClient;

namespace GymNegocio.Login
{
    public class AccesoUsuario
    {
        public string conexion = ConexionDatos.Conexion;
        // Valida las credenciales del usuario y retorna el rol si es valido, o null si no.

        public  void InsertarUsuario(UsuariosActivos usuarios)
        {
            using (SqlConnection conn = new SqlConnection(ConexionDatos.Conexion))
            {
                conn.Open();
                string query = "INSERT INTO Usuarios (Usuario, Contrasena, Rol) VALUES (@Usuario, @Contrasena, @Rol)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Usuario", usuarios.Usuario);
                    cmd.Parameters.AddWithValue("@Contrasena", usuarios.Contrasena);
                    cmd.Parameters.AddWithValue("@Rol", usuarios.Rol);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void ActualizarUsuario(UsuariosActivos usuarios)
        {

            using (SqlConnection conn = new SqlConnection(ConexionDatos.Conexion))
            {
                conn.Open();
                string query = "UPDATE Usuarios SET Usuario = @Usuario, Contrasena = @Contrasena, Rol = @Rol WHERE Id = @Id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Usuario", usuarios.Usuario);
                    cmd.Parameters.AddWithValue("@Contrasena", usuarios.Contrasena);
                    cmd.Parameters.AddWithValue("@Rol", usuarios.Rol); 


                    cmd.Parameters.AddWithValue("@Id", usuarios.Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void EliminarUsuario(int id)
        {
            using (SqlConnection conn = new SqlConnection(ConexionDatos.Conexion))
            {
                conn.Open();
                string query = "DELETE FROM Usuarios WHERE Id = @Id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static UsuariosActivos ObtenerUsuarioPorId(int id)
        {
            UsuariosActivos usuarios = null;
            using (SqlConnection conn = new SqlConnection(ConexionDatos.Conexion))
            {
                string query = "SELECT Id, Usuario, Contrasena, Rol FROM Usuarios WHERE Id = @Id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            usuarios = new UsuariosActivos
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Usuario = reader["Usuario"].ToString(),
                                Contrasena = reader["Contrasena"].ToString(),
                                Rol = reader["Rol"].ToString()

                            };
                        }
                    }
                }
                return usuarios;
            }
        }

        public string ValidarUsuario(string usuario, string contrasena, string tipoAcceso)
        {
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(ConexionDatos.Conexion))
                    {
                        conn.Open();
                        string query = "SELECT Rol FROM Usuarios WHERE Usuario = @Usuario AND Contrasena = @Contrasena AND Rol = @Rol";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@Usuario", usuario);
                            cmd.Parameters.AddWithValue("@Contrasena", contrasena);
                            cmd.Parameters.AddWithValue("@Rol", tipoAcceso);

                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    return reader["Rol"].ToString(); // Devuelve el rol correctamente
                                }
                                else
                                {
                                    return null;
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al validar usuario: " + ex.Message);
                }
            }
        }
        public List<UsuariosActivos> ListarUsuarios()
        {
            List<UsuariosActivos> usuarios = new List<UsuariosActivos>();
            using (SqlConnection conn = new SqlConnection(ConexionDatos.Conexion))
            {
                string query = " SELECT Id, Usuario, Contrasena, Rol FROM Usuarios ORDER BY Id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            usuarios.Add(new UsuariosActivos
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Usuario = reader["Usuario"].ToString(),
                                Contrasena = reader["Contrasena"].ToString(),
                                Rol = reader["Rol"].ToString()
                            });
                        }
                    }
                }
            }
            return usuarios;
        }


    }


  
}
