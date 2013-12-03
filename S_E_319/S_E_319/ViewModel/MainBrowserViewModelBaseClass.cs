using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S_E_319
{
    abstract class MainBrowserViewModelBaseClass : ViewModelBase
    {
        #region Fields and Autoproperties
        private static ObservableCollection<Book> _items;
        #endregion


        #region Properties

        public ObservableCollection<Book> Items
        {
            get { return _items; }
            protected set { _items = value; OnPropertyChanged("Items"); }
        }

        #endregion


        #region Methods

        public static void GenerateList()
        {
            _items = new ObservableCollection<Book>();
            _items.Add(new Book("Bible", "God", "Fantasy", "Hell", "Stuff", "Random Guy", DateTime.Now, false, false));
        }

        #endregion

    }
}
