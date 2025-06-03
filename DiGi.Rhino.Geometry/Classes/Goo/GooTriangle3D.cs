using DiGi.Geometry.Spatial.Classes;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.Rhino.Geometry.Classes
{
    public class GooTriangle3D : GooGeometry3D<Triangle3D>
    {
        public GooTriangle3D()
            : base()
        {
        }

        public GooTriangle3D(Triangle3D triangle3D)
        {
            Value = triangle3D;
        }

        public override IGH_Goo Duplicate()
        {
            return new GooTriangle3D(Value);
        }
    }

    public class GooTriangle3DParam : GooGeometryParam<Triangle3D>
    {
        public override Guid ComponentGuid => new Guid("a89cf240-e7be-41ff-9d05-c62a7f7fc4a9");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public GooTriangle3DParam()
            : base()
        {
        }
    }
}
