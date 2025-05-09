using System;
using System.Collections.Generic;
using System.Linq;

namespace CulturAppEscritorio.Models
{
    public static class TypeEventOrm
    {
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
                return new List<Type_event>();
            }
        }

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
