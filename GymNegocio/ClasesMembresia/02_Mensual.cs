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
        // esto es para saber  que tipo de membresia que para esta clase es mensual 
        public override string TipoMembresia => "Mensual";
        private static readonly decimal CostoMensualBase = 1200m; //costo de la memebresia de forma mensual
        //Constructor sin parametros 
        public Mensual() : base()
        {
            CalcularCostoTotal(); //llamammos al metodo de calcualrCostoTotal
        }

        //Constructor con parametros para la clase Mensual
        public Mensual(DateTime fechaInicio, string nombre, string telefono)
            : base(fechaInicio, 0, nombre, telefono)
        {
            FechaFin = FechaInicio.AddMonths(1); //esto es para un mes de membresia
            CalcularCostoTotal();//calculamos el costo total 

        }

        public override void CalcularCostoTotal()// sobreescribir el metodo calcualr
                                                 // membresia para establecer el costo total 
                                                 // de la membresia mensual.
        {
            CostoTotal = CostoMensualBase;
        }
    }
}
