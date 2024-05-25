using Grasshopper.Kernel.Types;
using System;
using DiGi.Geometry.Spatial.Interfaces;

namespace DiGi.Rhino.Geometry.Classes
{
    public class GooGeometry3D<T> : GooGeometry<T> where T : IGeometry3D
    {
        public GooGeometry3D()
            : base()
        {
        }

        public GooGeometry3D(T geometry3D)
        {
            Value = geometry3D;
        }

        public override IGH_Goo Duplicate()
        {
            return new GooGeometry3D<T>(Value);
        }
    }

    public class GooGeometry3D : GooGeometry3D<IGeometry3D>
    {
        public GooGeometry3D()
            : base()
        {
        }

        public GooGeometry3D(IGeometry3D geometry3D)
        {
            Value = geometry3D;
        }

        public override IGH_Goo Duplicate()
        {
            return new GooGeometry3D(Value);
        }

    }

    public class GooGeometry3DParam : GooGeometryParam<IGeometry3D>
    {
        public override Guid ComponentGuid => new Guid("e3385a00-6a5f-4203-9a9d-374652dc7d21");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public GooGeometry3DParam()
            : base()
        {
        }
    }
}
