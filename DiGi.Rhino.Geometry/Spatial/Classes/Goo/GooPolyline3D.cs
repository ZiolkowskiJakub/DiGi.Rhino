using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using DiGi.Rhino.Geometry.Core.Classes;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.Rhino.Geometry.Spatial.Classes
{
    public class GooPolyline3D : GooGeometry3D<Polyline3D>
    {
        public GooPolyline3D()
            : base()
        {
        }

        public GooPolyline3D(Polyline3D polyline3D)
        {
            Value = polyline3D;
        }

        public GooPolyline3D(GooPolyline3D gooPolyline3D)
        {
            Value = gooPolyline3D?.Value;
        }

        public override IGH_Goo Duplicate()
        {
            return new GooPolyline3D(this);
        }

    }

    public class GooPolyline3DParam : GooGeometryParam<IPolygonalFace3D>
    {
        public override Guid ComponentGuid => new Guid("9e97b291-662d-4bdf-9ae7-d87427470db3");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public GooPolyline3DParam()
            : base()
        {
        }
    }
}