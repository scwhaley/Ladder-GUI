using System;
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
        public ICommand LoadProgramCommand { get; set; }
        #region Properties
        private RoutineViewModel _loadedRoutine;
        public RoutineViewModel LoadedRoutine
        {
            get => _loadedRoutine;
            set
            {
                if (_loadedRoutine == value)
                    return;

                _loadedRoutine = value;
                OnPropertyChanged();
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
                OnPropertyChanged();
            }
        }
        #endregion Properties

        public LadderGUIViewModel()
        {
            BackgroundColor = "LightBlue";
            this.LoadProgramCommand = new RelayCommand(LoadProgram);
        }

        private void LoadProgram()
        {
            File.AppendAllText(@"C:\Temp\Debug.txt", $"Entered LoadProgram method {Environment.NewLine}");
            if (BackgroundColor == "LightBlue")
                BackgroundColor = "LightGreen";
            else
                BackgroundColor = "LightBlue";
        }

    }
}