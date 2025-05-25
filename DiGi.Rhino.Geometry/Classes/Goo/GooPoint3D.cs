using DiGi.Geometry.Spatial.Classes;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.Rhino.Geometry.Classes
{
    public class GooPoint3D : GooGeometry3D<Point3D>
    {
        public GooPoint3D()
            : base()
        {
        }

        public GooPoint3D(Point3D point3D)
        {
            Value = point3D;
        }

        public override IGH_Goo Duplicate()
        {
            return new GooPoint3D(Value);
        }
    }

    public class GooPoint3DParam : GooGeometryParam<Point3D>
    {
        public override Guid ComponentGuid => new Guid("baacf835-6a09-41d4-9219-dd9ef1b54a0e");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public GooPoint3DParam()
            : base()
        {
        }
    }
}
