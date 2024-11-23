using DiGi.Geometry.Planar.Classes;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.Rhino.Geometry.Classes
{
    public class GooRectangle2D : GooGeometry2D<Rectangle2D>
    {
        public GooRectangle2D()
            : base()
        {
        }

        public GooRectangle2D(Rectangle2D rectangle2D)
        {
            Value = rectangle2D;
        }

        public override IGH_Goo Duplicate()
        {
            return new GooRectangle2D(Value);
        }

    }

    public class GooRectangle2DParam : GooGeometryParam<Rectangle2D>
    {
        public override Guid ComponentGuid => new Guid("4fe103ef-4e57-47d9-b992-bccb9a67a22a");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public GooRectangle2DParam()
            : base()
        {
        }
    }
}

