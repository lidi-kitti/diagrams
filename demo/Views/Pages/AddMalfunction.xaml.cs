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
    /// Логика взаимодействия для AddMalfunction.xaml
    /// </summary>
    public partial class AddMalfunction : Page
    {
        public AddMalfunction()
        {
            InitializeComponent();
        }
        
        private int k = 7;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DataClass dataClass = new DataClass();

            string malName = Name.Text.Trim();

           

            int k = 0;
            if (malName.Length < 1)
            {
                Name.ToolTip = "Это поле введено некорректно!";
                Name.Background = Brushes.DarkRed;
            }
           
            else
            {
                Name.ToolTip = "";
                Name.Background = Brushes.Transparent;

                Random r = new Random();
                k = r.Next(6, 10000);
                k = k + 1;
                string querystring = $"insert into [script].[dbo].[Неисправности] (id_неисправности, Неисправности) values ('{k}','{malName}')";
                SqlCommand command = new SqlCommand(querystring, dataClass.getConnection());

                dataClass.openConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Успешно сохранено");
                    this.NavigationService.GoBack();

                }

                else
                {
                    MessageBox.Show("Сохранение прервано");
                }

                dataClass.closeConnection();
            }
        }



        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new TableOfMalfunctionPage());
        }
    }
}

