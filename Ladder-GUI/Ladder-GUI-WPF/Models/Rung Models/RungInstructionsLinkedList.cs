using Ladder_GUI_WPF.Models;
using System;
using System.IO;

namespace Ladder_GUI_WPF
{
    class RungInstructionsLinkedList
    {
        public RungInstructionsLinkedListNode Head { get; set; }

        public RungInstructionsLinkedList()
        {
            
            File.AppendAllText(@"C:\Temp\Debug.txt", $"{DateTime.Now.ToString("HH:mm:ss")} - RungInstructionLinkedList.Count: {this.GetNumberOfInstructions()} {Environment.NewLine}");
        }

        public void InsertInstruction(IBaseInstructionModel instruction, int index)
        {
            RungInstructionsLinkedListNode node = Head;
            RungInstructionsLinkedListNode previousNode = null;
            RungInstructionsLinkedListNode nextNode = null;
            RungInstructionsLinkedListNode newNode = new RungInstructionsLinkedListNode(instruction);

            int tracker = 0;
            //try
            //{
            //    File.AppendAllText(@"C:\Temp\Debug.txt", $"{DateTime.Now.ToString("HH:mm:ss")} - In InsertInstruction trying to insert {newNode.Instruction.ASCIIName}.{newNode.ID} instruction at index {index} {Environment.NewLine}");
            //    File.AppendAllText(@"C:\Temp\Debug.txt", $"{DateTime.Now.ToString("HH:mm:ss")} - Current Head: {node.Instruction.ASCIIName}.{node.ID} {Environment.NewLine}");
            //}
            //catch(Exception) { }


            // Head
            if (index == 0)
            {
                if (Head is null)
                {
                    Head = newNode;
                    return;
                }
                Head.Previous = newNode;
                newNode.Next = Head;
                Head = newNode;
                //try
                //{
                //    File.AppendAllText(@"C:\Temp\Debug.txt", $"{DateTime.Now.ToString("HH:mm:ss")} - Changed Head to: {Head.Instruction.ASCIIName}.{Head.ID} {Environment.NewLine}");
                //    File.AppendAllText(@"C:\Temp\Debug.txt", $"{DateTime.Now.ToString("HH:mm:ss")} - RungInstructionLinkedList.Count: {this.GetNumberOfInstructions()} {Environment.NewLine}");
                //}
                //catch(Exception) { }

                return;
            }

            // For other nodes, traverse the linked list to the index
            while (tracker != index)
            {

                previousNode = node;
                node = node.Next;
                nextNode = node.Next;
                tracker++;

                //try { File.AppendAllText(@"C:\Temp\Debug.txt", $"{DateTime.Now.ToString("HH:mm:ss")} - Node {tracker} is: {node.Instruction.ASCIIName}.{node.ID} {Environment.NewLine}"); } catch(Exception) { }

            }

            // Join the preceding and following nodes.
            previousNode.Next = newNode;
            node.Previous = newNode;

            //try
            //{
            //    File.AppendAllText(@"C:\Temp\Debug.txt", $"{DateTime.Now.ToString("HH:mm:ss")} - Changed Node {tracker} to: {node.Instruction.ASCIIName}.{node.ID} {Environment.NewLine}");
            //    File.AppendAllText(@"C:\Temp\Debug.txt", $"{DateTime.Now.ToString("HH:mm:ss")} - Node {tracker}.Previous: {previousNode.Instruction.ASCIIName}.{node.ID}{Environment.NewLine}");
            //    File.AppendAllText(@"C:\Temp\Debug.txt", $"{DateTime.Now.ToString("HH:mm:ss")} - Node {tracker}.Next : {nextNode.Instruction.ASCIIName}.{node.ID} {Environment.NewLine}");
            //}
            //catch(Exception){ }
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
                //try { File.AppendAllText(@"C:\Temp\Debug.txt", $"{DateTime.Now.ToString("HH:mm:ss")} - In GetNumInstructions - Node {count} is: {node.Instruction.ASCIIName}.{node.ID}{Environment.NewLine}"); } catch(Exception) { }
                node = node.Next;
                count++;
            }

            return (count);
        }
    }
}
