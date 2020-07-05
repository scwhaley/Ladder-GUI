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
        public string Type{ get { return _routineModel.Type; } }

        #endregion Properties

        #region Constructor
        public BaseRoutineViewModel(IRoutineModel routineModel)
        {
            RoutineModel = routineModel;
        }
        #endregion Constructor
    }
}
