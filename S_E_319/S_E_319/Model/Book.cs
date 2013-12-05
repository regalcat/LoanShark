using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace S_E_319
{
    public class Book
    {
        #region Fields and Autoproperties

        public string Title { get; private set; }
        public string Author { get; private set; }
        public string Genre { get; private set; }
        public string Location { get; private set; }
        public string Description { get; private set; }
        public string Borrower { get; private set; }
        public string BorrowDate { get; private set; }
        public bool IsFavorite { get; private set; }
        public bool IsLoaned { get; private set; }

        #endregion

        #region Constructors
        public Book()
        { }

        public Book(string title, string author, string genre, string location, string description, string borrower, string borrowDate, bool isFavorite, bool isLoaned)
        {
            Title = title;
            Author = author;
            Genre = genre;
            Location = location;
            Description = description;
            Borrower = borrower;
            BorrowDate = borrowDate;
            IsFavorite = isFavorite;
            IsLoaned = isLoaned;
        }

        public Book(XmlNode node)
        {
            Title = getXmlParameter(node, "title");
            Author = getXmlParameter(node, "author");
            Genre = getXmlParameter(node, "genre");
            Location = getXmlParameter(node, "location");
            Description = getXmlParameter(node, "description");
            Borrower = getXmlParameter(node, "borrower");
            BorrowDate = getXmlParameter(node, "borrowDate");
            IsFavorite = ! getXmlParameter(node, "favorite").Equals("");
            IsLoaned = ! getXmlParameter(node, "loaned").Equals("");
        }

        #endregion

       private static string getXmlParameter(XmlNode node, string name)
        {
            XmlNode parameter = node.SelectSingleNode(name);
            if (parameter != null)
            {
                return parameter.Value;
            }
            return "";
        }


        private static void setXmlParameter(XmlNode node, XmlDocument doc, string name, string value)
        {
            XmlElement n = doc.CreateElement(name); ;
            n.Value = value;
            node.AppendChild(n);
        }

       public void appendToXml(XmlNode parent, XmlDocument doc)
       {
           XmlNode node = doc.CreateElement("book");
           setXmlParameter(node, doc, "title", Title);
           setXmlParameter(node, doc, "author", Author);
           setXmlParameter(node, doc, "genre", Genre);
           setXmlParameter(node, doc, "location", Location);
           setXmlParameter(node, doc, "description", Description);
           setXmlParameter(node, doc, "borrower", Borrower);
           setXmlParameter(node, doc, "borrowDate", BorrowDate);
           if (IsFavorite)
               setXmlParameter(node, doc, "favorite", "I like dis!");
           if(IsLoaned)
               setXmlParameter(node, doc, "loaned", "Gimme it back!");
           parent.AppendChild(node);
       }

       public string getSearchString()
       {
           return Title + Author + Genre + Location + Description + Borrower;
       }

    }
}
