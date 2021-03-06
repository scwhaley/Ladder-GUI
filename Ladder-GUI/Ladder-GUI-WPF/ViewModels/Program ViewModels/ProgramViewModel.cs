﻿using System;
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
        public ICommand SelectedRoutineChangedCommand { get; set; }
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

        private ObservableCollection<LadderRoutineViewModel> _routines;
        public ObservableCollection<LadderRoutineViewModel> Routines
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

        private LadderRoutineViewModel _loadedRoutine;
        public LadderRoutineViewModel LoadedRoutine
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
        /// <param name="programName">The name of the program to create.</param>
        public ProgramViewModel(string programName)
        {
            ProgramModel = new ProgramModel(programName);
            Routines = new ObservableCollection<LadderRoutineViewModel>();
            this.AddRoutineCommand = new RelayCommand<object>(AddRoutine);
            this.SelectedRoutineChangedCommand = new RelayCommand<object>(SelectedRoutineChanged);
        }
        #endregion Constructors

        #region Methods
        private void AddRoutine(object obj)
        {
            Random rand = new Random();
            string name = rand.Next().ToString();
            _programModel.RoutineList.Add(new LadderRoutineModel(name));
            this.UpdateRoutineViewModels();
        }

        public void DeleteRoutine(object obj)
        {
            var routine = obj as LadderRoutineViewModel;
            _programModel.RoutineList.Remove(routine);
            this.UpdateRoutineViewModels();
        }

        /// <summary>
        /// (Re)creates the RoutineViewModel list with new view models based on the RoutineModel list.
        /// </summary>
        private void UpdateRoutineViewModels()
        {
            Routines.Clear();
            foreach (var routineModel in _programModel.RoutineList)
            {
                LadderRoutineViewModel routineViewModel = new LadderRoutineViewModel(routineModel);
                Routines.Add(routineViewModel);
            }
        }

        public void SelectedRoutineChanged(object obj)
        {
            var routine = obj as LadderRoutineViewModel;
            LoadedRoutine = routine;
        }
        #endregion Methods
    }
}
