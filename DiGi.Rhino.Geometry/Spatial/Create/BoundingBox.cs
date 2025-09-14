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
        public static BoundingBox BoundingBox(this IGeometry? geometry)
        {
            if (geometry is IBoundable3D boundable3D)
            {
                return Convert.ToRhino(boundable3D.GetBoundingBox());
            }

            if (geometry is Point3D point3D)
            {
                return Convert.ToRhino(new BoundingBox3D(point3D, DiGi.Core.Constans.Tolerance.Distance));
            }

            if (geometry is IBoundable2D boundable2D)
            {
                IGeometry3D? geometry3D = DiGi.Geometry.Spatial.Query.Convert(DiGi.Geometry.Spatial.Constans.Plane.WorldZ, boundable2D);
                if (geometry3D is IBoundable3D boundable3D_Temp)
                {
                    return Convert.ToRhino(boundable3D_Temp.GetBoundingBox());
                }
            }
            else if (geometry is Point2D point2D)
            {
                Point3D? point3D_Temp = DiGi.Geometry.Spatial.Query.Convert(DiGi.Geometry.Spatial.Constans.Plane.WorldZ, point2D);
                return Convert.ToRhino(new BoundingBox3D(point3D_Temp, DiGi.Core.Constans.Tolerance.Distance));
            }

            return global::Rhino.Geometry.BoundingBox.Unset;
        }

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

        public static BoundingBox BoundingBox(this IIntersectionResult3D? intersectionResult3D)
        {
            return BoundingBox(intersectionResult3D?.GetGeometry3Ds<IGeometry3D>()?.Cast<IGeometry>());
        }
    }
}
