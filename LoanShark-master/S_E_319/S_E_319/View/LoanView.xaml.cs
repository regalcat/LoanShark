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
    /// Interaction logic for LoanView.xaml
    /// </summary>
    public partial class LoanView : Window
    {
        private Book book;

        public LoanView(Book b)
        {
            InitializeComponent();
            book = b;
        }

        private void Cancel_Button(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            this.Close();
        }

        private void Loan_Button(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            book.IsLoaned = true;
            book.Borrower = BorrowerName.Text;
            int day;
            int month;
            int year;
            try
            {
                day = Convert.ToInt32(Day.Text);
            }
            catch
            {
                day = DateTime.Now.Day;
            }
            try
            {
                month = Convert.ToInt32(Month.Text);
            }
            catch
            {
                month = DateTime.Now.Month;
            }
            try
            {
                year = Convert.ToInt32(Year.Text);
            }
            catch
            {
                year = DateTime.Now.Year;
            }

            if (day < 1 || day > 31)
            {
                day = DateTime.Now.Day;
            }
            if (month < 1 || month > 12)
            {
                month = DateTime.Now.Month;
            }

            book.BorrowDate = String.Format("{0}/{1}/{2}", month, day, year);

            this.Close();
        }
    }
}
