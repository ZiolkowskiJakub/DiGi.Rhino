using DiGi.Geometry.Planar.Classes;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.Rhino.Geometry.Classes
{
    public class GooEllipse2D : GooGeometry2D<Ellipse2D>
    {
        public GooEllipse2D()
            : base()
        {
        }

        public GooEllipse2D(Ellipse2D ellipse2D)
        {
            Value = ellipse2D;
        }

        public override IGH_Goo Duplicate()
        {
            return new GooEllipse2D(Value);
        }

    }

    public class GooEllipse2DParam : GooGeometryParam<Ellipse2D>
    {
        public override Guid ComponentGuid => new Guid("7e79f2a6-a3a8-4955-bcec-536e646943ea");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public GooEllipse2DParam()
            : base()
        {
        }
    }
}