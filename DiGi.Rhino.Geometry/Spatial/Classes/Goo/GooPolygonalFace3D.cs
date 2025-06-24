using DiGi.Geometry.Spatial.Interfaces;
using DiGi.Rhino.Geometry.Core.Classes;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.Rhino.Geometry.Spatial.Classes
{
    public class GooPolygonalFace3D : GooGeometry3D<IPolygonalFace3D>
    {
        public GooPolygonalFace3D()
            : base()
        {
        }

        public GooPolygonalFace3D(IPolygonalFace3D polygonalFace3D)
        {
            Value = polygonalFace3D;
        }

        public GooPolygonalFace3D(GooPolygonalFace3D gooPolygonalFace3D)
        {
            Value = gooPolygonalFace3D?.Value;
        }

        public override IGH_Goo Duplicate()
        {
            return new GooPolygonalFace3D(this);
        }

    }

    public class GooPolygonalFace3DParam : GooGeometryParam<IPolygonalFace3D>
    {
        public override Guid ComponentGuid => new Guid("81f5aaec-0abd-470f-93b0-13cdce5aeb34");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public GooPolygonalFace3DParam()
            : base()
        {
        }
    }
}