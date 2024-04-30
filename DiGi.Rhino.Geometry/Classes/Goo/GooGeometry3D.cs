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

namespace DiGi.Rhino.Geometry.Classes
{
    public class GooGeometry3D<T> : GooSerializableObject<T>, IGH_PreviewData, IGH_BakeAwareData where T : IGeometry3D
    {
        public GooGeometry3D()
            : base()
        {
        }

        public GooGeometry3D(T geometry3D)
        {
            Value = geometry3D;
        }

        public BoundingBox ClippingBox
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
            return new GooGeometry3D<T>(Value);
        }

        public override bool CastFrom(object source)
        {
            if (source == null)
                return false;

            if (source is T)
            {
                Value = (T)(object)source;
                return true;
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

    public class GooGeometry3DParam<T> : GH_PersistentParam<GooGeometry3D<T>> where T : IGeometry3D
    {
        public override Guid ComponentGuid => new Guid("6498e8f7-9c0d-41f9-84f9-990877b2c987");
        
        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public GooGeometry3DParam()
           : base(typeof(T).Name, typeof(T).Name, typeof(T).FullName.Replace(".", " "), "Params", "DiGi")
        {
        }

        protected override GH_GetterResult Prompt_Plural(ref List<GooGeometry3D<T>> values)
        {
            throw new NotImplementedException();
        }

        protected override GH_GetterResult Prompt_Singular(ref GooGeometry3D<T> value)
        {
            throw new NotImplementedException();
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

        public override bool CastFrom(object source)
        {
            if(source is IGooSerializableObject)
            {
                Value = ((IGooSerializableObject)source).GetValue<IGeometry3D>();
                return true;
            }
            else if(source is IGH_GeometricGoo)
            {
                Value = ((IGH_GeometricGoo)source).ToDiGi();
                return true;
            }

            return base.CastFrom(source);
        }

        public override bool CastTo<Y>(ref Y target)
        {

            if (typeof(IGH_GeometricGoo).IsAssignableFrom(typeof(Y)))
            {
                target = Convert.ToGrasshopper(Value as dynamic);
                return true;
            }

            return base.CastTo(ref target);
        }
    }

    public class GooGeometry3DParam : GH_PersistentParam<GooGeometry3D>
    {
        public override Guid ComponentGuid => new Guid("e3385a00-6a5f-4203-9a9d-374652dc7d21");

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
    }
}
