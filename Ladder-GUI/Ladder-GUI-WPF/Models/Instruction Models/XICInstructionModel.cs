namespace Ladder_GUI_WPF
{
    class XICInstructionModel : IBaseInstructionModel
    {
        public bool Enabled { get ; set; }
        public string LongName { get; } = "Examine If Closed";
        public string ShortName { get; } = "XIC";
        public bool IsOutput { get; } = false;
    }
}
