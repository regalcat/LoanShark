using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace S_E_319
{
    abstract class MainBrowserViewModelBaseClass : ViewModelBase
    {
        public Brush BackgroundColor { get; private set; }

        #region Fields and Autoproperties
        private static ObservableCollection<ItemBaseClass> _items;
        #endregion


        #region Properties

        public ObservableCollection<ItemBaseClass> Items
        {
            get { return _items; }
            protected set { _items = value; OnPropertyChanged("Items"); }
        }

        #endregion


        #region Methods

        public static void GenerateList()
        {
            _items = new ObservableCollection<ItemBaseClass>();
            _items.Add(new BookItem("Harry Potter", "J.K. Rowling", 929292, "Caleb", "Fantasy"));
            _items.Add(new BookItem("The Bible", "Our God Almighty", 1, "Caleb", "Fantasy"));
            _items.Add(new MiscItem("Nic-nak", "Caleb", "Misc"));
        }

        public void ChangeColor(SolidColorBrush b)
        {
            BackgroundColor = b;
        }

        
        #endregion

    }
}
