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

        public EntrenadorPilates(string nombre, string genero, string telefono, decimal salario)
          : base(nombre, genero, telefono, salario)
        {
            Area = "Pilates";
        }

        // Implementación del método abstracto - SALARIO TOTAL CON BONIFICACIÓN
        public override decimal CalcularSalarioTotal()
        {
            // Los entrenadores de Pilates tienen 7% de bonificación
            return Salario + (Salario * 0.07m);
        }

        // Override del método virtual para bonificación específica
        public override decimal CalcularBonificacion()
        {
            return Salario * 0.07m; // 7% para pilates
        }

        public decimal CalcularSalario()
        {
            return CalcularSalarioTotal();
        }
    }
}

    
