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
using DiGi.Geometry.Planar.Interfaces;
using DiGi.Geometry.Planar.Classes;

namespace DiGi.Rhino.Geometry.Core.Classes
{
    public class GooGeometry<T> : GooSerializableObject<T>, IGooGeometry where T : IGeometry
    {
        public GooGeometry()
            : base()
        {
        }

        public GooGeometry(T geometry)
        {
            Value = geometry;
        }

        public virtual BoundingBox ClippingBox
        {
            get
            {
                if (Value is IBoundable3D)
                {
                    return Spatial.Convert.ToRhino(((IBoundable3D)Value).GetBoundingBox());
                }

                if(Value is Point3D)
                {
                    return Spatial.Convert.ToRhino(new BoundingBox3D((Point3D)(object)Value, DiGi.Core.Constans.Tolerance.Distance));
                }

                if(Value is IBoundable2D)
                {
                    IGeometry3D geometry3D = DiGi.Geometry.Spatial.Query.Convert(DiGi.Geometry.Spatial.Constans.Plane.WorldZ, (IGeometry2D)Value);
                    if(geometry3D is IBoundable3D)
                    {
                        return Spatial.Convert.ToRhino(((IBoundable3D)geometry3D).GetBoundingBox());
                    }
                }
                else if (Value is Point2D)
                {
                    Point3D point3D = DiGi.Geometry.Spatial.Query.Convert(DiGi.Geometry.Spatial.Constans.Plane.WorldZ, (Point2D)(object)Value);
                    return Spatial.Convert.ToRhino(new BoundingBox3D(point3D, DiGi.Core.Constans.Tolerance.Distance));
                }

                return BoundingBox.Unset;
            }
        }

        public bool BakeGeometry(RhinoDoc rhinoDoc, ObjectAttributes objectAttributes, out Guid guid)
        {
            guid = Guid.Empty;

            bool result = Spatial.Modify.BakeGeometry(Value, rhinoDoc, objectAttributes, out List<Guid> guids);
            if (guids == null || guids.Count == 0)
            {
                return false;
            }

            guid = guids[0];
            return true;
        }

        public bool BakeGeometry(RhinoDoc rhinoDoc, ObjectAttributes objectAttributes, out List<Guid> guids)
        {
            return Spatial.Modify.BakeGeometry(Value, rhinoDoc, objectAttributes, out guids);
        }

        public override bool CastFrom(object source)
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

            if (source is IGooSerializableObject)
            {
                Value = ((IGooSerializableObject)source).GetValue<T>();
                return true;
            }

            if (source is IGH_GeometricGoo)
            {
                IGeometry3D geometry3D = Spatial.Convert.ToDiGi(((IGH_GeometricGoo)source));
                if (geometry3D is T)
                {
                    Value = (T)geometry3D;
                    return true;
                }
            }

            Type type_Source = source?.GetType();
            if (type_Source != null)
            {
                if (typeof(IGooSerializableObject).IsAssignableFrom(type_Source))
                {
                    ISerializableObject serializableObject = ((IGooSerializableObject)source).GetValue<ISerializableObject>();
                    if (serializableObject is T)
                    {
                        Value = (T)serializableObject;
                    }

                    return true;
                }

                if (typeof(IGH_Goo).IsAssignableFrom(type_Source))
                {
                    object @object = null;
                    if (typeof(IGH_GeometricGoo).IsAssignableFrom(type_Source))
                    {
                        @object = Spatial.Convert.ToDiGi((IGH_GeometricGoo)source);
                    }
                    else
                    {
                        @object = (source as dynamic).Value;
                    }

                    if (@object is T)
                    {
                        Value = (T)@object;
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
                target = (Y)(object)Value;
                return true;
            }

            if (typeof(Y) == typeof(object))
            {
                target = (Y)(object)Value;
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
                        target = (Y)(object)Value.Clone();
                    }
                    else
                    {
                        target = DiGi.Core.Create.Object<Y>(Value);
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
            Spatial.Modify.DrawViewportMeshes(Value, args, args.Material);
        }

        public void DrawViewportWires(GH_PreviewWireArgs args)
        {
            Spatial.Modify.DrawViewportWires(Value, args, args.Color);
        }

        public override IGH_Goo Duplicate()
        {
            return new GooGeometry<T>(Value);
        }
    }

    public abstract class GooGeometryParam<T> : GooPresistentParam<GooGeometry<T>, T>, IGH_PreviewObject, IGH_BakeAwareObject where T : IGeometry
    {
        public GooGeometryParam()
           : base()
        {
        }

        public BoundingBox ClippingBox => Preview_ComputeClippingBox();
        
        public override Guid ComponentGuid => new Guid("63680047-20b3-4e89-a085-2add878abb76");
        
        public bool Hidden { get; set; }

        public bool IsBakeCapable => !VolatileData.IsEmpty;
        
        public bool IsPreviewCapable => !VolatileData.IsEmpty;
        
        public void BakeGeometry(RhinoDoc rhinoDoc, List<Guid> guids)
        {
            BakeGeometry(rhinoDoc, rhinoDoc?.CreateDefaultAttributes(), guids);
        }

        public void BakeGeometry(RhinoDoc rhinoDoc, ObjectAttributes objectAttributes, List<Guid> guids)
        {
            if (rhinoDoc == null)
            {
                return;
            }

            if (guids == null)
            {
                guids = new List<Guid>();
            }

            foreach (var value in VolatileData.AllData(true))
            {
                IGH_BakeAwareData gH_BakeAwareData = value as IGH_BakeAwareData;
                if (gH_BakeAwareData == null)
                {
                    continue;
                }

                if(gH_BakeAwareData is IGooGeometry)
                {
                    if(((IGooGeometry)gH_BakeAwareData).BakeGeometry(rhinoDoc, objectAttributes, out List<Guid> guids_Temp) && guids_Temp != null)
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

        public override Guid ComponentGuid => new Guid("38d1d698-3de7-4537-9175-3b19372718f9");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;
    }
}
