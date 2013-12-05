using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
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

        public BookItem(XmlNode node) : base(node)
        {
            XmlAttributeCollection attributes = node.Attributes;
            if (attributes.GetNamedItem("name") != null)
                Name = attributes.GetNamedItem("name").Value;
            else
                Name = "";
            if (attributes.GetNamedItem("author") != null)
                Author = attributes.GetNamedItem("author").Value;
            else
                Author = "";
            if (attributes.GetNamedItem("isbn") != null)
                ISBN = attributes.GetNamedItem("isbn").Value;
            else
                ISBN = "";
        }

        #endregion

        public string getSearchValues()
        {
            return base.getSearchValues() + Author + ISBN;
        }

        public string getType()
        {
            return "Book";
        }

        public void putIntoElement(XmlElement cur)
        {
            base.putIntoElement(cur);
            cur.SetAttribute("author", Author);
            cur.SetAttribute("isbn", ISBN);
        }

    }
}
