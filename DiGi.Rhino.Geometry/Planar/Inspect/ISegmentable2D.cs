using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Geometry.Planar.Classes;
using Grasshopper.Kernel.Types;
using System.Collections.Generic;

namespace DiGi.Rhino.Geometry.Planar
{
    public static partial class Inspect
    {
        /// <summary>
        /// Gets the length of the specified 2D segmentable object as a <see cref="GH_Number"/>.
        /// </summary>
        /// <param name="segmentable2D">The 2D segmentable object to inspect.</param>
        /// <returns>A <see cref="GH_Number"/> representing the length, or <c>null</c> if the input is null.</returns>
        [Inspect("Length", "Length", "Length")]
        public static GH_Number? Length(this DiGi.Geometry.Planar.Interfaces.ISegmentable2D? segmentable2D)
        {
            if (segmentable2D == null)
            {
                return null;
            }

            return new GH_Number(segmentable2D.Length);
        }

        /// <summary>
        /// Retrieves the points of the specified 2D segmentable object as a collection of <see cref="GooPoint2D"/>.
        /// </summary>
        /// <param name="segmentable2D">The 2D segmentable object to inspect.</param>
        /// <returns>An enumerable collection of <see cref="GooPoint2D"/>, or <c>null</c> if the input is null.</returns>
        [Inspect("Points", "Points", "Points")]
        public static IEnumerable<GooPoint2D>? Points(this DiGi.Geometry.Planar.Interfaces.ISegmentable2D? segmentable2D)
        {
            if (segmentable2D == null)
            {
                return null;
            }

            return segmentable2D?.GetPoints()?.ConvertAll(x => new GooPoint2D(x));
        }

        /// <summary>
        /// Gets the bounding rectangle of the specified 2D segmentable object as a <see cref="GooRectangle2D"/>.
        /// </summary>
        /// <param name="segmentable2D">The 2D segmentable object to inspect.</param>
        /// <returns>A <see cref="GooRectangle2D"/> representing the bounding rectangle, or <c>null</c> if the input is null.</returns>
        [Inspect("Rectangle2D", "Rectangle2D", "Rectangle2D")]
        public static GooRectangle2D? Rectangle2D(this DiGi.Geometry.Planar.Interfaces.ISegmentable2D? segmentable2D)
        {
            if (segmentable2D == null)
            {
                return null;
            }

            return new GooRectangle2D(DiGi.Geometry.Planar.Create.Rectangle2D(segmentable2D));
        }

        /// <summary>
        /// Retrieves the segments of the specified 2D segmentable object as a collection of <see cref="GooSegment2D"/>.
        /// </summary>
        /// <param name="segmentable2D">The 2D segmentable object to inspect.</param>
        /// <returns>An enumerable collection of <see cref="GooSegment2D"/>, or <c>null</c> if the input is null.</returns>
        [Inspect("Segments", "Segments", "Segments")]
        public static IEnumerable<GooSegment2D>? Segments(this DiGi.Geometry.Planar.Interfaces.ISegmentable2D? segmentable2D)
        {
            if (segmentable2D == null)
            {
                return null;
            }

            return segmentable2D?.GetSegments()?.ConvertAll(x => new GooSegment2D(x));
        }
    }
}