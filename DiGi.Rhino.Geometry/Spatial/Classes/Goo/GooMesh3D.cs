using DiGi.Geometry.Spatial.Classes;
using DiGi.Rhino.Geometry.Core.Classes;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.Rhino.Geometry.Spatial.Classes
{
    /// <summary>
    /// Represents a wrapper for a 3D mesh object, allowing it to be passed through the Grasshopper data pipeline.
    /// </summary>
    public class GooMesh3D : GooGeometry3D<Mesh3D>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GooMesh3D"/> class.
        /// </summary>
        public GooMesh3D()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GooMesh3D"/> class with the specified mesh.
        /// </summary>
        /// <param name="mesh3D">The 3D mesh to wrap.</param>
        public GooMesh3D(Mesh3D? mesh3D)
        {
            Value = mesh3D;
        }

        /// <summary>
        /// Creates a duplicate of the current Goo object.
        /// </summary>
        /// <returns>A new <see cref="GooMesh3D"/> instance containing the same value.</returns>
        public override IGH_Goo Duplicate()
        {
            return new GooMesh3D(Value);
        }
    }

    /// <summary>
    /// Represents the Grasshopper parameter type for 3D mesh objects.
    /// </summary>
    public class GooMesh3DParam : GooGeometryParam<Mesh3D>
    {
        /// <summary>
        /// Gets the unique identifier for the component associated with this parameter.
        /// </summary>
        /// <value>The GUID of the component.</value>
        public override Guid ComponentGuid => new("ec6450c0-08fd-4959-be9b-647687d61980");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        /// <summary>
        /// Initializes a new instance of the <see cref="GooMesh3DParam"/> class.
        /// </summary>
        public GooMesh3DParam()
            : base()
        {
        }
    }
}