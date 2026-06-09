using DiGi.Geometry.Spatial.Classes;

namespace DiGi.Rhino.Geometry.Spatial
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts a <see cref="Point3D"/> to a Rhino <see cref="global::Rhino.Geometry.Point3d"/>.
        /// </summary>
        /// <param name="point3D">The 3D point to convert.</param>
        /// <returns>The equivalent Rhino <see cref="global::Rhino.Geometry.Point3d"/>, or <see cref="global::Rhino.Geometry.Point3d.Unset"/> if the input is null.</returns>
        public static global::Rhino.Geometry.Point3d ToRhino(this Point3D? point3D)
        {
            if (point3D == null)
            {
                return global::Rhino.Geometry.Point3d.Unset;
            }

            return new global::Rhino.Geometry.Point3d(point3D.X, point3D.Y, point3D.Z);
        }
    }
}