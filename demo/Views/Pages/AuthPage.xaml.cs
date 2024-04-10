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
using demo.Controllers;
namespace demo.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для AuthPage.xaml
    /// </summary>
    public partial class AuthPage : Page
    {
        UserControllers userController = new UserControllers();
        public AuthPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
                if (!String.IsNullOrEmpty(Login.Text) && !String.IsNullOrEmpty(Password.Text))
                {
                    var user = userController.SignInUser(Login.Text, Password.Text);
                    App.currentUser = user;
                    this.NavigationService.Navigate(new HomePage());

                }
                else
                {
                    MessageBox.Show("Не все поля заполнены", "Системная ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new RegPage());
        }
    }
}
