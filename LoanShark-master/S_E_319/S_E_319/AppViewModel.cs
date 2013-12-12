﻿using System;
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
        public MainBrowserTileViewModel MainBrowser { get; private set; }
        //public event EventHandler colors0;

        #endregion

        #region Constructors

        public AppViewModel()
        {
            Database.GenerateList();
            MenuBar = new MenuBarViewModel();
            ToolBar = new ToolBarViewModel();
            SidePanel = new SidePanelViewModel();
            MainBrowser = new MainBrowserTileViewModel();
            

            MenuBar.Cyclone_Pride += OnThemeChanged;
            MenuBar.LoanShark += OnThemeChanged;
            MainBrowser.UpdateSidePanel += OnTileClicked;
            MenuBar.Murica += OnThemeChanged;
            MenuBar.Rainforest += OnThemeChanged;
        }



        #endregion


        private void OnTileClicked(Object sender, EventArgs e)
        {
            Book b = (Book)sender;
            SidePanel.ChangeContent(b);
        }

        private void OnThemeChanged(Object sender, EventArgs e)
        {

            ToolBar.ChangeColor(((ColorChangedEventArgs)e).getBrush0());
            MenuBar.ChangeColor(((ColorChangedEventArgs)e).getBrush1());
            SidePanel.ChangeColor(((ColorChangedEventArgs)e).getBrush2());
            MainBrowser.ChangeColor(((ColorChangedEventArgs)e).getBrush3());
        }
    }
}
