using System;
using System.Collections.Generic;
using System.Text;

namespace Ladder_GUI_WPF.ViewModels.Routine_ViewModels
{
    /// <summary>
    /// A factory for creating a routine viewmodel from a routine model.
    /// </summary>
    class RoutineViewModelFactory
    {
        /// <summary>
        /// Creates a routine viewmodel from a routine model.
        /// </summary>
        /// <param name="routineModel">The routine model to create a routine viewmodel from.</param>
        /// <returns>A routine viewmodel.</returns>
        public LadderRoutineViewModel CreateRoutineViewModel(IRoutineModel routineModel)
        {
            if(routineModel is LadderRoutineModel)
                return new LadderRoutineViewModel(routineModel);
            
            // If the instruction type did not exist, throw argument exception
            throw new ArgumentException($"The {routineModel.Type} routine is not in the {nameof(RoutineViewModelFactory)} factory");
        }
    }
}
