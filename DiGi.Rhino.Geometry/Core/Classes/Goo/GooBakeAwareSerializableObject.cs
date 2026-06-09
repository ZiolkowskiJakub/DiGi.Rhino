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
    /// <summary>
    /// Represents an abstract base class for objects that are both serializable and aware of the baking process into a Rhino document.
    /// </summary>
    /// <typeparam name="TSerializableObject">The type of the serializable object, which must implement <see cref="ISerializableObject"/>.</typeparam>
    public abstract class GooBakeAwareSerializableObject<TSerializableObject> : GooSerializableObject<TSerializableObject>, IGooBakeAwareSerializableObject where TSerializableObject : ISerializableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GooBakeAwareSerializableObject{TSerializableObject}"/> class.
        /// </summary>
        public GooBakeAwareSerializableObject()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GooBakeAwareSerializableObject{TSerializableObject}"/> class with a specified geometry value.
        /// </summary>
        /// <param name="geometry">The serializable geometry object to initialize the value with.</param>
        public GooBakeAwareSerializableObject(TSerializableObject? geometry)
        {
            Value = geometry;
        }

        /// <summary>
        /// Gets the bounding box of the geometries associated with this object, used for clipping.
        /// </summary>
        public virtual BoundingBox ClippingBox
        {
            get
            {
                return Spatial.Create.BoundingBox(Geometries);
            }
        }

        /// <summary>
        /// Gets the array of geometries that represent this object in 3D space.
        /// </summary>
        public abstract IGeometry[]? Geometries { get; }

        /// <summary>
        /// Bakes the associated geometries into the specified Rhino document using the provided attributes.
        /// </summary>
        /// <param name="rhinoDoc">The target Rhino document.</param>
        /// <param name="objectAttributes">The attributes to apply to the baked objects.</param>
        /// <param name="guid">When this method returns, contains the Guid of the first baked object, or <see cref="Guid.Empty"/> if baking failed.</param>
        /// <returns><c>true</c> if at least one geometry was successfully baked; otherwise, <c>false</c>.</returns>
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

        /// <summary>
        /// Bakes the associated geometries into the specified Rhino document using the provided attributes and returns a list of all created object Guids.
        /// </summary>
        /// <param name="rhinoDoc">The target Rhino document.</param>
        /// <param name="objectAttributes">The attributes to apply to the baked objects.</param>
        /// <param name="guids">When this method returns, contains a list of Guids for all successfully baked objects.</param>
        /// <returns><c>true</c> if baking was successful; otherwise, <c>false</c>.</returns>
        public virtual bool BakeGeometry(RhinoDoc? rhinoDoc, ObjectAttributes? objectAttributes, out List<Guid>? guids)
        {
            return Spatial.Modify.BakeGeometry(Geometries, rhinoDoc, objectAttributes, out guids);
        }

        /// <summary>
        /// Draws the mesh representations of the geometries in the Rhino viewport.
        /// </summary>
        /// <param name="args">The arguments containing preview and material information.</param>
        public void DrawViewportMeshes(GH_PreviewMeshArgs? args)
        {
            Spatial.Modify.DrawViewportMeshes(Geometries, args, args?.Material);
        }

        /// <summary>
        /// Draws the wireframe representations of the geometries in the Rhino viewport.
        /// </summary>
        /// <param name="args">The arguments containing preview and color information.</param>
        public void DrawViewportWires(GH_PreviewWireArgs? args)
        {
            Spatial.Modify.DrawViewportWires(Geometries, args, args == null ? System.Drawing.Color.Empty : args.Color);
        }
    }

    /// <summary>
    /// Represents a Grasshopper parameter that handles serializable and bake-aware objects.
    /// </summary>
    /// <typeparam name="X">The type of the Goo object, which must inherit from <see cref="GooBakeAwareSerializableObject{T}"/>.</typeparam>
    /// <typeparam name="T">The type of the underlying serializable object, which must implement <see cref="ISerializableObject"/>.</typeparam>
    public class GooBakeAwareSerializableParam<X, T> : GooSerializablePresistentParam<X, T>, IGooBakeAwareParam where T : ISerializableObject where X : GooBakeAwareSerializableObject<T>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GooBakeAwareSerializableParam{X, T}"/> class.
        /// </summary>
        public GooBakeAwareSerializableParam()
           : base()
        {
        }

        /// <summary>
        /// Gets the clipping box for the parameter's preview based on its volatile data.
        /// </summary>
        public virtual BoundingBox ClippingBox => Preview_ComputeClippingBox();

        /// <summary>
        /// Gets or sets a value indicating whether the parameter is hidden from view.
        /// </summary>
        public virtual bool Hidden { get; set; }

        /// <summary>
        /// Gets a value indicating whether the current data in the parameter can be baked into Rhino.
        /// </summary>
        public virtual bool IsBakeCapable => !VolatileData.IsEmpty;

        /// <summary>
        /// Gets a value indicating whether the current data in the parameter can be previewed in the viewport.
        /// </summary>
        public virtual bool IsPreviewCapable => !VolatileData.IsEmpty;

        /// <summary>
        /// Bakes the objects contained within the parameter into the specified Rhino document using default attributes.
        /// </summary>
        /// <param name="rhinoDoc">The target Rhino document.</param>
        /// <param name="guids">The list to which the Guids of the baked objects will be added.</param>
        public virtual void BakeGeometry(RhinoDoc rhinoDoc, List<Guid> guids)
        {
            BakeGeometry(rhinoDoc, rhinoDoc?.CreateDefaultAttributes(), guids);
        }

        /// <summary>
        /// Bakes the objects contained within the parameter into the specified Rhino document using provided attributes.
        /// </summary>
        /// <param name="rhinoDoc">The target Rhino document.</param>
        /// <param name="objectAttributes">The attributes to apply to the baked objects.</param>
        /// <param name="guids">The list to which the Guids of the baked objects will be added. If null, a new list may be initialized internally but not returned unless passed by reference.</param>
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

        /// <summary>
        /// Handles the rendering of mesh previews for the objects contained within the parameter.
        /// </summary>
        /// <param name="args">The preview arguments provided by Grasshopper.</param>
        public virtual void DrawViewportMeshes(IGH_PreviewArgs args)
        {
            Preview_DrawMeshes(args);
        }

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;
        /// <summary>
        /// Handles the rendering of wireframe previews for the objects contained within the parameter.
        /// </summary>
        /// <param name="args">The preview arguments provided by Grasshopper.</param>
        public virtual void DrawViewportWires(IGH_PreviewArgs args)
        {
            Preview_DrawWires(args);
        }
    }
}