using DiGi.Geometry.Spatial.Classes;
using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Geometry.Spatial.Classes;

namespace DiGi.Rhino.Geometry.Spatial
{
    public static partial class Inspect
    {
        /// <summary>
        /// Gets the direction vector of the specified ray as a <see cref="GooVector3D"/>.
        /// </summary>
        /// <param name="ray3D">The ray to inspect.</param>
        /// <returns>A <see cref="GooVector3D"/> representing the direction, or <c>null</c> if the ray or its direction is null.</returns>
        [Inspect("Direction", "Direction", "Direction")]
        public static GooVector3D? Direction(this Ray3D? ray3D)
        {
            if (ray3D == null)
            {
                return null;
            }

            Vector3D? direction = ray3D.Direction;

            return direction == null ? null : new GooVector3D(direction);
        }

        /// <summary>
        /// Gets the origin point of the specified ray as a <see cref="GooPoint3D"/>.
        /// </summary>
        /// <param name="ray3D">The ray to inspect.</param>
        /// <returns>A <see cref="GooPoint3D"/> representing the origin, or <c>null</c> if the ray or its origin is null.</returns>
        [Inspect("Origin", "Origin", "Origin")]
        public static GooPoint3D? Origin(this Ray3D? ray3D)
        {
            if (ray3D == null)
            {
                return null;
            }

            DiGi.Geometry.Spatial.Classes.Point3D? origin = ray3D.Origin;

            return origin == null ? null : new GooPoint3D(origin);
        }
    }
}