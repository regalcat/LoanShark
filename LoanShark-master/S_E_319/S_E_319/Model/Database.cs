﻿
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Xml;
using System.Windows.Controls;

namespace S_E_319
{
    static class Database
    {

        public static ObservableCollection<Book> items = new ObservableCollection<Book>();
        private static ICollectionView _itemView = CollectionViewSource.GetDefaultView(items);
        private static string _filterString = "" ;
        

        public static void GenerateList()
        {
            _itemView.Filter = filter;
            items.Clear();
            items.Add(new Book("Bible", "God", "Fantasy", "test", "test", "Random Guy", DateTime.Now.ToString(), false, false));
            _filterString = "";
            
        }

        public static void readXml(string path)
        {
            _itemView.Filter = filter;
            items.Clear();
            _filterString = "";
            _itemView = CollectionViewSource.GetDefaultView(items);
            _itemView.Filter = filter;

            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            XmlNode root = doc.FirstChild;
            foreach (XmlNode n in root.ChildNodes)
            {
                items.Add(new Book(n));
            }
            _itemView.Refresh();
        }

        public static void saveXml(string path)
        {
            XmlDocument doc = new XmlDocument();
            XmlNode root = doc.CreateElement("root");
            foreach (Book b in items)
            {
                b.appendToXml(root, doc);
            }
            doc.AppendChild(root);
            doc.Save(path);
        }

        public static void search(String search)
        {
            FilterString = search;
        }

        public static string FilterString
        {
            get { return _filterString; }
            set
            {
                _filterString = value;
                _itemView.Refresh();
            }
        }

        private static bool filter(object item)
        {
            if (_filterString.Equals(""))
                return true;
            Book book = item as Book;
            if(_filterString.Equals("~fav"))
                return book.IsFavorite;
            if(_filterString.Equals("~loan"))
                return book.IsLoaned;;
            return book.getSearchString().ToLower().Contains( _filterString.ToLower() );
        }
    }
}