using DiGi.Core.Parameter.Classes;
using DiGi.GIS.Rhino.Classes;
using DiGi.Rhino.Core.Classes;
using Grasshopper.Kernel.Types;

namespace DiGi.Rhino.Core
{
    public static partial class Inspect
    {

        [Inspect("Name", "Name", "Name")]
        public static GH_String? Name(this Parameter? parameter)
        {
            if (parameter == null)
            {
                return null;
            }

            return new GH_String(parameter.Name);
        }

        [Inspect("ParameterDefinition", "ParameterDefinition", "ParameterDefinition")]
        public static GooParameterDefinition? ParameterDefinition(this Parameter? parameter)
        {
            if (parameter == null)
            {
                return null;
            }

            return new GooParameterDefinition(parameter.ParameterDefinition);
        }

        [Inspect("ParameterType", "ParameterType", "ParameterType")]
        public static GooEnum? ParameterType(this Parameter? parameter)
        {
            if (parameter == null)
            {
                return null;
            }

            return new GooEnum(parameter.ParameterType);
        }

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
