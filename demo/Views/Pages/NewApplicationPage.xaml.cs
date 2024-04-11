﻿using demo.Controllers;
using demo.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
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
    /// Логика взаимодействия для NewApplicationPage.xaml
    /// </summary>
    public partial class NewApplicationPage : Page
    {
        private Заявки _currentOrder = new Заявки();
        public NewApplicationPage()
        {
            InitializeComponent();
            DataContext = _currentOrder;
            fill_breakingBox();
            fill_breakingBox2();
            //Equipment_cb.ItemsSource = App.Context.Оборудование.ToList();
            // Defect_cb.ItemsSource = App.Context.Неисправности.ToList();

        }
        void fill_breakingBox()
        {
            string connectionString = "Data Source=LAPTOP-N9J4H06Q\\MSSQLSERVER01;Initial Catalog=script;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);

            // Напишите SQL-запрос для извлечения значений
            string query = "select Оборудование from [script].[dbo].[Оборудование]";
           // Создаем объект DataAdapter для выполнения запроса
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
            DataSet dataSet = new DataSet();

            // Заполняем набор данных с помощью DataAdapter
            dataAdapter.Fill(dataSet, "Оборудование");
            // Создаем объект DataTable, куда будем загружать данные
            DataTable dt = dataSet.Tables["Оборудование"];
            // Привязываем данные к свойству ItemsSource вашего ComboBox
            Equipment_cb.ItemsSource = dt.DefaultView;
            Equipment_cb.DisplayMemberPath = "Оборудование"; // Указываем, какое поле отображать в ComboBox

        }
        void fill_breakingBox2()
        {
            string connectionString = "Data Source=LAPTOP-N9J4H06Q\\MSSQLSERVER01;Initial Catalog=script;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);

            // Напишите SQL-запрос для извлечения значений
            string query2 = "select Неисправность from [script].[dbo].[Неисправности]";
            // Создаем объект DataAdapter для выполнения запроса
            SqlDataAdapter dataAdapter2 = new SqlDataAdapter(query2, connection);
            DataSet dataSet = new DataSet();

            // Заполняем набор данных с помощью DataAdapter
            dataAdapter2.Fill(dataSet, "Неисправности");
            // Создаем объект DataTable, куда будем загружать данные
            DataTable dt2 = dataSet.Tables["Неисправности"];
            // Привязываем данные к свойству ItemsSource вашего ComboBox
            Defect_cb.ItemsSource = dt2.DefaultView;
            Defect_cb.DisplayMemberPath = "Неисправность"; // Указываем, какое поле отображать в ComboBox

        }


        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            if (_currentOrder.id_заявки == 0)

            {
                
                DataClass dataClass = new DataClass();

                string problem = Problem_tb.Text.Trim();



                int k = 0;
               

                    Random r = new Random();
                    k = r.Next(6, 10000);
                    k = k + 1;
                    string querystring = $"insert into [script].[dbo].[Заявки] (id_заявки, Описание_проблемы) values ('{k}','{problem}')";
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

        private void Equipment_cb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataRowView selectedDataRowViewEquipment = Equipment_cb.SelectedItem as DataRowView;
            string name = selectedDataRowViewEquipment["Оборудование"].ToString();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new AuthPage());
        }

        private void Malfunction_cb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataRowView selectedDataRowViewMalfunction = Defect_cb.SelectedItem as DataRowView;
            string name = selectedDataRowViewMalfunction["Неисправность"].ToString();

        }
    }
}
