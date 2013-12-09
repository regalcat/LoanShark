using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Input;

namespace S_E_319
{
    class MenuBarViewModel : ViewModelBase
    {
        public MenuBarViewModel()
        {
            Cyclone_Click = new RelayCommand(kitty => Cyclone_Clicked());
            LoanShark_Click = new RelayCommand(blah => LoanShark_Clicked());
        }

        public Brush bColor;

        public event EventHandler Cyclone_Pride;

        public event EventHandler LoanShark;

        public ICommand Cyclone_Click { get; private set; }

        public ICommand LoanShark_Click { get; private set; }


        public void Cyclone_Clicked()
        {
            var handler = Cyclone_Pride;

            if (handler != null)
            {

                var e = new ColorChangedEventArgs(Brushes.IndianRed, Brushes.PaleGoldenrod, Brushes.Red, Brushes.Yellow);
                handler(this, e);
            }
        }

        public void LoanShark_Clicked()
        {
            var handler = LoanShark;

            if (handler != null)
            {
                var e = new ColorChangedEventArgs(Brushes.PowderBlue, Brushes.Navy, Brushes.Tan, Brushes.LightSkyBlue);
                handler(this, e);
            }
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
    }

    class ColorChangedEventArgs : EventArgs
    {
        private Brush brush0;
        private Brush brush1;
        private Brush brush2;
        private Brush brush3;

        public ColorChangedEventArgs(Brush a, Brush b, Brush c, Brush d)
        {
            this.brush0 = a;
            this.brush1 = b;
            this.brush2 = c;
            this.brush3 = d;
        }

        public Brush getBrush0()
        {
            return this.brush0;
        }

        public Brush getBrush1()
        {
            return this.brush1;
        }

        public Brush getBrush2()
        {
            return this.brush2;
        }

        public Brush getBrush3()
        {
            return this.brush3;
        }
    }
    public class RelayCommand : ICommand { 
        #region Fields 
        readonly Action<object> _execute;
        readonly Predicate<object> _canExecute;
        #endregion // Fields 
        #region Constructors
        public RelayCommand(Action<object> execute) : this(execute, null) { } 
        public RelayCommand(Action<object> execute, Predicate<object> canExecute) { if (execute == null) throw new ArgumentNullException("execute"); _execute = execute; _canExecute = canExecute; } 
        #endregion // Constructors 
        #region ICommand Members [DebuggerStepThrough] 
        public bool CanExecute(object parameter) { return _canExecute == null ? true : _canExecute(parameter); } 
        public event EventHandler CanExecuteChanged { add { CommandManager.RequerySuggested += value; } remove { CommandManager.RequerySuggested -= value; } } 
        public void Execute(object parameter) { _execute(parameter); } 
        #endregion // ICommand Members 
    }
}
