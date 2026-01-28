using DiGi.Core.Parameter.Interfaces;
using DiGi.Rhino.Core.Classes;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.GIS.Rhino.Classes
{
    public class GooParametrizedObject : GooSerializableObject<IParametrizedObject>
    {
        public GooParametrizedObject()
            : base()
        {
        }

        public GooParametrizedObject(IParametrizedObject? parametrizedObject)
            : base()
        {
            Value = parametrizedObject;
        }

        public override IGH_Goo Duplicate()
        {
            return new GooParametrizedObject(Value);
        }
    }

    public class GooParametrizedObjectParam : GooSerializablePresistentParam<GooParametrizedObject, IParametrizedObject>
    {
        public override Guid ComponentGuid => new("221d1e55-a083-4d11-a1d2-65faa76972fb");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public GooParametrizedObjectParam()
            : base()
        {
        }
    }
}