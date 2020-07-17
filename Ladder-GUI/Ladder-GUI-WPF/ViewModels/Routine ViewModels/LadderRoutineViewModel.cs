using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Documents;
using System.Windows.Input;

namespace Ladder_GUI_WPF
{
    class LadderRoutineViewModel : BaseViewModel
    {
        public ICommand AddRungCommand { get; set; }
        public ICommand AddRungFromModelCommand { get; set; }

        #region Properties
        private LadderRoutineModel _routineModel;
        public LadderRoutineModel RoutineModel
        {
            get => _routineModel;
            set
            {
                if (_routineModel == value)
                    return;

                _routineModel = value;
                OnPropertyChanged(nameof(RoutineModel));
            }
        }

        public string Name
        {
            get { return _routineModel.Name; }
            set
            {
                if (_routineModel.Name == value)
                    return;

                _routineModel.Name = value;
                OnPropertyChanged(nameof(Name));
            }

        }
        public string Type { get { return _routineModel.Type; } }

        private ObservableCollection<RungViewModel> _rungVMList;
        public ObservableCollection<RungViewModel> RungVMList
        {
            get { return _rungVMList; }
            set 
            {
                if (_rungVMList == value)
                    return;

                _rungVMList = value;
                OnPropertyChanged(nameof(RungVMList));
            }
        }

        private RungViewModel _selectedRung;
        public RungViewModel SelectedRung
        {
            get { return _selectedRung; }
            set 
            { 
                if( _selectedRung == value)
                    return;

                _selectedRung = value;
                OnPropertyChanged(nameof(SelectedRung));
            }
        }
        #endregion Properties

        #region Constructor
        public LadderRoutineViewModel(LadderRoutineModel routineModel)
        {
            RoutineModel = routineModel;
            RungVMList = new ObservableCollection<RungViewModel>();
            AddRungCommand = new RelayCommand<object>(AddRung);
            AddRungFromModelCommand = new RelayCommand<RungModel>(AddRungFromModel);
        }
        #endregion Constructor

        private void AddRung(object obj)
        {
            RungVMList.Add(new RungViewModel(new RungModel()));
        }
        private void AddRungFromModel(RungModel rungModel)
        {
            RungVMList.Add(new RungViewModel(rungModel));
        }
    }
}
