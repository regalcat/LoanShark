using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace S_E_319
{
    class BookItem : ItemBaseClass
    {
        #region Fields and Autoproperties

        public string Author { get; private set; }
        public string ISBN { get; private set; }

        #endregion

        #region Constructors

        public BookItem(string name, string author, string isbn, string owner, string category)
        {
            Name = name;
            Author = author;
            ISBN = isbn;
            Owner = owner;
            Borrower = "N/A";
            Category = category;
        }

        public BookItem(XmlNode node)
        {
            Name = node.Attributes.GetNamedItem("name").InnerText;
            Author = node.Attributes.GetNamedItem("author").InnerText;
            ISBN = node.Attributes.GetNamedItem("isbn").InnerText;
            Owner = node.Attributes.GetNamedItem("owner").InnerText;
            Borrower = node.Attributes.GetNamedItem("borrower").InnerText;
            Category = node.Attributes.GetNamedItem("category").InnerText;
        }

        #endregion
    }
}
