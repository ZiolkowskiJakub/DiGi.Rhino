using DiGi.Geometry.Spatial.Classes;
using DiGi.Rhino.Geometry.Core.Classes;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.Rhino.Geometry.Spatial.Classes
{
    public class GooVector3D : GooGeometry3D<Vector3D>
    {
        public GooVector3D()
            : base()
        {
        }

        public GooVector3D(Vector3D vector3D)
        {
            Value = vector3D;
        }

        public override IGH_Goo Duplicate()
        {
            return new GooVector3D(Value);
        }
    }

    public class GooVector3DParam : GooGeometryParam<Vector3D>
    {
        public override Guid ComponentGuid => new Guid("e441884e-b98c-4e51-8f67-71ad21fcf07f");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public GooVector3DParam()
            : base()
        {
        }
    }
}
