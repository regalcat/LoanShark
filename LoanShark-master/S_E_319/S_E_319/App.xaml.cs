using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace S_E_319
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            var appView = new AppView();
            var appViewModel = new AppViewModel();
            appView.DataContext = appViewModel;
            appView.Show();
        }
    }
}
