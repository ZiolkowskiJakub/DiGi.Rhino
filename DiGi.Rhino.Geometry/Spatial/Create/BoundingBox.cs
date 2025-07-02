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
        public static BoundingBox BoundingBox(this IGeometry geometry)
        {
            if (geometry is IBoundable3D)
            {
                return Convert.ToRhino(((IBoundable3D)geometry).GetBoundingBox());
            }

            if (geometry is Point3D)
            {
                return Convert.ToRhino(new BoundingBox3D((Point3D)(object)geometry, DiGi.Core.Constans.Tolerance.Distance));
            }

            if (geometry is IBoundable2D)
            {
                IGeometry3D geometry3D = DiGi.Geometry.Spatial.Query.Convert(DiGi.Geometry.Spatial.Constans.Plane.WorldZ, (IGeometry2D)geometry);
                if (geometry3D is IBoundable3D)
                {
                    return Convert.ToRhino(((IBoundable3D)geometry3D).GetBoundingBox());
                }
            }
            else if (geometry is Point2D)
            {
                Point3D point3D = DiGi.Geometry.Spatial.Query.Convert(DiGi.Geometry.Spatial.Constans.Plane.WorldZ, (Point2D)(object)geometry);
                return Convert.ToRhino(new BoundingBox3D(point3D, DiGi.Core.Constans.Tolerance.Distance));
            }

            return global::Rhino.Geometry.BoundingBox.Unset;
        }

        public static BoundingBox BoundingBox(this IEnumerable<IGeometry> geometries)
        {
            if (geometries == null || geometries.Count() == 0)
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

        public static BoundingBox BoundingBox(this IIntersectionResult3D intersectionResult3D)
        {
            return BoundingBox(intersectionResult3D?.GetGeometry3Ds<IGeometry3D>()?.Cast<IGeometry>());
        }
    }
}
