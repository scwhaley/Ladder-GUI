using System;
using System.Collections.Generic;
using System.Text;

namespace Ladder_GUI_WPF.Models.Routine_Models
{
    interface IRoutineModel
    {
        public List<IRungModel> RungList { get; set; }
    }
}
