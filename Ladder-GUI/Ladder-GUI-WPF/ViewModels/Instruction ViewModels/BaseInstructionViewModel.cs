using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Ladder_GUI_WPF
{
    /// <summary>
    /// The base view model for all instructions.
    /// </summary>
    abstract class BaseInstructionViewModel : BaseViewModel
    {
        #region Properties
        private bool _enabled;
        public bool Enabled {get => _enabled;
            set
            {
                if (_enabled == value)
                    return;
  
                _enabled = value;
                OnPropertyChanged(nameof(Enabled));
            }
        }
        public string LongName { get => _instructionModel.LongName; }
        public string ShortName { get => _instructionModel.ShortName; }
        public bool IsOutput { get => _instructionModel.IsOutput; }
        public int VMID { get => _instructionModel.ID; }

        private int _rowIndex;
        public int RowIndex
        {
            get { return _rowIndex; }
            set 
            {
                if (_rowIndex == value)
                    return;

                _rowIndex = value;
                OnPropertyChanged(nameof(RowIndex));
            }
        }
        private int _columnIndex;
        public int ColumnIndex
        {
            get { return _columnIndex; }
            set
            {
                if (_columnIndex == value)
                    return;

                _columnIndex = value;
                OnPropertyChanged(nameof(ColumnIndex));
            }
        }
        private IBaseInstructionModel _instructionModel;

        public IBaseInstructionModel InstructionModel
        {   
            get { return _instructionModel; }
            protected set 
            {
                if (_instructionModel == value)
                    return;

                _instructionModel = value;
                OnPropertyChanged(nameof(InstructionModel));
            }
        }

        #endregion Properties

        #region Constructor
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="instructionModel">The instruction model linked to the instruction view model.</param>
        public BaseInstructionViewModel(IBaseInstructionModel instructionModel)
        {
            InstructionModel = instructionModel;
        }
        #endregion Constructor
    }
}
