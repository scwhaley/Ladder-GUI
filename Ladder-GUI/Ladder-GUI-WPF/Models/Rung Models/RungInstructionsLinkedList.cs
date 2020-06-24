using Ladder_GUI_WPF.Models;


namespace Ladder_GUI_WPF
{
    class RungInstructionsLinkedList
    {
        public RungInstructionsLinkedListNode Head { get; set; }

        public void AppendInstruction(IBaseInstructionModel instruction, int index)
        {
            RungInstructionsLinkedListNode node = Head;
            RungInstructionsLinkedListNode previousNode = null;
            RungInstructionsLinkedListNode nextNode = null;
            RungInstructionsLinkedListNode newNode = new RungInstructionsLinkedListNode(instruction);

            int tracker = 0;

            // Head
            if (index == 0)
            {
                Head.Previous = newNode;
                Head = newNode;
                return;
            }

            // For other nodes, traverse the linked list to the index
            while (tracker != index)
            {
                previousNode = node;
                node = node.Next;
                nextNode = node.Next;
                tracker++;
            }

            // Join the preceding and following nodes.
            previousNode.Next = newNode;
            node.Previous = newNode;
        }

        public void DeleteInstruction(int index)
        {
            RungInstructionsLinkedListNode node = Head;
            RungInstructionsLinkedListNode previousNode = null;
            RungInstructionsLinkedListNode nextNode = null;
            int tracker = 0;

            // To delete the head, jsut call the next node the head
            if (index == 0)
            {
                Head = Head.Next;
                return;
            }

            // For other nodes, traverse the linked list to the index
            while (tracker != index)
            {
                previousNode = node;
                node = node.Next;
                nextNode = node.Next;
                tracker++;
            }

            // Join the preceding and following nodes.
            previousNode.Next = nextNode;
            nextNode.Previous = previousNode;
        }

        public int GetNumberOfInstructions()
        {
            RungInstructionsLinkedListNode node = Head;

            int count = 0;

            // For other nodes, traverse the linked list to the index
            while (node != null)
            {
                node = node.Next;
                count++;
            }

            return (count);
        }
    }
}
