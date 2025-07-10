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

        public virtual void RegistrarMembresia(Membresia nuevaMembresia)
        {
            if (string.IsNullOrWhiteSpace(nuevaMembresia.Nombre))
            {
                throw new ArgumentException("El nombre del Miembro es Obligatorio. ");

            }
            if (string.IsNullOrWhiteSpace(nuevaMembresia.Telefono))
            {
                throw new AbandonedMutexException("El Telefono del Cliente es obligatorio");
            }

            if (nuevaMembresia.FechaInicio > DateTime.Now.AddDays(30))
            {
                throw new ArgumentException("La fecha de inicio no puede ser mayor a 30 dias en el futuro.");
            }

            var membresiasExistentes = _accesoDatos.Listar();
            var membresiaActiva = membresiasExistentes.FirstOrDefault(m => m.Telefono == nuevaMembresia.Telefono && m.Activa);

            if (membresiaActiva != null)
            {
                throw new ArgumentException("Ya existe una membresia activa para este numero de telefono");
            }

            if (nuevaMembresia.FechaInicio > nuevaMembresia.FechaFin)// Si la fecha de inicio es hoy, la fecha de fin se calcula 
            {
                throw new ArgumentException("La fecha de inicio no puede ser posterior a la fecha fin. ");
            }
            //Mensual y Anual , calcular costo y vencimiento al ser creadas ,
            //pero de todos modos llamaremos aqui para estar seguros de que se puedan actualizar antes de guardar.
            nuevaMembresia.CalcularCostoTotal();
            nuevaMembresia.CalcularVencimiento();

            _accesoDatos.InsertarMembresia(nuevaMembresia);
        }

        public virtual void ActualizarMembresia(Membresia miembro)
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

            if (string.IsNullOrWhiteSpace(miembro.Telefono))
            {
                throw new ArgumentException("El telefono del Cliente es obligatorio.");
            }
            miembro.CalcularVencimiento();
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

            var membresiaExistente = _accesoDatos.ObtenerPorId(idMembresia);
            
            if (membresiaExistente == null)
            {
                throw new ArgumentException("Membresia no esxiste");
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

        public List<Membresia> ObtenerMembresiaActivas()
        {
            return ObtenerTodasLasMembresias().Where(m => m.Activa).ToList();
        }

        public List<Membresia> ObtenerMembresiasPorTipo(string tipo)
        {
            return ObtenerTodasLasMembresias().Where(m => m.TipoMembresia.Equals(tipo, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public List<Membresia> ObtenerMembresiasVencidas()
        {
            return ObtenerTodasLasMembresias().Where(m => !m.Activa).ToList();
        }

        public decimal CalcularIngresosTotales()
        {
            return ObtenerMembresiaActivas().Sum(m => m.CostoTotal);
        }

        public int ContarMembresiasActivas()
        {
            return ObtenerMembresiaActivas().Count;
        }

        // Método abstracto simulado - para demostrar concepto
        public abstract class ServicioBase
        {
            public abstract void ProcesarDatos();
        }
    }
}

