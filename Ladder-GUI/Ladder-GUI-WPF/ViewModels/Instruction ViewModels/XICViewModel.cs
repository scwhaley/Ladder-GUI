using System;
using System.IO;

namespace Ladder_GUI_WPF
{
    class XICViewModel : BaseInstructionViewModel
    {
        #region Constructor
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="instructionModel">The instruction model linked to the instruction view model.</param>
        public XICViewModel(IBaseInstructionModel instructionModel) : base(instructionModel)
        {
        }
        #endregion Constructor
    }
}
