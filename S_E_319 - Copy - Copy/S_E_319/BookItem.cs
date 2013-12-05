using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S_E_319
{
    class BookItem : ItemBaseClass
    {
        #region Fields and Autoproperties

        public string Author { get; private set; }
        public string ISBN { get; private set; }

        #endregion

        #region Constructors

        public BookItem(string name, string author, int isbn, string owner, string category)
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
            Name = node.Atttributes.getNamedItem("name").innerText();
            Author = node.Atttributes.getNamedItem("author").innerText();
            ISBN = node.Atttributes.getNamedItem("isbn").innerText();
            Owner = node.Atttributes.getNamedItem("owner").innerText();
            Borrower = node.Atttributes.getNamedItem("borrower").innerText();
            Category = node.Atttributes.getNamedItem("category").innerText();
        }

        #endregion


    }
}
