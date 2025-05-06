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
            try
            {
                Users _user =
                (Users)(from user in Orm.bd.Users
                        where user.email == email && user.password == password && user.active == true
                        select user).FirstOrDefault();

                return _user;
            } 
            catch (Exception ex)
            {
                Console.WriteLine($"Error in Users Selectlogin: {ex.Message}");
                return null;
            }
            
        }
        public static Users SelectWithMail(string email)
        {
            try
            {
                Users _user =
                (Users)(from user in Orm.bd.Users
                        where user.email == email && user.active == true
                        select user).FirstOrDefault();

                return _user;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in Users SelectWithMail: {ex.Message}");
                return null;
            }
        }

        public static List<Users> SelectGlobal()
        {
            try
            {
                List<Users> _users =
                        (from user in Orm.bd.Users
                         where user.active == true
                         select user).ToList();
                return _users;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in Users SelectGlobal: {ex.Message}");
                return new List<Users>();
            } 
        }

        public static void Insert(Users user)
        {
            try
            {
                Orm.bd.Users.Add(user);
                Orm.bd.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in Users Insert: {ex.Message}");
            }
            
        }

        public static void Delete(Users user)
        {
            try
            {
                Users _existingUser = Orm.bd.Users.FirstOrDefault(existingUser => existingUser.id == user.id);
                if (_existingUser != null)
                {
                    _existingUser.active = false;
                    Orm.bd.SaveChanges();
                }
                else
                {
                    Console.WriteLine($"Error in Users user with ID {user.id} not found.");
                }
            } 
            catch (Exception ex)
            {
                Console.WriteLine($"Error in Users Delete: {ex.Message}");
            }
        }

        public static void Update(Users user)
        {
            try
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
                else
                {
                    Console.WriteLine($"Error in Users user with ID {user.id} not found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in Users Update: {ex.Message}");
            } 
        }
        

        public static void UpdateWithoutPass(Users user)
        {
            try
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
                else
                {
                    Console.WriteLine($"Error in Users user with ID {user.id} not found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in Users UpdateWithoutPass: {ex.Message}");
            }
        }
    }
}
