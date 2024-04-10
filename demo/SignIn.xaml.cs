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
using System.Windows.Shapes;
using System.Xml.Linq;

namespace demo
{
    /// <summary>
    /// Логика взаимодействия для SignIn.xaml
    /// </summary>
    public partial class SignIn : Window
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Login.Text==null||Password.Text==null)
            {
                MessageBox.Show("Заполните все поля");
            }
            else
            {
                App.Global = Login.Text;
                var user = App.Context.Пользователи.FirstOrDefault(p => p.Почта == Login.Text && p.Пароль == Password.Text);
                if (user!=null)
                {
                
                    App.CurrentUser = user;
                    if (App.CurrentUser.id_роли == '1')
                    {
                        MessageBox.Show("Вы клиент");
                        ApplicationIN applicationIN = new ApplicationIN();
                        this.Close();
                        applicationIN.ShowDialog();
                    }
                    if (App.CurrentUser.id_роли == '2')
                    {
                        MessageBox.Show("Вы администратор");
                        ApplicationIN applicationIN = new ApplicationIN();
                        this.Close();
                        applicationIN.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Попробуйте еще раз", "Ошибка");
                }
            }
            
           

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Close();
            mainWindow.ShowDialog();
        }
    }
}
