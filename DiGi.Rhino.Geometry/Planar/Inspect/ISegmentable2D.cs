using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Geometry.Planar.Classes;
using Grasshopper.Kernel.Types;
using System.Collections.Generic;

namespace DiGi.Rhino.Geometry.Planar
{
    public static partial class Inspect
    {
        [Inspect("Length", "Length", "Length")]
        public static GH_Number? Length(this DiGi.Geometry.Planar.Interfaces.ISegmentable2D? segmentable2D)
        {
            if (segmentable2D == null)
            {
                return null;
            }

            return new GH_Number(segmentable2D.Length);
        }

        [Inspect("Points", "Points", "Points")]
        public static IEnumerable<GooPoint2D>? Points(this DiGi.Geometry.Planar.Interfaces.ISegmentable2D? segmentable2D)
        {
            if (segmentable2D == null)
            {
                return null;
            }

            return segmentable2D?.GetPoints()?.ConvertAll(x => new GooPoint2D(x));
        }

        [Inspect("Rectangle2D", "Rectangle2D", "Rectangle2D")]
        public static GooRectangle2D? Rectangle2D(this DiGi.Geometry.Planar.Interfaces.ISegmentable2D? segmentable2D)
        {
            if (segmentable2D == null)
            {
                return null;
            }

            return new GooRectangle2D(DiGi.Geometry.Planar.Create.Rectangle2D(segmentable2D));
        }

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
