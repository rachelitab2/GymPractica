using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymNegocio.ClasesEntrenador
{
    public class EntrenadorYoga : Entrenador
    {
        public EntrenadorYoga() 
        {
            Area = "Yoga";
        }
        public decimal CalcularSalario()
        {
            return Salario;
        }
    }

}

   
