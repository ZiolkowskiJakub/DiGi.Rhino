using DiGi.Geometry.Spatial.Classes;

namespace DiGi.Rhino.Geometry.Spatial
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts a <see cref="Vector3D"/> to a Rhino <see cref="global::Rhino.Geometry.Vector3d"/>.
        /// </summary>
        /// <param name="vector3D">The source 3D vector to convert.</param>
        /// <returns>A Rhino <see cref="global::Rhino.Geometry.Vector3d"/> representation of the input vector, or <see cref="global::Rhino.Geometry.Vector3d.Unset"/> if the input is null.</returns>
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