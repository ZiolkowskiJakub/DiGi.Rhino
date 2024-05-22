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

    public abstract class GooGeometryParam<T> : GH_PersistentParam<GooGeometry<T>> where T : IGeometry
    {
        public override Guid ComponentGuid => new Guid("63680047-20b3-4e89-a085-2add878abb76");
        
        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public GooGeometryParam()
           : base(typeof(T).Name, typeof(T).Name, typeof(T).FullName.Replace(".", " "), "Params", "DiGi")
        {
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

    public class GooGeometryParam : GooGeometryParam<IGeometry>, IGH_PreviewObject, IGH_BakeAwareObject
    {
        public override Guid ComponentGuid => new Guid("38d1d698-3de7-4537-9175-3b19372718f9");

        public BoundingBox ClippingBox => Preview_ComputeClippingBox();

        public bool Hidden { get; set; }

        public bool IsPreviewCapable => !VolatileData.IsEmpty;

        public bool IsBakeCapable => !VolatileData.IsEmpty;

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public GooGeometryParam()
            : base()
        {
        }

        protected override GH_GetterResult Prompt_Plural(ref List<GooGeometry<IGeometry>> values)
        {
            throw new NotImplementedException();
        }

        protected override GH_GetterResult Prompt_Singular(ref GooGeometry<IGeometry> value)
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
