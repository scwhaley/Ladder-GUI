using Ladder_GUI_WPF.Models;
using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Windows.Controls;
using System.Windows.Documents;

namespace Ladder_GUI_WPF
{
    class RungViewModel : BaseViewModel
    {
        #region Commands

        #endregion Commands

        #region Properties
        private IRungModel _rungModel;
        public IRungModel RungModel { get => _rungModel;
            set
            {
                if (_rungModel == value)
                    return;

                _rungModel = value;
                OnPropertyChanged(nameof(RungModel));
            }
        }
        private ObservableCollection<BaseInstructionViewModel> _gridFormatInstructionList;
        public ObservableCollection<BaseInstructionViewModel> GridFormatInstructionList
        {
            get { return _gridFormatInstructionList; }
            set 
            {
                if (_gridFormatInstructionList == value)
                    return;

                _gridFormatInstructionList = value;
                OnPropertyChanged(nameof(GridFormatInstructionList));
            }
        }
        private int _rungNunmber;
        public int RungNumber { get => _rungNunmber;
            set
            {
                if (_rungNunmber == value)
                    return;

                _rungNunmber = value;
                OnPropertyChanged(nameof(RungNumber));
            }
        }
        #endregion Properties

        #region Constructor
        public RungViewModel()
        {
            RungModel = new RungModel();
            GridFormatInstructionList = new ObservableCollection<BaseInstructionViewModel>() { new BaseInstructionViewModel() { } }
            File.AppendAllText(@"C:\Temp\Debug.txt", $"{DateTime.Now.ToString("HH:mm:ss")} - Created new RungViewModel {Environment.NewLine}");
        }
        #endregion Constructor

        #region Methods
        // Adds an instruction to the rung models linked list of instructions
        public void addInstruction(int index, IBaseInstructionModel instruction)
        {
            File.AppendAllText(@"C:\Temp\Debug.txt", $"{DateTime.Now.ToString("HH:mm:ss")} -In AddInstruction method {Environment.NewLine}");
            RungModel.LinkedListOfInstructions.InsertInstruction(instruction, index);
        }

        public void CreateGridFormatRung()
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            InstructionViewModelFactory factory = new InstructionViewModelFactory();

            RungInstructionsLinkedListNode node = RungModel.LinkedListOfInstructions.Head;
            int rowIndex = 0;
            int columnIndex = 0;
            int loopNum = 0;

            File.AppendAllText(@"C:\Temp\Debug.txt", $"Setup ElapsedTime: {stopwatch.ElapsedMilliseconds}ms {Environment.NewLine}");

            Stopwatch loopWatch = Stopwatch.StartNew();
            while (node != null)
            {
                loopWatch.Restart();
                //               File.AppendAllText(@"C:\Temp\Debug.txt", $"{DateTime.Now.ToString("HH:mm:ss")} - Try to create InstructionViewModel for instruction node {node.ID}  {Environment.NewLine}");
                if (node.ID != GridFormatInstructionList[loopNum].VMID)
                {
                    File.AppendAllText(@"C:\Temp\Debug.txt", $"BEFORE FACTORY: {stopwatch.ElapsedMilliseconds}ms {Environment.NewLine}");
                    BaseInstructionViewModel instructionViewModel = factory.CreateInstructionViewModel(node.Instruction);
                    File.AppendAllText(@"C:\Temp\Debug.txt", $"AFTER  FACTORY: {stopwatch.ElapsedMilliseconds}ms {Environment.NewLine}");

                    instructionViewModel.RowIndex = rowIndex;
                    instructionViewModel.ColumnIndex = columnIndex;
                    instructionViewModel.VMID = node.ID;

                    GridFormatInstructionList[loopNum] = instructionViewModel;
                    //File.AppendAllText(@"C:\Temp\Debug.txt", $"{DateTime.Now.ToString("HH:mm:ss")} -Added InstructionvViewModel to GridFormatInstructionList with RowIndex {rowIndex} and ColumnIndex {columnIndex} {Environment.NewLine}");
                }
                File.AppendAllText(@"C:\Temp\Debug.txt", $"BEFORE FACTORY: {stopwatch.ElapsedMilliseconds}ms {Environment.NewLine}");
                
                columnIndex++;
                loopNum++;
                node = node.Next;

                File.AppendAllText(@"C:\Temp\Debug.txt", $"VM {columnIndex-1} created and added to list ElapsedTime: {stopwatch.ElapsedMilliseconds}ms {Environment.NewLine}");
            }

            File.AppendAllText(@"C:\Temp\Debug.txt", $"CreateGridFormatRung ElapsedTime: {stopwatch.ElapsedMilliseconds}ms {Environment.NewLine}");
            stopwatch.Stop();
        }

        #endregion Methods

    }
}
