using DiGi.Geometry.Spatial.Classes;
using DiGi.Rhino.Geometry.Core.Classes;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.Rhino.Geometry.Spatial.Classes
{
    public class GooSegment3D : GooGeometry3D<Segment3D>
    {
        public GooSegment3D()
            : base()
        {
        }

        public GooSegment3D(Segment3D segment3D)
        {
            Value = segment3D;
        }

        public override IGH_Goo Duplicate()
        {
            return new GooSegment3D(Value);
        }
    }

    public class GooSegment3DParam : GooGeometryParam<Segment3D>
    {
        public override Guid ComponentGuid => new Guid("93c88362-a263-4807-9d71-11dd09d334a5");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public GooSegment3DParam()
            : base()
        {
        }
    }
}
