using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;

namespace Ladder_GUI_WPF
{
    class RungViewModel : BaseViewModel
    {
        #region Properties
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
        private ObservableCollection<IBaseInstructionModel> RungInstructions { get; set; } = new ObservableCollection<IBaseInstructionModel>();
        #endregion Properties

        public void addInstruction(int index, IBaseInstructionModel instruction)
        {
            RungInstructions.Insert(index, instruction);
        }

    }
}
