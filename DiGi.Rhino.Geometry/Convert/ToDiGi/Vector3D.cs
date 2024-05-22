using DiGi.Geometry.Spatial.Classes;

namespace DiGi.Rhino.Geometry
{
    public static partial class Convert
    {
        public static Vector3D ToDiGi(this global::Rhino.Geometry.Vector3d vector3d)
        {
            if(!vector3d.IsValid)
            {
                return null;
            }

            return new Vector3D(vector3d.X, vector3d.Y, vector3d.Z);
        }
    }
}
