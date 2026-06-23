using DiGi.Geometry.Planar.Classes;
using DiGi.Rhino.Geometry.Core.Classes;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.Rhino.Geometry.Planar.Classes
{
    /// <summary>
    /// Represents a Grasshopper Goo wrapper for a <see cref="Vector2D"/>.
    /// </summary>
    public class GooVector2D : GooGeometry2D<Vector2D>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GooVector2D"/> class.
        /// </summary>
        public GooVector2D()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GooVector2D"/> class with the specified 2D vector.
        /// </summary>
        /// <param name="vector2D">The 2D vector to wrap.</param>
        public GooVector2D(Vector2D? vector2D)
        {
            Value = vector2D;
        }

        /// <summary>
        /// Creates a duplicate of this Goo object.
        /// </summary>
        /// <returns>A new <see cref="IGH_Goo"/> instance containing the same value.</returns>
        public override IGH_Goo Duplicate()
        {
            return new GooVector2D(Value);
        }
    }

    /// <summary>
    /// Represents a Grasshopper parameter used to pass 2D vector data.
    /// </summary>
    public class GooVector2DParam : GooGeometryParam<Vector2D>
    {
        /// <summary> Gets the unique identifier for the <see cref="GooVector2DParam" /> component. </summary>
        public override Guid ComponentGuid => new("81bcb4c8-8733-4935-9dbb-c2bcaeeaf47a");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        /// <summary>
        /// Initializes a new instance of the <see cref="GooVector2DParam"/> class.
        /// </summary>
        public GooVector2DParam()
            : base()
        {
        }
    }
}