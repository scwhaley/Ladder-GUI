using System;
using System.Collections.Generic;
using System.Text;

namespace Ladder_GUI_WPF
{
    interface IRoutineModel
    {
        public List<IRungModel> RungList { get; set; }
    }
}
