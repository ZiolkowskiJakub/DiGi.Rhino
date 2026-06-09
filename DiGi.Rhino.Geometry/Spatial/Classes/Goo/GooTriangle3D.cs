using DiGi.Geometry.Spatial.Classes;
using DiGi.Rhino.Geometry.Core.Classes;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.Rhino.Geometry.Spatial.Classes
{
    /// <summary>
    /// Represents a Grasshopper Goo wrapper for a 3D triangle geometry.
    /// </summary>
    public class GooTriangle3D : GooGeometry3D<Triangle3D>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GooTriangle3D"/> class.
        /// </summary>
        public GooTriangle3D()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GooTriangle3D"/> class with the specified triangle geometry.
        /// </summary>
        /// <param name="triangle3D">The 3D triangle geometry to wrap.</param>
        public GooTriangle3D(Triangle3D? triangle3D)
        {
            Value = triangle3D;
        }

        /// <summary>
        /// Creates a duplicate of this Goo object.
        /// </summary>
        /// <returns>A new instance of <see cref="GooTriangle3D"/> containing the same value.</returns>
        public override IGH_Goo Duplicate()
        {
            return new GooTriangle3D(Value);
        }
    }

    /// <summary>
    /// Represents a Grasshopper parameter type for 3D triangle geometry.
    /// </summary>
    public class GooTriangle3DParam : GooGeometryParam<Triangle3D>
    {
        /// <summary>
        /// Gets the unique identifier for the <see cref="GooTriangle3DParam"/> component.
        /// </summary>
        /// <returns>The Guid of the component.</returns>
        public override Guid ComponentGuid => new("a89cf240-e7be-41ff-9d05-c62a7f7fc4a9");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        /// <summary>
        /// Initializes a new instance of the <see cref="GooTriangle3DParam"/> class.
        /// </summary>
        public GooTriangle3DParam()
            : base()
        {
        }
    }
}