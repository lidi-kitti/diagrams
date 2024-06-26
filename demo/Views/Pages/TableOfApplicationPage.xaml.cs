﻿using demo.Models;
using System;
using System.Collections.Generic;
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
using System.Data.Entity.Core.Objects;
namespace demo.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для TableOfApplicationPage.xaml
    /// </summary>
    public partial class TableOfApplicationPage : Page
    {
        Demo_examEntities exEntities = new Demo_examEntities();
        public TableOfApplicationPage()
        {
            InitializeComponent();
        }

        private void PageLoaded(object sender, RoutedEventArgs e)
        {
            var query =
                from ApplicationTable in exEntities.ApplicationTable
                select new
                {
                    ApplicationTable.id_application,
                    ApplicationTable.id_executor,
                    ApplicationTable.id_client,
                    ApplicationTable.id_malfunction,
                    ApplicationTable.id_equipment,
                    ApplicationTable.id_status,
                    ApplicationTable.opening_date,
                    ApplicationTable.problem_description
                    
                };
            GridOrders.ItemsSource = query.ToList();
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }
    }
}
