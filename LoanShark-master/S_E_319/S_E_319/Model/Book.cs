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

        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public string Borrower { get; set; }
        public string BorrowDate { get; set; }
        public bool IsFavorite { get; set; }
        public bool IsLoaned { get; set; }

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
            IsFavorite = !getXmlParameter(node, "favorite").Equals("");
            IsLoaned = !getXmlParameter(node, "loaned").Equals("");
        }

        #endregion

        private static string getXmlParameter(XmlNode node, string name)
        {
            foreach (XmlNode param in node.ChildNodes)
                if (param.Name.Equals(name))
                {
                    return param.InnerXml;
                }
            return "";
        }

        private static void setXmlParameter(XmlNode node, XmlDocument doc, string name, string value)
        {

            XmlElement n = doc.CreateElement(name);
            n.InnerXml = value;
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
            if (IsLoaned)
                setXmlParameter(node, doc, "loaned", "Gimme it back!");
            parent.AppendChild(node);
        }

        public string getSearchString()
        {
            // this is a very quick and dirty search implementation, I generate this string
            // then see if this string contains the value I am searching for


            // the ~!~ isnt super necessary but it stops the search from finding a match across multiple fields
            return Title + "~!~" + Author + "~!~" + Genre + "~!~" + Location + "~!~" + Description + "~!~" + Borrower;
        }

    }
}
