using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;

namespace Ladder_GUI_WPF
{
    /// <summary>
    /// A view model for a program model.
    /// </summary>
    class ProgramViewModel : BaseViewModel
    {
        #region Commands
        public ICommand AddRoutineCommand { get; set; }
        #endregion Commands

        #region Properties
        public ObservableCollection<RoutineViewModel> RoutineList { get => (ObservableCollection<RoutineViewModel>)_programModel.RoutineList; }

        private ProgramModel _programModel;
        public ProgramModel ProgramModel
        {
            get { return _programModel; }
            private set 
            {
                if (_programModel == value)
                    return;

                _programModel = value;
                OnPropertyChanged(nameof(ProgramModel));
            }
        }

        #endregion Properties

        #region Constructor
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="programModel">The model to create the view model from.</param>
        public ProgramViewModel(ProgramModel programModel)
        {
            ProgramModel = programModel;
            this.AddRoutineCommand = new RelayCommand(AddRoutine);
        }
        #endregion Constructor

        #region Methods
        private void AddRoutine()
        {
            RoutineList.Add(new RoutineViewModel());
        }

        public void DeleteRoutine(int index)
        {
            RoutineList.RemoveAt(index);
        }
        #endregion Methods
    }
}
