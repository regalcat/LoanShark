using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S_E_319
{
    class AppViewModel
    {
        #region Fields and Autoproperties

        public MenuBarViewModel MenuBar { get; private set; }
        public ToolBarViewModel ToolBar { get; private set; }
        public SidePanelViewModel SidePanel { get; private set; }
        public MainBrowserViewModelBaseClass MainBrowser { get; private set; }

        #endregion

        #region Constructors

        public AppViewModel()
        {
            MainBrowserViewModelBaseClass.GenerateList();
            MenuBar = new MenuBarViewModel();
            ToolBar = new ToolBarViewModel();
            SidePanel = new SidePanelViewModel();
            MainBrowser = new MainBrowserTileViewModel();
            


        }

        

        #endregion

        private void OnThemeChanged(ColorChangedEventArgs e)
        {
            ToolBar.ChangeColor(e.getBrush0());
            MenuBar.ChangeColor(e.getBrush1());
            SidePanel.ChangeColor(e.getBrush2());
            MainBrowser.ChangeColor(e.getBrush3());
        }
    }
}
