using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using Rhino.Geometry;
using System.Collections.Generic;

namespace DiGi.Rhino.Geometry
{
    public static partial class Convert
    {
        public static PolylineCurve ToRhino(this IPolygonal3D polygonal3D)
        {
            List<Point3D> point3Ds = polygonal3D?.GetPoints();
            if(point3Ds == null)
            {
                return null;
            }

            List<Point3d> point3ds = point3Ds.ConvertAll(x => x.ToRhino());
            if(point3ds.Count > 1)
            {
                point3ds.Add(point3ds[0]);
            }

            if (point3ds == null || point3ds.Count < 2)
            {
                return null;
            }

            return new PolylineCurve(point3ds);

        }
    }
}