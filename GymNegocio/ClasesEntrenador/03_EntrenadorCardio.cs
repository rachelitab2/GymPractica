using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymNegocio.ClasesEntrenador
{
    public class EntrenadorCardio : Entrenador
    {
    public EntrenadorCardio()
        {
            Area = " Cardio"; //area especifica
        }

    public override decimal CalcularSalario()
        {
            // Salario base de 22,000 + bono por antigüedad
            return 22000; // salario estimado
        }



    }
}

