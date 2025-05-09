using System;
using System.Collections.Generic;
using System.Linq;

namespace CulturAppEscritorio.Models
{
    public static class UsersOrm
    {
        /// <summary>
        /// Valida las credenciales de un usuario durante el proceso de inicio de sesión.
        /// </summary>
        /// <param name="email">El correo electrónico del usuario.</param>
        /// <param name="password">La contraseña del usuario.</param>
        /// <returns>Un objeto <see cref="Users"/> que representa al usuario, o null si no se encuentra.</returns>
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
                Console.WriteLine($"Error in UsersOrm Selectlogin: {ex.Message}");
                return null;
            }
        }

        /// <summary>
        /// Obtiene un usuario utilizando su correo electrónico.
        /// </summary>
        /// <param name="email">El correo electrónico del usuario a buscar.</param>
        /// <returns>Un objeto <see cref="Users"/> que representa al usuario, o null si no se encuentra.</returns>
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
                Console.WriteLine($"Error in UsersOrm SelectWithMail: {ex.Message}");
                return null;
            }
        }

        /// <summary>
        /// Obtiene todos los usuarios activos.
        /// </summary>
        /// <returns>Lista de objetos <see cref="Users"/> que representan los usuarios activos en la base de datos.</returns>
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
                Console.WriteLine($"Error in UsersOrm SelectGlobal: {ex.Message}");
                return new List<Users>(); // Retorna una lista vacía en caso de error
            }
        }

        /// <summary>
        /// Inserta un nuevo usuario en la base de datos.
        /// </summary>
        /// <param name="user">El objeto <see cref="Users"/> que contiene los datos del nuevo usuario.</param>
        public static void Insert(Users user)
        {
            try
            {
                Orm.bd.Users.Add(user);  // Agrega el nuevo usuario
                Orm.bd.SaveChanges();  // Guarda los cambios en la base de datos
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in UsersOrm Insert: {ex.Message}");
            }
        }

        /// <summary>
        /// Elimina un usuario de la base de datos (lo marca como inactivo).
        /// </summary>
        /// <param name="user">El objeto <see cref="Users"/> que representa al usuario a eliminar.</param>
        public static void Delete(Users user)
        {
            try
            {
                Users _existingUser = Orm.bd.Users.FirstOrDefault(existingUser => existingUser.id == user.id);
                if (_existingUser != null)
                {
                    _existingUser.active = false;  // Marca al usuario como inactivo
                    Orm.bd.SaveChanges();  // Guarda los cambios
                }
                else
                {
                    Console.WriteLine($"Error in UsersOrm user with ID {user.id} not found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in UsersOrm Delete: {ex.Message}");
            }
        }

        /// <summary>
        /// Actualiza los datos de un usuario en la base de datos.
        /// </summary>
        /// <param name="user">El objeto <see cref="Users"/> con los datos actualizados del usuario.</param>
        public static void Update(Users user)
        {
            try
            {
                Users _existingUser = Orm.bd.Users.FirstOrDefault(existingUser => existingUser.id == user.id);
                if (_existingUser != null)
                {
                    // Actualiza los campos del usuario
                    _existingUser.name = user.name;
                    _existingUser.surname = user.surname;
                    _existingUser.email = user.email;
                    _existingUser.password = user.password;
                    _existingUser.type = user.type;
                    Orm.bd.SaveChanges();  // Guarda los cambios
                }
                else
                {
                    Console.WriteLine($"Error in UsersOrm user with ID {user.id} not found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in UsersOrm Update: {ex.Message}");
            }
        }

        /// <summary>
        /// Actualiza los datos de un usuario sin modificar la contraseña.
        /// </summary>
        /// <param name="user">El objeto <see cref="Users"/> con los datos actualizados del usuario (sin la contraseña).</param>
        public static void UpdateWithoutPass(Users user)
        {
            try
            {
                Users _existingUser = Orm.bd.Users.FirstOrDefault(existingUser => existingUser.id == user.id);
                if (_existingUser != null)
                {
                    // Actualiza los campos del usuario sin cambiar la contraseña
                    _existingUser.name = user.name;
                    _existingUser.surname = user.surname;
                    _existingUser.email = user.email;
                    _existingUser.type = user.type;
                    Orm.bd.SaveChanges();  // Guarda los cambios
                }
                else
                {
                    Console.WriteLine($"Error in UsersOrm user with ID {user.id} not found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in UsersOrm UpdateWithoutPass: {ex.Message}");
            }
        }
    }
}
