using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymNegocio.ClasesRutinas
{
   public class Servicio_Rutinas 
    {
        private readonly AccesoRutina _accesoRutina;

        public Servicio_Rutinas()
        {
            _accesoRutina = new AccesoRutina();
        }

        public void RegistrarRutina(Rutina nuevaRutina)
        {
            if (string.IsNullOrWhiteSpace(nuevaRutina.NombreRutina))
            {
                throw new ArgumentException("El Nombre de la rutina es Obligatorio.");
            }

            if (string.IsNullOrWhiteSpace(nuevaRutina.Genero))
            {
                throw new ArgumentException("El Genero de la Rutina es Obligatorio.");
            }

            if (nuevaRutina.IdEntrenador <= 0)
            {
                throw new ArgumentException("Se debe Asignar un Entrenador a la Rutina");
            }

            _accesoRutina.InsertarRutina(nuevaRutina);
        }

        public void ActualizarRutina(Rutina rutina)
        {
            if (rutina.Id <= 0)
            {
                throw new ArgumentException("ID de Rutina invalido para la Actualizacion.");
            }

            if (string.IsNullOrWhiteSpace(rutina.NombreRutina))
            {
                throw new ArgumentException("El Nombre de la Rutina es Obligatorio.");
            }

            if(rutina.IdEntrenador <= 0)
            {
                throw new ArgumentException("Se debe reasignar un Entrenador a la Rutina.");
            }
            _accesoRutina.ActualizarRutina(rutina);
        }

        public void EliminarRutina(int idRutina)
        {
            if(idRutina <= 0)
            {
                throw new ArgumentException("ID de Rutina invalido para la Eliminacion.");
            }
            _accesoRutina.EliminarRutina(idRutina);
        }

        public List<Rutina> ObtenerTodasLasRutinas()
        {
            return _accesoRutina.ListarRutina();
        }

        public Rutina ObtenerRutinasPorId(int idRutina)
        {
            if (idRutina <= 0)
            {
                return null;
            }

            return _accesoRutina.ObtenerRutinaPorId(idRutina);
        }
        public List<Rutina> ObtenerRutinasPorGenero(string genero)
        {
            return ObtenerTodasLasRutinas().Where(r => r.Genero.Equals(genero, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public List<Rutina> ObtenerRutinasPorArea(string areaCuerpo)
        {
            return ObtenerTodasLasRutinas().Where(r => r.AreaCuerpo.Equals(areaCuerpo, StringComparison.OrdinalIgnoreCase)).ToList();
        }
    }
}
