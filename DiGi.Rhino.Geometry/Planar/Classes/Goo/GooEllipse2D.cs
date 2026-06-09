using DiGi.Geometry.Planar.Classes;
using DiGi.Rhino.Geometry.Core.Classes;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.Rhino.Geometry.Planar.Classes
{
    /// <summary>
    /// Represents a Grasshopper Goo wrapper for a 2D ellipse.
    /// </summary>
    public class GooEllipse2D : GooGeometry2D<Ellipse2D>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GooEllipse2D"/> class.
        /// </summary>
        public GooEllipse2D()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GooEllipse2D"/> class with the specified 2D ellipse.
        /// </summary>
        /// <param name="ellipse2D">The 2D ellipse to wrap.</param>
        public GooEllipse2D(Ellipse2D? ellipse2D)
        {
            Value = ellipse2D;
        }

        /// <summary>
        /// Creates a duplicate of this Goo object.
        /// </summary>
        /// <returns>A new <see cref="IGH_Goo"/> instance containing the same value.</returns>
        public override IGH_Goo Duplicate()
        {
            return new GooEllipse2D(Value);
        }
    }

    /// <summary>
    /// Represents a Grasshopper parameter type for 2D ellipses.
    /// </summary>
    public class GooEllipse2DParam : GooGeometryParam<Ellipse2D>
    {
        /// <summary>
        /// Gets the unique identifier for the component.
        /// </summary>
        public override Guid ComponentGuid => new("7e79f2a6-a3a8-4955-bcec-536e646943ea");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        /// <summary>
        /// Initializes a new instance of the <see cref="GooEllipse2DParam"/> class.
        /// </summary>
        public GooEllipse2DParam()
            : base()
        {
        }
    }
}