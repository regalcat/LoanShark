using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace S_E_319
{
    class SidePanelViewModel : ViewModelBase
    {
        private Brush bColor;

        public Book CurrentBook { get; private set; }

        public string Title { get; private set; }

        public string Author { get; private set; }

        public string Genre { get; private set; }

        public string Location { get; private set; }

        public string Description { get; private set; }

        public string Borrower { get; private set; }

        public string BorrowDate { get; private set; }

        public bool Favorite {get; private set;}

        public bool Loaned { get; private set; }

        public SidePanelViewModel()
        {
        }

        public void ChangeColor(Brush b)
        {
            BackgroundColor = b;
        }

        public void ChangeContent(Book b)
        {
            Title = b.Title;
            Author = b.Author;
            Genre = b.Genre;
            Location = b.Location;
            Description = b.Description;
            Borrower = b.Borrower;
            BorrowDate = b.BorrowDate;
            Favorite = b.IsFavorite;
            Loaned = b.IsLoaned;
        }

        public Brush BackgroundColor
        {
            get { return bColor; }
            private set { bColor = value; OnPropertyChanged("BackgroundColor"); }
        }
    }
}
