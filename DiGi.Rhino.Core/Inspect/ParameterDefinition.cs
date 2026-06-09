using DiGi.Core.Parameter.Interfaces;
using DiGi.Rhino.Core.Classes;
using Grasshopper.Kernel.Types;

namespace DiGi.Rhino.Core
{
    public static partial class Inspect
    {
        /// <summary>
        /// Gets the group name of the specified parameter definition as a <see cref="GH_String"/>.
        /// </summary>
        /// <param name="parameterDefinition">The parameter definition to inspect.</param>
        /// <returns>A <see cref="GH_String"/> containing the group name, or <c>null</c> if the <paramref name="parameterDefinition"/> is null.</returns>
        [Inspect("GroupName", "GroupName", "GroupName")]
        public static GH_String? GroupName(this IParameterDefinition? parameterDefinition)
        {
            if (parameterDefinition == null)
            {
                return null;
            }

            return new GH_String(parameterDefinition.GroupName);
        }

        /// <summary>
        /// Gets the name of the specified parameter definition as a <see cref="GH_String"/>.
        /// </summary>
        /// <param name="parameterDefinition">The parameter definition to inspect.</param>
        /// <returns>A <see cref="GH_String"/> containing the name, or <c>null</c> if the <paramref name="parameterDefinition"/> is null.</returns>
        [Inspect("Name", "Name", "Name")]
        public static GH_String? Name(this IParameterDefinition? parameterDefinition)
        {
            if (parameterDefinition == null)
            {
                return null;
            }

            return new GH_String(parameterDefinition.Name);
        }

        /// <summary>
        /// Gets the parameter type of the specified parameter definition as a <see cref="GooEnum"/>.
        /// </summary>
        /// <param name="parameterDefinition">The parameter definition to inspect.</param>
        /// <returns>A <see cref="GooEnum"/> containing the parameter type, or <c>null</c> if the <paramref name="parameterDefinition"/> is null.</returns>
        [Inspect("ParameterType", "ParameterType", "ParameterType")]
        public static GooEnum? ParameterType(this IParameterDefinition? parameterDefinition)
        {
            if (parameterDefinition == null)
            {
                return null;
            }

            return new GooEnum(parameterDefinition.ParameterType);
        }

        /// <summary>
        /// Gets the unique identifier of the specified parameter definition as a <see cref="GH_String"/>.
        /// </summary>
        /// <param name="parameterDefinition">The parameter definition to inspect.</param>
        /// <returns>A <see cref="GH_String"/> containing the unique identifier, or <c>null</c> if the <paramref name="parameterDefinition"/> is null.</returns>
        [Inspect("UniqueId", "UniqueId", "UniqueId")]
        public static GH_String? UniqueId(this IParameterDefinition? parameterDefinition)
        {
            if (parameterDefinition == null)
            {
                return null;
            }

            return new GH_String(parameterDefinition.UniqueId);
        }
    }
}