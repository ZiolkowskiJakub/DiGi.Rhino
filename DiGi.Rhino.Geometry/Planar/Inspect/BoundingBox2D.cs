using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Geometry.Planar.Classes;
using Grasshopper.Kernel.Types;
using System.Collections.Generic;

namespace DiGi.Rhino.Geometry.Planar
{
    public static partial class Inspect
    {
        /// <summary>
        /// Gets the bottom-left corner of the specified 2D bounding box.
        /// </summary>
        /// <param name="boundingBox2D">The 2D bounding box to inspect.</param>
        /// <returns>A <see cref="GooPoint2D"/> representing the bottom-left corner, or null if the bounding box is null.</returns>
        [Inspect("BottomLeft", "BottomLeft", "Bottom Left Corrner")]
        public static GooPoint2D? BottomLeft(this DiGi.Geometry.Planar.Classes.BoundingBox2D? boundingBox2D)
        {
            if (boundingBox2D == null)
            {
                return null;
            }

            return new GooPoint2D(boundingBox2D.BottomLeft);
        }

        /// <summary>
        /// Gets the bottom-right corner of the specified 2D bounding box.
        /// </summary>
        /// <param name="boundingBox2D">The 2D bounding box to inspect.</param>
        /// <returns>A <see cref="GooPoint2D"/> representing the bottom-right corner, or null if the bounding box is null.</returns>
        [Inspect("BottomRight", "BottomRight", "Bottom Right Corrner")]
        public static GooPoint2D? BottomRight(this DiGi.Geometry.Planar.Classes.BoundingBox2D? boundingBox2D)
        {
            if (boundingBox2D == null)
            {
                return null;
            }

            return new GooPoint2D(boundingBox2D.BottomRight);
        }

        /// <summary>
        /// Gets the centroid of the specified 2D bounding box.
        /// </summary>
        /// <param name="boundingBox2D">The 2D bounding box to inspect.</param>
        /// <returns>A <see cref="GooPoint2D"/> representing the centroid, or null if the bounding box is null.</returns>
        [Inspect("Centroid", "Centroid", "Centroid")]
        public static GooPoint2D? Centroid(this DiGi.Geometry.Planar.Classes.BoundingBox2D? boundingBox2D)
        {
            if (boundingBox2D == null)
            {
                return null;
            }

            return new GooPoint2D(boundingBox2D.GetCentroid());
        }

        /// <summary>
        /// Gets the height of the specified 2D bounding box.
        /// </summary>
        /// <param name="boundingBox2D">The 2D bounding box to inspect.</param>
        /// <returns>A <see cref="GH_Number"/> representing the height, or null if the bounding box is null.</returns>
        [Inspect("Height", "Height", "Height")]
        public static GH_Number? Height(this DiGi.Geometry.Planar.Classes.BoundingBox2D? boundingBox2D)
        {
            if (boundingBox2D == null)
            {
                return null;
            }

            return new GH_Number(boundingBox2D.Height);
        }

        /// <summary>
        /// Gets the corner points of the specified 2D bounding box.
        /// </summary>
        /// <param name="boundingBox2D">The 2D bounding box to inspect.</param>
        /// <returns>A collection of <see cref="GooPoint2D"/> representing the corners, or null if the bounding box is null.</returns>
        [Inspect("Points", "Points", "Points")]
        public static IEnumerable<GooPoint2D>? Points(this DiGi.Geometry.Planar.Classes.BoundingBox2D? boundingBox2D)
        {
            if (boundingBox2D == null)
            {
                return null;
            }

            return boundingBox2D?.GetPoints()?.ConvertAll(x => new GooPoint2D(x));
        }

        /// <summary>
        /// Gets the boundary segments of the specified 2D bounding box.
        /// </summary>
        /// <param name="boundingBox2D">The 2D bounding box to inspect.</param>
        /// <returns>A collection of <see cref="GooSegment2D"/> representing the edges, or null if the bounding box is null.</returns>
        [Inspect("Segments", "Segments", "Segments")]
        public static IEnumerable<GooSegment2D>? Segments(this DiGi.Geometry.Planar.Classes.BoundingBox2D? boundingBox2D)
        {
            if (boundingBox2D == null)
            {
                return null;
            }

            return boundingBox2D?.GetSegments()?.ConvertAll(x => new GooSegment2D(x));
        }

        /// <summary>
        /// Gets the top-left corner of the specified 2D bounding box.
        /// </summary>
        /// <param name="boundingBox2D">The 2D bounding box to inspect.</param>
        /// <returns>A <see cref="GooPoint2D"/> representing the top-left corner, or null if the bounding box is null.</returns>
        [Inspect("TopLeft", "TopLeft", "Top Left Corrner")]
        public static GooPoint2D? TopLeft(this DiGi.Geometry.Planar.Classes.BoundingBox2D? boundingBox2D)
        {
            if (boundingBox2D == null)
            {
                return null;
            }

            return new GooPoint2D(boundingBox2D.TopLeft);
        }

        /// <summary>
        /// Gets the top-right corner of the specified 2D bounding box.
        /// </summary>
        /// <param name="boundingBox2D">The 2D bounding box to inspect.</param>
        /// <returns>A <see cref="GooPoint2D"/> representing the top-right corner, or null if the bounding box is null.</returns>
        [Inspect("TopRight", "TopRight", "Top Right Corrner")]
        public static GooPoint2D? TopRight(this DiGi.Geometry.Planar.Classes.BoundingBox2D? boundingBox2D)
        {
            if (boundingBox2D == null)
            {
                return null;
            }

            return new GooPoint2D(boundingBox2D.TopRight);
        }

        /// <summary>
        /// Gets the width of the specified 2D bounding box.
        /// </summary>
        /// <param name="boundingBox2D">The 2D bounding box to inspect.</param>
        /// <returns>A <see cref="GH_Number"/> representing the width, or null if the bounding box is null.</returns>
        [Inspect("Width", "Width", "Width")]
        public static GH_Number? Width(this DiGi.Geometry.Planar.Classes.BoundingBox2D? boundingBox2D)
        {
            if (boundingBox2D == null)
            {
                return null;
            }

            return new GH_Number(boundingBox2D.Width);
        }
    }
}