using DiGi.Geometry.Spatial.Classes;
using DiGi.Rhino.Geometry.Core.Classes;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.Rhino.Geometry.Spatial.Classes
{
    public class GooPlane : GooGeometry3D<Plane>
    {
        public GooPlane()
            : base()
        {
        }

        public GooPlane(Plane plane)
        {
            Value = plane;
        }

        public override IGH_Goo Duplicate()
        {
            return new GooPlane(Value);
        }
    }

    public class GooPlaneParam : GooGeometryParam<Plane>
    {
        public override Guid ComponentGuid => new Guid("3c36ec41-1560-4ec9-93cc-01bc990f5486");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public GooPlaneParam()
            : base()
        {
        }
    }
}
