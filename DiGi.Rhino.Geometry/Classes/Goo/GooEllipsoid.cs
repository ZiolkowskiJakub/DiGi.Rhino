using Grasshopper.Kernel.Types;
using System;

namespace DiGi.Rhino.Geometry.Classes
{
    public class GooEllipsoid : GooGeometry3D<DiGi.Geometry.Spatial.Classes.Ellipsoid>
    {
        public GooEllipsoid()
            : base()
        {
        }

        public GooEllipsoid(DiGi.Geometry.Spatial.Classes.Ellipsoid ellipsoid)
        {
            Value = ellipsoid;
        }

        public override IGH_Goo Duplicate()
        {
            return new GooEllipsoid(Value);
        }
    }

    public class GooEllipsoidParam : GooGeometryParam<DiGi.Geometry.Spatial.Classes.Ellipsoid>
    {
        public override Guid ComponentGuid => new Guid("528cbdfc-6142-4856-9eab-38c9a20dadbc");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public GooEllipsoidParam()
            : base()
        {
        }
    }
}
