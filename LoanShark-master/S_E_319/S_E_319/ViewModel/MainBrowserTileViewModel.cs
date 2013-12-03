using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace S_E_319
{
    class MainBrowserTileViewModel : MainBrowserViewModelBaseClass
    {
        public Brush BackgroundColor { get; private set; }
        #region Fields and Autoproperties

        

        #endregion

        #region Constructors

        public MainBrowserTileViewModel()
        {
        }

        #endregion

        #region Properties

        #endregion

        public void ChangeColor(SolidColorBrush b)
        {
            BackgroundColor = b;
        }
    }
}
