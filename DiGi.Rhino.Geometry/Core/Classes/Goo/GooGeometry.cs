using Grasshopper.Kernel.Types;
using Grasshopper.Kernel;
using System;
using System.Collections.Generic;
using DiGi.Rhino.Core.Interfaces;
using DiGi.Core.Interfaces;
using DiGi.Rhino.Core.Classes;
using Rhino;
using Rhino.DocObjects;
using Rhino.Geometry;
using DiGi.Rhino.Geometry.Core.Interfaces;
using DiGi.Geometry.Core.Interfaces;
using DiGi.Geometry.Spatial.Interfaces;
using DiGi.Geometry.Spatial.Classes;
using DiGi.Rhino.Geometry.Spatial;

namespace DiGi.Rhino.Geometry.Core.Classes
{
    public class GooGeometry<T> : GooSerializableObject<T>, IGooGeometry where T : IGeometry
    {
        public GooGeometry()
            : base()
        {
        }

        public GooGeometry(T? geometry)
        {
            Value = geometry;
        }

        public virtual BoundingBox ClippingBox
        {
            get
            {
                return Create.BoundingBox(Value);
            }
        }

        public bool BakeGeometry(RhinoDoc rhinoDoc, ObjectAttributes objectAttributes, out Guid guid)
        {
            guid = Guid.Empty;

            bool result = Modify.BakeGeometry(Value, rhinoDoc, objectAttributes, out List<Guid>? guids);
            if (guids != null && guids.Count == 0)
            {
                guid = guids[0];
            }

            return result;
        }

        public bool BakeGeometry(RhinoDoc? rhinoDoc, ObjectAttributes? objectAttributes, out List<Guid>? guids)
        {
            return Modify.BakeGeometry(Value, rhinoDoc, objectAttributes, out guids);
        }

        public override bool CastFrom(object? source)
        {
            if (source == null)
            {
                return false;
            }

            if (source is T)
            {
                Value = (T)(object)source;
                return true;
            }

            if (source is IGooSerializableObject gooSerializableObject)
            {
                Value = gooSerializableObject.GetValue<T>();
                return true;
            }

            if (source is IGH_GeometricGoo gH_GeometricGoo)
            {
                IGeometry3D? geometry3D = Spatial.Convert.ToDiGi(gH_GeometricGoo);
                if (geometry3D is T t)
                {
                    Value = t;
                    return true;
                }
            }

            Type? type_Source = source?.GetType();
            if (type_Source != null)
            {
                if (typeof(IGooSerializableObject).IsAssignableFrom(type_Source))
                {
                    ISerializableObject? serializableObject = ((IGooSerializableObject)source!).GetValue<ISerializableObject>();
                    if (serializableObject is T t)
                    {
                        Value = t;
                    }

                    return true;
                }

                if (typeof(IGH_Goo).IsAssignableFrom(type_Source))
                {
                    object? @object = null;
                    if (typeof(IGH_GeometricGoo).IsAssignableFrom(type_Source))
                    {
                        @object = Spatial.Convert.ToDiGi((IGH_GeometricGoo)source!);
                    }
                    if(typeof(GH_Vector).IsAssignableFrom(type_Source))
                    {
                        GH_Vector gH_Vector = (GH_Vector)source!;
                        if (typeof(T).IsAssignableFrom(typeof(Vector3D)))
                        {
                            if((T?)(object?)gH_Vector.Value.ToDiGi() is T t_Temp)
                            {
                                Value = t_Temp;
                                return true;
                            }
                        }
                    }
                    else
                    {
                        @object = ((dynamic)source!).Value;
                    }

                    if (@object is T t)
                    {
                        Value = t;
                        return true;
                    }
                }
            }

            return base.CastFrom(source);
        }

        public override bool CastTo<Y>(ref Y target)
        {
            if (typeof(Y) == typeof(T))
            {
                target = (Y)(object)Value!;
                return true;
            }

            if (typeof(Y) == typeof(object))
            {
                target = (Y)(object)Value!;
                return true;
            }

            if (typeof(GH_ObjectWrapper) == typeof(Y))
            {
                target = (Y)(object)(new GH_ObjectWrapper(Value));
                return true;
            }

            if (typeof(IGH_GeometricGoo).IsAssignableFrom(typeof(Y)))
            {
                target = Spatial.Convert.ToGrasshopper(Value as dynamic);
                return true;
            }

            try
            {
                if (Value != null)
                {
                    if (typeof(Y).IsAssignableFrom(Value.GetType()))
                    {
                        if((Y?)(object?)Value.Clone() is Y y)
                        {
                            target = y;
                        }
                    }
                    else
                    {
                        if(DiGi.Core.Create.Object<Y>(Value) is Y y)
                        {
                            target = y;
                        }
                    }

                    if (target != null)
                    {
                        return true;
                    }
                }
            }
            catch
            {

            }

            return base.CastTo(ref target);
        }

        public void DrawViewportMeshes(GH_PreviewMeshArgs args)
        {
            Modify.DrawViewportMeshes(Value, args, args.Material);
        }

        public void DrawViewportWires(GH_PreviewWireArgs args)
        {
            Modify.DrawViewportWires(Value, args, args.Color);
        }

        public override IGH_Goo Duplicate()
        {
            return new GooGeometry<T>(Value);
        }
    }

    public class GooGeometryParam<T> : GooPresistentParam<GooGeometry<T>, T>, IGooGeometryParam where T : IGeometry
    {
        public GooGeometryParam()
           : base()
        {
        }

        public BoundingBox ClippingBox => Preview_ComputeClippingBox();
        
        public override Guid ComponentGuid => new ("63680047-20b3-4e89-a085-2add878abb76");
        
        public bool Hidden { get; set; }

        public bool IsBakeCapable => !VolatileData.IsEmpty;
        
        public bool IsPreviewCapable => !VolatileData.IsEmpty;
        
        public void BakeGeometry(RhinoDoc rhinoDoc, List<Guid> guids)
        {
            BakeGeometry(rhinoDoc, rhinoDoc?.CreateDefaultAttributes(), guids);
        }

        public void BakeGeometry(RhinoDoc? rhinoDoc, ObjectAttributes? objectAttributes, List<Guid>? guids)
        {
            if (rhinoDoc == null)
            {
                return;
            }

            guids ??= [];

            foreach (var value in VolatileData.AllData(true))
            {
                if (value is not IGH_BakeAwareData gH_BakeAwareData)
                {
                    continue;
                }

                if (gH_BakeAwareData is IGooGeometry gooGeometry)
                {
                    if(gooGeometry.BakeGeometry(rhinoDoc, objectAttributes, out List<Guid>? guids_Temp) && guids_Temp != null)
                    {
                        guids.AddRange(guids_Temp);
                    }

                    continue;
                }

                if (!gH_BakeAwareData.BakeGeometry(rhinoDoc, objectAttributes, out Guid guid))
                {
                    continue;
                }

                guids.Add(guid);
            }
        }

        void IGH_PreviewObject.DrawViewportMeshes(IGH_PreviewArgs args)
        {
            Preview_DrawMeshes(args);
        }

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;
        void IGH_PreviewObject.DrawViewportWires(IGH_PreviewArgs args)
        {
            Preview_DrawWires(args);
        }

        protected override GH_GetterResult Prompt_Plural(ref List<GooGeometry<T>> values)
        {
            throw new NotImplementedException();
        }

        protected override GH_GetterResult Prompt_Singular(ref GooGeometry<T> value)
        {
            throw new NotImplementedException();
        }
    }

    public class GooGeometryParam : GooGeometryParam<IGeometry>
    {
        public GooGeometryParam()
            : base()
        {
        }

        public override Guid ComponentGuid => new ("38d1d698-3de7-4537-9175-3b19372718f9");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;
    }
}
