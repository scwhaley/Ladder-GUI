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
                OnPropertyChanged();
            }
        }
        public string LongName { get; }
        public string ASCIIName { get; }
        public bool IsOutput { get; }
    }
}
