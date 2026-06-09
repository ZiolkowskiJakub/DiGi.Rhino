using System;

namespace DiGi.Rhino.Core.Enums
{
    /// <summary>
    /// Specifies the visibility or requirement level of a parameter.
    /// </summary>
    [Flags]
    public enum ParameterVisibility
    {
        /// <summary>
        /// The parameter is optional and not required for execution.
        /// </summary>
        Voluntary = 0,

        /// <summary>
        /// The parameter is mandatory and must be provided.
        /// </summary>
        Mandatory = 1,

        /// <summary>
        /// The parameter has a default value assigned.
        /// </summary>
        Default = 2,

        /// <summary>
        /// The parameter is used as a binding reference.
        /// </summary>
        Binding = 3
    }
}