using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Ladder_GUI_WPF
{
    abstract class BaseInstructionViewModel : BaseViewModel
    {
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
        public string LongName { get; set; }
        public string ASCIIName { get; set; }
        public bool IsOutput { get; set; }
        public int VMID { get; set; }

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


    }
}
