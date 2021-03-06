﻿using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.Specialized;
using System.IO;

namespace Ladder_GUI_WPF
{
    class BaseViewModel : INotifyPropertyChanged, INotifyCollectionChanged
    {
        // Event that you can raise whenever a property is changed.
        public event PropertyChangedEventHandler PropertyChanged;
        public event NotifyCollectionChangedEventHandler CollectionChanged;

        // Create the OnPropertyChanged method to raise the event
        // The calling member's name will be used as the parameter.
        protected void OnPropertyChanged(string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

        }
    }
}
