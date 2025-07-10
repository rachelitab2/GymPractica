using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymNegocio.ClasesEntrenador

    // CLASE PADRE 
{
    public abstract class Entrenador// clase abstracta base para los entrenadores 
        // esto es para definir las propiedades comunes que todo entrenador debe de tner.
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Genero { get; set; }
        public string Area { get; protected set; } // el set es protected porque la clase hija lo definira.
        public string Telefono { get; set; }
        public DateTime FechaIngreso { get; set; }
        public int Duracion { get; set; } //Duracion del Contrato en Meses 
        public bool Activo { get; set; }

        public decimal Salario { get; set; }

        public decimal SalarioTotal
        {
            get { return CalcularSalarioTotal(); }
        }

        //Constructor
        public Entrenador()
        {
            FechaIngreso = DateTime.Now;
            Activo = true;
        }
         // Constructor con parámetros
        protected Entrenador(string nombre, string genero, string telefono, decimal salario)
        {
            Nombre = nombre;
            Genero = genero;
            Telefono = telefono;
            Salario = salario;
            FechaIngreso = DateTime.Now;
            Activo = true;
            Duracion = 12; // Duración por defecto
        }

        // Método abstracto que debe implementar cada tipo de entrenador

        public virtual bool ValidarDisponibilidad()
        {
            return Activo && DateTime.Now <= FechaIngreso.AddMonths(Duracion);
        }

        public string EstadoContrato
        {
            get
            {
                return ValidarDisponibilidad() ? "Vigente" : "Vencido";
            }
        }

        // Método virtual para calcular bonificaciones
        public virtual decimal CalcularBonificacion()
        {
            // Bonificación base del 5% del salario
            return Salario * 0.05m;
        }

        // Método abstracto que debe implementar cada tipo de entrenador
        public abstract decimal CalcularSalarioTotal();



    }



}
