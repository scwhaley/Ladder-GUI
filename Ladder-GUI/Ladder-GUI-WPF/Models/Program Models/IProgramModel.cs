using System.Collections.Generic;

namespace Ladder_GUI_WPF
{
    interface IProgramModel
    {
        public string Name { get; set; }
        public List<IRoutineModel> RoutineList { get; set; }
    }
}
