using System;

namespace Ladder_GUI_WPF
{
    class RoutineViewModel : BaseViewModel
    {

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

        private int _tempProp;
        public int TempProp
        {
            get => _tempProp;
            set
            {
                if (_tempProp == value)
                    return;

                _tempProp = value;
                OnPropertyChanged(nameof(TempProp));
            }
        }

        public RoutineViewModel()
        {
            Random randNumGenerator = new Random();
            TempProp = randNumGenerator.Next();
            RoutineModel = new RoutineModel();
        }
    }
}
