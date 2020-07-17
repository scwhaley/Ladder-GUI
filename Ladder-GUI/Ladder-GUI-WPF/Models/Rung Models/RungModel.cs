﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Ladder_GUI_WPF
{
    class RungModel
    {
        public bool Enabled { get; set; }
        public RungInstructionsLinkedList LinkedListOfInstructions { get; set; }

        public RungModel()
        {
            LinkedListOfInstructions = new RungInstructionsLinkedList();
        }
    }
}
