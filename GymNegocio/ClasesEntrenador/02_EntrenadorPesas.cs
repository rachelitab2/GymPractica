﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymNegocio.ClasesEntrenador
{
   public class EntrenadorPesas : Entrenador
    {
        public EntrenadorPesas()
        {
            Area = "Pesas"; 
        }

        public override decimal CalcularSalario()
        {
            return 25000;
        }
    }
}
