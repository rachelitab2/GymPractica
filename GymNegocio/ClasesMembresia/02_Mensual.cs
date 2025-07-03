using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GymNegocio.ClasesMembresia
{

    //Clase hija derivada  Membresia Mensual
    public class Mensual : Membresia
    {
        public override string TipoMembresia => "Mensual";
        private static readonly decimal CostoMensualBase = 1200m; //costo de la memebresia de forma mensual
        //Constructor sin parametros 
        public Mensual() : base()
        {
            CalcularCostoTotal(); //llamammos al metodo de calcualrCostoTotal
        }

        public Mensual(DateTime fechaInicio, string nombre, string telefono)
            : base(fechaInicio, 0, nombre, telefono)
        {
            FechaFin = FechaInicio.AddMonths(1); //eso es para un mes de membresia
            CalcularCostoTotal();

        }

        public override void CalcularCostoTotal()
        {
            CostoTotal = CostoMensualBase;
        }
    }
}
