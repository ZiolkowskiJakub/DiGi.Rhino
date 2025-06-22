using DiGi.Geometry.Core.Interfaces;
using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using Rhino.Geometry;
using System.Collections.Generic;

namespace DiGi.Rhino.Geometry
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

        public static BoundingBox BoundingBox(this IIntersectionResult3D intersectionResult3D)
        {
            List<IGeometry3D> geometry3Ds = intersectionResult3D?.GetGeometry3Ds<IGeometry3D>();
            if(geometry3Ds == null || geometry3Ds.Count == 0)
            {
                return global::Rhino.Geometry.BoundingBox.Unset;
            }

            BoundingBox result = global::Rhino.Geometry.BoundingBox.Unset;
            foreach(IGeometry3D geometry3D in geometry3Ds)
            {
                if(geometry3D == null)
                {
                    continue;
                }

                BoundingBox boundingBox = BoundingBox(geometry3D);
                if(global::Rhino.Geometry.BoundingBox.Unset.Equals(boundingBox))
                {
                    continue;
                }

                if(global::Rhino.Geometry.BoundingBox.Unset.Equals(boundingBox))
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
    }
}
