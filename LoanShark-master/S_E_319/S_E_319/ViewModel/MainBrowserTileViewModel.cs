using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Input;
using System.Windows.Controls;
using System.Windows.Data;

namespace S_E_319
{
    class MainBrowserTileViewModel : ViewModelBase
    {
        #region Fields and Autoproperties

        public Object CurrentlySelectedItem { get; set; }
        
        private static ObservableCollection<Book> _items;

        public event EventHandler UpdateSidePanel;

        public event EventHandler TileSelectionChanged;

        public ICommand LoanCommand { get; private set; }
        public ICommand EditCommand { get; private set; }
        public ICommand RemoveCommand { get; private set; }


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
            EditCommand = new RelayCommand(OnEditCommand);
            RemoveCommand = new RelayCommand(OnRemoveCommand);
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


        private void OnLoanCommand(Object o)
        {
            Book b = CurrentlySelectedItem as Book;
            if (b == null) { return; }
            var wind = new LoanView(b);
            wind.ShowDialog();
        }

        private bool CanLoanBook(Object o)
        {
            Book b = CurrentlySelectedItem as Book;
            if (b == null) { return false; }
            return !b.IsLoaned;
        }

        private void OnEditCommand(Object o)
        {
            Book b = CurrentlySelectedItem as Book;
            if (b == null) { return; }
            var wind = new AddEditView(b);
            wind.ShowDialog();
        }

        private void OnRemoveCommand(Object o)
        {
            Book b = CurrentlySelectedItem as Book;
            if (b == null) { return; }
            Database.items.Remove(b);
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

        public void OnTileSelectionChanged(object sender, SelectionChangedEventArgs e) 
        {
            var handler = TileSelectionChanged;
            if (handler != null)
            {
                handler(sender, e);
            }
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
