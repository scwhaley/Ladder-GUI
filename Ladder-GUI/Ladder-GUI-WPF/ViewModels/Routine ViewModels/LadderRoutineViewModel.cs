using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Documents;
using System.Windows.Input;

namespace Ladder_GUI_WPF
{
    class LadderRoutineViewModel : BaseRoutineViewModel
    {
        public ICommand AddRungCommand { get; set; }
        public ICommand AddRungFromModelCommand { get; set; }
        public ICommand SelectedRungChangedCommand { get; set; }

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


        #region Constructor
        public LadderRoutineViewModel(LadderRoutineModel routineModel) : base(routineModel)
        {
            RungVMList = new ObservableCollection<RungViewModel>();
            AddRungCommand = new RelayCommand<object>(AddRung);
            AddRungFromModelCommand = new RelayCommand<RungModel>(AddRungFromModel);
            SelectedRungChangedCommand = new RelayCommand<object>(SelectedRungChanged);
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
        public void SelectedRungChanged(object obj)
        {
            var rung = obj as RungViewModel;
            SelectedRung = rung;
        }
    }
}
