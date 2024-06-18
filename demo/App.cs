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
        public static Demo_examEntities GetContext { get; } = new Demo_examEntities();
        public static Demo_examEntities Context
        {  get; set; }
        public static UserTable currentUser = null;
        public static ApplicationTable currentApplication = null;
        public static string Global {  get; set; }
    }
}
