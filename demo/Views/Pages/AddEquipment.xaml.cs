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
    /// Логика взаимодействия для AddEquipment.xaml
    /// </summary>
    public partial class AddEquipment : Page
    {
        public AddEquipment()
        {
            InitializeComponent();
        }
        
        private int k = 7;
       
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DataClass dataClass = new DataClass();

            string eqipName = Name.Text.Trim();
            
            string serName = SerName.Text.Trim();
           
            int k = 0;
            if (eqipName.Length < 1)
            {
                Name.ToolTip = "Это поле введено некорректно!";
                Name.Background = Brushes.DarkRed;
            }
            else if (serName.Length < 1)
            {
                SerName.ToolTip = "Это поле введено некорректно!";
                SerName.Background = Brushes.DarkRed;
            }
           
            else
            {
                Name.ToolTip = "";
                Name.Background = Brushes.Transparent;

                SerName.ToolTip = "";
                SerName.Background = Brushes.Transparent;

               
                Random r = new Random();
                k = r.Next(6, 10000);
                k = k + 1;
                string querystring = $"insert into [script].[dbo].[Оборудование] (id_оборудования, Оборудование, Серийный_номер) values ('{k}','{eqipName}','{serName}')";
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
            this.NavigationService.Navigate(new TapleOfEquipmentPage());
        }
    }
}

