using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GigFinder.Models;

namespace CulturAppEscritorio.Modules
{
    public static class UsersOrm
    {
        public static Users Selectlogin(string email, string password)
        {
            Users _user =
                (Users)(from user in Orm.bd.Users
                        where user.email == email && user.password == password && user.active == true
                        select user).FirstOrDefault();

            return _user;
        }
    }
}
