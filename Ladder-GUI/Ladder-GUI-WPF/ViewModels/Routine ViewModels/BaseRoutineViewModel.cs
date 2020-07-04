namespace Ladder_GUI_WPF
{
    abstract class BaseRoutineViewModel : BaseViewModel
    {
        #region Properties
        private IRoutineModel _routineModel;
        public IRoutineModel RoutineModel
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
        #endregion Properties

        #region Constructor
        public BaseRoutineViewModel(IRoutineModel routineModel)
        {
            RoutineModel = routineModel;
        }
        #endregion Constructor
    }
}
