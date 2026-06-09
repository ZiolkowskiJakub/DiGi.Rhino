using DiGi.Geometry.Spatial.Classes;

namespace DiGi.Rhino.Geometry.Spatial
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts a Rhino <see cref="global::Rhino.Geometry.Rectangle3d"/> to a DiGi <see cref="Rectangle3D"/>.
        /// </summary>
        /// <param name="rectangle3D">The Rhino rectangle to convert.</param>
        /// <returns>A <see cref="Rectangle3D"/> instance if the input rectangle is valid; otherwise, <c>null</c>.</returns>
        public static Rectangle3D? ToDiGi(this global::Rhino.Geometry.Rectangle3d rectangle3D)
        {
            if (!rectangle3D.IsValid)
            {
                return null;
            }

            return new Rectangle3D(rectangle3D.Plane.ToDiGi(), rectangle3D.Width, rectangle3D.Height);
        }
    }
}