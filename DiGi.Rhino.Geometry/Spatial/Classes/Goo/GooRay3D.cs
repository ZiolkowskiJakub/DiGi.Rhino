using DiGi.Geometry.Spatial.Classes;
using DiGi.Rhino.Geometry.Core.Classes;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.Rhino.Geometry.Spatial.Classes
{
    public class GooRay3D : GooGeometry3D<Ray3D>
    {
        public GooRay3D()
            : base()
        {
        }

        public GooRay3D(Ray3D? ray3D)
        {
            Value = ray3D;
        }

        public override IGH_Goo Duplicate()
        {
            return new GooRay3D(Value);
        }
    }

    public class GooRay3DParam : GooGeometryParam<Ray3D>
    {
        public override Guid ComponentGuid => new ("2977f462-45d4-4ec0-8152-83f5800ef328");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public GooRay3DParam()
            : base()
        {
        }
    }
}
