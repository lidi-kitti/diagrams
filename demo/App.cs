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
        public static DemoEntities1 GetContext { get; } = new DemoEntities1();
        public static DemoEntities1 Context
        {  get; set; }
        public static Пользователи currentUser = null;
        public static Заявки currentApplication = null;
        public static string Global {  get; set; }
    }
}
