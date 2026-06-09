using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Geometry.Planar.Classes;

namespace DiGi.Rhino.Geometry.Planar
{
    public static partial class Inspect
    {
        /// <summary>
        /// Calculates the 2D bounding box for the specified boundable 2D object.
        /// </summary>
        /// <param name="boundable2D">The 2D object that implements <see cref="DiGi.Geometry.Planar.Interfaces.IBoundable2D"/>.</param>
        /// <returns>A <see cref="GooBoundingBox2D"/> representing the bounding box, or <c>null</c> if the provided <paramref name="boundable2D"/> is null.</returns>
        [Inspect("BoundinBox2D", "BoundinBox2D", "BoundinBox2D")]
        public static GooBoundingBox2D? BoundinBox2D(this DiGi.Geometry.Planar.Interfaces.IBoundable2D? boundable2D)
        {
            if (boundable2D == null)
            {
                return null;
            }

            return new GooBoundingBox2D(boundable2D.GetBoundingBox());
        }
    }
}