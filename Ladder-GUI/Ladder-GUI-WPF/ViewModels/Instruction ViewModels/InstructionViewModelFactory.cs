using System;

namespace Ladder_GUI_WPF
{
    class InstructionViewModelFactory : AbstractInstructionViewModelFactory
    {
        public override BaseInstructionViewModel CreateInstructionViewModel(IBaseInstructionModel InstructionModel)
        {
            switch (InstructionModel.ASCIIName)
            {
                case ("XIC"):
                    return new XICViewModel(InstructionModel);
                case ("XIO"):
                    return new XIOViewModel(InstructionModel);
                case ("OTE"):
                    return new OTEViewModel(InstructionModel);
            }

            // If the instruction type did not exist, throw argument exception
            throw new ArgumentException($"The {InstructionModel.ASCIIName} instruction is not in the {nameof(InstructionViewModelFactory)} factory");
        }
    }
}
