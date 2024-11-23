using DiGi.Geometry.Spatial.Classes;

namespace DiGi.Rhino.Geometry
{
    public static partial class Convert
    {
        public static global::Rhino.Geometry.Point3d ToRhino(this Point3D point3D)
        {
            if (point3D == null)
            {
                return global::Rhino.Geometry.Point3d.Unset;
            }

            return new global::Rhino.Geometry.Point3d(point3D.X, point3D.Y, point3D.Z);
        }
    }
}
