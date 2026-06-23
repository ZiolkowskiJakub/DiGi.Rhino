using DiGi.Geometry.Spatial.Classes;
using DiGi.Rhino.Geometry.Core.Classes;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.Rhino.Geometry.Spatial.Classes
{
    /// <summary>
    /// Represents a Grasshopper Goo wrapper for a <see cref="Ray3D"/>.
    /// </summary>
    public class GooRay3D : GooGeometry3D<Ray3D>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GooRay3D"/> class.
        /// </summary>
        public GooRay3D()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GooRay3D"/> class with the specified ray.
        /// </summary>
        /// <param name="ray3D">The 3D ray to wrap.</param>
        public GooRay3D(Ray3D? ray3D)
        {
            Value = ray3D;
        }

        /// <summary>
        /// Creates a duplicate of this Goo object.
        /// </summary>
        /// <returns>A copy of the current <see cref="GooRay3D"/> instance.</returns>
        public override IGH_Goo Duplicate()
        {
            return new GooRay3D(Value);
        }
    }

    /// <summary>
    /// Represents a Grasshopper parameter for 3D rays.
    /// </summary>
    public class GooRay3DParam : GooGeometryParam<Ray3D>
    {
        /// <summary> Gets the unique identifier for the component. </summary>
        public override Guid ComponentGuid => new("2977f462-45d4-4ec0-8152-83f5800ef328");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        /// <summary>
        /// Initializes a new instance of the <see cref="GooRay3DParam"/> class.
        /// </summary>
        public GooRay3DParam()
            : base()
        {
        }
    }
}