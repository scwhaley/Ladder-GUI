using System.Collections.Generic;

namespace Ladder_GUI_WPF
{
    interface IProgramModel
    {
        public List<IRoutineModel> RoutineList { get; set; }
    }
}
