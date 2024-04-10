﻿using System;
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

namespace demo.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для HomePage.xaml
    /// </summary>
    public partial class HomePage : Page
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new TapleOfEquipmentPage());
        }
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new TableOfMalfunctionPage());
        }
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new EmployeePage());
        }
        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new TableOfApplicationPage());
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new NewApplicationPage());

        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new PartsPage());
        }
    }
}
