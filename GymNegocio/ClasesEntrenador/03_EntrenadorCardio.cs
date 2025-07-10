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

        // Constructor con parámetros
        public EntrenadorCardio(string nombre, string genero, string telefono, decimal salario) 
            : base (nombre, genero, telefono, salario)
        {
            Area = "Cardio";
        }

        // Implementación del método abstracto - SALARIO TOTAL CON BONIFICACIÓN
        public override decimal CalcularSalarioTotal()
        {
            // Los entrenadores de cardio tienen 8% de bonificación
            return Salario + (Salario * 0.08m);
        }
        // Override del método virtual para bonificación específica
        public override decimal CalcularBonificacion()
        {
            return Salario * 0.08m; // 8% para cardio
        }
        public decimal CalcularSalario()
        {
            
            return CalcularSalarioTotal();
        }



    }
}

