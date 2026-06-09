using DiGi.Geometry.Planar.Interfaces;
using DiGi.Rhino.Geometry.Core.Classes;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.Rhino.Geometry.Planar.Classes
{
    /// <summary>
    /// Represents a Grasshopper Goo wrapper for 2D polygonal geometry.
    /// </summary>
    public class GooPolygonal2D : GooGeometry2D<IPolygonal2D>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GooPolygonal2D"/> class.
        /// </summary>
        public GooPolygonal2D()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GooPolygonal2D"/> class with the specified polygonal geometry.
        /// </summary>
        /// <param name="polygonal2D">The 2D polygonal geometry to wrap.</param>
        public GooPolygonal2D(IPolygonal2D? polygonal2D)
        {
            Value = polygonal2D;
        }

        /// <summary>
        /// Creates a duplicate of this Goo object.
        /// </summary>
        /// <returns>A new <see cref="IGH_Goo"/> instance containing the same value.</returns>
        public override IGH_Goo Duplicate()
        {
            return new GooPolygonal2D(Value);
        }
    }

    /// <summary>
    /// Represents a Grasshopper parameter for 2D polygonal geometry.
    /// </summary>
    public class GooPolygonal2DParam : GooGeometryParam<IPolygonal2D>
    {
        /// <summary>
        /// Gets the unique identifier for the <see cref="GooPolygonal2DParam"/> component.
        /// </summary>
        public override Guid ComponentGuid => new("8da7aab4-6b42-4a22-90ad-48e94329f8aa");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        /// <summary>
        /// Initializes a new instance of the <see cref="GooPolygonal2DParam"/> class.
        /// </summary>
        public GooPolygonal2DParam()
            : base()
        {
        }
    }
}