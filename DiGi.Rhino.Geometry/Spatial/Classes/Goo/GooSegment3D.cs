using DiGi.Geometry.Spatial.Classes;
using DiGi.Rhino.Geometry.Core.Classes;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.Rhino.Geometry.Spatial.Classes
{
    /// <summary>
    /// Represents a Goo wrapper for a 3D line segment, allowing it to be passed through Grasshopper components.
    /// </summary>
    public class GooSegment3D : GooGeometry3D<Segment3D>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GooSegment3D"/> class.
        /// </summary>
        public GooSegment3D()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GooSegment3D"/> class with the specified 3D line segment.
        /// </summary>
        /// <param name="segment3D">The 3D line segment to wrap.</param>
        public GooSegment3D(Segment3D? segment3D)
        {
            Value = segment3D;
        }

        /// <summary>
        /// Creates a duplicate of this Goo object.
        /// </summary>
        /// <returns>A new <see cref="IGH_Goo"/> instance containing the same value.</returns>
        public override IGH_Goo Duplicate()
        {
            return new GooSegment3D(Value);
        }
    }

    /// <summary>
    /// Represents the Grasshopper parameter type for 3D line segments.
    /// </summary>
    public class GooSegment3DParam : GooGeometryParam<Segment3D>
    {
        /// <summary> Gets the unique identifier for the <see cref="GooSegment3DParam" /> component. </summary>
        public override Guid ComponentGuid => new("93c88362-a263-4807-9d71-11dd09d334a5");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        /// <summary>
        /// Initializes a new instance of the <see cref="GooSegment3DParam"/> class.
        /// </summary>
        public GooSegment3DParam()
            : base()
        {
        }
    }
}
