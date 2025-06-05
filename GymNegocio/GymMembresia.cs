using System;
using System.Collections.Generic;
using System.Data.SqlClient; 
using GymDatos;
using Microsoft.Data.SqlClient; // verificacion de push

namespace GymNegocio
//el nombre es importante para la llamada correcta y demas...
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
        //una nueva propiedad para el estado de la membresia del cliente para saber si la membresia del cliente esta activa 

        public abstract string TipoMembresia { get; }
        // esto va a forzar a la membresia a decir cual es su tipo, si es Mensual O Anual opciones 

        public virtual void CalcularVencimiento()
        // void es que no devuelvo ningun valor, y aqui vamos a calcular la fecha de vencimiento de la membresia,
        // si la FechaFin pasa de la FechaInicio entonces debe de vencer 
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
            //Se puede quedar vacio es un metodo que usaremos mas adelante 
        }

        // haremos esto para la creacion de nuevas membresias
        protected Membresia(DateTime fechaInicio, decimal costoTotal, string nombre, string telefono)
        {
            FechaInicio = fechaInicio;
            CostoTotal = costoTotal;
            Nombre = nombre;
            Telefono = telefono;
            Activa = true;
        }

        protected Membresia()
        {
            FechaInicio = DateTime.Now;
            Activa = true;
        }
    }

    //Clase hija derivada  Membresia Mensual
    public class Mensual : Membresia
    {
        public override string TipoMembresia => "Mensual";
        private static readonly decimal CostoMensualBase = 1200m;// costo de la memebresia de forma mensual
        //Constructor sin parametros 
        public Mensual() : base()
        {
            CalcularCostoTotal();// llamammos al metodo de calcualrCostoTotal
        }

        public Mensual(DateTime fechaInicio, string nombre, string telefono) 
            : base(fechaInicio, 0, nombre, telefono)
        {
            FechaFin = FechaInicio.AddMonths(1);// eso es para un mes de membresia
            CalcularCostoTotal();

        }

        public override void CalcularCostoTotal()
        {
            CostoTotal = CostoMensualBase;
        }
    }

    //clase Hija derivada - Membresia Anual
    //Lo mismo pero para la opcion anual
    public class Anual : Membresia
    {
        public override string TipoMembresia => "Anual";
        private static readonly decimal CostoAnualBase = 14400m;
        // Constructor sin parametros para el Datareader
        public Anual() : base()
        {
            CalcularCostoTotal();// llamammos al metodo de calcualrCostoTotal
        }

        //Constructor con parametros 
        public Anual(DateTime fechaInicio, string nombre, string telefono) 
            : base(fechaInicio, 0 , nombre, telefono)
       
        {
            FechaFin = FechaInicio.AddYears(1);
                CalcularCostoTotal();
        }

        public override void CalcularCostoTotal()
        {
                CostoTotal = CostoAnualBase;
        }
    }

    //Clase Acceso
    //Usaremos ahora esto para insertar, actualizar y eliminar y listar nueva etapa del codigo
    public class MemGymnasio //Nombre de la clase 
    {
        public void InsertarMembresia(Membresia membresia)  // INSERTA
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

                    membresia.Id = Convert.ToInt32(cmd.ExecuteScalar()); //Ejecuta el comando y obtiene el Id generado
                }
            }
        }

        public void Actualizar(Membresia membresia) //ACTUALIZAR
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

    //Implementamos aqui lo que es la logica de negocio
    public class Servicio_Membresia
    {
        public MemGymnasio _accesoDatos; 

        public Servicio_Membresia()
        {
            _accesoDatos = new MemGymnasio();
        }

        public int ContarMembresiaActivas()
        {
            return ObtenerTodasLasMembresias().Count(m => m.Activa);
        }

        public void RegistrarMembresia(Membresia miembro)
        {
            if (string.IsNullOrWhiteSpace(miembro.Nombre))
            {
                throw new ArgumentException("El nombre del Miembro es Obligatorio. ");
                
            }
            if (miembro.FechaInicio > miembro.FechaFin)// Si la fecha de inicio es hoy, la fecha de fin se calcula 
            {
                throw new ArgumentException("La fecha de inicio no puede ser posterior a la fecha fin. ");
            }
            //Mensual y Anual , calcular costo y vencimiento al ser creadas ,
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
            //Llamamos nuevamente 
            miembro.CalcularCostoTotal();
            miembro.CalcularVencimiento();

            _accesoDatos.Actualizar(miembro);//actualiza 
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

        public Membresia ObtenerMembresiaPorId(int idMembresia) 
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