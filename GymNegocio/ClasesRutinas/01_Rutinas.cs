using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymNegocio.ClasesRutinas
{
    public class Rutina
    {
        public int Id { get; set; }
        public string NombreRutina { get; set; }
        public string Genero { get; set; }
        public string AreaCuerpo { get; set; }
        public int DuracionMinutos { get; set; }
    }
}
