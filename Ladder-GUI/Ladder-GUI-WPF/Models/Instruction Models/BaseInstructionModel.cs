using System;
using System.Collections.Generic;
using System.Text;

namespace Ladder_GUI_WPF
{
    class BaseInstructionModel : IBaseInstructionModel
    {
        public bool Enabled { get; set; }

        public string LongName { get; protected set; }

        public string ShortName { get; protected set; }

        public bool IsOutput { get; protected set; }

        private int id;
        public int ID
        {
            get { return id; }
            protected set { id = value; }
        }

        public BaseInstructionModel()
        {
            Random rand = new Random();
            ID = rand.Next();
        }
    }
}
