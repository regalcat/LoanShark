using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace S_E_319
{
    class ToolBarViewModel : ViewModelBase
    {
        private string _name;
        public string name { get { if (_name == null) _name = "Search here!"; return _name; } set { _name = value; } }
        public ToolBarViewModel()
        {
        }


        RelayCommand _searchCommand; public ICommand SearchCommand { get { if (_searchCommand == null) { _searchCommand = new RelayCommand(SearchClicked, null); } return _searchCommand; } }
        
        private void SearchClicked(object obj)
        {
            Database.search(name);
        }
    }
}
