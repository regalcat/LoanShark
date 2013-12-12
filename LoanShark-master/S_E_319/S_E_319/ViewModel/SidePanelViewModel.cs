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

        private Book _book;

        public Book CurrentBook 
        {
            get { return _book; }
            private set { _book = value; OnPropertyChanged("CurrentBook"); } 
        }

        public SidePanelViewModel()
        {
        }

        public void ChangeColor(Brush b)
        {
            BackgroundColor = b;
        }

        public void ChangeContent(Book b)
        {
            CurrentBook = b;
        }

        public Brush BackgroundColor
        {
            get { return bColor; }
            private set { bColor = value; OnPropertyChanged("BackgroundColor"); }
        }
    }
}
