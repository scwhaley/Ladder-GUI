using System;
using System.Collections.Generic;

namespace Ladder_GUI_WPF
{
    class LadderRoutineModel : IRoutineModel
    {
        public string Type { get; } = "Ladder";
        public string Name { get; set; }
        public List<IRungModel> RungList { get; set; }

        public LadderRoutineModel(string name)
        {
            Name = name;
        }
    }
}
