using Grasshopper.Kernel.Types;
using Grasshopper.Kernel;
using System;
using System.Collections.Generic;
using DiGi.Geometry.Spatial.Interfaces;
using Rhino.Geometry;
using Rhino.DocObjects;
using Rhino;

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

    public class GooGeometry3DParam : GH_PersistentParam<GooGeometry3D>, IGH_PreviewObject, IGH_BakeAwareObject
    {
        public override Guid ComponentGuid => new Guid("e3385a00-6a5f-4203-9a9d-374652dc7d21");

        public BoundingBox ClippingBox => Preview_ComputeClippingBox();

        public bool Hidden { get; set; }

        public bool IsPreviewCapable => !VolatileData.IsEmpty;

        public bool IsBakeCapable => !VolatileData.IsEmpty;

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public GooGeometry3DParam()
            : base(typeof(IGeometry3D).Name, typeof(IGeometry3D).Name, typeof(IGeometry3D).FullName.Replace(".", " "), "Params", "DiGi")
        {
        }

        protected override GH_GetterResult Prompt_Plural(ref List<GooGeometry3D> values)
        {
            throw new NotImplementedException();
        }

        protected override GH_GetterResult Prompt_Singular(ref GooGeometry3D value)
        {
            throw new NotImplementedException();
        }

        void IGH_PreviewObject.DrawViewportWires(IGH_PreviewArgs args)
        {
            Preview_DrawWires(args);
        }

        void IGH_PreviewObject.DrawViewportMeshes(IGH_PreviewArgs args)
        {
            Preview_DrawMeshes(args);
        }

        public bool BakeGeometry(RhinoDoc doc, ObjectAttributes att, out Guid obj_guid)
        {
            throw new NotImplementedException();
        }

        public void BakeGeometry(RhinoDoc doc, List<Guid> obj_ids)
        {
            throw new NotImplementedException();
        }

        public void BakeGeometry(RhinoDoc doc, ObjectAttributes att, List<Guid> obj_ids)
        {
            throw new NotImplementedException();
        }
    }
}
