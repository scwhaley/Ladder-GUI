using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;

namespace Ladder_GUI_WPF
{
    class ProgramViewModel : BaseViewModel
    {
        #region Commands
        public ICommand AddRoutineCommand { get; set; }
        #endregion Commands

        private ObservableCollection<RoutineViewModel> _routineList;
        public ObservableCollection<RoutineViewModel> RoutineList { get => _routineList;
            set
            {
                if (_routineList == value)
                    return;

                _routineList = value;
                OnPropertyChanged();
            }        
        }


        public ProgramViewModel()
        {
            RoutineList = new ObservableCollection<RoutineViewModel>();
            this.AddRoutineCommand = new RelayCommand(AddRoutine);
        }

        private void AddRoutine()
        {
            RoutineList.Add(new RoutineViewModel());
        }

        public void DeleteRoutine(int index)
        {
            RoutineList.RemoveAt(index);
        }
    }
}
