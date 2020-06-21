using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Ladder_GUI_WPF
{
    class BaseInstructionViewModel : INotifyPropertyChanged
    {
        private bool _enabled;
        public bool Enabled {get => _enabled;
            set
            {
                if (_enabled == value)
                    return;
  
                _enabled = value;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(Enabled)));
            }
        }
        public string LongName { get; }
        public string ASCIIName { get; }
        public bool IsOutput { get; }

        // TODO: Check whether i need to explicitly do : public event PropertyChangedEventHandler PropertyChanged = (sender, e) => { };
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
