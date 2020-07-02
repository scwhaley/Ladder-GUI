using System;
using System.IO;

namespace Ladder_GUI_WPF
{
    class XICViewModel : BaseInstructionViewModel
    {
        public XICViewModel(IBaseInstructionModel instructionModel)
        {
            InstructionModel = instructionModel;
            ASCIIName = instructionModel.ShortName;
            LongName = instructionModel.LongName;
            File.AppendAllText(@"C:\Temp\Debug.txt", $"{DateTime.Now.ToString("HH:mm:ss")} - Created new XICViewModel {Environment.NewLine}");
        }
    }
}
