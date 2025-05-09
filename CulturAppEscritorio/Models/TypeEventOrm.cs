using System.Collections.Generic;
using System.Linq;

namespace CulturAppEscritorio.Models
{
    public static class TypeEventOrm
    {
        public static List<Type_event> SelectGlobal()
        {
            List<Type_event> _type =
                        (from type in Orm.bd.Type_event
                         select type).ToList();
            return _type;
        }

        public static Type_event SelectByName(string name)
        {
            Type_event _type =
                        (from type in Orm.bd.Type_event
                         where type.name == name
                         select type).FirstOrDefault();
            return _type;
        }
    }
}
