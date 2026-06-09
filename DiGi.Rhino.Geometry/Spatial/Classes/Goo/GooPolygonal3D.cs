using DiGi.Geometry.Spatial.Interfaces;
using DiGi.Rhino.Geometry.Core.Classes;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.Rhino.Geometry.Spatial.Classes
{
    /// <summary>
    /// Represents a Goo wrapper for 3D polygonal geometry, allowing it to be passed through Grasshopper components.
    /// </summary>
    public class GooPolygonal3D : GooGeometry3D<IPolygonal3D>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GooPolygonal3D"/> class.
        /// </summary>
        public GooPolygonal3D()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GooPolygonal3D"/> class with the specified polygonal geometry.
        /// </summary>
        /// <param name="polygonal3D">The 3D polygonal geometry to wrap.</param>
        public GooPolygonal3D(IPolygonal3D? polygonal3D)
        {
            Value = polygonal3D;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GooPolygonal3D"/> class by copying another <see cref="GooPolygonal3D"/> wrapper.
        /// </summary>
        /// <param name="gooPolygonal3D">The source Goo wrapper to copy.</param>
        public GooPolygonal3D(GooPolygonal3D? gooPolygonal3D)
        {
            Value = gooPolygonal3D?.Value;
        }

        /// <summary>
        /// Creates a duplicate of the current <see cref="GooPolygonal3D"/> instance.
        /// </summary>
        /// <returns>A new <see cref="IGH_Goo"/> object that is a copy of this instance.</returns>
        public override IGH_Goo Duplicate()
        {
            return new GooPolygonal3D(this);
        }
    }

    /// <summary>
    /// Represents the parameter type for 3D polygonal geometry in Grasshopper.
    /// </summary>
    public class GooPolygonal3DParam : GooGeometryParam<IPolygonal3D>
    {
        /// <summary>
        /// Gets the unique identifier for the component.
        /// </summary>
        public override Guid ComponentGuid => new("b1999ae8-dd6d-450e-8080-286119574b29");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        /// <summary>
        /// Initializes a new instance of the <see cref="GooPolygonal3DParam"/> class.
        /// </summary>
        public GooPolygonal3DParam()
            : base()
        {
        }
    }
}