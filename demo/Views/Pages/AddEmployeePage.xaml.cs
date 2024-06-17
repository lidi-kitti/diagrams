using demo.Controllers;
using demo.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace demo.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddEmployeePage.xaml
    /// </summary>
    public partial class AddEmployeePage : Page
    {
        public AddEmployeePage()
        {
            InitializeComponent();
        }
        UserControllers userControllers = new UserControllers();
        private int k = 7;
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DataClass dataClass = new DataClass();

            string firstName = Name.Text.Trim();
            string lastName = LastName.Text.Trim();
            string secondName = SecondName.Text.Trim();
            string email = Email.Text.Trim();
            string password = Password.Text.Trim();
            int k = 0;
            if (firstName.Length < 1)
            {
                Name.ToolTip = "Это поле введено некорректно!";
                Name.Background = Brushes.DarkRed;
            }
            else if (lastName.Length < 1)
            {
                LastName.ToolTip = "Это поле введено некорректно!";
                LastName.Background = Brushes.DarkRed;
            }
            else if (password.Length < 5)
            {
                Password.ToolTip = "Это поле введено некорректно!";
                Password.Background = Brushes.DarkRed;
            }


            else if (email.Length < 1)
            {
                Email.ToolTip = "Это поле введено некорректно!";
                Email.Background = Brushes.DarkRed;
            }
            else
            {
                Name.ToolTip = "";
                Name.Background = Brushes.Transparent;

                LastName.ToolTip = "";
                LastName.Background = Brushes.Transparent;

                Password.ToolTip = "";
                Password.Background = Brushes.Transparent;
                Random r = new Random();
                k = r.Next(6, 10000);
                k = k + 1;
                string querystring = $"insert into [script].[dbo].[UserTable] (id_user, surname_user, name_user, patronymic_user, email_user, password_user, id_role) values ('{k}','{secondName}','{firstName}', '{lastName}', '{email}', '{password}','1')";
                SqlCommand command = new SqlCommand(querystring, dataClass.getConnection());

                dataClass.openConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Регистрация успешна");
                    this.NavigationService.GoBack();

                }

                else
                {
                    MessageBox.Show("Аккаунт не создан");
                }

                dataClass.closeConnection();
            }
        }



        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new HomePage());
        }
    }
}

