using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace S_E_319
{
    /// <summary>
    /// Interaction logic for AddEditView.xaml
    /// </summary>
    public partial class AddEditView : Window
    {
        #region Fields
        private Book book;
        #endregion

        #region Constructors
        public AddEditView()
        {
            InitializeComponent();
        }

        public AddEditView(Book b)
        {
            InitializeComponent();
            book = b;

            BookTitle.Text = book.Title;
            AuthorName.Text = book.Author;
            Genre.Text = book.Genre;
            Favorite.IsChecked = book.IsFavorite;
            Location.Text = book.Location;
            Description.Text = book.Description;
        }

        #endregion

        #region Methods

        public Book GetBook()
        {
            return book;
        }

        #endregion

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            this.Close();
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(BookTitle.Text) || BookTitle.Text.Equals("Title"))
            {
                BookTitle.Text = "Untitled";
            }
            if (string.IsNullOrEmpty(AuthorName.Text) || AuthorName.Text.Equals("Name"))
            {
                AuthorName.Text = "Unknown";
            }
            if (string.IsNullOrEmpty(Genre.Text) || Genre.Text.Equals("Genre"))
            {
                Genre.Text = "Unknown";
            }
            if (string.IsNullOrEmpty(Location.Text) || Location.Text.Equals("Location"))
            {
                Genre.Text = "Unknown";
            }
            if (string.IsNullOrEmpty(Description.Text) || Description.Text.Equals("Description"))
            {
                Genre.Text = "Unknown";
            }

            String title = BookTitle.Text;
            String author = AuthorName.Text;
            String genre = Genre.Text;
            String location = Location.Text;
            String description = Description.Text;
            bool isFavorite = (bool)Favorite.IsChecked;

            if (book == null)
            {
                book = new Book();
            }

            book.Title = BookTitle.Text;
            book.Author = AuthorName.Text;
            book.Genre = Genre.Text;
            book.Location = Location.Text;
            book.Description = Description.Text;
            book.IsFavorite = (bool)Favorite.IsChecked;

            DialogResult = true;
            this.Close();
        }
    }
}
