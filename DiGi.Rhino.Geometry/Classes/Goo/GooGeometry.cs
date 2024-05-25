using Grasshopper.Kernel.Types;
using Grasshopper.Kernel;
using System;
using System.Collections.Generic;
using DiGi.Rhino.Core.Interfaces;
using DiGi.Core.Interfaces;
using DiGi.Rhino.Core.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using Rhino;
using Rhino.DocObjects;
using Rhino.Geometry;
using DiGi.Geometry.Core.Interfaces;
using DiGi.Geometry.Planar.Interfaces;
using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Planar.Classes;

namespace DiGi.Rhino.Geometry.Classes
{
    public class GooGeometry<T> : GooSerializableObject<T>, IGH_PreviewData, IGH_BakeAwareData where T : IGeometry
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
                    return Convert.ToRhino(((IBoundable3D)Value).GetBoundingBox());
                }

                if(Value is Point3D)
                {
                    return Convert.ToRhino(new BoundingBox3D((Point3D)(object)Value, DiGi.Core.Constans.Tolerance.Distance));
                }

                if(Value is IBoundable2D)
                {
                    IGeometry3D geometry3D = DiGi.Geometry.Spatial.Query.Convert(DiGi.Geometry.Spatial.Constans.Plane.WorldZ, (IGeometry2D)Value);
                    if(geometry3D is IBoundable3D)
                    {
                        return Convert.ToRhino(((IBoundable3D)geometry3D).GetBoundingBox());
                    }
                }
                else if (Value is Point2D)
                {
                    Point3D point3D = DiGi.Geometry.Spatial.Query.Convert(DiGi.Geometry.Spatial.Constans.Plane.WorldZ, (Point2D)(object)Value);
                    return Convert.ToRhino(new BoundingBox3D(point3D, DiGi.Core.Constans.Tolerance.Distance));
                }

                return BoundingBox.Unset;
            }
        }

        public override IGH_Goo Duplicate()
        {
            return new GooGeometry<T>(Value);
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
                IGeometry3D geometry3D = ((IGH_GeometricGoo)source).ToDiGi();
                if(geometry3D is T)
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
                        @object = Convert.ToDiGi((IGH_GeometricGoo)source);
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
                target = Convert.ToGrasshopper(Value as dynamic);
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

        public bool BakeGeometry(RhinoDoc doc, ObjectAttributes att, out Guid obj_guid)
        {
            throw new NotImplementedException();
        }

        public void DrawViewportWires(GH_PreviewWireArgs args)
        {
            Modify.DrawViewportWires(Value, args, args.Color);
        }

        public void DrawViewportMeshes(GH_PreviewMeshArgs args)
        {
            Modify.DrawViewportMeshes(Value, args, args.Material);
        }
    }

    public abstract class GooGeometryParam<T> : GooPresistentParam<GooGeometry<T>, T>, IGH_PreviewObject, IGH_BakeAwareObject where T : IGeometry
    {
        public override Guid ComponentGuid => new Guid("63680047-20b3-4e89-a085-2add878abb76");

        public BoundingBox ClippingBox => Preview_ComputeClippingBox();

        public bool Hidden { get; set; }

        public bool IsPreviewCapable => !VolatileData.IsEmpty;

        public bool IsBakeCapable => !VolatileData.IsEmpty;

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public GooGeometryParam()
           : base()
        {
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

        protected override GH_GetterResult Prompt_Singular(ref GooGeometry<T> value)
        {
            throw new NotImplementedException();
        }

        protected override GH_GetterResult Prompt_Plural(ref List<GooGeometry<T>> values)
        {
            throw new NotImplementedException();
        }
    }

    public class GooGeometryParam : GooGeometryParam<IGeometry>
    {
        public override Guid ComponentGuid => new Guid("38d1d698-3de7-4537-9175-3b19372718f9");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public GooGeometryParam()
            : base()
        {
        }
    }
}
