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
    /// Логика взаимодействия для TableOfMalfunctionPage.xaml
    /// </summary>
    public partial class TableOfMalfunctionPage : Page
    {
        DemoEntities1 exEntities = new DemoEntities1();
        public TableOfMalfunctionPage()
        {
            InitializeComponent();
            GridMalfunction.ItemsSource = App.GetContext.Неисправности.ToList();

        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new HomePage());
        }

        private void PageLoaded(object sender, RoutedEventArgs e)
        {
            var query =
               from Неисправности in exEntities.Неисправности
               select new
               {
                   Неисправности.id_неисправности,
                   Неисправности.Неисправность
                   
               };
            GridMalfunction.ItemsSource = query.ToList();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new AddMalfunction());
        }
    }
}
