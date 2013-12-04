using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace S_E_319
{
    class MenuBarViewModel
    {
        public MenuBarViewModel()
        {
        }

        public Brush BackgroundColor { get; private set; }

        public event EventHandler Cyclone_Pride;

        public event EventHandler LoanShark;

        public void Cyclone_Clicked()
        {
            var handler = Cyclone_Pride;

            if (handler != null)
            {

                var e = new ColorChangedEventArgs(Brushes.IndianRed, Brushes.PaleGoldenrod, Brushes.Red, Brushes.Yellow);
                handler(this, e);
            }
        }

        public void LoanShark_Clicked()
        {
            var handler = LoanShark;

            if (handler != null)
            {
                var e = new ColorChangedEventArgs(Brushes.PowderBlue, Brushes.Tan, Brushes.Navy, Brushes.LightSkyBlue);
            }
        }

        public void ChangeColor(SolidColorBrush b)
        {
            BackgroundColor = b;
        }
    }

    class ColorChangedEventArgs : EventArgs
    {
        private SolidColorBrush brush0;
        private SolidColorBrush brush1;
        private SolidColorBrush brush2;
        private SolidColorBrush brush3;

        public ColorChangedEventArgs(SolidColorBrush a, SolidColorBrush b, SolidColorBrush c, SolidColorBrush d)
        {
            this.brush0 = a;
            this.brush1 = b;
            this.brush2 = c;
            this.brush3 = d;
        }

        public SolidColorBrush getBrush0()
        {
            return this.brush0;
        }

        public SolidColorBrush getBrush1()
        {
            return this.brush1;
        }

        public SolidColorBrush getBrush2()
        {
            return this.brush2;
        }

        public SolidColorBrush getBrush3()
        {
            return this.brush3;
        }
    }
}
