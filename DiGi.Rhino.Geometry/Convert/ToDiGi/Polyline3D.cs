using DiGi.Geometry.Spatial.Classes;
using System.Collections.Generic;

namespace DiGi.Rhino.Geometry
{
    public static partial class Convert
    {
        public static Polyline3D ToDiGi(this global::Rhino.Geometry.Polyline polyline)
        {
            if(polyline == null || !polyline.IsValid)
            {
                return null;
            }

            List<Point3D> point3Ds = new List<Point3D>();
            foreach(global::Rhino.Geometry.Point3d point3D in polyline)
            {
                point3Ds.Add(point3D.ToDiGi());
            }

            return new Polyline3D(point3Ds);
        }
    }
}
