using System.Collections.Specialized;
using System.ComponentModel;

namespace Ladder_GUI_WPF
{
    class RoutineViewModel : BaseViewModel
    {
        private int _numberOfRungs;
        public int NumberOfRungs { get => _numberOfRungs;
            set
            {
                if (_numberOfRungs == value)
                    return;

                _numberOfRungs = value;
                OnPropertyChanged()
            } 
        }
    }
}
