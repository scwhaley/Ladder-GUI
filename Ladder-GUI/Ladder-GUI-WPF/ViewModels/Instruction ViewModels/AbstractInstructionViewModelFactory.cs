using System;
using System.Collections.Generic;
using System.Text;

namespace Ladder_GUI_WPF
{
    /// <summary>
    /// An abstract class defining a factory for creating Instruction viewmodels.
    /// </summary>
    abstract class AbstractInstructionViewModelFactory
    {
        /// <summary>
        /// Creates an instruction viewmodel from an instruction model.
        /// </summary>
        /// <param name="InstructionModel">The instruction model to create an instruction viewmodel from.</param>
        /// <returns>An instruction viewmodel.</returns>
        public abstract BaseInstructionViewModel CreateInstructionViewModel(IBaseInstructionModel InstructionModel);

    }
}
