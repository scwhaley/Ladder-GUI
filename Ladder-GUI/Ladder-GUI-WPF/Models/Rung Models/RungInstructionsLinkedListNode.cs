using System;
using System.Collections.Generic;
using System.Text;

namespace Ladder_GUI_WPF.Models
{
    class RungInstructionsLinkedListNode
    {
        public RungInstructionsLinkedListNode Previous { get; set; }
        public RungInstructionsLinkedListNode Next { get; set; }
        public IBaseInstructionModel Instruction { get; set; }
        public int NodeID { get; protected set; }

        public RungInstructionsLinkedListNode(IBaseInstructionModel instruction)
        {
            Instruction = instruction;
            NodeID = Instruction.ID;
        }
    }
}
