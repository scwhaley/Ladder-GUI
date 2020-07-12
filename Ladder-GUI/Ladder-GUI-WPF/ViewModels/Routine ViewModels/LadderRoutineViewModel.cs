using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Documents;

namespace Ladder_GUI_WPF
{
    class LadderRoutineViewModel : BaseRoutineViewModel
    {
        private ObservableCollection<RungViewModel> _rungList;
        public ObservableCollection<RungViewModel> RungList
        {
            get { return _rungList; }
            set 
            {
                if (_rungList == value)
                    return;

                _rungList = value;
                OnPropertyChanged(nameof(RungList));
            }
        }

        #region Constructor
        public LadderRoutineViewModel(LadderRoutineModel routineModel) : base(routineModel)
        {
            routineModel.RungList
        }
        #endregion Constructor

        private ObservableCollection<RungViewModel> GenerateRungViewModelList(List<RungModel> modelList)
        {
            ObservableCollection<RungViewModel> viewModelObservableCollection = new ObservableCollection<RungViewModel>();
            foreach (RungModel model in modelList)
            {
                viewModelObservableCollection.Add(new RungViewModel(model));
            }

            return viewModelObservableCollection;
        }
    }
}
