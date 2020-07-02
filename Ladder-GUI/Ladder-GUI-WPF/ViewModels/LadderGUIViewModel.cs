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
        #region Commands
        public ICommand LoadProgramCommand { get; set; }
        public ICommand AddXICInstructionCommand { get; set; }

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
            this.LoadProgramCommand = new RelayCommand(LoadProgram);
            LoadedProgram = new ProgramViewModel();
            TestRung = new RungViewModel();
            this.AddXICInstructionCommand = new RelayCommand(AddXICInstruction);
        }

        private void CreateNewProgram()
        {
            LoadedProgram = new ProgramViewModel();
        }

        private void LoadProgram()
        {
//            File.AppendAllText(@"C:\Temp\Debug.txt", $"{DateTime.Now.ToString("HH:mm:ss")} -Entered LoadProgram method {Environment.NewLine}");
            if (BackgroundColor == "LightBlue")
                BackgroundColor = "LightGreen";
            else
                BackgroundColor = "LightBlue";
        }

        private void AddXICInstruction()
        {
//            File.AppendAllText(@"C:\Temp\Debug.txt", $"{DateTime.Now.ToString("HH:mm:ss")} -Calling TestRung.AddInstruction method {Environment.NewLine}");
            TestRung.addInstruction(0, new XICInstructionModel());
            TestRung.CreateGridFormatRung();
        }
    }
}