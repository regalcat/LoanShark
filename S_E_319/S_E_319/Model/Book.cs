using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S_E_319
{
    class Book
    {
        #region Fields and Autoproperties

        public string Title { get; private set; }
        public string Author { get; private set; }
        public string Genre { get; private set; }
        public string Location { get; private set; }
        public string Description { get; private set; }
        public string Borrower { get; private set; }
        public DateTime BorrowDate { get; private set; }
        public bool IsFavorite { get; private set; }
        public bool IsLoaned { get; private set; }

        #endregion

        #region Constructors

        public Book(string title, string author, string genre, string location, string description, string borrower, DateTime borrowDate, bool isFavorite, bool isLoaned)
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

        #endregion
    }
}
