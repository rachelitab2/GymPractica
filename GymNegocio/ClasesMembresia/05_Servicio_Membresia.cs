using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymDatos;
using Microsoft.Data.SqlClient; // verificacion de push
using GymNegocio.ClasesMembresia;
using GymNegocio.Interfaces;

namespace GymNegocio.ClasesMembresia
{

    //Implementamos aqui lo que es la logica de negocio
    public class Servicio_Membresia
    {
        private readonly IRepositorio<Membresia> _accesoDatos;


        public Servicio_Membresia(IRepositorio<Membresia> accesoDatos)
        {
            _accesoDatos = accesoDatos;
        }

        public async Task<int> ContarMembresiaActivasAsync()
        {

            var membresias = await _accesoDatos.ListarAsync();
            return membresias.Count(m => m.Activa); ; //Metodos normal Implementados 
        }

        public async Task RegistrarMembresiaAsync(Membresia nuevaMembresia)
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

            var membresiasExistentes = await _accesoDatos.ListarAsync();
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

            await _accesoDatos.InsertarAsync(nuevaMembresia);
        }

        public async Task ActualizarMembresiaAsync(Membresia miembro)
        {
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
                await _accesoDatos.ActualizarAsync(miembro);//actualiza 
            }

        }

        public async Task EliminarMembresiaAsync(int idMembresia)
        {
            if (idMembresia <= 0)
            {
                throw new ArgumentException("ID de Membresia Invalido para la Eliminacion.");
            }

            var membresiaExistente = await  _accesoDatos.ObtenerPorIdAsync(idMembresia);
            
            if (membresiaExistente == null)
            {
                throw new ArgumentException("Membresia no esxiste");
            }
            await _accesoDatos.EliminarAsync(idMembresia);
        }

        public async Task<List<Membresia>> ObtenerTodasLasMembresiasAsync()
        {
            var membresias = await _accesoDatos.ListarAsync(); //Llama a los datos
                                                    //Metodo normal implementado
            foreach (var m in membresias)
            {
                m.CalcularVencimiento();
            }
            return membresias;
        }

        public async Task<Membresia> ObtenerMembresiaPorId(int idMembresia)
        {
            if (idMembresia <= 0)
            {
                return null;
            }
            var membresia = await _accesoDatos.ObtenerPorIdAsync(idMembresia);
            if (membresia != null)// solo si se encuentra la membresia se va a actualizar su estado 
            {
                membresia.CalcularVencimiento();
            }
            return membresia;
        }

        public async Task<List<Membresia>> ObtenerMembresiaActivasAsync()
        {
            var membresias = await ObtenerTodasLasMembresiasAsync();
            return membresias.Where(m => m.Activa).ToList();
        }

        public async Task<List<Membresia>> ObtenerMembresiasPorTipoAsync(string tipo)
        {
            var membresias = await ObtenerTodasLasMembresiasAsync();
            return membresias.Where(m => m.TipoMembresia.Equals(tipo, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public async Task<List<Membresia>> ObtenerMembresiasVencidasAsync()
        {
            var membresias = await ObtenerTodasLasMembresiasAsync();
            return membresias.Where(m => !m.Activa).ToList();
        }

        public async Task<decimal> CalcularIngresosTotalesAsync()
        {
            var membresias = await ObtenerMembresiaActivasAsync();
            return membresias.Sum(m => m.CostoTotal);
        }

        public async Task<int> ContarMembresiasActivasAsync()
        {
            var membresias = await ObtenerMembresiaActivasAsync();
            return membresias.Count;
        }

        // Método abstracto simulado - para demostrar concepto
        public abstract class ServicioBase
        {
            public abstract void ProcesarDatos();
        }
    }
}

