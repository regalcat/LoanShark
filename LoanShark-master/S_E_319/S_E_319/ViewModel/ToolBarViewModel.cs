using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace S_E_319
{
    class ToolBarViewModel
    {
        public Brush BackgroundColor {get; private set;}
        public ToolBarViewModel()
        {
        }

        public void ChangeColor(SolidColorBrush b)
        {
            BackgroundColor = b;
        }
    }
}
