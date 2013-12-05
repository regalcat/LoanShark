using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Input;
using System.Windows;
using Microsoft.TeamFoundation;


namespace S_E_319
{
    class AppViewModel
    {
        #region Fields and Autoproperties

        public MenuBarViewModel MenuBar { get; private set; }
        public ToolBarViewModel ToolBar { get; private set; }
        public SidePanelViewModel SidePanel { get; private set; }
        public MainBrowserTileViewModel MainBrowser { get; private set; }

        #endregion

        #region Constructors

        public AppViewModel()
        {
            MainBrowserTileViewModel.GenerateList();
            MenuBar = new MenuBarViewModel();
            ToolBar = new ToolBarViewModel();
            SidePanel = new SidePanelViewModel();
            MainBrowser = new MainBrowserTileViewModel();
        }

        #endregion


    }
}
