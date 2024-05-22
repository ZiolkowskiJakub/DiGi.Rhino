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

    public abstract class GooGeometry2DParam<T> : GH_PersistentParam<GooGeometry2D<T>> where T : IGeometry2D
    {
        public override Guid ComponentGuid => new Guid("6e75e25e-c691-4cc3-868b-50e722a36bea");
        
        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public GooGeometry2DParam()
           : base(typeof(T).Name, typeof(T).Name, typeof(T).FullName.Replace(".", " "), "Params", "DiGi")
        {
        }

        protected override GH_GetterResult Prompt_Plural(ref List<GooGeometry2D<T>> values)
        {
            throw new NotImplementedException();
        }

        protected override GH_GetterResult Prompt_Singular(ref GooGeometry2D<T> value)
        {
            throw new NotImplementedException();
        }
    }

    public class GooGeometry2DParam : GooGeometry2DParam<IGeometry2D>
    {
        public override Guid ComponentGuid => new Guid("db40a120-61d3-4eb4-9bd4-df62ebfb0c48");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public GooGeometry2DParam()
            : base()
        {
        }

        protected override GH_GetterResult Prompt_Plural(ref List<GooGeometry2D<IGeometry2D>> values)
        {
            throw new NotImplementedException();
        }

        protected override GH_GetterResult Prompt_Singular(ref GooGeometry2D<IGeometry2D> value)
        {
            throw new NotImplementedException();
        }
    }
}
