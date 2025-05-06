using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CulturAppEscritorio.Models;

namespace CulturAppEscritorio.Models
{
    public static class UsersOrm
    {
        public static Users SelectLogin(string email, string password)
        {
            Users _user =
                (Users)(from user in Orm.bd.Users
                        where user.email == email && user.password == password && user.active == true
                        select user).FirstOrDefault();

            return _user;
        }
        public static Users SelectWithMail(string email)
        {
            Users _user =
                (Users)(from user in Orm.bd.Users
                        where user.email == email && user.active == true
                        select user).FirstOrDefault();

            return _user;
        }

        public static List<Users> SelectGlobal()
        {
            List<Users> _users =
                        (from user in Orm.bd.Users
                         where user.active == true
                         select user).ToList();
            return _users;
        }

        public static void Insert(Users user)
        {
            Orm.bd.Users.Add(user);
            Orm.bd.SaveChanges();
        }

        public static void Delete(Users user)
        {
            Users _existingUser = Orm.bd.Users.FirstOrDefault(existingUser => existingUser.id == user.id);
            if (_existingUser != null)
            {
                _existingUser.active = false;
                Orm.bd.SaveChanges();
            }
        }

        public static void Update(Users user)
        {
            Users _existingUser = Orm.bd.Users.FirstOrDefault(existingUser => existingUser.id == user.id);
            if (_existingUser != null)
            {
                _existingUser.name = user.name;
                _existingUser.surname = user.surname;
                _existingUser.email = user.email;
                _existingUser.password = user.password;
                _existingUser.type = user.type;
                Orm.bd.SaveChanges();
            }
        }

        public static void UpdateWithoutPass(Users user)
        {
            Users _existingUser = Orm.bd.Users.FirstOrDefault(existingUser => existingUser.id == user.id);
            if (_existingUser != null)
            {
                _existingUser.name = user.name;
                _existingUser.surname = user.surname;
                _existingUser.email = user.email;
                _existingUser.type = user.type;
                Orm.bd.SaveChanges();
            }
        }
    }
}
