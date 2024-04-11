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
using System.Data.Entity.Core.Objects;
namespace demo.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для TableOfApplicationPage.xaml
    /// </summary>
    public partial class TableOfApplicationPage : Page
    {
        DemoEntities1 exEntities = new DemoEntities1();
        public TableOfApplicationPage()
        {
            InitializeComponent();
        }

        private void PageLoaded(object sender, RoutedEventArgs e)
        {
            var query =
                from Заявки in exEntities.Заявки
                select new
                {
                    Заявки.id_заявки,
                    Заявки.id_исполнителя,
                    Заявки.id_клиента,
                    Заявки.id_неисправности,
                    Заявки.id_оборудования,
                    Заявки.id_статуса,
                    Заявки.Дата_открытия,
                    Заявки.Описание_проблемы,
                    Заявки.Статус
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
