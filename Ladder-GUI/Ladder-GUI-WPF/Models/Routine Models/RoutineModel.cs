using Ladder_GUI_WPF.Models.Routine_Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ladder_GUI_WPF
{
    class RoutineModel : IRoutineModel
    {
        List<IRungModel> IRoutineModel.RungList { get; set; }
    }
}
