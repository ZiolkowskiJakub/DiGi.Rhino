using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using Rhino.Geometry;
using System.Collections.Generic;

namespace DiGi.Rhino.Geometry.Spatial
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts an <see cref="IPolygonal3D"/> instance to a Rhino <see cref="PolylineCurve"/>.
        /// </summary>
        /// <param name="polygonal3D">The polygonal 3D object to convert.</param>
        /// <returns>A <see cref="PolylineCurve"/> representing the polygonal object, or <c>null</c> if the input is null or contains insufficient points for a curve.</returns>
        public static PolylineCurve? ToRhino(this IPolygonal3D? polygonal3D)
        {
            List<Point3D>? point3Ds = polygonal3D?.GetPoints();
            if (point3Ds == null)
            {
                return null;
            }

            List<Point3d>? point3ds = point3Ds.ConvertAll(x => x.ToRhino());
            if (point3ds.Count > 1)
            {
                point3ds.Add(point3ds[0]);
            }

            if (point3ds == null || point3ds.Count < 2)
            {
                return null;
            }

            return new PolylineCurve(point3ds);
        }

        /// <summary>
        /// Converts a <see cref="Polyline3D"/> instance to a Rhino <see cref="PolylineCurve"/>.
        /// </summary>
        /// <param name="polyline3D">The polyline 3D object to convert.</param>
        /// <returns>A <see cref="PolylineCurve"/> representing the polyline, or <c>null</c> if the input is null or contains insufficient points for a curve.</returns>
        public static PolylineCurve? ToRhino(this Polyline3D? polyline3D)
        {
            List<Point3D>? point3Ds = polyline3D?.GetPoints();
            if (point3Ds == null)
            {
                return null;
            }

            List<Point3d> point3ds = point3Ds.ConvertAll(x => x.ToRhino());
            if (point3ds == null || point3ds.Count < 2)
            {
                return null;
            }

            return new PolylineCurve(point3ds);
        }
    }
}