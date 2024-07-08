using DiGi.Geometry.Planar.Classes;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.Rhino.Geometry.Classes
{
    public class GooPolygonalFace2D : GooGeometry2D<PolygonalFace2D>
    {
        public GooPolygonalFace2D()
            : base()
        {
        }

        public GooPolygonalFace2D(PolygonalFace2D polygonalFace2D)
        {
            Value = polygonalFace2D;
        }

        public override IGH_Goo Duplicate()
        {
            return new GooPolygonalFace2D(Value);
        }

    }

    public class GooPolygonalFace2DParam : GooGeometryParam<PolygonalFace2D>
    {
        public override Guid ComponentGuid => new Guid("0e44ab21-a17b-4b26-94c7-f49a433987c8");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public GooPolygonalFace2DParam()
            : base()
        {
        }
    }
}
