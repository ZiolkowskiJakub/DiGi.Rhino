using DiGi.Geometry.Core.Interfaces;
using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Core.Interfaces;
using DiGi.Rhino.Geometry.Core.Interfaces;
using DiGi.Rhino.Geometry.Spatial;
using Grasshopper.Kernel;
using Grasshopper.Kernel.Types;
using Rhino;
using Rhino.DocObjects;
using Rhino.Geometry;
using System;
using System.Collections.Generic;

namespace DiGi.Rhino.Geometry.Core.Classes
{
    /// <summary>
    /// A generic Grasshopper Goo wrapper for DiGi geometry types that implement <see cref="IGeometry"/>.
    /// Provides baking, viewport preview, and type-casting capabilities.
    /// </summary>
    /// <typeparam name="T">The DiGi geometry type being wrapped. Must implement <see cref="IGeometry"/>.</typeparam>
    public class GooGeometry<T> : GooSerializableObject<T>, IGooGeometry where T : IGeometry
    {
        /// <summary>
        /// Initializes a new default instance of <see cref="GooGeometry{T}"/>.
        /// </summary>
        public GooGeometry()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of <see cref="GooGeometry{T}"/> with the specified geometry value.
        /// </summary>
        /// <param name="geometry">The geometry object to wrap, or <see langword="null"/>.</param>
        public GooGeometry(T? geometry)
        {
            Value = geometry;
        }

        /// <summary>
        /// Gets the Rhino bounding box used for viewport clipping.
        /// </summary>
        public virtual BoundingBox ClippingBox
        {
            get
            {
                return Create.BoundingBox(Value);
            }
        }

        /// <summary>
        /// Bakes the wrapped geometry into a Rhino document, returning the GUID of the first baked object.
        /// </summary>
        /// <param name="rhinoDoc">The Rhino document to bake into.</param>
        /// <param name="objectAttributes">The object attributes to apply when baking.</param>
        /// <param name="guid">When this method returns, contains the GUID of the first baked object, or <see cref="Guid.Empty"/> if baking failed.</param>
        /// <returns><see langword="true"/> if baking was successful; otherwise <see langword="false"/>.</returns>
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

        /// <summary>
        /// Bakes the wrapped geometry into a Rhino document, returning all generated GUIDs.
        /// </summary>
        /// <param name="rhinoDoc">The Rhino document to bake into, or <see langword="null"/>.</param>
        /// <param name="objectAttributes">The object attributes to apply when baking, or <see langword="null"/>.</param>
        /// <param name="guids">When this method returns, contains the list of GUIDs of all baked objects, or <see langword="null"/>.</param>
        /// <returns><see langword="true"/> if baking was successful; otherwise <see langword="false"/>.</returns>
        public bool BakeGeometry(RhinoDoc? rhinoDoc, ObjectAttributes? objectAttributes, out List<Guid>? guids)
        {
            return Modify.BakeGeometry(Value, rhinoDoc, objectAttributes, out guids);
        }

        /// <summary>
        /// Attempts to cast from a source object into this wrapper's value.
        /// </summary>
        /// <param name="source">The source object to cast from.</param>
        /// <returns><see langword="true"/> if the cast was successful; otherwise <see langword="false"/>.</returns>
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
                if (Rhino.Core.Query.TryGetValue(gooSerializableObject, out T? t))
                {
                    Value = t;
                    return true;
                }
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
                    if (Rhino.Core.Query.TryGetValue((IGooSerializableObject)source!, out T? t))
                    {
                        Value = t;
                        return true;
                    }
                }

                if (typeof(IGH_Goo).IsAssignableFrom(type_Source))
                {
                    object? @object = null;
                    if (typeof(IGH_GeometricGoo).IsAssignableFrom(type_Source))
                    {
                        @object = Spatial.Convert.ToDiGi((IGH_GeometricGoo)source!);
                    }
                    if (typeof(GH_Vector).IsAssignableFrom(type_Source))
                    {
                        GH_Vector gH_Vector = (GH_Vector)source!;
                        if (typeof(T).IsAssignableFrom(typeof(Vector3D)))
                        {
                            if ((T?)(object?)gH_Vector.Value.ToDiGi() is T t_Temp)
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

        /// <summary>
        /// Attempts to cast the wrapped geometry value to the specified target type <typeparamref name="Y"/>.
        /// </summary>
        /// <typeparam name="Y">The target type to cast to.</typeparam>
        /// <param name="target">When this method returns, contains the cast value if successful.</param>
        /// <returns><see langword="true"/> if the cast was successful; otherwise <see langword="false"/>.</returns>
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
        /// Draws the geometry as shaded meshes in the Grasshopper viewport preview.
        /// </summary>
        /// <param name="args">The preview mesh arguments including material settings.</param>
        public void DrawViewportMeshes(GH_PreviewMeshArgs args)
        {
            Modify.DrawViewportMeshes(Value, args, args.Material);
        }

        /// <summary>
        /// Draws the geometry as wireframe curves in the Grasshopper viewport preview.
        /// </summary>
        /// <param name="args">The preview wire arguments including color settings.</param>
        public void DrawViewportWires(GH_PreviewWireArgs args)
        {
            Modify.DrawViewportWires(Value, args, args.Color);
        }

        /// <summary>
        /// Creates a duplicate of this <see cref="GooGeometry{T}"/> instance.
        /// </summary>
        /// <returns>A new <see cref="IGH_Goo"/> wrapping the same geometry value.</returns>
        public override IGH_Goo Duplicate()
        {
            return new GooGeometry<T>(Value);
        }
    }

    /// <summary>
    /// A generic Grasshopper persistent parameter for <see cref="GooGeometry{T}"/> values,
    /// supporting baking and viewport preview.
    /// </summary>
    /// <typeparam name="T">The DiGi geometry type. Must implement <see cref="IGeometry"/>.</typeparam>
    public class GooGeometryParam<T> : GooSerializablePresistentParam<GooGeometry<T>, T>, IGooGeometryParam where T : IGeometry
    {
        /// <summary>
        /// Initializes a new default instance of <see cref="GooGeometryParam{T}"/>.
        /// </summary>
        public GooGeometryParam()
           : base()
        {
        }

        /// <summary>
        /// Gets the Rhino bounding box enclosing all geometry values held in this parameter.
        /// </summary>
        public BoundingBox ClippingBox => Preview_ComputeClippingBox();

        /// <summary>
        /// Gets the unique identifier for this parameter component.
        /// </summary>
        public override Guid ComponentGuid => new("63680047-20b3-4e89-a085-2add878abb76");

        /// <summary>
        /// Gets or sets a value indicating whether this parameter is hidden in the viewport.
        /// </summary>
        public bool Hidden { get; set; }

        /// <summary>
        /// Gets a value indicating whether this parameter is capable of baking geometry to Rhino.
        /// </summary>
        public bool IsBakeCapable => !VolatileData.IsEmpty;

        /// <summary>
        /// Gets a value indicating whether this parameter is capable of showing a viewport preview.
        /// </summary>
        public bool IsPreviewCapable => !VolatileData.IsEmpty;

        /// <summary>
        /// Bakes all geometry values in this parameter to a Rhino document using default attributes.
        /// </summary>
        /// <param name="rhinoDoc">The Rhino document to bake into.</param>
        /// <param name="guids">The list to which the GUIDs of all baked objects are added.</param>
        public void BakeGeometry(RhinoDoc rhinoDoc, List<Guid> guids)
        {
            BakeGeometry(rhinoDoc, rhinoDoc?.CreateDefaultAttributes(), guids);
        }

        /// <summary>
        /// Bakes all geometry values in this parameter to a Rhino document with the specified attributes.
        /// </summary>
        /// <param name="rhinoDoc">The Rhino document to bake into, or <see langword="null"/>.</param>
        /// <param name="objectAttributes">The object attributes to apply when baking, or <see langword="null"/>.</param>
        /// <param name="guids">The list to which the GUIDs of all baked objects are added, or <see langword="null"/>.</param>
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
                    if (gooGeometry.BakeGeometry(rhinoDoc, objectAttributes, out List<Guid>? guids_Temp) && guids_Temp != null)
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

        /// <summary>
        /// Draws shaded mesh previews for all geometry values in the Grasshopper viewport.
        /// </summary>
        /// <param name="args">The preview arguments.</param>
        void IGH_PreviewObject.DrawViewportMeshes(IGH_PreviewArgs args)
        {
            Preview_DrawMeshes(args);
        }

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        /// <summary>
        /// Draws wireframe previews for all geometry values in the Grasshopper viewport.
        /// </summary>
        /// <param name="args">The preview arguments.</param>
        void IGH_PreviewObject.DrawViewportWires(IGH_PreviewArgs args)
        {
            Preview_DrawWires(args);
        }

        /// <summary>
        /// Prompts the user to select multiple geometry values.
        /// </summary>
        /// <param name="values">The list of selected values.</param>
        /// <returns>A <see cref="GH_GetterResult"/> indicating the result of the prompt.</returns>
        protected override GH_GetterResult Prompt_Plural(ref List<GooGeometry<T>?> values)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Prompts the user to select a single geometry value.
        /// </summary>
        /// <param name="value">The selected value.</param>
        /// <returns>A <see cref="GH_GetterResult"/> indicating the result of the prompt.</returns>
        protected override GH_GetterResult Prompt_Singular(ref GooGeometry<T>? value)
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// A non-generic Grasshopper persistent parameter for <see cref="IGeometry"/> values,
    /// specializing <see cref="GooGeometryParam{T}"/> with <see cref="IGeometry"/>.
    /// </summary>
    public class GooGeometryParam : GooGeometryParam<IGeometry>
    {
        /// <summary>
        /// Initializes a new default instance of <see cref="GooGeometryParam"/>.
        /// </summary>
        public GooGeometryParam()
            : base()
        {
        }

        /// <summary>
        /// Gets the unique identifier for this parameter component.
        /// </summary>
        public override Guid ComponentGuid => new("38d1d698-3de7-4537-9175-3b19372718f9");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;
    }
}