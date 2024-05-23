using Grasshopper.Kernel.Types;
using Grasshopper.Kernel;
using System;
using System.Collections.Generic;
using DiGi.Geometry.Planar.Interfaces;

namespace DiGi.Rhino.Geometry.Classes
{
    public class GooGeometry2D<T> : GooGeometry<T> where T : IGeometry2D
    {
        public GooGeometry2D()
            : base()
        {
        }

        public GooGeometry2D(T geometry2D)
        {
            Value = geometry2D;
        }

        public override IGH_Goo Duplicate()
        {
            return new GooGeometry2D<T>(Value);
        }
    }

    public class GooGeometry2D : GooGeometry2D<IGeometry2D>
    {
        public GooGeometry2D()
            : base()
        {
        }

        public GooGeometry2D(IGeometry2D geometry2D)
        {
            Value = geometry2D;
        }

        public override IGH_Goo Duplicate()
        {
            return new GooGeometry2D(Value);
        }

    }

    public class GooGeometry2DParam : GooGeometryParam<IGeometry2D>
    {
        public override Guid ComponentGuid => new Guid("b058cbef-083c-4093-a53a-d6e4d913f662");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public GooGeometry2DParam()
            : base()
        {
        }

        protected override GH_GetterResult Prompt_Plural(ref List<GooGeometry<IGeometry2D>> values)
        {
            throw new NotImplementedException();
        }

        protected override GH_GetterResult Prompt_Singular(ref GooGeometry<IGeometry2D> value)
        {
            throw new NotImplementedException();
        }
    }
}
