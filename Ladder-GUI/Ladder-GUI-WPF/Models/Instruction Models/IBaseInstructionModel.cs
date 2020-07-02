namespace Ladder_GUI_WPF
{
    interface IBaseInstructionModel
    {
        public bool Enabled { get; set; }
        public string LongName { get; }
        public string ShortName { get; }
        public bool IsOutput { get; }
        public int ID { get; }
    }
}
