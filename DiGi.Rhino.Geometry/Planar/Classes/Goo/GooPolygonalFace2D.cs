using DiGi.Geometry.Planar.Classes;
using DiGi.Rhino.Geometry.Core.Classes;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.Rhino.Geometry.Planar.Classes
{
    /// <summary>
    /// Represents a Grasshopper wrapper for a <see cref="PolygonalFace2D"/>.
    /// </summary>
    public class GooPolygonalFace2D : GooGeometry2D<PolygonalFace2D>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GooPolygonalFace2D"/> class.
        /// </summary>
        public GooPolygonalFace2D()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GooPolygonalFace2D"/> class with the specified polygonal face.
        /// </summary>
        /// <param name="polygonalFace2D">The 2D polygonal face to wrap.</param>
        public GooPolygonalFace2D(PolygonalFace2D? polygonalFace2D)
        {
            Value = polygonalFace2D;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GooPolygonalFace2D"/> class by copying another wrapper.
        /// </summary>
        /// <param name="gooPolygonalFace2D">The source wrapper to copy from.</param>
        public GooPolygonalFace2D(GooPolygonalFace2D? gooPolygonalFace2D)
        {
            Value = gooPolygonalFace2D?.Value;
        }

        /// <summary>
        /// Creates a duplicate of the current object.
        /// </summary>
        /// <returns>A duplicated <see cref="IGH_Goo"/> object.</returns>
        public override IGH_Goo Duplicate()
        {
            return new GooPolygonalFace2D(this);
        }
    }

    /// <summary>
    /// Represents the parameter type for 2D polygonal faces in Grasshopper.
    /// </summary>
    public class GooPolygonalFace2DParam : GooGeometryParam<PolygonalFace2D>
    {
        /// <summary>
        /// Gets the unique identifier for the component.
        /// </summary>
        public override Guid ComponentGuid => new("0e44ab21-a17b-4b26-94c7-f49a433987c8");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        /// <summary>
        /// Initializes a new instance of the <see cref="GooPolygonalFace2DParam"/> class.
        /// </summary>
        public GooPolygonalFace2DParam()
            : base()
        {
        }
    }
}