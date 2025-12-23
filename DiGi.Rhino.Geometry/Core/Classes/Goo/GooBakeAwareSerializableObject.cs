using DiGi.Core.Interfaces;
using DiGi.Geometry.Core.Interfaces;
using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Geometry.Core.Interfaces;
using Grasshopper.Kernel;
using Rhino;
using Rhino.DocObjects;
using Rhino.Geometry;
using System;
using System.Collections.Generic;

namespace DiGi.Rhino.Geometry.Core.Classes
{
    public abstract class GooBakeAwareSerializableObject<TSerializableObject> : GooSerializableObject<TSerializableObject>, IGooBakeAwareSerializableObject where TSerializableObject : ISerializableObject
    {
        public GooBakeAwareSerializableObject()
            : base()
        {
        }

        public GooBakeAwareSerializableObject(TSerializableObject? geometry)
        {
            Value = geometry;
        }

        public virtual BoundingBox ClippingBox
        {
            get
            {
                return Spatial.Create.BoundingBox(Geometries);
            }
        }

        public abstract IGeometry[]? Geometries { get; }

        public virtual bool BakeGeometry(RhinoDoc? rhinoDoc, ObjectAttributes? objectAttributes, out Guid guid)
        {
            guid = Guid.Empty;

            bool result = Spatial.Modify.BakeGeometry(Geometries, rhinoDoc, objectAttributes, out List<Guid>? guids);
            if (guids != null && guids.Count != 0)
            {
                guid = guids[0];
            }


            return result;
        }

        public virtual bool BakeGeometry(RhinoDoc? rhinoDoc, ObjectAttributes? objectAttributes, out List<Guid>? guids)
        {
            return Spatial.Modify.BakeGeometry(Geometries, rhinoDoc, objectAttributes, out guids);
        }

        public void DrawViewportMeshes(GH_PreviewMeshArgs? args)
        {
            Spatial.Modify.DrawViewportMeshes(Geometries, args, args?.Material);
        }

        public void DrawViewportWires(GH_PreviewWireArgs? args)
        {
            Spatial.Modify.DrawViewportWires(Geometries, args, args == null ? System.Drawing.Color.Empty : args.Color);
        }
    }

    public class GooBakeAwareSerializableParam<X, T> : GooSerializablePresistentParam<X, T>, IGooBakeAwareParam where T : ISerializableObject where X : GooBakeAwareSerializableObject<T>
    {
        public GooBakeAwareSerializableParam()
           : base()
        {
        }

        public virtual BoundingBox ClippingBox => Preview_ComputeClippingBox();

        public virtual bool Hidden { get; set; }

        public virtual bool IsBakeCapable => !VolatileData.IsEmpty;

        public virtual bool IsPreviewCapable => !VolatileData.IsEmpty;

        public virtual void BakeGeometry(RhinoDoc rhinoDoc, List<Guid> guids)
        {
            BakeGeometry(rhinoDoc, rhinoDoc?.CreateDefaultAttributes(), guids);
        }

        public virtual void BakeGeometry(RhinoDoc? rhinoDoc, ObjectAttributes? objectAttributes, List<Guid>? guids)
        {
            if (rhinoDoc == null)
            {
                return;
            }

            guids ??= [];

            foreach (var value in VolatileData.AllData(true))
            {
                if (value is not IGooBakeAwareSerializableObject gooBakeAwareSerializableObject)
                {
                    continue;
                }

                if (!gooBakeAwareSerializableObject.BakeGeometry(rhinoDoc, objectAttributes, out List<Guid>? guids_Temp) || guids_Temp == null)
                {
                    continue;
                }

                guids.AddRange(guids_Temp);
            }
        }

        public virtual void DrawViewportMeshes(IGH_PreviewArgs args)
        {
            Preview_DrawMeshes(args);
        }

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;
        public virtual void DrawViewportWires(IGH_PreviewArgs args)
        {
            Preview_DrawWires(args);
        }
    }
}
