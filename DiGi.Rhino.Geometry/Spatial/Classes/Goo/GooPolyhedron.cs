using DiGi.Geometry.Spatial.Classes;
using DiGi.Rhino.Geometry.Core.Classes;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.Rhino.Geometry.Spatial.Classes
{
    /// <summary>
    /// Represents a Grasshopper Goo wrapper for a <see cref="Polyhedron"/> object.
    /// </summary>
    public class GooPolyhedron : GooGeometry3D<Polyhedron>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GooPolyhedron"/> class.
        /// </summary>
        public GooPolyhedron()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GooPolyhedron"/> class with the specified polyhedron.
        /// </summary>
        /// <param name="polyhedron">The <see cref="Polyhedron"/> to wrap.</param>
        public GooPolyhedron(Polyhedron? polyhedron)
        {
            Value = polyhedron;
        }

        /// <summary>
        /// Creates a duplicate of the current <see cref="GooPolyhedron"/> instance.
        /// </summary>
        /// <returns>A new <see cref="IGH_Goo"/> object containing a copy of the wrapped value.</returns>
        public override IGH_Goo Duplicate()
        {
            return new GooPolyhedron(Value);
        }
    }

    /// <summary>
    /// Represents a Grasshopper parameter type for <see cref="GooPolyhedron"/> objects.
    /// </summary>
    public class GooPolyhedronParam : GooGeometryParam<Polyhedron>
    {
        /// <summary>
        /// Gets the unique identifier for the polyhedron component.
        /// </summary>
        public override Guid ComponentGuid => new("e125980f-b14a-4f02-9910-55c2d093e13c");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        /// <summary>
        /// Initializes a new instance of the <see cref="GooPolyhedronParam"/> class.
        /// </summary>
        public GooPolyhedronParam()
            : base()
        {
        }
    }
}