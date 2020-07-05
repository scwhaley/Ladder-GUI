using System;
using System.IO;

namespace Ladder_GUI_WPF
{
    class InstructionViewModelFactory : AbstractInstructionViewModelFactory
    {
        /// <summary>
        /// Creates an instruction view model for the given instruction model.
        /// </summary>
        /// <param name="instructionModel">The instruction model to make the view model from.</param>
        /// <returns>An instruction view model derived from BaseInstructionViewModel.</returns>
        public override BaseInstructionViewModel CreateInstructionViewModel(IBaseInstructionModel instructionModel)
        {
            if (instructionModel is XICInstructionModel)
                return new XICViewModel(instructionModel);
            if (instructionModel is XIOInstructionModel)
                return new XIOViewModel(instructionModel);
            if (instructionModel is OTEInstructionModel)
                return new OTEViewModel(instructionModel);

            // If the instruction type did not exist, throw argument exception
            throw new ArgumentException($"The {instructionModel.ShortName} instruction is not in the {nameof(InstructionViewModelFactory)} factory");
        }
    }
}
