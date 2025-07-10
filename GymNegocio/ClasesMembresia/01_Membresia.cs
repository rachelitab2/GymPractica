using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GymNegocio.ClasesMembresia

//el nombre es importante para la llamada correcta y demas...
{
    public abstract class Membresia //Clase principal o clase padre, para poder heredar en otras clases hijas 
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public decimal CostoTotal { get; set; }
        public bool Activa { get; set; }
        //una nueva propiedad para el estado de la membresia del cliente para saber si la membresia del cliente esta activa 

        public abstract string TipoMembresia { get; }
        // esto va a forzar a la membresia a decir cual es su tipo, si es Mensual O Anual opciones 

        public virtual void CalcularVencimiento()
        // void es que no devuelvo ningun valor, y aqui vamos a calcular la fecha de vencimiento de la membresia,
        // si la FechaFin pasa de la FechaInicio entonces debe de vencer 
        {
            if (DateTime.Now > FechaFin)
            {
                Activa = false; // si fecha actual sobrepasa a FechaFin es vencida osea callo la membresia 
            }
            else
            {
                Activa = true; // osea que si no ha vencido es que sigue activa 
            }
        }

        public virtual void CalcularCostoTotal()
        {
            //Se puede quedar vacio es un metodo que usaremos mas adelante 
        }

        // haremos esto para la creacion de nuevas membresias
        protected Membresia(DateTime fechaInicio, decimal costoTotal, string nombre, string telefono)
        {
            FechaInicio = fechaInicio;
            CostoTotal = costoTotal;
            Nombre = nombre;
            Telefono = telefono;
            Activa = true;
        }

        protected Membresia()
        {
            FechaInicio = DateTime.Now;
            Activa = true;// esto se pone para que por default se considere una nueva membresia activa 
        }
    }
}