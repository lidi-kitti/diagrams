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
using System.Windows.Shapes;

namespace demo
{
    /// <summary>
    /// Логика взаимодействия для RegApp.xaml
    /// </summary>
    public partial class RegApp : Window
    {
        public RegApp()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ApplicationIN applicationIN = new ApplicationIN();
            this.Close();
            applicationIN.ShowDialog();
        }
    }
}
