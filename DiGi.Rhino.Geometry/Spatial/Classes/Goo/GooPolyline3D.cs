using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using DiGi.Rhino.Geometry.Core.Classes;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.Rhino.Geometry.Spatial.Classes
{
    /// <summary>
    /// Represents a wrapper for a <see cref="Polyline3D"/> object to be used within the Grasshopper environment.
    /// </summary>
    public class GooPolyline3D : GooGeometry3D<Polyline3D>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GooPolyline3D"/> class.
        /// </summary>
        public GooPolyline3D()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GooPolyline3D"/> class with the specified polyline.
        /// </summary>
        /// <param name="polyline3D">The <see cref="Polyline3D"/> to wrap.</param>
        public GooPolyline3D(Polyline3D polyline3D)
        {
            Value = polyline3D;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GooPolyline3D"/> class by copying another <see cref="GooPolyline3D"/> instance.
        /// </summary>
        /// <param name="gooPolyline3D">The source <see cref="GooPolyline3D"/> to copy from.</param>
        public GooPolyline3D(GooPolyline3D gooPolyline3D)
        {
            Value = gooPolyline3D?.Value;
        }

        /// <summary>
        /// Creates a duplicate of the current <see cref="GooPolyline3D"/> instance.
        /// </summary>
        /// <returns>A new <see cref="IGH_Goo"/> object that is a copy of this instance.</returns>
        public override IGH_Goo Duplicate()
        {
            return new GooPolyline3D(this);
        }
    }

    /// <summary>
    /// Represents the parameter type for <see cref="GooPolyline3D"/> used in Grasshopper components.
    /// </summary>
    public class GooPolyline3DParam : GooGeometryParam<IPolygonalFace3D>
    {
        /// <summary>
        /// Gets the unique identifier for the component.
        /// </summary>
        public override Guid ComponentGuid => new("9e97b291-662d-4bdf-9ae7-d87427470db3");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        /// <summary>
        /// Initializes a new instance of the <see cref="GooPolyline3DParam"/> class.
        /// </summary>
        public GooPolyline3DParam()
            : base()
        {
        }
    }
}