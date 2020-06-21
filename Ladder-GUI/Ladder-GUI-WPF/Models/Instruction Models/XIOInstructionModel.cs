namespace Ladder_GUI_WPF
{
    class XIOInstructionModel : IBaseInstructionModel
    {
        public bool Enabled { get; set; }
        public string LongName { get; } = "Examine If Open";
        public string ASCIIName { get; } = "XIO";
        public bool IsOutput { get; } = false;
    }
}
