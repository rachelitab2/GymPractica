using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymNegocio.ClasesMembresia
{
    //clase Hija derivada - Membresia Anual
    //Lo mismo pero para la opcion anual
    public class Anual : Membresia
    {
        public override string TipoMembresia => "Anual";
        private static readonly decimal CostoAnualBase = 14400m;
        // Constructor sin parametros para el Datareader
        public Anual() : base()
        {
            CalcularCostoTotal();// llamammos al metodo de calcualrCostoTotal
        }

        //Constructor con parametros 
        public Anual(DateTime fechaInicio, string nombre, string telefono)
            : base(fechaInicio, 0, nombre, telefono)

        {
            FechaFin = FechaInicio.AddYears(1); // establece lo que es la fecha de fin para el ano de membresia 
            CalcularCostoTotal();// calculamos el costo total
        }

        public override void CalcularCostoTotal()//sobreescribimos el metodo  para estabalecer el csoto
        {
            CostoTotal = CostoAnualBase;
        }
    }
}
