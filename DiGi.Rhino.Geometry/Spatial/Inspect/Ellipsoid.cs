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
        /// Gets the length of semi-axis A of the specified ellipsoid.
        /// </summary>
        /// <param name="ellipsoid">The ellipsoid to inspect.</param>
        /// <returns>The length of semi-axis A as a <see cref="GH_Number"/>, or <c>null</c> if the ellipsoid is null.</returns>
        [Inspect("A", "A", "A")]
        public static GH_Number? A(this DiGi.Geometry.Spatial.Classes.Ellipsoid? ellipsoid)
        {
            if (ellipsoid == null)
            {
                return null;
            }

            return new GH_Number(ellipsoid.A);
        }

        /// <summary>
        /// Gets the length of semi-axis B of the specified ellipsoid.
        /// </summary>
        /// <param name="ellipsoid">The ellipsoid to inspect.</param>
        /// <returns>The length of semi-axis B as a <see cref="GH_Number"/>, or <c>null</c> if the ellipsoid is null.</returns>
        [Inspect("B", "B", "B")]
        public static GH_Number? B(this DiGi.Geometry.Spatial.Classes.Ellipsoid? ellipsoid)
        {
            if (ellipsoid == null)
            {
                return null;
            }

            return new GH_Number(ellipsoid.B);
        }

        /// <summary>
        /// Gets the length of semi-axis C of the specified ellipsoid.
        /// </summary>
        /// <param name="ellipsoid">The ellipsoid to inspect.</param>
        /// <returns>The length of semi-axis C as a <see cref="GH_Number"/>, or <c>null</c> if the ellipsoid is null.</returns>
        [Inspect("C", "C", "C")]
        public static GH_Number? C(this DiGi.Geometry.Spatial.Classes.Ellipsoid? ellipsoid)
        {
            if (ellipsoid == null)
            {
                return null;
            }

            return new GH_Number(ellipsoid.C);
        }

        /// <summary>
        /// Gets the center point of the specified ellipsoid.
        /// </summary>
        /// <param name="ellipsoid">The ellipsoid to inspect.</param>
        /// <returns>The center point as a <see cref="GooPoint3D"/>, or <c>null</c> if the ellipsoid is null.</returns>
        [Inspect("Center", "Center", "Center")]
        public static GooPoint3D? Center(this DiGi.Geometry.Spatial.Classes.Ellipsoid? ellipsoid)
        {
            if (ellipsoid == null)
            {
                return null;
            }

            return new GooPoint3D(ellipsoid.Center);
        }

        /// <summary>
        /// Gets the direction vector of semi-axis A of the specified ellipsoid.
        /// </summary>
        /// <param name="ellipsoid">The ellipsoid to inspect.</param>
        /// <returns>The direction vector A as a <see cref="GooVector3D"/>, or <c>null</c> if the ellipsoid is null.</returns>
        [Inspect("DirectionA", "DirectionA", "Direction A")]
        public static GooVector3D? DirectionA(this DiGi.Geometry.Spatial.Classes.Ellipsoid? ellipsoid)
        {
            if (ellipsoid == null)
            {
                return null;
            }

            return new GooVector3D(ellipsoid.DirectionA);
        }

        /// <summary>
        /// Gets the direction vector of semi-axis B of the specified ellipsoid.
        /// </summary>
        /// <param name="ellipsoid">The ellipsoid to inspect.</param>
        /// <returns>The direction vector B as a <see cref="GooVector3D"/>, or <c>null</c> if the ellipsoid is null.</returns>
        [Inspect("DirectionB", "DirectionB", "Direction B")]
        public static GooVector3D? DirectionB(this DiGi.Geometry.Spatial.Classes.Ellipsoid? ellipsoid)
        {
            if (ellipsoid == null)
            {
                return null;
            }

            return new GooVector3D(ellipsoid.DirectionB);
        }

        /// <summary>
        /// Gets the direction vector of semi-axis C of the specified ellipsoid.
        /// </summary>
        /// <param name="ellipsoid">The ellipsoid to inspect.</param>
        /// <returns>The direction vector C as a <see cref="GooVector3D"/>, or <c>null</c> if the ellipsoid is null.</returns>
        [Inspect("DirectionC", "DirectionC", "Direction C")]
        public static GooVector3D? DirectionC(this DiGi.Geometry.Spatial.Classes.Ellipsoid? ellipsoid)
        {
            if (ellipsoid == null)
            {
                return null;
            }

            return new GooVector3D(ellipsoid.DirectionC);
        }

        /// <summary>
        /// Gets the focal points of the specified ellipsoid.
        /// </summary>
        /// <param name="ellipsoid">The ellipsoid to inspect.</param>
        /// <returns>A collection of focal points as <see cref="GooPoint3D"/>, or <c>null</c> if the ellipsoid is null.</returns>
        [Inspect("FocalPoints", "FocalPoints", "Focal Points")]
        public static IEnumerable<GooPoint3D>? FocalPoints(this DiGi.Geometry.Spatial.Classes.Ellipsoid? ellipsoid)
        {
            if (ellipsoid == null)
            {
                return null;
            }

            return ellipsoid.GetFocalPoints()?.ToList().ConvertAll(x => new GooPoint3D(x));
        }
    }
}