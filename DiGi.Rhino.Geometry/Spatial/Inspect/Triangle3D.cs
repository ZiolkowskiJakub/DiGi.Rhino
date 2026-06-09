using DiGi.Geometry.Spatial.Classes;
using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Geometry.Spatial.Classes;
using Grasshopper.Kernel.Types;
using System.Collections.Generic;

namespace DiGi.Rhino.Geometry.Spatial
{
    public static partial class Inspect
    {
        /// <summary>
        /// Gets the vertices of the specified 3D triangle as a collection of <see cref="GooPoint3D"/>.
        /// </summary>
        /// <param name="triangle3D">The 3D triangle to inspect.</param>
        /// <returns>A collection of points representing the triangle's vertices, or <c>null</c> if the triangle is null.</returns>
        [Inspect("Points", "Points", "Points")]
        public static IEnumerable<GooPoint3D>? Points(this Triangle3D? triangle3D)
        {
            if (triangle3D == null)
            {
                return null;
            }

            return triangle3D.GetPoints()?.ConvertAll(x => new GooPoint3D(x));
        }

        /// <summary>
        /// Gets the centroid of the specified 3D triangle as a <see cref="GooPoint3D"/>.
        /// </summary>
        /// <param name="triangle3D">The 3D triangle to inspect.</param>
        /// <returns>The centroid point of the triangle, or <c>null</c> if the triangle is null.</returns>
        [Inspect("Centroid", "Centroid", "Centroid")]
        public static GooPoint3D? Centroid(this Triangle3D? triangle3D)
        {
            if (triangle3D == null)
            {
                return null;
            }

            return new GooPoint3D(triangle3D.GetCentroid());
        }

        /// <summary>
        /// Gets the area of the specified 3D triangle as a <see cref="GH_Number"/>.
        /// </summary>
        /// <param name="triangle3D">The 3D triangle to inspect.</param>
        /// <returns>The area of the triangle, or <c>null</c> if the triangle is null.</returns>
        [Inspect("Area", "Area", "Area")]
        public static GH_Number? Area(this Triangle3D? triangle3D)
        {
            if (triangle3D == null)
            {
                return null;
            }

            return new GH_Number(triangle3D.GetArea());
        }

        /// <summary>
        /// Gets the segments forming the perimeter of the specified 3D triangle as a collection of <see cref="GooSegment3D"/>.
        /// </summary>
        /// <param name="triangle3D">The 3D triangle to inspect.</param>
        /// <returns>A collection of segments representing the triangle's edges, or <c>null</c> if the triangle is null.</returns>
        [Inspect("Segments", "Segments", "Segments")]
        public static IEnumerable<GooSegment3D>? Segments(this Triangle3D? triangle3D)
        {
            if (triangle3D == null)
            {
                return null;
            }

            return triangle3D.GetSegments()?.ConvertAll(x => new GooSegment3D(x));
        }

        /// <summary>
        /// Gets the total perimeter length of the specified 3D triangle as a <see cref="GH_Number"/>.
        /// </summary>
        /// <param name="triangle3D">The 3D triangle to inspect.</param>
        /// <returns>The total length of the triangle's edges, or <c>null</c> if the triangle is null.</returns>
        [Inspect("Length", "Length", "Length")]
        public static GH_Number? Length(this Triangle3D? triangle3D)
        {
            if (triangle3D == null)
            {
                return null;
            }

            return new GH_Number(triangle3D.Length);
        }

        /// <summary>
        /// Gets the plane on which the specified 3D triangle lies as a <see cref="GooPlane"/>.
        /// </summary>
        /// <param name="triangle3D">The 3D triangle to inspect.</param>
        /// <returns>The plane of the triangle, or <c>null</c> if the triangle is null.</returns>
        [Inspect("Plane", "Plane", "Plane")]
        public static GooPlane? Plane(this Triangle3D? triangle3D)
        {
            if (triangle3D == null)
            {
                return null;
            }

            return new GooPlane(triangle3D.Plane);
        }
    }
}