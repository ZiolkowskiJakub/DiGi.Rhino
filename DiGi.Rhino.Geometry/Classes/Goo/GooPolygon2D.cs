using Grasshopper.Kernel.Types;
using System;
using DiGi.Geometry.Planar.Classes;

namespace DiGi.Rhino.Geometry.Classes
{
    public class GooPolygon2D : GooGeometry2D<Polygon2D>
    {
        public GooPolygon2D()
            : base()
        {
        }

        public GooPolygon2D(Polygon2D polygon2D)
        {
            Value = polygon2D;
        }

        public override IGH_Goo Duplicate()
        {
            return new GooPolygon2D(Value);
        }

    }

    public class GooPolygon2DParam : GooGeometryParam<Polygon2D>
    {
        public override Guid ComponentGuid => new Guid("d20aa671-8cc3-48b6-9b7a-2dd61ceb3799");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public GooPolygon2DParam()
            : base()
        {
        }
    }
}
