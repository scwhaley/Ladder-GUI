using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;

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
                OnPropertyChanged();
            }
        }

        private int _rungNunmber;
        public int RungNumber { get => _rungNunmber;
            set
            {
                if (_rungNunmber == value)
                    return;

                _rungNunmber = value;
                OnPropertyChanged();
            }
        }
        public ObservableCollection<BaseInstructionViewModel> RungInstructions { get; set; } = new ObservableCollection<BaseInstructionViewModel>();
        #endregion Properties

        #region Constructor
        public RungViewModel()
        {
            IRungModel RungModel = new RungModel();
        }
        #endregion Constructor

        #region Methods
        // Adds an instruction to the rung models linked list of instructions
        public void addInstruction(int index, IBaseInstructionModel instruction)
        {
            RungModel.LinkedListOfInstructions.AppendInstruction(instruction, index);
        }

        #endregion Methods

    }
}
