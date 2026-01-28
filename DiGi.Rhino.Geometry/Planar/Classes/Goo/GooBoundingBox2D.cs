using DiGi.Geometry.Planar.Classes;
using DiGi.Rhino.Geometry.Core.Classes;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.Rhino.Geometry.Planar.Classes
{
    public class GooBoundingBox2D : GooGeometry2D<BoundingBox2D>
    {
        public GooBoundingBox2D()
            : base()
        {
        }

        public GooBoundingBox2D(BoundingBox2D? boundingBox2D)
        {
            Value = boundingBox2D;
        }

        public GooBoundingBox2D(GooBoundingBox2D? gooBoundingBox2D)
        {
            Value = gooBoundingBox2D?.Value;
        }

        public override IGH_Goo Duplicate()
        {
            return new GooBoundingBox2D(this);
        }
    }

    public class GooBoundingBox2DParam : GooGeometryParam<BoundingBox2D>
    {
        public GooBoundingBox2DParam()
            : base()
        {
        }

        public override Guid ComponentGuid => new("f0734aef-47d6-4c0e-a10f-cc2761fd7289");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;
    }
}