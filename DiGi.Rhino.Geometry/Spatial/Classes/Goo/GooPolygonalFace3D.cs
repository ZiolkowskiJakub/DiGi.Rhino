using DiGi.Geometry.Spatial.Interfaces;
using DiGi.Rhino.Geometry.Core.Classes;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.Rhino.Geometry.Spatial.Classes
{
    /// <summary>
    /// Represents a wrapper for a 3D polygonal face, allowing it to be used within the Grasshopper environment.
    /// </summary>
    public class GooPolygonalFace3D : GooGeometry3D<IPolygonalFace3D>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GooPolygonalFace3D"/> class.
        /// </summary>
        public GooPolygonalFace3D()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GooPolygonalFace3D"/> class with the specified polygonal face.
        /// </summary>
        /// <param name="polygonalFace3D">The 3D polygonal face to wrap.</param>
        public GooPolygonalFace3D(IPolygonalFace3D? polygonalFace3D)
        {
            Value = polygonalFace3D;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GooPolygonalFace3D"/> class by copying another wrapper.
        /// </summary>
        /// <param name="gooPolygonalFace3D">The source wrapper to copy from.</param>
        public GooPolygonalFace3D(GooPolygonalFace3D? gooPolygonalFace3D)
        {
            Value = gooPolygonalFace3D?.Value;
        }

        /// <summary>
        /// Creates a duplicate of the current <see cref="GooPolygonalFace3D"/> instance.
        /// </summary>
        /// <returns>A new <see cref="IGH_Goo"/> object that is a copy of this instance.</returns>
        public override IGH_Goo Duplicate()
        {
            return new GooPolygonalFace3D(this);
        }
    }

    /// <summary>
    /// Represents a Grasshopper parameter used to handle <see cref="GooPolygonalFace3D"/> objects.
    /// </summary>
    public class GooPolygonalFace3DParam : GooGeometryParam<IPolygonalFace3D>
    {
        /// <summary>
        /// Gets the unique identifier for the component.
        /// </summary>
        public override Guid ComponentGuid => new("81f5aaec-0abd-470f-93b0-13cdce5aeb34");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        /// <summary>
        /// Initializes a new instance of the <see cref="GooPolygonalFace3DParam"/> class.
        /// </summary>
        public GooPolygonalFace3DParam()
            : base()
        {
        }
    }
}