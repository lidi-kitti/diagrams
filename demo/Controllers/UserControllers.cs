using demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace demo.Controllers
{
    internal class UserControllers
    {
        Connection connection = new Connection();
        private int kp=6;
        public List<Пользователи> GetUsers()
        {
            try
            {
                var users = connection.auth.Пользователи.ToList();
                return users;
            }
            catch (Exception ex) { throw new Exception($"{ex.Message}"); }
        }
        public Пользователи CreateNewUser(string name, string secondname, string lastname, string email, string password)
        {
            try
            {
                Пользователи users = new Пользователи
                {
                    id_пользователя = kp + 1,
                    Фамилия = string.Empty,
                    Имя = string.Empty,
                    Отчество = string.Empty,
                    Почта = string.Empty,
                    Пароль = string.Empty,
                    id_роли = 1
                    

                };
                connection.auth.Пользователи.Add(users);
                connection.auth.SaveChanges();
                MessageBox.Show("Пользователь зарегистрирован!");
                return users;
            }
            catch (Exception ex) 
            { throw new Exception($"{ex.Message}"); }
        }
        
        public Пользователи SignInUser( string username, string password)
        {
            try
            {
                var user = connection.auth.Пользователи.Where(x => x.Почта == username && x.Пароль == password).First();
                return user;
            }
            catch (Exception ex)
            {
                throw new Exception($"{ex.Message}");
            }
        }
    }
}
