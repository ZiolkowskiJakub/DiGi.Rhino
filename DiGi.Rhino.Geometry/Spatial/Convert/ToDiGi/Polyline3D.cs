using DiGi.Geometry.Spatial.Classes;
using System.Collections.Generic;

namespace DiGi.Rhino.Geometry.Spatial
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts a Rhino Geometry Polyline to a DiGi Polyline3D.
        /// </summary>
        /// <param name="polyline">The Rhino polyline instance to convert.</param>
        /// <returns>A new <see cref="Polyline3D"/> instance if the input is valid and not null; otherwise, <c>null</c>.</returns>
        public static Polyline3D? ToDiGi(this global::Rhino.Geometry.Polyline? polyline)
        {
            if (polyline == null || !polyline.IsValid)
            {
                return null;
            }

            List<Point3D> point3Ds = [];
            foreach (global::Rhino.Geometry.Point3d point3D in polyline)
            {
                if (point3D.ToDiGi() is Point3D point3D_Temp)
                {
                    point3Ds.Add(point3D_Temp);
                }
            }

            return new Polyline3D(point3Ds);
        }
    }
}