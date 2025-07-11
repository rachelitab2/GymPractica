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


    // Constructor con parametros
    public EntrenadorYoga(string nombre, string genero, string telefono, decimal salario)
           : base(nombre, genero, telefono, salario)
        {
            Area = "Yoga";
        }

  
        public override decimal CalcularSalarioTotal()
        {
            // Los entrenadores de Yoga tienen 6% de bonificacion
            return Salario + (Salario * 0.06m);
        }

        // Override del metodo virtual para bonificacion especifica
        public override decimal CalcularBonificacion()
        {
            return Salario * 0.06m; // 6% para yoga
        }

        public decimal CalcularSalario()
        {
            return CalcularSalarioTotal();
        }
    }

}

   
