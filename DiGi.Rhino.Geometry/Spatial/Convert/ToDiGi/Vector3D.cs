using DiGi.Geometry.Spatial.Classes;

namespace DiGi.Rhino.Geometry.Spatial
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts a Rhino <see cref="global::Rhino.Geometry.Vector3d"/> to a DiGi <see cref="Vector3D"/>.
        /// </summary>
        /// <param name="vector3d">The Rhino vector to convert.</param>
        /// <returns>A <see cref="Vector3D"/> instance if the input vector is valid; otherwise, <c>null</c>.</returns>
        public static Vector3D? ToDiGi(this global::Rhino.Geometry.Vector3d vector3d)
        {
            if (!vector3d.IsValid)
            {
                return null;
            }

            return new Vector3D(vector3d.X, vector3d.Y, vector3d.Z);
        }
    }
}