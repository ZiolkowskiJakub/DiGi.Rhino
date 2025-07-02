using DiGi.Geometry.Planar.Interfaces;
using DiGi.Rhino.Geometry.Core.Classes;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.Rhino.Geometry.Planar.Classes
{
    public class GooPolygonal2D : GooGeometry2D<IPolygonal2D>
    {
        public GooPolygonal2D()
            : base()
        {
        }

        public GooPolygonal2D(IPolygonal2D polygonal2D)
        {
            Value = polygonal2D;
        }

        public override IGH_Goo Duplicate()
        {
            return new GooPolygonal2D(Value);
        }

    }

    public class GooPolygonal2DParam : GooGeometryParam<IPolygonal2D>
    {
        public override Guid ComponentGuid => new Guid("8da7aab4-6b42-4a22-90ad-48e94329f8aa");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public GooPolygonal2DParam()
            : base()
        {
        }
    }
}

