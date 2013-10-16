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
        public int ISBN { get; private set; }

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

        #endregion
    }
}
