using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Printing;

namespace Ladder_GUI_WPF.Model
{
    class User : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private int _userId;
        private string firstName;
        private string lastName;

        public int UserID
        {
            get
            {
                return _userId;
            }

            set
            {
                _userId = value;
            }
        }

    }
}
