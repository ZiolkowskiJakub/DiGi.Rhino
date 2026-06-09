using DiGi.Geometry.Planar.Classes;
using DiGi.Rhino.Geometry.Core.Classes;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.Rhino.Geometry.Planar.Classes
{
    /// <summary>
    /// Represents a Grasshopper Goo wrapper for a 2D bounding box, allowing it to be passed through Grasshopper wires.
    /// </summary>
    public class GooBoundingBox2D : GooGeometry2D<BoundingBox2D>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GooBoundingBox2D"/> class.
        /// </summary>
        public GooBoundingBox2D()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GooBoundingBox2D"/> class with the specified 2D bounding box.
        /// </summary>
        /// <param name="boundingBox2D">The 2D bounding box to wrap.</param>
        public GooBoundingBox2D(BoundingBox2D? boundingBox2D)
        {
            Value = boundingBox2D;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GooBoundingBox2D"/> class by copying another Goo bounding box wrapper.
        /// </summary>
        /// <param name="gooBoundingBox2D">The source Goo bounding box wrapper to copy from.</param>
        public GooBoundingBox2D(GooBoundingBox2D? gooBoundingBox2D)
        {
            Value = gooBoundingBox2D?.Value;
        }

        /// <summary>
        /// Creates a duplicate of the current Goo bounding box.
        /// </summary>
        /// <returns>A duplicated <see cref="IGH_Goo"/> object.</returns>
        public override IGH_Goo Duplicate()
        {
            return new GooBoundingBox2D(this);
        }
    }

    /// <summary>
    /// Represents a Grasshopper parameter used to handle 2D bounding box data in component inputs and outputs.
    /// </summary>
    public class GooBoundingBox2DParam : GooGeometryParam<BoundingBox2D>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GooBoundingBox2DParam"/> class.
        /// </summary>
        public GooBoundingBox2DParam()
            : base()
        {
        }

        /// <summary>
        /// Gets the unique identifier for the 2D bounding box component parameter.
        /// </summary>
        /// <value>The GUID associated with this parameter type.</value>
        public override Guid ComponentGuid => new("f0734aef-47d6-4c0e-a10f-cc2761fd7289");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;
    }
}