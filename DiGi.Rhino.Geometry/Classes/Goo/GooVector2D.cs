using DiGi.Geometry.Planar.Classes;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.Rhino.Geometry.Classes
{
    public class GooVector2D : GooGeometry2D<Vector2D>
    {
        public GooVector2D()
            : base()
        {
        }

        public GooVector2D(Vector2D vector2D)
        {
            Value = vector2D;
        }

        public override IGH_Goo Duplicate()
        {
            return new GooVector2D(Value);
        }
    }

    public class GooVector2DParam : GooGeometryParam<Vector2D>
    {
        public override Guid ComponentGuid => new Guid("81bcb4c8-8733-4935-9dbb-c2bcaeeaf47a");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public GooVector2DParam()
            : base()
        {
        }
    }
}
