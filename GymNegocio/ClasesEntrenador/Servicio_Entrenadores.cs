using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GymNegocio.ClasesEntrenador
{

    //implementamos la logica de negocio
    public class Servicio_Entrenadores

    {
        // Interactua con la capa de acceso a datos y aplica validaciones.
        private AccesoEntrenador _accesoEntrenador;

        public Servicio_Entrenadores()
        {
            //Instancia de la clase de acceso a datos para interactuar con la base de datos de entrenadores 
            _accesoEntrenador = new AccesoEntrenador();
        }
        public void RegistrarEntrenador(Entrenador nuevoEntrenador )
        {
            // Validaciones de negocio: esto se asegura que los campos obligatorios no esten vacios.
            if (string.IsNullOrWhiteSpace(nuevoEntrenador.Nombre))
            {
                throw new ArgumentException("El nombre del entrenador es obligatorio.");
            }

            if (string.IsNullOrWhiteSpace(nuevoEntrenador.Genero))
            {
                throw new ArgumentException("El género del entrenador es obligatorio.");
            }

            if (string.IsNullOrWhiteSpace(nuevoEntrenador.Area))
            {
                throw new ArgumentException("El área de especialización es obligatoria.");
            }

            if (string.IsNullOrWhiteSpace(nuevoEntrenador.Telefono))
            {
                throw new ArgumentException("El teléfono del entrenador es obligatorio.");
            }

            if (nuevoEntrenador.Duracion <= 0)
            {
                throw new ArgumentException("La duración de las sesiones debe ser mayor a 0 minutos.");
            }
             
            //Validar si ya existe un entrenador con el mismo numero de telefono para evitar duplicados de el mismo telefono 
            var entrenadoresExistentes = _accesoEntrenador.ListarEntrenadores();
            if (entrenadoresExistentes.Any(e => e.Telefono == nuevoEntrenador.Telefono))
            {
                throw new ArgumentException("Ya existe un entrenador con ese numero de telefono.");
            }
            // si todas las validaciones pasan, para proceder a insertar el entrenador en la base de datos 
            _accesoEntrenador.InsertarEntrenador(nuevoEntrenador);
        }
      

        public void ActualizarEntrenador(Entrenador entrenador)
        {
            // Validaciones de negocio para actualización
            if (entrenador.Id <= 0)
            {
                throw new ArgumentException("ID de entrenador inválido para la actualización.");
            }

            if (string.IsNullOrWhiteSpace(entrenador.Nombre))
            {
                throw new ArgumentException("El nombre del entrenador es obligatorio.");
            }

            if (string.IsNullOrWhiteSpace(entrenador.Genero))
            {
                throw new ArgumentException("El género del entrenador es obligatorio.");
            }

            if (string.IsNullOrWhiteSpace(entrenador.Area))
            {
                throw new ArgumentException("El área de especialización es obligatoria.");
            }

            if (string.IsNullOrWhiteSpace(entrenador.Telefono))
            {
                throw new ArgumentException("El teléfono del entrenador es obligatorio.");
            }

            if (entrenador.Duracion <= 0)
            {
                throw new ArgumentException("La duración de las sesiones debe ser mayor a 0 minutos.");
            }

            _accesoEntrenador.ActualizarEntrenador(entrenador);
        }

        public void EliminarEntrenador(int idEntrenador)
        {
            if (idEntrenador <= 0)
            {
                throw new ArgumentException("ID de entrenador inválido para la eliminación.");
            }

            var entrenadorExistente = _accesoEntrenador.ObtenerPorId(idEntrenador);
            if(entrenadorExistente == null)
            {
                throw new ArgumentException("El Entrenador no existe.");
            }

            _accesoEntrenador.EliminarEntrenador(idEntrenador);
        }


       
        public List<Entrenador> ObtenerTodos()
        {
            return _accesoEntrenador.ListarEntrenadores();
        }

        // Obtener entrendor por ID 
        // el ID del entrenador a buscar
        // el objeto entrendor si se encuentra, o es null el Id es invalido o no existe 
        public Entrenador ObtenerPorId(int idEntrenador)
        {
            if (idEntrenador <= 0)
            {
                return null; // retorna null si el ID es invalido 
            }

            return _accesoEntrenador.ObtenerPorId(idEntrenador);
        }

        public List<Entrenador> ObtenerPorArea(string area)
        {
            return ObtenerTodos().Where(e => e.Area.Equals(area, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public List<Entrenador> ObtenerEntrenadoresActivos()
        {
            return ObtenerTodos().Where(e => e.Activo).ToList();
        }

        public int ContarEntrenadoresActivos()
        {
            return ObtenerEntrenadoresActivos().Count();
        }
        public List<Entrenador> BuscarPorNombre(string nombre)
        {
            if (string.IsNullOrEmpty(nombre))
            {
                return new List<Entrenador>();
            }

            return ObtenerTodos().Where(e => e.Nombre.Contains(nombre, StringComparison.OrdinalIgnoreCase)).ToList();
        }

    }
}

