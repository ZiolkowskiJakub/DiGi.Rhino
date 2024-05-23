using Grasshopper.Kernel.Types;
using Grasshopper.Kernel;
using System;
using System.Collections.Generic;
using DiGi.Geometry.Spatial.Classes;

namespace DiGi.Rhino.Geometry.Classes
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

        protected override GH_GetterResult Prompt_Plural(ref List<GooGeometry<Plane>> values)
        {
            throw new NotImplementedException();
        }

        protected override GH_GetterResult Prompt_Singular(ref GooGeometry<Plane> value)
        {
            throw new NotImplementedException();
        }
    }
}
