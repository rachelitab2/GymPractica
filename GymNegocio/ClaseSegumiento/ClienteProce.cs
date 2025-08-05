using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymNegocio.ClasesRutinas
{
    public class Cliente

    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Peso { get; set; }
        public decimal Altura { get; set; }
        public decimal Grasa { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
