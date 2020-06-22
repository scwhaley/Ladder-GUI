using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Text;
using System.Windows;

namespace Ladder_GUI_WPF
{
    class LadderGUIViewModel : INotifyCollectionChanged, INotifyPropertyChanged
    {
        #region Properties
        private RoutineViewModel _loadedRoutine;
        public RoutineViewModel LoadedRoutine { get => _loadedRoutine;
            set
            {
                if (_loadedRoutine == value)
                    return;

                _loadedRoutine = value;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(LoadedRoutine)));
            }
        }

        private string _backgroundColor;
        public string BackgroundColor
        {
            get => _backgroundColor;
            set
            {
                if (_backgroundColor == value)
                    return;

                _backgroundColor = value;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(LoadedRoutine)));
            }
        }

        public LadderGUIViewModel()
        {
            BackgroundColor = "LightBlue";
        }


        #endregion Properties

        public event NotifyCollectionChangedEventHandler CollectionChanged;
        public event PropertyChangedEventHandler PropertyChanged;

        public void LoadRoutine_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
