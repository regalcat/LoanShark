using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Input;

namespace S_E_319
{
    class ToolBarViewModel : ViewModelBase
    {
        public Brush bColor;
        public ToolBarViewModel()
        {

        }

        public void ChangeColor(Brush b)
        {
            BackgroundColor = b;
        }

        public Brush BackgroundColor
        {
            get { return bColor; }
            private set { bColor = value; OnPropertyChanged("BackgroundColor"); }
        }

        private string _name;
        public string name { get { if (_name == null) _name = "Search here!"; return _name; } set { _name = value; } }



        RelayCommand _searchCommand; public ICommand SearchCommand { get { if (_searchCommand == null) { _searchCommand = new RelayCommand(SearchClicked, null); } return _searchCommand; } }

        private void SearchClicked(object obj)
        {
            Database.search(name);
        }


        RelayCommand _showCommand; public ICommand ShowCommand { get { if (_showCommand == null) { _showCommand = new RelayCommand(showClicked, null); } return _showCommand; } }

        private void showClicked(object obj)
        {

            Database.search("");
        }

        RelayCommand _loanedCommand; public ICommand LoanedCommand { get { if (_loanedCommand == null) { _loanedCommand = new RelayCommand(loanedClicked, null); } return _loanedCommand; } }

        private void loanedClicked(object obj)
        {
            Database.search("~loan");
        }

        RelayCommand _favoriteCommand; public ICommand FavoriteCommand { get { if (_favoriteCommand == null) { _favoriteCommand = new RelayCommand(favoriteClicked, null); } return _favoriteCommand; } }

        private void favoriteClicked(object obj)
        {
            Database.search("~fav");
        }
    }
}

