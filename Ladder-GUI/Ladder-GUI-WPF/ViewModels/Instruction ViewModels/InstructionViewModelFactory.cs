using System;
using System.IO;

namespace Ladder_GUI_WPF
{
    class InstructionViewModelFactory : AbstractInstructionViewModelFactory
    {
        /// <summary>
        /// Creates an instruction view model for the given instruction model.
        /// </summary>
        /// <param name="InstructionModel">The instruction model to make the view model from.</param>
        /// <returns>An instruction view model derived from BaseInstructionViewModel.</returns>
        public override BaseInstructionViewModel CreateInstructionViewModel(IBaseInstructionModel InstructionModel)
        {
            switch (InstructionModel.ShortName)
            {
                case ("XIC"):
                    return new XICViewModel(InstructionModel);
                case ("XIO"):
                    return new XIOViewModel(InstructionModel);
                case ("OTE"):
                    return new OTEViewModel(InstructionModel);
            }

            // If the instruction type did not exist, throw argument exception
            throw new ArgumentException($"The {InstructionModel.ShortName} instruction is not in the {nameof(InstructionViewModelFactory)} factory");
        }
    }
}
