using DiGi.Geometry.Spatial.Classes;

namespace DiGi.Rhino.Geometry.Spatial
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts a Rhino Point3d to a DiGi Point3D.
        /// </summary>
        /// <param name="point3d">The Rhino Point3d instance to convert.</param>
        /// <returns>A <see cref="Point3D"/> if the input point is valid; otherwise, <c>null</c>.</returns>
        public static Point3D? ToDiGi(this global::Rhino.Geometry.Point3d point3d)
        {
            if (!point3d.IsValid)
            {
                return null;
            }

            return new Point3D(point3d.X, point3d.Y, point3d.Z);
        }

        /// <summary>
        /// Converts a Rhino Point3f to a DiGi Point3D.
        /// </summary>
        /// <param name="point3f">The Rhino Point3f instance to convert.</param>
        /// <returns>A <see cref="Point3D"/> if the input point is valid; otherwise, <c>null</c>.</returns>
        public static Point3D? ToDiGi(this global::Rhino.Geometry.Point3f point3f)
        {
            if (!point3f.IsValid)
            {
                return null;
            }

            return new Point3D(point3f.X, point3f.Y, point3f.Z);
        }
    }
}