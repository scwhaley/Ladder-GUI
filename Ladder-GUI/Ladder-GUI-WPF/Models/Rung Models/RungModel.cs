using System;
using System.Collections.Generic;
using System.Text;

namespace Ladder_GUI_WPF
{
    class RungModel : IRungModel
    {
        public bool Enabled { get; set; }
        public RungInstructionsLinkedList LinkedListOfInstructions { get; set; }
    }
}
