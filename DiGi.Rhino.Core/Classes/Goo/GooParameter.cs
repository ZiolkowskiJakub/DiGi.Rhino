using DiGi.Rhino.Core.Classes;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.GIS.Rhino.Classes
{
    public class GooParameter : GooSerializableObject<Core.Parameter.Classes.Parameter>
    {
        public GooParameter()
            : base()
        {
        }

        public GooParameter(Core.Parameter.Classes.Parameter parameter)
            : base()
        {
            Value = parameter;
        }

        public override IGH_Goo Duplicate()
        {
            return new GooParameter(Value);
        }

    }

    public class GooParameterParam : GooPresistentParam<GooParameter, Core.Parameter.Classes.Parameter>
    {
        public override Guid ComponentGuid => new Guid("e91d099f-37df-4817-aac9-0d3eded74b42");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public GooParameterParam()
            : base()
        {
        }
    }
}

