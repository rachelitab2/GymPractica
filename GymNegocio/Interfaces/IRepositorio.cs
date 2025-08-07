using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymNegocio.Interfaces
{
        public interface IRepositorio<T>
        {
            Task<List<T>> ListarAsync();
            Task InsertarAsync(T entidad);
            Task ActualizarAsync(T entidad);
            Task EliminarAsync(int id);

            Task<T> ObtenerPorIdAsync(int id);
    }
    
}
/*
 * Interfaz genérica para el acceso a datos en el sistema de gimnasio.
 * Define las operaciones CRUD básicas (Crear, Leer, Actualizar, Eliminar) de forma asíncrona.
 * Todas las clases de repositorio (Membresía, Cliente, Entrenador, etc.) pueden implementar esta interfaz
 * para garantizar un acceso a datos consistente y reutilizable.
 * 
 * Requisito técnico solicitado por el maestro: uso de interfaces y métodos asíncronos.
 * 
 * Autor: [Tu nombre o grupo]
 * Fecha: [Fecha de implementación]
 * 
 * TODO: Implementar esta interfaz en las clases de acceso a datos para cada entidad.
 */