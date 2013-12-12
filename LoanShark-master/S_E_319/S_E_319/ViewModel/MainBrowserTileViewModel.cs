using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Input;

namespace S_E_319
{
    class MainBrowserTileViewModel : ViewModelBase
    {
        #region Fields and Autoproperties
        
        private static ObservableCollection<Book> _items;

        public event EventHandler UpdateSidePanel;

        public event EventHandler someEvent;

        public ICommand LoanCommand { get; private set; }

        public Brush bColor;

        public ObservableCollection<Book> Items
        {
            get { return _items; }
            protected set { _items = value; OnPropertyChanged("Items"); }
        }

        #endregion

        #region Constructors

        public MainBrowserTileViewModel()
        {
            LoanCommand = new RelayCommand(OnLoanCommand, CanLoanBook);
            if (Database.items == null) { Database.GenerateList(); }
            Items = Database.items;
        }

        #endregion

        #region Properties

        #endregion

        #region Methods

        public void UpdateSide()
        {
            var handler = UpdateSidePanel;
            if (handler != null)
            {
                var e = new EventArgs();
                handler(this, e);
            }
        }

        public void OnEvent()
        {
            var handler = someEvent;
            if (handler != null)
            {
                handler(this, new EventArgs());
            }
        }

        private void OnLoanCommand(Object o)
        {
            
            Book b = o as Book;
            if (b == null) { return; }
            var wind = new LoanView(b);
            wind.ShowDialog();
        }

        private bool CanLoanBook(Object o)
        {
            Book b = o as Book;
            if (b != null)
            {
                return !b.IsLoaned;
            }
            return false;
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

        
        #endregion
    }

    class TileClickedEventArgs : EventArgs
    {
        public Book book { get; private set; }

        public TileClickedEventArgs(Book b)
        {
            book = b;
        }
    }



}
