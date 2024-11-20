using DiGi.Geometry.Planar.Classes;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.Rhino.Geometry.Classes
{
    public class GooSegment2D : GooGeometry2D<Segment2D>
    {
        public GooSegment2D()
            : base()
        {
        }

        public GooSegment2D(Segment2D segment2D)
        {
            Value = segment2D;
        }

        public override IGH_Goo Duplicate()
        {
            return new GooSegment2D(Value);
        }
    }

    public class GooSegment2DParam : GooGeometryParam<Segment2D>
    {
        public override Guid ComponentGuid => new Guid("ed94a00f-cd43-4ae1-bbec-9d792395f248");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public GooSegment2DParam()
            : base()
        {
        }
    }
}
