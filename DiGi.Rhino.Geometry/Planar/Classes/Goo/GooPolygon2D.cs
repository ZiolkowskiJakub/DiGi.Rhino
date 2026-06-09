using DiGi.Geometry.Planar.Classes;
using DiGi.Rhino.Geometry.Core.Classes;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.Rhino.Geometry.Planar.Classes
{
    /// <summary>
    /// Represents a Grasshopper Goo wrapper for a <see cref="Polygon2D"/>.
    /// </summary>
    public class GooPolygon2D : GooGeometry2D<Polygon2D>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GooPolygon2D"/> class.
        /// </summary>
        public GooPolygon2D()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GooPolygon2D"/> class with the specified 2D polygon.
        /// </summary>
        /// <param name="polygon2D">The 2D polygon to wrap.</param>
        public GooPolygon2D(Polygon2D? polygon2D)
        {
            Value = polygon2D;
        }

        /// <summary>
        /// Creates a duplicate of this Goo object.
        /// </summary>
        /// <returns>A new <see cref="IGH_Goo"/> instance containing the same value.</returns>
        public override IGH_Goo Duplicate()
        {
            return new GooPolygon2D(Value);
        }
    }

    /// <summary>
    /// Represents a Grasshopper parameter type for 2D polygons.
    /// </summary>
    public class GooPolygon2DParam : GooGeometryParam<Polygon2D>
    {
        /// <summary>
        /// Gets the unique identifier for the component.
        /// </summary>
        public override Guid ComponentGuid => new("d20aa671-8cc3-48b6-9b7a-2dd61ceb3799");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        /// <summary>
        /// Initializes a new instance of the <see cref="GooPolygon2DParam"/> class.
        /// </summary>
        public GooPolygon2DParam()
            : base()
        {
        }
    }
}