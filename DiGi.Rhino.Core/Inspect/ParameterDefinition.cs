using DiGi.Core.Parameter.Interfaces;
using DiGi.Rhino.Core.Classes;
using Grasshopper.Kernel.Types;

namespace DiGi.Rhino.Core
{
    public static partial class Inspect
    {
        [Inspect("GroupName", "GroupName", "GroupName")]
        public static GH_String? GroupName(this IParameterDefinition? parameterDefinition)
        {
            if (parameterDefinition == null)
            {
                return null;
            }

            return new GH_String(parameterDefinition.GroupName);
        }

        [Inspect("Name", "Name", "Name")]
        public static GH_String? Name(this IParameterDefinition? parameterDefinition)
        {
            if(parameterDefinition == null)
            {
                return null;
            }

            return new GH_String(parameterDefinition.Name);
        }
        
        [Inspect("ParameterType", "ParameterType", "ParameterType")]
        public static GooEnum? ParameterType(this IParameterDefinition? parameterDefinition)
        {
            if (parameterDefinition == null)
            {
                return null;
            }

            return new GooEnum(parameterDefinition.ParameterType);
        }

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
