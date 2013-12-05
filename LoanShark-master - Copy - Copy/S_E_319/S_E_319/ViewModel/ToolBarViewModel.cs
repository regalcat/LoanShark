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

        public void Add_Clicked()
        {

        }

        public void Edit_Clicked()
        {

        }

        public void New_Clicked()
        {

        }

        public void test_Clicked()
        {

        }

        public void Search_Clicked()
        {

        }

        public void Open_clicked()
        {

        }

        public void Save_clicked()
        {

        }

        public void ChangeColor(SolidColorBrush b)
        {
            BackgroundColor = b;
        }
    }
}
