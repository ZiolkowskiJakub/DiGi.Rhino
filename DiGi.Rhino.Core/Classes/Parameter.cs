using DiGi.Rhino.Core.Enums;
using Grasshopper.Kernel;

namespace DiGi.Rhino.Core.Classes
{
    public struct Parameter
    {
        public readonly IGH_Param Param;
        public readonly ParameterVisibility ParameterVisibility;

        public Parameter(IGH_Param param)
        {
            Param = param;
            ParameterVisibility = ParameterVisibility.Binding;
        }

        public Parameter(IGH_Param param, ParameterVisibility parameterVisibility)
        {
            Param = param;
            ParameterVisibility = parameterVisibility;
        }
    }
}
