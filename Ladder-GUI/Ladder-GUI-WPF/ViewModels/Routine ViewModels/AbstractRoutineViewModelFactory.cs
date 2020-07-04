using System;
using System.Collections.Generic;
using System.Text;

namespace Ladder_GUI_WPF.ViewModels.Routine_ViewModels
{
    /// <summary>
    /// An abstract factory for creating a routine viewmodel from a routine model.
    /// </summary>
    abstract class AbstractRoutineViewModelFactory
    {
        /// <summary>
        /// Creates a routine viewmodel from a routine model.
        /// </summary>
        /// <param name="routineModel">The routine model to create a routine viewmodel from.</param>
        /// <returns>A routine viewmodel.</returns>
        public abstract RoutineViewModel CreateRoutineViewModel(IRoutineModel routineModel);
    }
}
