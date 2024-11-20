using DiGi.Geometry.Planar.Classes;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.Rhino.Geometry.Classes
{
    public class GooPoint2D : GooGeometry2D<Point2D>
    {
        public GooPoint2D()
            : base()
        {
        }

        public GooPoint2D(Point2D point2D)
        {
            Value = point2D;
        }

        public override IGH_Goo Duplicate()
        {
            return new GooPoint2D(Value);
        }
    }

    public class GooPoint2DParam : GooGeometryParam<Point2D>
    {
        public override Guid ComponentGuid => new Guid("34696feb-c38e-4458-ba2b-3db180fa12e9");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public GooPoint2DParam()
            : base()
        {
        }
    }
}
