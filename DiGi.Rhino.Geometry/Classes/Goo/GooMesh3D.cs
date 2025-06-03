using DiGi.Geometry.Spatial.Classes;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.Rhino.Geometry.Classes
{
    public class GooMesh3D : GooGeometry3D<Mesh3D>
    {
        public GooMesh3D()
            : base()
        {
        }

        public GooMesh3D(Mesh3D mesh3D)
        {
            Value = mesh3D;
        }

        public override IGH_Goo Duplicate()
        {
            return new GooMesh3D(Value);
        }
    }

    public class GooMesh3DParam : GooGeometryParam<Mesh3D>
    {
        public override Guid ComponentGuid => new Guid("ec6450c0-08fd-4959-be9b-647687d61980");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public GooMesh3DParam()
            : base()
        {
        }
    }
}
