using DiGi.Geometry.Spatial.Classes;
using DiGi.Rhino.Geometry.Core.Classes;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.Rhino.Geometry.Spatial.Classes
{
    /// <summary>
    /// Represents a wrapper for a 3D vector used within the Grasshopper environment.
    /// </summary>
    public class GooVector3D : GooGeometry3D<Vector3D>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GooVector3D"/> class.
        /// </summary>
        public GooVector3D()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GooVector3D"/> class with the specified vector value.
        /// </summary>
        /// <param name="vector3D">The 3D vector to wrap.</param>
        public GooVector3D(Vector3D? vector3D)
        {
            Value = vector3D;
        }

        /// <summary>
        /// Creates a duplicate of the current <see cref="GooVector3D"/> instance.
        /// </summary>
        /// <returns>A new <see cref="IGH_Goo"/> object containing a copy of the value.</returns>
        public override IGH_Goo Duplicate()
        {
            return new GooVector3D(Value);
        }
    }

    /// <summary>
    /// Represents a Grasshopper parameter type for 3D vectors.
    /// </summary>
    public class GooVector3DParam : GooGeometryParam<Vector3D>
    {
        /// <summary>
        /// Gets the unique identifier for the <see cref="GooVector3DParam"/> component.
        /// </summary>
        /// <value>The GUID of the component.</value>
        public override Guid ComponentGuid => new("e441884e-b98c-4e51-8f67-71ad21fcf07f");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        /// <summary>
        /// Initializes a new instance of the <see cref="GooVector3DParam"/> class.
        /// </summary>
        public GooVector3DParam()
            : base()
        {
        }
    }
}