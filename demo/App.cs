using demo.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace demo
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static Demo_exEntities GetContext { get; } = new Demo_exEntities();
        public static Demo_exEntities Context
        {  get; set; }
        public static Пользователи currentUser = null;
        public static string Global {  get; set; }
    }
}
