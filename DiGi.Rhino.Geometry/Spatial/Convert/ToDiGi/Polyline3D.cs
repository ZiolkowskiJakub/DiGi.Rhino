using DiGi.Geometry.Spatial.Classes;
using System.Collections.Generic;

namespace DiGi.Rhino.Geometry.Spatial
{
    public static partial class Convert
    {
        public static Polyline3D? ToDiGi(this global::Rhino.Geometry.Polyline? polyline)
        {
            if(polyline == null || !polyline.IsValid)
            {
                return null;
            }

            List<Point3D> point3Ds = [];
            foreach(global::Rhino.Geometry.Point3d point3D in polyline)
            {
                if(point3D.ToDiGi() is Point3D point3D_Temp)
                {
                    point3Ds.Add(point3D_Temp);
                }
                
            }

            return new Polyline3D(point3Ds);
        }
    }
}
