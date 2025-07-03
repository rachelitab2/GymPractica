using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymDatos;
using Microsoft.Data.SqlClient; // verificacion de push
using GymNegocio.ClasesMembresia;

namespace GymNegocio.ClasesMembresia
{

    //Implementamos aqui lo que es la logica de negocio
    public class Servicio_Membresia
    {
        public MemGymnasio _accesoDatos;

        public Servicio_Membresia()
        {
            _accesoDatos = new MemGymnasio();
        }

        public int ContarMembresiaActivas()
        {
            return ObtenerTodasLasMembresias().Count(m => m.Activa);
        }

        public void RegistrarMembresia(Membresia miembro)
        {
            if (string.IsNullOrWhiteSpace(miembro.Nombre))
            {
                throw new ArgumentException("El nombre del Miembro es Obligatorio. ");

            }
            if (miembro.FechaInicio > miembro.FechaFin)// Si la fecha de inicio es hoy, la fecha de fin se calcula 
            {
                throw new ArgumentException("La fecha de inicio no puede ser posterior a la fecha fin. ");
            }
            //Mensual y Anual , calcular costo y vencimiento al ser creadas ,
            //pero de todos modos llamaremos aqui para estar seguros de que se puedan actualizar antes de guardar.
            miembro.CalcularCostoTotal();
            miembro.CalcularVencimiento();

            _accesoDatos.InsertarMembresia(miembro);
        }

        public void ActualizarMembresia(Membresia miembro)
        {
            // agregamos reglas para el negocio y ver validaciones para la actualizacion 
            if (miembro.Id <= 0)
            {
                throw new ArgumentException("ID de Membresia Invalido para la Actualizacion.");
            }
            if (string.IsNullOrEmpty(miembro.Nombre))
            {
                throw new ArgumentException("Nombre del Miembro Obligatorio");
            }
            //Llamamos nuevamente 
            miembro.CalcularCostoTotal();
            miembro.CalcularVencimiento();

            _accesoDatos.Actualizar(miembro);//actualiza 
        }

        public void EliminarMembresia(int idMembresia)
        {
            if (idMembresia <= 0)
            {
                throw new ArgumentException("ID de Membresia Invalido para la Eliminacion.");
            }
            _accesoDatos.Eliminar(idMembresia);
        }

        public List<Membresia> ObtenerTodasLasMembresias()
        {
            var membresias = _accesoDatos.Listar(); //Llama a los datos 
            foreach (var m in membresias)
            {
                m.CalcularVencimiento();
            }
            return membresias;
        }

        public Membresia ObtenerMembresiaPorId(int idMembresia)
        {
            if (idMembresia <= 0)
            {
                return null;
            }
            var membresia = _accesoDatos.ObtenerPorId(idMembresia);
            if (membresia != null)// solo si se encuentra la membresia se va a actualizar su estado 
            {
                membresia.CalcularVencimiento();
            }
            return membresia;
        }
    }
}

