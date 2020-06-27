using Ladder_GUI_WPF.Models;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Windows.Controls;
using System.Windows.Documents;

namespace Ladder_GUI_WPF
{
    class RungViewModel : BaseViewModel
    {
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
        #endregion Constructor

        #region Methods
        // Adds an instruction to the rung models linked list of instructions
        public void addInstruction(int index, IBaseInstructionModel instruction)
        {
            RungModel.LinkedListOfInstructions.InsertInstruction(instruction, index);
        }

        public void CreateGridFormatRung()
        {
            GridFormatInstructionList = new ObservableCollection<BaseInstructionViewModel>();
            InstructionViewModelFactory factory = new InstructionViewModelFactory();

            RungInstructionsLinkedListNode node = RungModel.LinkedListOfInstructions.Head;
            int rowIndex = 0;
            int columnIndex = 0;

            while (node != null)
            {
                BaseInstructionViewModel instructionViewModel = factory.CreateInstructionViewModel(node.Instruction);
                instructionViewModel.RowIndex = rowIndex;
                instructionViewModel.ColumnIndex = columnIndex;

                GridFormatInstructionList.Add(instructionViewModel);

                rowIndex++;

                node = node.Next;
            }
        }

        #endregion Methods

    }
}
