using System;
using System.Collections.Generic;
using System.Linq;

namespace CulturAppEscritorio.Models
{
    public static class TypeEventOrm
    {
        /// <summary>
        /// Obtiene todos los tipos de evento de la base de datos.
        /// </summary>
        /// <returns>Lista de objetos <see cref="Type_event"/> que representan los tipos de evento en la base de datos.</returns>
        public static List<Type_event> SelectGlobal()
        {
            try
            {
                List<Type_event> _type =
                    (from type in Orm.bd.Type_event
                     select type).ToList();
                return _type;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en TypeEventOrm SelectGlobal: " + ex.Message);
                return new List<Type_event>();  // Retorna una lista vacía en caso de error
            }
        }

        /// <summary>
        /// Obtiene un tipo de evento específico por su nombre.
        /// </summary>
        /// <param name="name">El nombre del tipo de evento a buscar.</param>
        /// <returns>Un objeto <see cref="Type_event"/> que representa el tipo de evento, o null si no se encuentra.</returns>
        public static Type_event SelectByName(string name)
        {
            try
            {
                Type_event _type =
                    (from type in Orm.bd.Type_event
                     where type.name == name
                     select type).FirstOrDefault();
                return _type;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en TypeEventOrm SelectByName: " + ex.Message);
                return null;
            }
        }
    }
}
