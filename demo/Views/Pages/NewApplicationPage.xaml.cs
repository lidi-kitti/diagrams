using demo.Controllers;
using demo.Models;
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
    /// Логика взаимодействия для NewApplicationPage.xaml
    /// </summary>
    public partial class NewApplicationPage : Page
    {
        private Заявки _currentOrder = new Заявки();
        public NewApplicationPage()
        {
            InitializeComponent();
            DataContext = _currentOrder;

            Equipment_cb.ItemsSource = App.Context.Оборудование.ToList();
            Defect_cb.ItemsSource = App.Context.Неисправности.ToList();
        }

       
        
        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            if (_currentOrder.id_заявки == 0)

            {
                App.GetContext.Заявки.Add(_currentOrder);

                try
                {
                    App.GetContext.SaveChanges();
                    MessageBox.Show("Заявка сохранена", "Message", MessageBoxButton.OK, MessageBoxImage.Information);
                    this.NavigationService.Navigate(new HomePageClient());
                }
                catch
                {
                    MessageBox.Show("Ошибка", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void Equipment_cb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }
    }
}
