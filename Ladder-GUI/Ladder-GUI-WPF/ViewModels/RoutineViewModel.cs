using System.Collections.Specialized;
using System.ComponentModel;

namespace Ladder_GUI_WPF
{
    class RoutineViewModel: INotifyPropertyChanged, INotifyCollectionChanged
    {
        private int _numberOfRungs;
        public int NumberOfRungs { get => _numberOfRungs;
            set
            {
                if (_numberOfRungs == value)
                    return;

                _numberOfRungs = value;
            } 
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public event NotifyCollectionChangedEventHandler CollectionChanged;
    }
}
