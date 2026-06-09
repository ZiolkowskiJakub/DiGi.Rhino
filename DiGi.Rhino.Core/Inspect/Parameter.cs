using DiGi.Core.Parameter.Classes;
using DiGi.GIS.Rhino.Classes;
using DiGi.Rhino.Core.Classes;
using Grasshopper.Kernel.Types;

namespace DiGi.Rhino.Core
{
    public static partial class Inspect
    {
        /// <summary>
        /// Gets the name of the specified parameter as a <see cref="GH_String"/>.
        /// </summary>
        /// <param name="parameter">The parameter to inspect.</param>
        /// <returns>A <see cref="GH_String"/> containing the parameter's name, or <c>null</c> if the parameter is null.</returns>
        [Inspect("Name", "Name", "Name")]
        public static GH_String? Name(this Parameter? parameter)
        {
            if (parameter == null)
            {
                return null;
            }

            return new GH_String(parameter.Name);
        }

        /// <summary>
        /// Gets the definition of the specified parameter as a <see cref="GooParameterDefinition"/>.
        /// </summary>
        /// <param name="parameter">The parameter to inspect.</param>
        /// <returns>A <see cref="GooParameterDefinition"/> wrapping the parameter's definition, or <c>null</c> if the parameter is null.</returns>
        [Inspect("ParameterDefinition", "ParameterDefinition", "ParameterDefinition")]
        public static GooParameterDefinition? ParameterDefinition(this Parameter? parameter)
        {
            if (parameter == null)
            {
                return null;
            }

            return new GooParameterDefinition(parameter.ParameterDefinition);
        }

        /// <summary>
        /// Gets the type of the specified parameter as a <see cref="GooEnum"/>.
        /// </summary>
        /// <param name="parameter">The parameter to inspect.</param>
        /// <returns>A <see cref="GooEnum"/> wrapping the parameter's type, or <c>null</c> if the parameter is null.</returns>
        [Inspect("ParameterType", "ParameterType", "ParameterType")]
        public static GooEnum? ParameterType(this Parameter? parameter)
        {
            if (parameter == null)
            {
                return null;
            }

            return new GooEnum(parameter.ParameterType);
        }

        /// <summary>
        /// Gets the value of the specified parameter as an <see cref="IGH_Goo"/> object.
        /// </summary>
        /// <param name="parameter">The parameter to inspect.</param>
        /// <returns>An <see cref="IGH_Goo"/> representation of the parameter's value, or <c>null</c> if the parameter is null.</returns>
        [Inspect("Value", "Value", "Value")]
        public static IGH_Goo? Value(this Parameter? parameter)
        {
            if (parameter == null)
            {
                return null;
            }

            return Create.GH_Goo(parameter.ParameterType, parameter.Value);
        }
    }
}