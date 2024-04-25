using System;

namespace DiGi.Rhino.Core.Enums
{
    [Flags]
    public enum ParameterVisibility
    {
        Voluntary = 0,
        Mandatory = 1,
        Default = 2,
        Binding = 3
    }
}
