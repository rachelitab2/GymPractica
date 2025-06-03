using System;
using System.Collections.Generic;
using System.Data.SqlClient; // Necesitamos esto para interactuar con la BD
using GymDatos;
using Microsoft.Data.SqlClient; // Necesitamos esta referencia para acceder a ConexionDatos.connectionString

namespace GymNegocio
//el nombre es importante para la llamada correcta y demas 
{
    public abstract class Membresia //Clase principal o clase padre, para poder heredar en otras clases hijas 
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public decimal CostoTotal { get; set; }
        public bool Activa { get; set; }
        //una nueva propiedad para el estado de la membresia del cliente 

        public abstract string TipoMembresia { get; }
        // esto va a forzar a la membresia a decir cual es su tipo 

        public virtual void CalcularVencimiento()
        // void es que no devuelvo ningun valor 
        // aqui vamos a calcular la fecha de vencimiento de la membresia 
        //si la FechaFin pasa de la FechaInicio entonces debe de vencer 
        {
            if (DateTime.Now > FechaFin)
            {
                Activa = false; // si fecha actual sobrepasa a FechaFin es vencida osea callo la membresia 
            }
            else
            {
                Activa = true; // osea que si no ha vencido es que sigue activa 
            }
        }

        public virtual void CalcularCostoTotal()
        {
        }

        protected Membresia()
        {
            FechaInicio = DateTime.Now;
            Activa = true;
        }
    }

    //Clase hija derivada  Membresia Mensual - AHORA FUERA DE LA CLASE ABSTRACTA
    public class Mensual : Membresia
    {
        public override string TipoMembresia => "Mensual";

        //Constructor sin parametros 
        public Mensual() : base()
        {
        }

        public Mensual(DateTime fechaInicio, decimal costoTotal, string nombre) : base()
        {
            FechaInicio = fechaInicio;
            FechaFin = FechaInicio.AddMonths(1);
            CostoTotal = costoTotal;
            Nombre = nombre;
        }
    }

    //clase Hija derivada - Membresia Anual - AHORA FUERA DE LA CLASE ABSTRACTA
    public class Anual : Membresia
    {
        public override string TipoMembresia => "Anual";

        // Constructor sin parametros para el Datareader
        public Anual() : base()
        {
        }

        //Constructor con parametros 
        public Anual(DateTime fechaInicio, decimal costoTotal, string nombre) : base()
        {
            FechaInicio = fechaInicio;
            FechaFin = FechaInicio.AddYears(1);
            CostoTotal = costoTotal;
            Nombre = nombre;
        }
    }

    //Clase Acceso a datos - AHORA FUERA DE LA CLASE ABSTRACTA
    public class MemGymnasio
    {
        public void InsertarMembresia(Membresia membresia)
        {
            using (SqlConnection conn = new SqlConnection(ConexionDatos.Conexion))
            {
                conn.Open(); //Abre la conexion 
                //Consulta SQL para insertar. 
                string query = "INSERT INTO Membresia (NOMBRE, TELEFONO, TIPO, FECHAINICIO, FECHAFIN, COSTOTOTAL, Activa) " +
                               " VALUES(@Nombre, @Telefono, @Tipo,  @FechaInicio, @FechaFin, @CostoTotal, @Activa); " +
                               "SELECT SCOPE_IDENTITY();";//Para obtener el Id que se genera automaticamente 

                using (SqlCommand cmd = new SqlCommand(query, conn))//Crea el comando SQL 
                {
                    cmd.Parameters.AddWithValue("@Nombre", membresia.Nombre);
                    cmd.Parameters.AddWithValue("@Telefono", membresia.Telefono);
                    cmd.Parameters.AddWithValue("@Tipo", membresia.TipoMembresia);
                    cmd.Parameters.AddWithValue("@FechaInicio", membresia.FechaInicio);
                    cmd.Parameters.AddWithValue("@FechaFin", membresia.FechaFin);
                    cmd.Parameters.AddWithValue("@CostoTotal", membresia.CostoTotal);
                    cmd.Parameters.AddWithValue("@Activa", membresia.Activa);

                    membresia.Id = Convert.ToInt32(cmd.ExecuteScalar()); //Ejecuta el comando y obtiene el Id generado
                }
            }
        }

        public void Actualizar(Membresia membresia)
        {
            using (SqlConnection conn = new SqlConnection(ConexionDatos.Conexion))
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

        public void Eliminar(int IdMembresia)
        {
            using (SqlConnection conn = new SqlConnection(ConexionDatos.Conexion))
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

        public List<Membresia> Listar()
        {
            List<Membresia> membresias = new List<Membresia>();
            using (SqlConnection conn = new SqlConnection(ConexionDatos.Conexion))
            {
                string query = "SELECT Id, Nombre, Telefono, Tipo, FechaInicio, FechaFin, CostoTotal, Activa FROM Membresia";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Membresia membresia;
                            string tipo = reader["Tipo"].ToString();

                            if (tipo == "Mensual")
                                membresia = new Mensual();
                            else if (tipo == "Anual")
                                membresia = new Anual();
                            else
                                continue;

                            membresia.Id = Convert.ToInt32(reader["Id"]);
                            membresia.Nombre = reader["Nombre"].ToString();
                            membresia.Telefono = reader["Telefono"].ToString();
                            membresia.FechaInicio = Convert.ToDateTime(reader["FechaInicio"]);
                            membresia.FechaFin = Convert.ToDateTime(reader["FechaFin"]);
                            membresia.CostoTotal = Convert.ToDecimal(reader["CostoTotal"]);
                            membresia.Activa = Convert.ToBoolean(reader["Activa"]);

                            membresias.Add(membresia);
                        }
                    }
                }
            }
            return membresias;
        }

        public Membresia ObtenerPorId(int IdMembresia)
        {
            Membresia membresia = null;
            using (SqlConnection conn = new SqlConnection(ConexionDatos.Conexion))
            {
                string query = "SELECT Id, Nombre, Telefono, Tipo, FechaInicio, FechaFin, CostoTotal, Activa FROM Membresia WHERE Id = @IdMembresia";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IdMembresia", IdMembresia);
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string tipo = reader["Tipo"].ToString();
                            if (tipo == "Mensual")
                                membresia = new Mensual();
                            else if (tipo == "Anual")
                                membresia = new Anual();
                            else
                                return null; // para tipo desconocido

                            membresia.Id = Convert.ToInt32(reader["Id"]);
                            membresia.Nombre = reader["Nombre"].ToString();
                            membresia.Telefono = reader["Telefono"].ToString();
                            membresia.FechaInicio = Convert.ToDateTime(reader["FechaInicio"]);
                            membresia.FechaFin = Convert.ToDateTime(reader["FechaFin"]);
                            membresia.CostoTotal = Convert.ToDecimal(reader["CostoTotal"]);
                            membresia.Activa = Convert.ToBoolean(reader["Activa"]);
                        }
                    }
                }
            }
            return membresia;
        }
    }

    //Implementamos aqui lo que es la logica de negocio - AHORA FUERA DE LA CLASE ABSTRACTA
    public class Servicio_Membresia
    {
        public MemGymnasio _accesoDatos; // Cambiado de Membresia.MemGymnasio a MemGymnasio

        public Servicio_Membresia()
        {
            _accesoDatos = new MemGymnasio(); // Cambiado de Membresia.MemGymnasio a MemGymnasio
        }

        public void RegistrarMembresia(Membresia miembro)
        {
            if (string.IsNullOrWhiteSpace(miembro.Nombre))
            {
                throw new ArgumentException("El nombre del Miembro es Obligatorio. ");
                // Si la fecha de inicio es hoy, la fecha de fin se calcula 
            }
            if (miembro.FechaInicio > miembro.FechaFin)
            {
                throw new ArgumentException("La fecha de inicio no puede ser posterior a la fecha fin. ");
            }
            //Mensual y Anual deben  calcular costo y vencimiento al ser creadas ,
            //pero de todos modos llamaremos aqui para estar seguros de que se puedan actualizar antes de guardar.
            miembro.CalcularCostoTotal();
            miembro.CalcularVencimiento();

            _accesoDatos.InsertarMembresia(miembro);
        }

        public void ActualizarMembresia(Membresia miembro)
        {
            // agregamos reglas para el negocio y ver validaciones para la actualizacion 
            if (miembro.Id <= 0)
            {
                throw new ArgumentException("ID de Membresia Invalido para la Actualizacion.");
            }
            if (string.IsNullOrEmpty(miembro.Nombre))
            {
                throw new ArgumentException("Nombre del Miembro Obligatorio");
            }

            miembro.CalcularCostoTotal();
            miembro.CalcularVencimiento();

            _accesoDatos.Actualizar(miembro);
        }

        public void EliminarMembresia(int idMembresia)
        {
            if (idMembresia <= 0)
            {
                throw new ArgumentException("ID de Membresia Invalido para la Eliminacion.");
            }
            _accesoDatos.Eliminar(idMembresia);
        }

        public List<Membresia> ObtenerTodasLasMembresias()
        {
            var membresias = _accesoDatos.Listar(); //Llama a los datos 
            foreach (var m in membresias)
            {
                m.CalcularVencimiento();
            }
            return membresias;
        }

        public Membresia ObtenerMembresiaPorId(int idMembresia) // Cambié el nombre del método para evitar confusión
        {
            if (idMembresia <= 0)
            {
                return null;
            }
            var membresia = _accesoDatos.ObtenerPorId(idMembresia);
            if (membresia != null)// solo si se encuentra la membresia se va a actualizar su estado 
            {
                membresia.CalcularVencimiento();
            }
            return membresia;
        }
    }
}