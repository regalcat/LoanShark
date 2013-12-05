using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Xml;

namespace S_E_319
{
    abstract class MainBrowserViewModelBaseClass : ViewModelBase
    {
        public Brush BackgroundColor { get; private set; }

        #region Fields and Autoproperties
        private static ObservableCollection<ItemBaseClass> _items, total;
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
            _items.Add(new BookItem("Harry Potter", "J.K. Rowling", "929292", "Caleb", "Fantasy"));
            _items.Add(new BookItem("The Bible", "Our God Almighty", "1", "Caleb", "Fantasy"));
            _items.Add(new MiscItem("Nic-nak", "Caleb", "Misc"));
            total = _items;
        }

        public static void readFromXml(string path)
        {
            _items = new ObservableCollection<ItemBaseClass>();
            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            XmlNode root = doc.FirstChild;
            for (int i = 0; i < root.ChildNodes.Count; i++)
            {
                if (root.ChildNodes[i].Name.Equals("book"))
                    _items.Add(new BookItem(root.ChildNodes[i]));
                else
                    _items.Add(new MiscItem(root.ChildNodes[i]));
            }
            total = _items;
        }

        public static void saveXml(string path)
        {
            XmlDocument xml = new XmlDocument();
            XmlElement cur, root;
            root = xml.CreateElement("root");
            ItemBaseClass book;
            for (int i = 0; i < total.Count; i++)
            {
                // setting attributes is not the best way to do this
                // but i didn't feel like messing around with right now
                // probably will be implemented in a day or two
                book = total[i];
                cur = xml.CreateElement(book.type());
                book.putIntoElement(cur);
                root.AppendChild(cur);
            }
            xml.AppendChild(root);
            xml.Save(path);
        }

        public static ObservableCollection<ItemBaseClass> search(string s)
        {
            ObservableCollection<ItemBaseClass> found = new ObservableCollection<ItemBaseClass>();
            foreach (ItemBaseClass item in total)
            {
                if(item.getSearchValues().Contains(s))
                    found.Add(item);
            }

            return found;

        }

        public void ChangeColor(SolidColorBrush b)
        {
            BackgroundColor = b;
        }

        
        #endregion

    }
}
