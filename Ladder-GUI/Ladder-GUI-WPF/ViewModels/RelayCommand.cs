using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

// The purpose of the relayCommand class is to make the various methods in a view model accesible to View elements as a command.
// It acts as a wrapper.
namespace Ladder_GUI_WPF
{
    class RelayCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private Action _action;

        // Set the action
        public RelayCommand(Action action)
        {
            _action = action;
        }

        // Since this just runs an provided action, we deal with the Can execute at the action level, not here
        public bool CanExecute(object parameter)
        {
            return true;
        }

        // Runs the action
        public void Execute(object parameter)
        {
            _action();
        }   
    }
}
