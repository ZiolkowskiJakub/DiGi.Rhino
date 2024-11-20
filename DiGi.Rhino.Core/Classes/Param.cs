using DiGi.Rhino.Core.Enums;
using Grasshopper.Kernel;
using System.Reflection;

namespace DiGi.Rhino.Core.Classes
{
    public struct Param
    {
        public readonly IGH_Param GH_Param;
        public readonly ParameterVisibility ParameterVisibility;

        public Param(IGH_Param gH_Param)
        {
            GH_Param = gH_Param;
            ParameterVisibility = ParameterVisibility.Binding;
        }

        public Param(IGH_Param gH_Param, ParameterVisibility parameterVisibility)
        {
            GH_Param = gH_Param;
            ParameterVisibility = parameterVisibility;
        }
    }
}