using DiGi.Geometry.Spatial.Classes;

namespace DiGi.Rhino.Geometry.Spatial
{
    public static partial class Convert
    {
        public static global::Rhino.Geometry.Vector3d ToRhino(this Vector3D vector3D)
        {
            if (vector3D == null)
            {
                return global::Rhino.Geometry.Vector3d.Unset;
            }

            return new global::Rhino.Geometry.Vector3d(vector3D.X, vector3D.Y, vector3D.Z);
        }
    }
}
