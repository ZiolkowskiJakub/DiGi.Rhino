using DiGi.Geometry.Planar.Classes;
using DiGi.Rhino.Geometry.Core.Classes;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.Rhino.Geometry.Planar.Classes
{
    /// <summary>
    /// Represents a Grasshopper Goo wrapper for a 2D line segment.
    /// </summary>
    public class GooSegment2D : GooGeometry2D<Segment2D>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GooSegment2D"/> class.
        /// </summary>
        public GooSegment2D()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GooSegment2D"/> class with the specified 2D segment.
        /// </summary>
        /// <param name="segment2D">The 2D segment to wrap.</param>
        public GooSegment2D(Segment2D? segment2D)
        {
            Value = segment2D;
        }

        /// <summary>
        /// Creates a duplicate of this Goo object.
        /// </summary>
        /// <returns>A new instance of <see cref="GooSegment2D"/> containing the same value.</returns>
        public override IGH_Goo Duplicate()
        {
            return new GooSegment2D(Value);
        }
    }

    /// <summary>
    /// Represents the Grasshopper parameter type for 2D line segments.
    /// </summary>
    public class GooSegment2DParam : GooGeometryParam<Segment2D>
    {
        /// <summary> Gets the unique identifier for the <see cref="GooSegment2DParam" /> component. </summary>
        public override Guid ComponentGuid => new("ed94a00f-cd43-4ae1-bbec-9d792395f248");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        /// <summary>
        /// Initializes a new instance of the <see cref="GooSegment2DParam"/> class.
        /// </summary>
        public GooSegment2DParam()
            : base()
        {
        }
    }
}
