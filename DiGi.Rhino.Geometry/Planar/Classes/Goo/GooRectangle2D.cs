using DiGi.Geometry.Planar.Classes;
using DiGi.Rhino.Geometry.Core.Classes;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.Rhino.Geometry.Planar.Classes
{
    /// <summary>
    /// Represents a Grasshopper Goo wrapper for a <see cref="Rectangle2D"/>.
    /// </summary>
    public class GooRectangle2D : GooGeometry2D<Rectangle2D>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GooRectangle2D"/> class.
        /// </summary>
        public GooRectangle2D()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GooRectangle2D"/> class with the specified 2D rectangle.
        /// </summary>
        /// <param name="rectangle2D">The 2D rectangle to wrap.</param>
        public GooRectangle2D(Rectangle2D? rectangle2D)
        {
            Value = rectangle2D;
        }

        /// <summary>
        /// Creates a duplicate of this Goo object.
        /// </summary>
        /// <returns>A new instance of <see cref="GooRectangle2D"/> containing the same value.</returns>
        public override IGH_Goo Duplicate()
        {
            return new GooRectangle2D(Value);
        }
    }

    /// <summary>
    /// Represents a Grasshopper parameter for 2D rectangles.
    /// </summary>
    public class GooRectangle2DParam : GooGeometryParam<Rectangle2D>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GooRectangle2DParam"/> class.
        /// </summary>
        public GooRectangle2DParam()
            : base()
        {
        }

        /// <summary>
        /// Gets the unique identifier for the component.
        /// </summary>
        /// <value>The GUID associated with this parameter type.</value>
        public override Guid ComponentGuid => new("4fe103ef-4e57-47d9-b992-bccb9a67a22a");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;
    }
}