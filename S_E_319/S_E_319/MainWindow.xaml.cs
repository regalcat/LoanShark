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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AddEdit
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public Book SubmitClicked(object sender, RoutedEventArgs e)
        {
            String title = Title.Text;
            String author = FirstName.Text + " " + MiddleName.Text + " " + LastName.Text;
            String genre = Genre.Text;
            String location = Location.Text;
            String description = Description.Text;
            Boolean isFavorite = Favorite.IsPressed;

            String borrower = null;
            DateTime borrowDate;
            Boolean isLoaned = false;

            Book book = new Book(title, author, genre, location, description, borrower, borrowDate, isFavorite, isLoaned);

            return book;
        }

        public void CancelClicked(object sender, RoutedEventArgs e)
        {
            //Cancel should destroy the add/edit window without looking at or saving anything.
            this.Close();
        }

    }
}
