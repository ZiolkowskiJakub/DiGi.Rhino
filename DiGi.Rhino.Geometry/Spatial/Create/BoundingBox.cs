using DiGi.Geometry.Core.Interfaces;
using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using Rhino.Geometry;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Rhino.Geometry.Spatial
{
    public static partial class Create
    {
        /// <summary>
        /// Calculates the bounding box for the specified geometry.
        /// </summary>
        /// <param name="geometry">The geometry to calculate the bounding box for.</param>
        /// <returns>A <see cref="global::Rhino.Geometry.BoundingBox"/> representing the bounds of the geometry, or <see cref="BoundingBox.Unset"/> if the geometry is null or cannot be bounded.</returns>
        public static BoundingBox BoundingBox(this IGeometry? geometry)
        {
            if (geometry is IBoundable3D boundable3D)
            {
                return Convert.ToRhino(boundable3D.GetBoundingBox());
            }

            if (geometry is Point3D point3D)
            {
                return Convert.ToRhino(new BoundingBox3D(point3D, DiGi.Core.Constants.Tolerance.Distance));
            }

            if (geometry is IBoundable2D boundable2D)
            {
                IGeometry3D? geometry3D = DiGi.Geometry.Spatial.Query.Convert(DiGi.Geometry.Spatial.Constants.Plane.WorldZ, boundable2D);
                if (geometry3D is IBoundable3D boundable3D_Temp)
                {
                    return Convert.ToRhino(boundable3D_Temp.GetBoundingBox());
                }
            }
            else if (geometry is Point2D point2D)
            {
                Point3D? point3D_Temp = DiGi.Geometry.Spatial.Query.Convert(DiGi.Geometry.Spatial.Constants.Plane.WorldZ, point2D);
                return Convert.ToRhino(new BoundingBox3D(point3D_Temp, DiGi.Core.Constants.Tolerance.Distance));
            }

            return global::Rhino.Geometry.BoundingBox.Unset;
        }

        /// <summary>
        /// Calculates the unioned bounding box for a collection of geometries.
        /// </summary>
        /// <param name="geometries">The collection of geometries to evaluate.</param>
        /// <returns>A <see cref="global::Rhino.Geometry.BoundingBox"/> that encompasses all valid geometries in the collection, or <see cref="BoundingBox.Unset"/> if the collection is null or empty.</returns>
        public static BoundingBox BoundingBox(this IEnumerable<IGeometry>? geometries)
        {
            if (geometries == null || !geometries.Any())
            {
                return global::Rhino.Geometry.BoundingBox.Unset;
            }

            BoundingBox result = global::Rhino.Geometry.BoundingBox.Unset;
            foreach (IGeometry geometry in geometries)
            {
                if (geometry == null)
                {
                    continue;
                }

                BoundingBox boundingBox = BoundingBox(geometry);
                if (global::Rhino.Geometry.BoundingBox.Unset.Equals(boundingBox))
                {
                    continue;
                }

                if (global::Rhino.Geometry.BoundingBox.Unset.Equals(boundingBox))
                {
                    result = boundingBox;
                }
                else
                {
                    result.Union(boundingBox);
                }
            }

            return result;
        }

        /// <summary>
        /// Calculates the bounding box for the geometries resulting from a 3D intersection operation.
        /// </summary>
        /// <param name="intersectionResult3D">The intersection result containing the geometries.</param>
        /// <returns>A <see cref="global::Rhino.Geometry.BoundingBox"/> encompassing all resulting geometries, or <see cref="BoundingBox.Unset"/> if no valid geometry is found.</returns>
        public static BoundingBox BoundingBox(this IIntersectionResult3D? intersectionResult3D)
        {
            return BoundingBox(intersectionResult3D?.GetGeometry3Ds<IGeometry3D>()?.Cast<IGeometry>());
        }
    }
}