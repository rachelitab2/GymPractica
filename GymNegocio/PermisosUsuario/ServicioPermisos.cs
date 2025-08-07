using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using GymDatos;
using Microsoft.Data.SqlClient;

namespace GymNegocio.Login
{
    public class ServicioPermisos
    {
        private readonly string _conexion = ConexionDatos.Conexion;

        public List<string> ObtenerPermisosPorRol(string rol)
        {
            List<string> permisos = new List<string>();

            using (SqlConnection conn = new SqlConnection(_conexion))
            {
                conn.Open();
                string query = @"
                    SELECT p.Nombre
                    FROM Permisos p
                    INNER JOIN RolPermisos rp ON p.Id = rp.PermisoId
                    WHERE rp.Rol = @Rol";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Rol", rol);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            permisos.Add(reader.GetString(0));
                        }
                    }
                }
            }

            return permisos;
        }

        public bool TienePermiso(string rol, string permiso)
        {
            var permisos = ObtenerPermisosPorRol(rol);
            return permisos.Contains(permiso);
        }
    }
}