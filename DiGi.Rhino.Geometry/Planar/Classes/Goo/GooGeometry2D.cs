using DiGi.Geometry.Planar.Interfaces;
using DiGi.Rhino.Geometry.Core.Classes;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.Rhino.Geometry.Planar.Classes
{
    /// <summary>
    /// Represents a Goo wrapper for 2D geometry of type <typeparamref name="T"/>.
    /// </summary>
    /// <typeparam name="T">The type of the 2D geometry, which must implement <see cref="IGeometry2D"/>.</typeparam>
    public class GooGeometry2D<T> : GooGeometry<T> where T : IGeometry2D
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GooGeometry2D{T}"/> class.
        /// </summary>
        public GooGeometry2D()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GooGeometry2D{T}"/> class with the specified geometry.
        /// </summary>
        /// <param name="geometry2D">The 2D geometry to wrap.</param>
        public GooGeometry2D(T? geometry2D)
        {
            Value = geometry2D;
        }

        /// <summary>
        /// Creates a duplicate of the current Goo object.
        /// </summary>
        /// <returns>A new instance of <see cref="GooGeometry2D{T}"/> containing the same value.</returns>
        public override IGH_Goo Duplicate()
        {
            return new GooGeometry2D<T>(Value);
        }
    }

    /// <summary>
    /// Represents a Goo wrapper for 2D geometry implementing <see cref="IGeometry2D"/>.
    /// </summary>
    public class GooGeometry2D : GooGeometry2D<IGeometry2D>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GooGeometry2D"/> class.
        /// </summary>
        public GooGeometry2D()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GooGeometry2D"/> class with the specified geometry.
        /// </summary>
        /// <param name="geometry2D">The 2D geometry to wrap.</param>
        public GooGeometry2D(IGeometry2D? geometry2D)
        {
            Value = geometry2D;
        }

        /// <summary>
        /// Creates a duplicate of the current Goo object.
        /// </summary>
        /// <returns>A new instance of <see cref="GooGeometry2D"/> containing the same value.</returns>
        public override IGH_Goo Duplicate()
        {
            return new GooGeometry2D(Value);
        }
    }

    /// <summary>
    /// Represents a Grasshopper parameter for 2D geometry.
    /// </summary>
    public class GooGeometry2DParam : GooGeometryParam<IGeometry2D>
    {
        /// <summary>
        /// Gets the unique identifier for the component.
        /// </summary>
        public override Guid ComponentGuid => new("b058cbef-083c-4093-a53a-d6e4d913f662");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        /// <summary>
        /// Initializes a new instance of the <see cref="GooGeometry2DParam"/> class.
        /// </summary>
        public GooGeometry2DParam()
            : base()
        {
        }
    }
}