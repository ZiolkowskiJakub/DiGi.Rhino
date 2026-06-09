using DiGi.Geometry.Spatial.Classes;
using DiGi.Rhino.Geometry.Core.Classes;
using DiGi.Rhino.Geometry.Spatial.Classes;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.Rhino.Geometry.Planar.Classes
{
    /// <summary>
    /// Represents a Goo wrapper for a three-dimensional bounding box.
    /// </summary>
    public class GooBoundingBox3D : GooGeometry3D<BoundingBox3D>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GooBoundingBox3D"/> class.
        /// </summary>
        public GooBoundingBox3D()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GooBoundingBox3D"/> class with the specified bounding box.
        /// </summary>
        /// <param name="boundingBox3D">The bounding box to wrap.</param>
        public GooBoundingBox3D(BoundingBox3D boundingBox3D)
        {
            Value = boundingBox3D;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GooBoundingBox3D"/> class by copying another Goo bounding box.
        /// </summary>
        /// <param name="gooBoundingBox3D">The source Goo bounding box to copy.</param>
        public GooBoundingBox3D(GooBoundingBox3D gooBoundingBox3D)
        {
            Value = gooBoundingBox3D?.Value;
        }

        /// <summary>
        /// Creates a duplicate of the current Goo bounding box.
        /// </summary>
        /// <returns>A duplicate <see cref="IGH_Goo"/> object.</returns>
        public override IGH_Goo Duplicate()
        {
            return new GooBoundingBox3D(this);
        }
    }

    /// <summary>
    /// Represents the Grasshopper parameter type for <see cref="GooBoundingBox3D"/>.
    /// </summary>
    public class GooBoundingBox3DParam : GooGeometryParam<BoundingBox3D>
    {
        /// <summary>
        /// Gets the unique identifier for the component.
        /// </summary>
        public override Guid ComponentGuid => new("c683dd64-31fd-4363-8c26-8328aaea8d55");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        /// <summary>
        /// Initializes a new instance of the <see cref="GooBoundingBox3DParam"/> class.
        /// </summary>
        public GooBoundingBox3DParam()
            : base()
        {
        }
    }
}