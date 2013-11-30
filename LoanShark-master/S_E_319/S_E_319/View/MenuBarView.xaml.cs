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

        private void Cyclone_Checked(object sender, RoutedEventArgs e)
        {
            LSMenu.Background = Brushes.IndianRed;
            //ToolBarView.LSToolbarColorChange(Brushes.PaleGoldenrod);
            
        }

        private void Loanshark_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
