using System;
using System.Collections.Generic;
using System.Data.Entity;
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
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        private Пользователи пользователи = new Пользователи();

        public Registration()
        {
            InitializeComponent();
            DataContext = пользователи;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (lastname.Text==null||secondname.Text==null||name.Text==null||password.Text==null||password2.Text==null||email.Text==null)
            {
                MessageBox.Show("Заполните все поля");
            }
            else
            {
                Пользователи user = App.Context.Пользователи.FirstOrDefault(p=>p.Почта == email.Text && 
                (p.Пароль == password.Text));
                if(user.id_роли == '1')
                {
                    MessageBox.Show("Вы клиент");
                }
                if (user.id_роли == '2')
                {
                    MessageBox.Show("Вы администратор");
                }
            }
            MainWindow mainWindow = new MainWindow();
            this.Close();
            mainWindow.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Close();
            mainWindow.ShowDialog();
        }
    }
}
