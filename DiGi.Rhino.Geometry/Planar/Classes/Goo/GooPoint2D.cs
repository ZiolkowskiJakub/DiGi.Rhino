using DiGi.Geometry.Planar.Classes;
using DiGi.Rhino.Geometry.Core.Classes;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.Rhino.Geometry.Planar.Classes
{
    /// <summary>
    /// Represents a Grasshopper Goo wrapper for a 2D point.
    /// </summary>
    public class GooPoint2D : GooGeometry2D<Point2D>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GooPoint2D"/> class.
        /// </summary>
        public GooPoint2D()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GooPoint2D"/> class with the specified 2D point.
        /// </summary>
        /// <param name="point2D">The 2D point to wrap.</param>
        public GooPoint2D(Point2D? point2D)
        {
            Value = point2D;
        }

        /// <summary>
        /// Creates a duplicate of this Goo object.
        /// </summary>
        /// <returns>A new <see cref="IGH_Goo"/> instance containing the same value.</returns>
        public override IGH_Goo Duplicate()
        {
            return new GooPoint2D(Value);
        }
    }

    /// <summary>
    /// Represents a Grasshopper parameter for 2D points.
    /// </summary>
    public class GooPoint2DParam : GooGeometryParam<Point2D>
    {
        /// <summary>
        /// Gets the unique identifier for the component.
        /// </summary>
        /// <returns>The GUID of the component.</returns>
        public override Guid ComponentGuid => new("34696feb-c38e-4458-ba2b-3db180fa12e9");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        /// <summary>
        /// Initializes a new instance of the <see cref="GooPoint2DParam"/> class.
        /// </summary>
        public GooPoint2DParam()
            : base()
        {
        }
    }
}