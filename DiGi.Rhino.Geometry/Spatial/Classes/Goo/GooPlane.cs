using DiGi.Geometry.Spatial.Classes;
using DiGi.Rhino.Geometry.Core.Classes;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.Rhino.Geometry.Spatial.Classes
{
    /// <summary>
    /// Represents a Goo wrapper for a <see cref="Plane"/> geometry object, allowing it to be passed through Grasshopper wires.
    /// </summary>
    public class GooPlane : GooGeometry3D<Plane>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GooPlane"/> class.
        /// </summary>
        public GooPlane()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GooPlane"/> class with the specified plane value.
        /// </summary>
        /// <param name="plane">The <see cref="Plane"/> to be wrapped in this Goo object.</param>
        public GooPlane(Plane? plane)
        {
            Value = plane;
        }

        /// <summary>
        /// Creates a duplicate of the current <see cref="GooPlane"/> instance.
        /// </summary>
        /// <returns>A new <see cref="IGH_Goo"/> object containing a copy of the original plane value.</returns>
        public override IGH_Goo Duplicate()
        {
            return new GooPlane(Value);
        }
    }

    /// <summary>
    /// Represents a Grasshopper parameter used to handle <see cref="GooPlane"/> objects.
    /// </summary>
    public class GooPlaneParam : GooGeometryParam<Plane>
    {
        /// <summary>
        /// Gets the unique identifier for the plane component.
        /// </summary>
        public override Guid ComponentGuid => new("3c36ec41-1560-4ec9-93cc-01bc990f5486");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        /// <summary>
        /// Initializes a new instance of the <see cref="GooPlaneParam"/> class.
        /// </summary>
        public GooPlaneParam()
            : base()
        {
        }
    }
}