using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;

namespace DiGi.Rhino.Geometry
{
    public static partial class Convert
    {
        public static Point3D ToDiGi(this global::Rhino.Geometry.Point3d point3d)
        {
            if(!point3d.IsValid)
            {
                return null;
            }

            return new Point3D(point3d.X, point3d.Y, point3d.Z);
        }
    }
}
