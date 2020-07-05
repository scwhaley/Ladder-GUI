using System;
using System.Collections.Generic;
using System.Text;

namespace Ladder_GUI_WPF
{
    interface IRoutineModel
    {
        public string Type { get; }
        public string Name { get; set; }

    }
}
