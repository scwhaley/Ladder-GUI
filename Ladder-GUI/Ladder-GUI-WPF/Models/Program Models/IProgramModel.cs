using Ladder_GUI_WPF.Models.Routine_Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ladder_GUI_WPF.Models
{
    interface IProgramModel
    {
        public List<IRoutineModel> RoutineList { get; set; }
    }
}
