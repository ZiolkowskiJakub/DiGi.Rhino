using DiGi.Rhino.Geometry.Core.Classes;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.Rhino.Geometry.Spatial.Classes
{
    /// <summary>
    /// Represents a Goo wrapper for an ellipsoid geometry, allowing it to be passed through Grasshopper components.
    /// </summary>
    public class GooEllipsoid : GooGeometry3D<DiGi.Geometry.Spatial.Classes.Ellipsoid>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GooEllipsoid"/> class.
        /// </summary>
        public GooEllipsoid()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GooEllipsoid"/> class with the specified ellipsoid value.
        /// </summary>
        /// <param name="ellipsoid">The ellipsoid geometry to wrap.</param>
        public GooEllipsoid(DiGi.Geometry.Spatial.Classes.Ellipsoid? ellipsoid)
        {
            Value = ellipsoid;
        }

        /// <summary>
        /// Creates a duplicate of the current <see cref="GooEllipsoid"/> instance.
        /// </summary>
        /// <returns>A new <see cref="IGH_Goo"/> object containing a copy of the ellipsoid value.</returns>
        public override IGH_Goo Duplicate()
        {
            return new GooEllipsoid(Value);
        }
    }

    /// <summary>
    /// Represents a Grasshopper parameter type for handling <see cref="GooEllipsoid"/> objects.
    /// </summary>
    public class GooEllipsoidParam : GooGeometryParam<DiGi.Geometry.Spatial.Classes.Ellipsoid>
    {
        /// <summary>
        /// Gets the unique identifier for the component associated with this parameter.
        /// </summary>
        public override Guid ComponentGuid => new("528cbdfc-6142-4856-9eab-38c9a20dadbc");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        /// <summary>
        /// Initializes a new instance of the <see cref="GooEllipsoidParam"/> class.
        /// </summary>
        public GooEllipsoidParam()
            : base()
        {
        }
    }
}