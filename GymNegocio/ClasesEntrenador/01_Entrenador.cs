using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymNegocio.ClasesEntrenador
{
    public abstract class Entrenador
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Genero { get; set; }
        public string Area { get; protected set; } // el set es protected porque la clase hija lo definira.
        public string Telefono { get; set; }
        public DateTime FechaIngreso { get; set; }
        public int Duracion { get; set; } //Duracion del Contrato en Meses 
        public bool Activo { get; set; }

        //Constructor
        public Entrenador()
        {
            FechaIngreso = DateTime.Now;
            Activo = true;
        }


    //Metodo Abstracto para las Clases Hijas 
    public abstract decimal CalcularSalario();


        public virtual string ObtenerInformacion()
        {
            return $"Entrenador: {Nombre}, Area:{Area}";
        }

    }



}
