using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using Grasshopper.Kernel.Types;

namespace DiGi.Rhino.Geometry.Spatial
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts a <see cref="Segment3D"/> to a Grasshopper <see cref="GH_Curve"/>.
        /// </summary>
        /// <param name="segment3D">The 3D line segment to convert.</param>
        /// <returns>A <see cref="GH_Curve"/> representing the segment, or <c>null</c> if the input is <c>null</c>.</returns>
        public static GH_Curve? ToGrasshopper(this Segment3D? segment3D)
        {
            if (segment3D == null)
            {
                return null;
            }

            return new GH_Curve(segment3D.ToRhino());
        }

        /// <summary>
        /// Converts an <see cref="IPolygonal3D"/> to a Grasshopper <see cref="GH_Curve"/>.
        /// </summary>
        /// <param name="polygonal3D">The polygonal object to convert.</param>
        /// <returns>A <see cref="GH_Curve"/> representing the polygonal object, or <c>null</c> if the input is <c>null</c>.</returns>
        public static GH_Curve? ToGrasshopper(this IPolygonal3D? polygonal3D)
        {
            if (polygonal3D == null)
            {
                return null;
            }

            return new GH_Curve(polygonal3D.ToRhino());
        }

        /// <summary>
        /// Converts a <see cref="Polyline3D"/> to a Grasshopper <see cref="GH_Curve"/>.
        /// </summary>
        /// <param name="polyline3D">The 3D polyline to convert.</param>
        /// <returns>A <see cref="GH_Curve"/> representing the polyline, or <c>null</c> if the input is <c>null</c>.</returns>
        public static GH_Curve? ToGrasshopper(this Polyline3D? polyline3D)
        {
            if (polyline3D == null)
            {
                return null;
            }

            return new GH_Curve(polyline3D.ToRhino());
        }
    }
}