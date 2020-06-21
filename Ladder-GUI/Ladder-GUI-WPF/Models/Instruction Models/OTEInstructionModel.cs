namespace Ladder_GUI_WPF
{
    class OTEInstructionModel : IBaseInstructionModel
    {
        public bool Enabled { get; set; }
        public string LongName { get; } = "Output Energize";
        public string ASCIIName { get; } = "OTE";
        public bool IsOutput { get; } = true;
    }
}
