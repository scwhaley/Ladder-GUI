using System.Reflection;

namespace Ladder_GUI_WPF
{
    class OTEInstructionModel : BaseInstructionModel
    {
        public OTEInstructionModel()
        {
            LongName = "Output Energize";
            ShortName = "OTE";
            IsOutput = true;  
        }
    }
}
