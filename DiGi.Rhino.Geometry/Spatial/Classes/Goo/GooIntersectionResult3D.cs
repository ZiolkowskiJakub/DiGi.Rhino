using DiGi.Geometry.Core.Interfaces;
using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using DiGi.Rhino.Geometry.Core.Classes;
using Grasshopper.Kernel.Types;
using System;
using System.Linq;

namespace DiGi.Rhino.Geometry.Spatial.Classes
{
    /// <summary>
    /// Represents a Grasshopper Goo wrapper for the <see cref="IntersectionResult3D"/> class, 
    /// providing serialization and bake-aware capabilities.
    /// </summary>
    public class GooIntersectionResult3D : GooBakeAwareSerializableObject<IntersectionResult3D>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GooIntersectionResult3D"/> class.
        /// </summary>
        public GooIntersectionResult3D()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GooIntersectionResult3D"/> class with the specified intersection result.
        /// </summary>
        /// <param name="intersectionResult3D">The 3D intersection result to wrap.</param>
        public GooIntersectionResult3D(IntersectionResult3D? intersectionResult3D)
            : base()
        {
            Value = intersectionResult3D;
        }

        /// <summary>
        /// Gets the collection of geometries associated with the 3D intersection result.
        /// </summary>
        /// <returns>An array of <see cref="IGeometry"/> objects, or null if no value exists.</returns>
        public override IGeometry[]? Geometries
        {
            get
            {
                return Value?.GetGeometry3Ds<IGeometry3D>()?.Cast<IGeometry>()?.ToArray();
            }
        }

        /// <summary>
        /// Attempts to cast the specified source object to a <see cref="GooIntersectionResult3D"/>.
        /// </summary>
        /// <param name="source">The object to cast from.</param>
        /// <returns>True if the cast was successful; otherwise, false.</returns>
        public override bool CastFrom(object? source)
        {
            if (source == null)
            {
                return false;
            }

            return base.CastFrom(source);
        }

        /// <summary>
        /// Attempts to cast the wrapped value to a target type <typeparamref name="Y"/>.
        /// </summary>
        /// <typeparam name="Y">The target type for the cast.</typeparam>
        /// <param name="target">A reference to the target variable where the result will be stored.</param>
        /// <returns>True if the cast was successful; otherwise, false.</returns>
        public override bool CastTo<Y>(ref Y target)
        {
            if (target is null)
            {
                return base.CastTo(ref target);
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
                target = Convert.ToGrasshopper(Value as dynamic);
                return true;
            }

            try
            {
                if (Value != null)
                {
                    if (typeof(Y).IsAssignableFrom(Value.GetType()))
                    {
                        if ((Y?)(object?)Value.Clone() is Y y)
                        {
                            target = y;
                        }
                    }
                    else
                    {
                        if (DiGi.Core.Create.Object<Y>(Value) is Y y)
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

        /// <summary>
        /// Creates a duplicate of the current <see cref="GooIntersectionResult3D"/> instance.
        /// </summary>
        /// <returns>A new <see cref="IGH_Goo"/> object containing a copy of the value.</returns>
        public override IGH_Goo Duplicate()
        {
            return new GooIntersectionResult3D(Value);
        }
    }

    /// <summary>
    /// Represents the Grasshopper parameter type for <see cref="GooIntersectionResult3D"/>.
    /// </summary>
    public class GooIntersectionResult3DParam : GooBakeAwareSerializableParam<GooIntersectionResult3D, IntersectionResult3D>
    {
        /// <summary>
        /// Gets the unique identifier for the component.
        /// </summary>
        public override Guid ComponentGuid => new("9e9f7879-bd95-46b5-b0e2-4a05b6c12af1");
    }

    //public class GooIntersectionResult3D : GooSerializableObject<IntersectionResult3D>, IGooBakeAware
    //{
    //    public GooIntersectionResult3D()
    //        : base()
    //    {
    //    }

    //    public GooIntersectionResult3D(IntersectionResult3D intersectionResult3D)
    //    {
    //        Value = intersectionResult3D;
    //    }

    //    public virtual BoundingBox ClippingBox
    //    {
    //        get
    //        {
    //            return Create.BoundingBox(Value);
    //        }
    //    }

    //    public bool BakeGeometry(RhinoDoc rhinoDoc, ObjectAttributes objectAttributes, out Guid guid)
    //    {
    //        guid = Guid.Empty;

    //        bool result = Modify.BakeGeometry(Value, rhinoDoc, objectAttributes, out List<Guid> guids);
    //        if (guids == null || guids.Count == 0)
    //        {
    //            return false;
    //        }

    //        guid = guids[0];
    //        return true;
    //    }

    //    public bool BakeGeometry(RhinoDoc rhinoDoc, ObjectAttributes objectAttributes, out List<Guid> guids)
    //    {
    //        return Modify.BakeGeometry(Value, rhinoDoc, objectAttributes, out guids);
    //    }

    //    public override bool CastFrom(object source)
    //    {
    //        if (source == null)
    //        {
    //            return false;
    //        }

    //        return base.CastFrom(source);
    //    }

    //    public override bool CastTo<Y>(ref Y target)
    //    {
    //        if (typeof(Y) == typeof(object))
    //        {
    //            target = (Y)(object)Value;
    //            return true;
        //    }

    //        if (typeof(GH_ObjectWrapper) == typeof(Y))
    //        {
    //            target = (Y)(object)(new GH_ObjectWrapper(Value));
    //            return true;
    //        }

    //        if (typeof(IGH_GeometricGoo).IsAssignableFrom(typeof(Y)))
    //        {
    //            target = Convert.ToGrasshopper(Value as dynamic);
    //            return true;
    //        }

    //        try
    //        {
    //            if (Value != null)
    //            {
    //                if (typeof(Y).IsAssignableFrom(Value.GetType()))
    //                {
    //                    target = (Y)(object)Value.Clone();
    //                }
    //                else
    //                {
    //                    target = DiGi.Core.Create.Object<Y>(Value);
    //                }

    //                if (target != null)
    //                {
    //                    return true;
    //                }
    //            }
    //        }
    //        catch
    //        {
    //        }

    //        return base.CastTo(ref target);
    //    }

    //    public void DrawViewportMeshes(GH_PreviewMeshArgs args)
    //    {
    //        Modify.DrawViewportMeshes(Value, args, args.Material);
    //    }

    //    public void DrawViewportWires(GH_PreviewWireArgs args)
    //    {
    //        Modify.DrawViewportWires(Value, args, args.Color);
    //    }

    //    public override IGH_Goo Duplicate()
    //    {
    //        return new GooIntersectionResult3D(Value);
    //    }
    //}

    //public class GooIntersectionResult3DParam: GooPresistentParam<GooIntersectionResult3D, IntersectionResult3D>, IGooBakeAwareParam
    //{
    //    public GooIntersectionResult3DParam()
    //       : base()
    //    {
    //    }

    //    public BoundingBox ClippingBox => Preview_ComputeClippingBox();

    //    public override Guid ComponentGuid => new Guid("9e9f7879-bd95-46b5-b0e2-4a05b6c12af1");

    //    public bool Hidden { get; set; }

    //    public bool IsBakeCapable => !VolatileData.IsEmpty;

    //    public bool IsPreviewCapable => !VolatileData.IsEmpty;

    //    public void BakeGeometry(RhinoDoc rhinoDoc, List<Guid> guids)
    //    {
    //        BakeGeometry(rhinoDoc, rhinoDoc?.CreateDefaultAttributes(), guids);
    //    }

    //    public void BakeGeometry(RhinoDoc rhinoDoc, ObjectAttributes objectAttributes, List<Guid> guids)
    //    {
    //        if (rhinoDoc == null)
    //        {
    //            return;
    //        }

    //        if (guids == null)
    //        {
    //            guids = new List<Guid>();
    //        }

    //        foreach (var value in VolatileData.AllData(true))
    //        {
    //            IGH_BakeAwareData gH_BakeAwareData = value as IGH_BakeAwareData;
    //            if (gH_BakeAwareData == null)
    //            {
    //                continue;
    //            }

    //            if(gH_BakeAwareData is IGooGeometry)
    //            {
    //                if(((IGooGeometry)gH_BakeAwareData).BakeGeometry(rhinoDoc, objectAttributes, out List<Guid> guids_Temp) && guids_Temp != null)
    //                {
    //                    guids.AddRange(guids_Temp);
    //                }

    //                continue;
    //            }

    //            if (!gH_BakeAwareData.BakeGeometry(rhinoDoc, objectAttributes, out Guid guid))
    //            {
    //                continue;
    //            }

    //            guids.Add(guid);
    //        }
    //    }

    //    void IGH_PreviewObject.DrawViewportMeshes(IGH_PreviewArgs args)
    //    {
    //        Preview_DrawMeshes(args);
    //    }

    //    //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;
    //    void IGH_PreviewObject.DrawViewportWires(IGH_PreviewArgs args)
    //    {
    //        Preview_DrawWires(args);
    //    }

    //    protected override GH_GetterResult Prompt_Plural(ref List<GooIntersectionResult3D> values)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    protected override GH_GetterResult Prompt_Singular(ref GooIntersectionResult3D value)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
}