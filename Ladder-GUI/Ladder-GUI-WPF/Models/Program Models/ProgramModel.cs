using System.Collections.Generic;

namespace Ladder_GUI_WPF
{
    class ProgramModel : IProgramModel
    {
        public string Name { get; set; }
        public List<IRoutineModel> RoutineList { get; set; }
        public ProgramModel(string name)
        {
            Name = name;
            RoutineList = new List<IRoutineModel>();
        }
    }
}
