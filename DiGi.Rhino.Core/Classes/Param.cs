using DiGi.Rhino.Core.Enums;
using Grasshopper.Kernel;

namespace DiGi.Rhino.Core.Classes
{
    /// <summary>
    /// Represents a wrapper for a Grasshopper parameter, including its visibility settings.
    /// </summary>
    public readonly struct Param
    {
        /// <summary>
        /// Gets the underlying Grasshopper parameter instance.
        /// </summary>
        public readonly IGH_Param GH_Param;

        /// <summary>
        /// Gets the visibility setting for this parameter.
        /// </summary>
        public readonly ParameterVisibility ParameterVisibility;

        /// <summary>
        /// Initializes a new instance of the <see cref="Param"/> struct with default visibility set to <see cref="ParameterVisibility.Binding"/>.
        /// </summary>
        /// <param name="gH_Param">The Grasshopper parameter to wrap.</param>
        public Param(IGH_Param gH_Param)
        {
            GH_Param = gH_Param;
            ParameterVisibility = ParameterVisibility.Binding;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Param"/> struct with specified visibility.
        /// </summary>
        /// <param name="gH_Param">The Grasshopper parameter to wrap.</param>
        /// <param name="parameterVisibility">The visibility setting for the parameter.</param>
        public Param(IGH_Param gH_Param, ParameterVisibility parameterVisibility)
        {
            GH_Param = gH_Param;
            ParameterVisibility = parameterVisibility;
        }
    }
}