using System;
using System.Collections.Generic;
using System.Text;

namespace Ladder_GUI_WPF
{
    class ProgramViewModel : BaseViewModel
    {
        private List<RoutineViewModel> _routineList;
        public List<RoutineViewModel> RoutineList { get => _routineList;
            set
            {
                if (_routineList == value)
                    return;

                _routineList = value;
                OnPropertyChanged();
            }        
        }

        public void AddRoutine()
        {
            _routineList.Add(new RoutineViewModel());
        }
    }
}
