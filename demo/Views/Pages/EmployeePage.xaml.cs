using demo.Controllers;
using demo.Models;
using System;
using System.Collections.Generic;
using System.Data;
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
    /// Логика взаимодействия для EmployeePage.xaml
    /// </summary>
    public partial class EmployeePage : Page
    {
       
        private Пользователи _currentEmp = new Пользователи();
        public EmployeePage()
        {
            InitializeComponent();
            
            GridEmp.ItemsSource = App.GetContext.Пользователи.ToList();

        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new HomePage());

        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new AddEmployeePage());
           
        }

        private void SerchBoxBtn_Click(object sender, RoutedEventArgs e)
        {
            string connectionString = "Data Source=LAPTOP-N9J4H06Q\\MSSQLSERVER01;Initial Catalog=script;Integrated Security=True";

            string email = SerchBox.Text;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Создание и выполнение SQL-запроса с использованием параметров
                string query =
                    $"SELECT id_пользователя, Фамилия, Имя," +
                    $"Отчество," +
                    $"Почта," +
                    $"Пароль FROM [script].[dbo].[Пользователи] where Почта = @Email";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Email", email);

                SqlDataReader reader = command.ExecuteReader();

                // Создание DataTable и загрузка данных
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);

                // Привязка DataTable к DataGrid
                GridEmp.ItemsSource = dataTable.DefaultView;
            }              
        }
    }
}
