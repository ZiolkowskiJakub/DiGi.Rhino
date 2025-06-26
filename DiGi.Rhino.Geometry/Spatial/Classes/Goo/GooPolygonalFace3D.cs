using DiGi.Geometry.Spatial.Interfaces;
using DiGi.Rhino.Geometry.Core.Classes;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.Rhino.Geometry.Spatial.Classes
{
    public class GooPolygonal3D : GooGeometry3D<IPolygonal3D>
    {
        public GooPolygonal3D()
            : base()
        {
        }

        public GooPolygonal3D(IPolygonal3D polygonal3D)
        {
            Value = polygonal3D;
        }

        public GooPolygonal3D(GooPolygonal3D gooPolygonal3D)
        {
            Value = gooPolygonal3D?.Value;
        }

        public override IGH_Goo Duplicate()
        {
            return new GooPolygonal3D(this);
        }

    }

    public class GooPolygonal3DParam : GooGeometryParam<IPolygonal3D>
    {
        public override Guid ComponentGuid => new Guid("b1999ae8-dd6d-450e-8080-286119574b29");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public GooPolygonal3DParam()
            : base()
        {
        }
    }
}