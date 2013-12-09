using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace S_E_319
{
    class SidePanelViewModel : ViewModelBase
    {
        private Brush bColor;

        public BookItem CurrentBook { get; private set; }

        public SidePanelViewModel()
        {
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
}
