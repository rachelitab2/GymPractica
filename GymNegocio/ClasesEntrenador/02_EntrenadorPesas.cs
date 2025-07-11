﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymNegocio.ClasesEntrenador
{
   public class EntrenadorPesas : Entrenador // clase hija de entrenadores 
    {
        // esto es para asignar el area del entrenador 
        public EntrenadorPesas()
        {
            Area = "Pesas"; 
        }

        //Constructor con parametros
        public EntrenadorPesas(string nombre, string genero, string telefono, decimal salario)
            : base (nombre, genero, telefono, salario)
        {
            Area = "Pesas";
        }

        
        public override decimal CalcularSalarioTotal()
        {
            // Los entrenadores de pesas tienen 10% de bonificacion
            return Salario + (Salario * 0.10m);
        }

        // Override del metodo virtual para bonificacion especifica
        public override decimal CalcularBonificacion()
        {
            return Salario * 0.10m; // 10% para pesas
        }

        // esto es para devolver el salario 
        public decimal CalcularSalario()
        {
            return CalcularSalarioTotal();
        }
    }
}
