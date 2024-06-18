using demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace demo.Controllers
{
    internal class UserControllersBase
    {
        Connection connection = new Connection();
        private int kp = 6;
        public UserTable CreateNewUser(string name, string secondname, string lastname, string email, string password)
        {
            try
            {
                UserTable users = new UserTable
                {
                    id_user = kp + 1,
                    surname_user = string.Empty,
                    name_user = string.Empty,
                    patronymic_user = string.Empty,
                    email_user = string.Empty,
                    password_user = string.Empty,
                    id_role = 1,
                    phone_user = string.Empty


                };
                connection.auth.UserTable.Add(users);
                connection.auth.SaveChanges();
                MessageBox.Show("Пользователь зарегистрирован!");
                return users;
            }
            catch (Exception ex)
            { throw new Exception($"{ex.Message}"); }
        }
        public List<UserTable> GetUsers()
        {
            try
            {
                var users = connection.auth.UserTable.ToList();
                return users;
            }
            catch (Exception ex) { throw new Exception($"{ex.Message}"); }
        }

        public UserTable SignInUser(string username, string password)
        {
            try
            {
                var user = connection.auth.UserTable.Where(x => x.email_user == username && x.password_user == password).First();
                return user;
            }
            catch (Exception ex)
            {
                throw new Exception($"{ex.Message}");
            }
        }
    }
}