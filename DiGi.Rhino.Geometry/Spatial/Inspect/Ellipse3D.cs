using DiGi.Geometry.Spatial.Classes;
using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Geometry.Spatial.Classes;
using Grasshopper.Kernel.Types;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Rhino.Geometry.Spatial
{
    public static partial class Inspect
    {
        /// <summary>
        /// Gets the semi-major axis length of the specified 3D ellipse.
        /// </summary>
        /// <param name="ellipse3D">The 3D ellipse to inspect.</param>
        /// <returns>The semi-major axis length as a <see cref="GH_Number"/>, or null if the ellipse is null.</returns>
        [Inspect("A", "A", "A")]
        public static GH_Number? A(this Ellipse3D? ellipse3D)
        {
            if (ellipse3D == null)
            {
                return null;
            }

            return new GH_Number(ellipse3D.A);
        }

        /// <summary>
        /// Gets the semi-minor axis length of the specified 3D ellipse.
        /// </summary>
        /// <param name="ellipse3D">The 3D ellipse to inspect.</param>
        /// <returns>The semi-minor axis length as a <see cref="GH_Number"/>, or null if the ellipse is null.</returns>
        [Inspect("B", "B", "B")]
        public static GH_Number? B(this Ellipse3D? ellipse3D)
        {
            if (ellipse3D == null)
            {
                return null;
            }

            return new GH_Number(ellipse3D.B);
        }

        /// <summary>
        /// Gets the center point of the specified 3D ellipse.
        /// </summary>
        /// <param name="ellipse3D">The 3D ellipse to inspect.</param>
        /// <returns>The center point as a <see cref="GooPoint3D"/>, or null if the ellipse is null.</returns>
        [Inspect("Center", "Center", "Center")]
        public static GooPoint3D? Center(this Ellipse3D? ellipse3D)
        {
            if (ellipse3D == null)
            {
                return null;
            }

            return new GooPoint3D(ellipse3D.Center);
        }

        /// <summary>
        /// Gets the focal points of the specified 3D ellipse.
        /// </summary>
        /// <param name="ellipse3D">The 3D ellipse to inspect.</param>
        /// <returns>A collection of focal points as <see cref="GooPoint3D"/>, or null if the ellipse is null.</returns>
        [Inspect("FocalPoints", "FocalPoints", "Focal Points")]
        public static IEnumerable<GooPoint3D>? FocalPoints(this Ellipse3D? ellipse3D)
        {
            if (ellipse3D == null)
            {
                return null;
            }

            return ellipse3D.GetFocalPoints()?.ToList().ConvertAll(x => new GooPoint3D(x));
        }

        /// <summary>
        /// Gets the plane on which the specified 3D ellipse is defined.
        /// </summary>
        /// <param name="ellipse3D">The 3D ellipse to inspect.</param>
        /// <returns>The plane as a <see cref="GooPlane"/>, or null if the ellipse is null.</returns>
        [Inspect("Plane", "Plane", "Plane")]
        public static GooPlane? Plane(this Ellipse3D? ellipse3D)
        {
            if (ellipse3D == null)
            {
                return null;
            }

            return new GooPlane(ellipse3D.Plane);
        }
    }
}