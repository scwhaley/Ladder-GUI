using System;
using System.Collections.Generic;
using System.Text;

namespace Ladder_GUI_WPF
{
    interface IRungModel
    {
        public bool Enabled { get; set; }
        public RungInstructionsLinkedList LinkedListOfInstructions { get; set; }
    }
}
