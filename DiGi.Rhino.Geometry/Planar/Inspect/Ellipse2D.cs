using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Geometry.Planar.Classes;
using Grasshopper.Kernel.Types;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Rhino.Geometry.Planar
{
    public static partial class Inspect
    {
        /// <summary>
        /// Retrieves the semi-major axis length (A) of the specified 2D ellipse.
        /// </summary>
        /// <param name="ellipse2D">The 2D ellipse to inspect.</param>
        /// <returns>A <see cref="GH_Number"/> representing the semi-major axis length, or <c>null</c> if the ellipse is null.</returns>
        [Inspect("A", "A", "A")]
        public static GH_Number? A(this DiGi.Geometry.Planar.Classes.Ellipse2D? ellipse2D)
        {
            if (ellipse2D == null)
            {
                return null;
            }

            return new GH_Number(ellipse2D.A);
        }

        /// <summary>
        /// Retrieves the semi-minor axis length (B) of the specified 2D ellipse.
        /// </summary>
        /// <param name="ellipse2D">The 2D ellipse to inspect.</param>
        /// <returns>A <see cref="GH_Number"/> representing the semi-minor axis length, or <c>null</c> if the ellipse is null.</returns>
        [Inspect("B", "B", "B")]
        public static GH_Number? B(this DiGi.Geometry.Planar.Classes.Ellipse2D? ellipse2D)
        {
            if (ellipse2D == null)
            {
                return null;
            }

            return new GH_Number(ellipse2D.B);
        }

        /// <summary>
        /// Retrieves the centroid (center point) of the specified 2D ellipse.
        /// </summary>
        /// <param name="ellipse2D">The 2D ellipse to inspect.</param>
        /// <returns>A <see cref="GooPoint2D"/> representing the center point, or <c>null</c> if the ellipse is null.</returns>
        [Inspect("Center", "Center", "Center")]
        public static GooPoint2D? Centroid(this DiGi.Geometry.Planar.Classes.Ellipse2D? ellipse2D)
        {
            if (ellipse2D == null)
            {
                return null;
            }

            return new GooPoint2D(ellipse2D.Center);
        }

        /// <summary>
        /// Retrieves the focal points of the specified 2D ellipse.
        /// </summary>
        /// <param name="ellipse2D">The 2D ellipse to inspect.</param>
        /// <returns>A collection of <see cref="GooPoint2D"/> representing the focal points, or <c>null</c> if the ellipse is null.</returns>
        [Inspect("FocalPoints", "FocalPoints", "Focal Points")]
        public static IEnumerable<GooPoint2D>? FocalPoints(this DiGi.Geometry.Planar.Classes.Ellipse2D? ellipse2D)
        {
            if (ellipse2D == null)
            {
                return null;
            }

            return ellipse2D.GetFocalPoints()?.ToList().ConvertAll(x => new GooPoint2D(x));
        }
    }
}