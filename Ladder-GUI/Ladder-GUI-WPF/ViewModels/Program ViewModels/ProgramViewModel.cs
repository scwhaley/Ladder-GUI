using Ladder_GUI_WPF.ViewModels.Routine_ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Controls;
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
        public string Name
        {
            get => _programModel.Name;
            set
            {
                if (_programModel.Name == value)
                    return;

                _programModel.Name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

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

        private ObservableCollection<BaseRoutineViewModel> _routines;
        public ObservableCollection<BaseRoutineViewModel> Routines
        {
            get => _routines;
            set
            {
                if (_routines == value)
                    return;

                _routines = value;
                OnPropertyChanged(nameof(Routines));
            }
        }

        private BaseRoutineViewModel _loadedRoutine;
        public BaseRoutineViewModel LoadedRoutine
        {
            get { return _loadedRoutine; }
            set 
            {
                if( _loadedRoutine == value)
                    return;

                _loadedRoutine = value;
                OnPropertyChanged(nameof(LoadedRoutine));
            }
        }
        
        private string _testProp;
        public string TestProp
        {
            get { return _testProp; }
            set
            {
                if (_testProp == value)
                    return;

                _testProp = value;
                OnPropertyChanged(nameof(TestProp));
            }
        }

        #endregion Properties

        #region Constructors
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="programModel">The model to create the view model from.</param>
        public ProgramViewModel(string programName)
        {
            ProgramModel = new ProgramModel(programName);
            Routines = new ObservableCollection<BaseRoutineViewModel>();
            this.AddRoutineCommand = new RelayCommand(AddRoutine);
        }
        #endregion Constructors

        #region Methods
        private void AddRoutine()
        {
            Random rand = new Random();
            string name = rand.Next().ToString();
            _programModel.RoutineList.Add(new LadderRoutineModel(name));
            this.UpdateRoutineViewModels();
        }

        public void DeleteRoutine(int index)
        {
            _programModel.RoutineList.RemoveAt(index);
        }

        /// <summary>
        /// (Re)creates the RoutineViewModel list with new view models based on the RoutineModel list.
        /// </summary>
        private void UpdateRoutineViewModels()
        {
            Routines.Clear();
            RoutineViewModelFactory factory = new RoutineViewModelFactory();
            foreach (var routineModel in _programModel.RoutineList)
            {
                BaseRoutineViewModel routineViewModel = factory.CreateRoutineViewModel(routineModel);
                Routines.Add(routineViewModel);
            }
        }

        public void OnRoutineSelected(object sender, EventArgs e)
        {
            var item = sender as TreeViewItem;
            TestProp = item.Header.ToString();
        }
        #endregion Methods
    }
}
