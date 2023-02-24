using NutritionDiary.Models;
using NutritionDiary.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace NutritionDiary
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        private readonly Diary _diary;

        public App()
        {
            _diary = new Diary();
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = new MainWindow()
            {
                DataContext = new  MainViewModel(_diary)
            };
            MainWindow.Show();
            base.OnStartup(e);
        }
    }
}
