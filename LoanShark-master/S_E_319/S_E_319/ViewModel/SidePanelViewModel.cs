using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace S_E_319
{
    class SidePanelViewModel
    {
        public Brush BackgroundColor { get; private set; }

        public SidePanelViewModel()
        {
        }

        public void ChangeColor(SolidColorBrush b)
        {
            BackgroundColor = b;
        }
    }
}
