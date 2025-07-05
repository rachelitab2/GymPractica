using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymNegocio.ClasesEntrenador
{
    public class EntrenadorPilates : Entrenador
    {
        public EntrenadorPilates()
        {
            Area = "Pilates";
        }

        public override decimal CalcularSalario()
        {
            return 26000;
        }
    }
}

    
