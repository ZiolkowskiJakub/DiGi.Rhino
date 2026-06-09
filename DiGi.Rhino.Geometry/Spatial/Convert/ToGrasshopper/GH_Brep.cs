using DiGi.Geometry.Spatial.Classes;
using Grasshopper.Kernel.Types;

namespace DiGi.Rhino.Geometry.Spatial
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts a planar polygonal face to a Grasshopper Brep.
        /// </summary>
        /// <param name="polygonalFace3D">The polygonal face to convert.</param>
        /// <param name="tolerance">The distance tolerance used for the conversion.</param>
        /// <returns>A <see cref="GH_Brep"/> representation of the polygonal face, or <c>null</c> if the input is null.</returns>
        public static GH_Brep? ToGrasshopper(this PolygonalFace3D? polygonalFace3D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (polygonalFace3D == null)
            {
                return null;
            }

            return new GH_Brep(polygonalFace3D.ToRhino(tolerance));
        }

        /// <summary>
        /// Converts a polyhedron to a Grasshopper Brep.
        /// </summary>
        /// <param name="polyhedron">The polyhedron to convert.</param>
        /// <param name="tolerance">The distance tolerance used for the conversion.</param>
        /// <returns>A <see cref="GH_Brep"/> representation of the polyhedron, or <c>null</c> if the input is null.</returns>
        public static GH_Brep? ToGrasshopper(this Polyhedron? polyhedron, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (polyhedron == null)
            {
                return null;
            }

            return new GH_Brep(polyhedron.ToRhino(tolerance));
        }

        /// <summary>
        /// Converts an ellipsoid to a Grasshopper Brep.
        /// </summary>
        /// <param name="ellipsoid">The ellipsoid to convert.</param>
        /// <returns>A <see cref="GH_Brep"/> representation of the ellipsoid, or <c>null</c> if the input is null.</returns>
        public static GH_Brep? ToGrasshopper(this Ellipsoid? ellipsoid)
        {
            if (ellipsoid == null)
            {
                return null;
            }

            return new GH_Brep(ellipsoid.ToRhino());
        }
    }
}