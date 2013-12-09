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
    class MainBrowserTileViewModel : MainBrowserViewModelBaseClass
    {

        private static ObservableCollection<Book> _items;

        public event EventHandler UpdateSidePanel;

        public event EventHandler someEvent;

        public BookItem b;

        public ICommand LoanCommand { get; private set; }

        #region Fields and Autoproperties

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
        }

        #endregion

        #region Properties

        #endregion

        public static void GenerateList()
        {
            _items = new ObservableCollection<Book>();
            _items.Add(new Book("Bible", "God", "Fantasy", "Hell", "Stuff", "Random Guy", DateTime.Now.ToString(), false, false));
        }

        public void UpdateSide()
        {
            var handler = UpdateSidePanel;
            if (handler != null)
            {
                //b = new BookItem();
                //var e = new TileClickedEventArgs(b);
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
    }

    class TileClickedEventArgs : EventArgs
    {
        public BookItem book { get; private set; }

        public TileClickedEventArgs(BookItem b)
        {
            book = b;
        }
    }


       
}
