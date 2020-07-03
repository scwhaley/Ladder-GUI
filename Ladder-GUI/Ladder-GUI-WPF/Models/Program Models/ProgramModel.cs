using System.Collections.Generic;

namespace Ladder_GUI_WPF
{
    class ProgramModel : IProgramModel
    {
        public string Name { get; set; }
        public IList<IRoutineModel> RoutineList { get; set; }
    }
}
