using DiGi.Geometry.Spatial.Interfaces;
using DiGi.Rhino.Geometry.Core.Classes;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.Rhino.Geometry.Spatial.Classes
{
    /// <summary>
    /// Represents a Goo wrapper for 3D geometry types.
    /// </summary>
    /// <typeparam name="T">The type of the 3D geometry, which must implement <see cref="IGeometry3D"/>.</typeparam>
    public class GooGeometry3D<T> : GooGeometry<T> where T : IGeometry3D
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GooGeometry3D{T}"/> class.
        /// </summary>
        public GooGeometry3D()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GooGeometry3D{T}"/> class with the specified geometry value.
        /// </summary>
        /// <param name="geometry3D">The 3D geometry to wrap.</param>
        public GooGeometry3D(T? geometry3D)
        {
            Value = geometry3D;
        }

        /// <summary>
        /// Creates a duplicate of the current Goo object.
        /// </summary>
        /// <returns>A new instance of <see cref="IGH_Goo"/> containing the same geometry value.</returns>
        public override IGH_Goo Duplicate()
        {
            return new GooGeometry3D<T>(Value);
        }
    }

    /// <summary>
    /// Represents a non-generic Goo wrapper for 3D geometry implementing <see cref="IGeometry3D"/>.
    /// </summary>
    public class GooGeometry3D : GooGeometry3D<IGeometry3D>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GooGeometry3D"/> class.
        /// </summary>
        public GooGeometry3D()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GooGeometry3D"/> class with the specified geometry value.
        /// </summary>
        /// <param name="geometry3D">The 3D geometry to wrap.</param>
        public GooGeometry3D(IGeometry3D? geometry3D)
        {
            Value = geometry3D;
        }

        /// <summary>
        /// Creates a duplicate of the current Goo object.
        /// </summary>
        /// <returns>A new instance of <see cref="IGH_Goo"/> containing the same geometry value.</returns>
        public override IGH_Goo Duplicate()
        {
            return new GooGeometry3D(Value);
        }
    }

    /// <summary>
    /// Represents the Grasshopper parameter type for 3D geometry objects.
    /// </summary>
    public class GooGeometry3DParam : GooGeometryParam<IGeometry3D>
    {
        /// <summary> Gets the unique identifier for the component associated with this parameter. </summary>
        public override Guid ComponentGuid => new("e3385a00-6a5f-4203-9a9d-374652dc7d21");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        /// <summary>
        /// Initializes a new instance of the <see cref="GooGeometry3DParam"/> class.
        /// </summary>
        public GooGeometry3DParam()
            : base()
        {
        }
    }
}