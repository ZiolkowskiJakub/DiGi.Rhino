using DiGi.Rhino.Geometry.Core.Classes;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.Rhino.Geometry.Spatial.Classes
{
    /// <summary>
    /// Represents a wrapper for a 3D point that can be passed through Grasshopper components.
    /// </summary>
    public class GooPoint3D : GooGeometry3D<DiGi.Geometry.Spatial.Classes.Point3D>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GooPoint3D"/> class.
        /// </summary>
        public GooPoint3D()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GooPoint3D"/> class with the specified 3D point value.
        /// </summary>
        /// <param name="point3D">The 3D point to wrap.</param>
        public GooPoint3D(DiGi.Geometry.Spatial.Classes.Point3D? point3D)
        {
            Value = point3D;
        }

        /// <summary>
        /// Creates a duplicate of the current <see cref="GooPoint3D"/> instance.
        /// </summary>
        /// <returns>A new <see cref="IGH_Goo"/> object containing a copy of the original value.</returns>
        public override IGH_Goo Duplicate()
        {
            return new GooPoint3D(Value);
        }
    }

    /// <summary>
    /// Represents a Grasshopper parameter type for 3D points.
    /// </summary>
    public class GooPoint3DParam : GooGeometryParam<DiGi.Geometry.Spatial.Classes.Point3D>
    {
        /// <summary>
        /// Gets the unique identifier for the component associated with this parameter.
        /// </summary>
        public override Guid ComponentGuid => new("baacf835-6a09-41d4-9219-dd9ef1b54a0e");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        /// <summary>
        /// Initializes a new instance of the <see cref="GooPoint3DParam"/> class.
        /// </summary>
        public GooPoint3DParam()
            : base()
        {
        }
    }
}