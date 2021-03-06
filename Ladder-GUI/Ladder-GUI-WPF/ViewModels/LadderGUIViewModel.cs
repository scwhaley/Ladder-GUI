﻿using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Text;
using System.IO;
using System.Windows;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace Ladder_GUI_WPF
{
    class LadderGUIViewModel : BaseViewModel
    {
        #region Commands
        public ICommand ToggleBackgroundCommand { get; set; }

        #endregion Commands
        #region Properties
        private ProgramViewModel _loadedProgram;
        public ProgramViewModel LoadedProgram
        {
            get => _loadedProgram;
            set
            {
                if (_loadedProgram == value)
                    return;

                _loadedProgram = value;
                OnPropertyChanged(nameof(LoadedProgram));
            }
        }

        private string _backgroundColor;
        public string BackgroundColor
        {
            get => _backgroundColor;
            set
            {
                if (_backgroundColor == value)
                    return;

                _backgroundColor = value;
                OnPropertyChanged(nameof(BackgroundColor));
            }
        }

        private RungViewModel _testRung;
        public RungViewModel TestRung
        {
            get => _testRung;
            set
            {
                if (_testRung == value)
                    return;

                _testRung = value;
                OnPropertyChanged(nameof(TestRung));
            }
        }

        #endregion Properties

        public LadderGUIViewModel()
        {
            BackgroundColor = "LightBlue";
            LoadedProgram = new ProgramViewModel("Program 1");
            TestRung = new RungViewModel();
            this.ToggleBackgroundCommand = new RelayCommand<object>(ToggleBackground);
        }

        private void CreateNewProgram()
        {
            LoadedProgram = new ProgramViewModel("Test Name");
        }

        private void ToggleBackground(object obj)
        {
            if (BackgroundColor == "LightBlue")
                BackgroundColor = "LightGreen";
            else
                BackgroundColor = "LightBlue";
        }

    }
}