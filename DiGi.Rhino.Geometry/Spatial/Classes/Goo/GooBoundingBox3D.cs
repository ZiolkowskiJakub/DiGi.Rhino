using DiGi.Geometry.Spatial.Classes;
using DiGi.Rhino.Geometry.Core.Classes;
using DiGi.Rhino.Geometry.Spatial.Classes;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.Rhino.Geometry.Planar.Classes
{
    public class GooBoundingBox3D : GooGeometry3D<BoundingBox3D>
    {
        public GooBoundingBox3D()
            : base()
        {
        }

        public GooBoundingBox3D(BoundingBox3D boundingBox3D)
        {
            Value = boundingBox3D;
        }

        public GooBoundingBox3D(GooBoundingBox3D gooBoundingBox3D)
        {
            Value = gooBoundingBox3D?.Value;
        }

        public override IGH_Goo Duplicate()
        {
            return new GooBoundingBox3D(this);
        }

    }

    public class GooBoundingBox3DParam : GooGeometryParam<BoundingBox3D>
    {
        public override Guid ComponentGuid => new Guid("c683dd64-31fd-4363-8c26-8328aaea8d55");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public GooBoundingBox3DParam()
            : base()
        {
        }
    }
}
