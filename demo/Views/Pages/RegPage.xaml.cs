using demo.Controllers;
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

namespace demo.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для RegPage.xaml
    /// </summary>
    public partial class RegPage : Page
    {
        UserControllers userControllers = new UserControllers();
        public RegPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if(!String.IsNullOrEmpty(Name.Text) && !String.IsNullOrEmpty(SecondName.Text)&& !String.IsNullOrEmpty(LastName.Text) && !String.IsNullOrEmpty(Email.Text)&& !String.IsNullOrEmpty(Password.Text))
                {
                    var user = userControllers.CreateNewUser(Name.Text, SecondName.Text,LastName.Text, Email.Text,Password.Text);
                    App.currentUser = user;
                    this.NavigationService.Navigate(new HomePage());
                } 
                else
                {
                    MessageBox.Show("Не все поля заполнены!");
                }

            }
            catch (Exception)
            {
                throw;
            }
        }

       

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new AuthPage());
        }
    }
}
