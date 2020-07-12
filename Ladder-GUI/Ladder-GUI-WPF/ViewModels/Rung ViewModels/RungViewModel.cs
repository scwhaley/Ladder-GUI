using Ladder_GUI_WPF.Models;
using System;
using System.Collections.Generic;
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
            GridFormatInstructionList = new ObservableCollection<BaseInstructionViewModel>();
        }

        public RungViewModel(RungModel model)
        {
            RungModel = model;
            GridFormatInstructionList = new ObservableCollection<BaseInstructionViewModel>();
        }
        #endregion Constructor

        #region Methods
        // Adds an instruction to the rung models linked list of instructions
        public void addInstruction(int index, IBaseInstructionModel instruction)
        {
            RungModel.LinkedListOfInstructions.InsertInstruction(instruction, index);
        }

        public void CreateGridFormatRung()
        {
            InstructionViewModelFactory factory = new InstructionViewModelFactory();
            BaseInstructionViewModel instructionViewModel;

            RungInstructionsLinkedListNode node = RungModel.LinkedListOfInstructions.Head;
            int rowIndex = 0;
            int columnIndex = 0;
            int loopNum = 0;
            bool difference = false;

            // Walk the InstructionList and verify that it matches the existing GridFormatInstructionList.
            // If there is a node that doesn't match, start recreating the GridFormatList from there.
            // Better than fully recreating each time, but only marginal benefit for changes near the beginning of the list.
            while (node != null)
            {
                switch (loopNum >= GridFormatInstructionList.Count)
                {
                    // If we need to extend the list
                    case true:
                        instructionViewModel = factory.CreateInstructionViewModel(node.Instruction);
                        GridFormatInstructionList.Add(instructionViewModel);
                        instructionViewModel.RowIndex = rowIndex;
                        instructionViewModel.ColumnIndex = columnIndex;
                        break;

                    // If we only need to replace elements. Difference represents that an element has changed, so we can't rely on the existing GridFormatList any more.
                    case false:
                        if (node.NodeID != GridFormatInstructionList[loopNum].VMID || difference)
                        {
                            instructionViewModel = factory.CreateInstructionViewModel(node.Instruction);
                            GridFormatInstructionList[loopNum] = instructionViewModel;
                            instructionViewModel.RowIndex = rowIndex;
                            instructionViewModel.ColumnIndex = columnIndex;
                            difference = true;
                        }
                        break;
                }
                columnIndex++;
                loopNum++;
                node = node.Next;
            }
        }

        #endregion Methods

    }
}
