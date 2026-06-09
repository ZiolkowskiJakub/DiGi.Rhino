using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Geometry.Planar.Classes;
using Grasshopper.Kernel.Types;
using System.Collections.Generic;

namespace DiGi.Rhino.Geometry.Planar
{
    public static partial class Inspect
    {
        /// <summary>
        /// Gets the width of the specified rectangle as a GH_Number.
        /// </summary>
        /// <param name="rectangle2D">The rectangle to inspect.</param>
        /// <returns>A <see cref="GH_Number"/> representing the width, or null if the rectangle is null.</returns>
        [Inspect("Width", "Width", "Rectangle2D Width")]
        public static GH_Number? Width(this DiGi.Geometry.Planar.Classes.Rectangle2D? rectangle2D)
        {
            if (rectangle2D == null)
            {
                return null;
            }

            return new GH_Number(rectangle2D.Width);
        }

        /// <summary>
        /// Gets the height of the specified rectangle as a GH_Number.
        /// </summary>
        /// <param name="rectangle2D">The rectangle to inspect.</param>
        /// <returns>A <see cref="GH_Number"/> representing the height, or null if the rectangle is null.</returns>
        [Inspect("Height", "Height", "Rectangle2D Height")]
        public static GH_Number? Height(this DiGi.Geometry.Planar.Classes.Rectangle2D? rectangle2D)
        {
            if (rectangle2D == null)
            {
                return null;
            }

            return new GH_Number(rectangle2D.Height);
        }

        /// <summary>
        /// Gets the corner points of the specified rectangle converted to GooPoint2D objects.
        /// </summary>
        /// <param name="rectangle2D">The rectangle to inspect.</param>
        /// <returns>An enumerable collection of <see cref="GooPoint2D"/>, or null if the rectangle is null.</returns>
        [Inspect("Points", "Points", "Points")]
        public static IEnumerable<GooPoint2D>? Points(this DiGi.Geometry.Planar.Classes.Rectangle2D? rectangle2D)
        {
            if (rectangle2D == null)
            {
                return null;
            }

            return rectangle2D?.GetPoints()?.ConvertAll(x => new GooPoint2D(x));
        }

        /// <summary>
        /// Gets the vector representing the width direction of the specified rectangle.
        /// </summary>
        /// <param name="rectangle2D">The rectangle to inspect.</param>
        /// <returns>A <see cref="GooVector2D"/> representing the width direction, or null if the rectangle is null.</returns>
        [Inspect("WidthDirection", "WidthDirection", "Width Direction")]
        public static GooVector2D? WidthDirection(this DiGi.Geometry.Planar.Classes.Rectangle2D? rectangle2D)
        {
            if (rectangle2D == null)
            {
                return null;
            }

            return new GooVector2D(rectangle2D?.WidthDirection);
        }

        /// <summary>
        /// Gets the vector representing the height direction of the specified rectangle.
        /// </summary>
        /// <param name="rectangle2D">The rectangle to inspect.</param>
        /// <returns>A <see cref="GooVector2D"/> representing the height direction, or null if the rectangle is null.</returns>
        [Inspect("HeightDirection", "HeightDirection", "Height Direction")]
        public static GooVector2D? HeightDirection(this DiGi.Geometry.Planar.Classes.Rectangle2D? rectangle2D)
        {
            if (rectangle2D == null)
            {
                return null;
            }

            return new GooVector2D(rectangle2D?.HeightDirection);
        }

        /// <summary>
        /// Gets the centroid point of the specified rectangle.
        /// </summary>
        /// <param name="rectangle2D">The rectangle to inspect.</param>
        /// <returns>A <see cref="GooPoint2D"/> representing the centroid, or null if the rectangle is null.</returns>
        [Inspect("Centroid", "Centroid", "Rectnagle2D Centroid")]
        public static GooPoint2D? Centroid(this DiGi.Geometry.Planar.Classes.Rectangle2D? rectangle2D)
        {
            if (rectangle2D == null)
            {
                return null;
            }

            return new GooPoint2D(rectangle2D?.GetCentroid());
        }

        /// <summary>
        /// Gets the origin point of the specified rectangle.
        /// </summary>
        /// <param name="rectangle2D">The rectangle to inspect.</param>
        /// <returns>A <see cref="GooPoint2D"/> representing the origin, or null if the rectangle is null.</returns>
        [Inspect("Origin", "Origin", "Rectnagle2D Origin")]
        public static GooPoint2D? Origin(this DiGi.Geometry.Planar.Classes.Rectangle2D? rectangle2D)
        {
            if (rectangle2D == null)
            {
                return null;
            }

            return new GooPoint2D(rectangle2D?.Origin);
        }

        /// <summary>
        /// Gets the 2D bounding box of the specified rectangle.
        /// </summary>
        /// <param name="rectangle2D">The rectangle to inspect.</param>
        /// <returns>A <see cref="GooBoundingBox2D"/> representing the bounding box, or null if the rectangle is null.</returns>
        [Inspect("BoundingBox", "BoundingBox", "Rectnagle2D BoundingBox")]
        public static GooBoundingBox2D? BoundingBox(this DiGi.Geometry.Planar.Classes.Rectangle2D? rectangle2D)
        {
            if (rectangle2D == null)
            {
                return null;
            }

            return new GooBoundingBox2D(rectangle2D?.GetBoundingBox());
        }

        /// <summary>
        /// Calculates the area of the specified rectangle as a GH_Number.
        /// </summary>
        /// <param name="rectangle2D">The rectangle to inspect.</param>
        /// <returns>A <see cref="GH_Number"/> representing the area, or null if the rectangle is null.</returns>
        [Inspect("Area", "Area", "Rectangle2D Area")]
        public static GH_Number? Area(this DiGi.Geometry.Planar.Classes.Rectangle2D? rectangle2D)
        {
            if (rectangle2D == null)
            {
                return null;
            }

            return new GH_Number(rectangle2D.GetArea());
        }
    }
}