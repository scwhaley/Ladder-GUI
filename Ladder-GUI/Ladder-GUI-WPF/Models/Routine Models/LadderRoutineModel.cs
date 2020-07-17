using System;
using System.Collections.Generic;

namespace Ladder_GUI_WPF
{
    class LadderRoutineModel : BaseViewModel
    {
        public string Type { get; } = "Ladder";
        public string Name { get; set; }
        public List<RungModel> RungList { get; set; }

        public LadderRoutineModel(string name)
        {
            Name = name;
            RungList = new List<RungModel> { new RungModel()};
        }
    }
}
