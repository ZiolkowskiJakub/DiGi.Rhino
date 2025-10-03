using DiGi.Rhino.Core.Classes;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.GIS.Rhino.Classes
{
    public class GooParameterDefinition : GooSerializableObject<Core.Parameter.Interfaces.IParameterDefinition>
    {
        public GooParameterDefinition()
            : base()
        {
        }

        public GooParameterDefinition(Core.Parameter.Interfaces.IParameterDefinition? parameterDefinition)
            : base()
        {
            Value = parameterDefinition;
        }

        public override IGH_Goo Duplicate()
        {
            return new GooParameterDefinition(Value);
        }

    }

    public class GooParameterDefinitionParam : GooSerializablePresistentParam<GooParameterDefinition, Core.Parameter.Interfaces.IParameterDefinition>
    {
        public override Guid ComponentGuid => new ("ec1459a7-fdfd-4380-8549-7212b9ecc0bb");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public GooParameterDefinitionParam()
            : base()
        {
        }
    }
}

