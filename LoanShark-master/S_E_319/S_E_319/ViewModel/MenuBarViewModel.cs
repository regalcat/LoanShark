using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Input;
using System.Windows;
using System.IO;

namespace S_E_319
{
    class MenuBarViewModel : ViewModelBase
    {
        public MenuBarViewModel()
        {
            Cyclone_Click = new RelayCommand(kitty => Cyclone_Clicked());
            LoanShark_Click = new RelayCommand(blah => LoanShark_Clicked());
            Murica_Click = new RelayCommand(blah => Murica_Clicked());
            Rainforest_Click = new RelayCommand(blah => Rainforest_Clicked());
            SaveCommand = new RelayCommand(SaveClicked);
            LoadCommand = new RelayCommand(LoadClicked);
        }

        public Brush bColor;

        public event EventHandler Cyclone_Pride;

        public event EventHandler LoanShark;

        public event EventHandler Murica;

        public event EventHandler Rainforest;

        public ICommand Cyclone_Click { get; private set; }

        public ICommand LoanShark_Click { get; private set; }

        public ICommand Murica_Click { get; private set; }

        public ICommand Rainforest_Click { get; private set; }

        public ICommand SaveCommand { get; private set; }

        public ICommand LoadCommand { get; private set; }

        private void LoadClicked(object obj)
        {
            try
            {
                Database.readXml("./test.xml");
            }
            catch (FileNotFoundException e)
            {
                Database.GenerateList();
            }
            catch (Exception e)
            {
                string messageBoxText = "An error occured while trying to load :\n" + e.Message;
                string caption = "Load Exception";
                MessageBoxButton button = MessageBoxButton.OK;
                MessageBoxImage icon = MessageBoxImage.Warning;

                // Display message box
                MessageBox.Show(messageBoxText, caption, button, icon);
            }
        }

        private void SaveClicked(object obj)
        {
            try {
            Database.saveXml("./test.xml");
            }
            catch (Exception e)
            {
                string messageBoxText = "An error occured while trying to save :\n" + e.Message;
                string caption = "Save Exception";
                MessageBoxButton button = MessageBoxButton.OK;
                MessageBoxImage icon = MessageBoxImage.Warning;

                // Display message box
                MessageBox.Show(messageBoxText, caption, button, icon);
            }
        }

        public void Cyclone_Clicked()
        {
            var handler = Cyclone_Pride;

            if (handler != null)
            {

                var e = new ColorChangedEventArgs(Brushes.Yellow, Brushes.Crimson, Brushes.Red, Brushes.Yellow);
                handler(this, e);
            }
        }

        public void LoanShark_Clicked()
        {
            var handler = LoanShark;

            if (handler != null)
            {
                var e = new ColorChangedEventArgs(Brushes.PowderBlue, Brushes.AliceBlue, Brushes.Tan, Brushes.LightSkyBlue);
                handler(this, e);
            }
        }

        public void Murica_Clicked()
        {
            var handler = Murica;
            if (handler != null)
            {
                var e = new ColorChangedEventArgs(Brushes.CornflowerBlue, Brushes.White, Brushes.Crimson, Brushes.White);
                handler(this, e);
            }
        }

        public void Rainforest_Clicked()
        {
            var handler = Rainforest;
            if (handler != null)
            {
                var e = new ColorChangedEventArgs(Brushes.Olive, Brushes.OliveDrab, Brushes.Beige, Brushes.Beige);
                handler(this, e);
            }
        }

        public void ChangeColor(Brush b)
        {
            BackgroundColor = b;
        }

        public Brush BackgroundColor
        {
            get { return bColor; }
            private set { bColor = value; OnPropertyChanged("BackgroundColor"); }
        }
    }

    class ColorChangedEventArgs : EventArgs
    {
        private Brush brush0;
        private Brush brush1;
        private Brush brush2;
        private Brush brush3;

        public ColorChangedEventArgs(Brush a, Brush b, Brush c, Brush d)
        {
            this.brush0 = a;
            this.brush1 = b;
            this.brush2 = c;
            this.brush3 = d;
        }

        public Brush getBrush0()
        {
            return this.brush0;
        }

        public Brush getBrush1()
        {
            return this.brush1;
        }

        public Brush getBrush2()
        {
            return this.brush2;
        }

        public Brush getBrush3()
        {
            return this.brush3;
        }
    }
}
