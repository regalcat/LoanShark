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

namespace S_E_319
{
    /// <summary>
    /// Interaction logic for MenuBarView.xaml
    /// </summary>
    public partial class MenuBarView : UserControl
    {
        public MenuBarView()
        {
            InitializeComponent();
        }

        private void Exit_Clicked(object sender, RoutedEventArgs e)
        {
            System.Environment.Exit(0);
        }
        private void AddBook(object sender, RoutedEventArgs e)
        {
            var wind = new AddEditView();
            wind.ShowDialog();
            if ((bool)wind.DialogResult)
            {
                var b = wind.GetBook();
                Database.items.Add(b);
            }
        }
    }
}
