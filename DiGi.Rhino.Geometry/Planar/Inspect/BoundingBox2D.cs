using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Geometry.Planar.Classes;
using Grasshopper.Kernel.Types;
using System.Collections.Generic;

namespace DiGi.Rhino.Geometry.Planar
{
    public static partial class Inspect
    {
        [Inspect("BottomLeft", "BottomLeft", "Bottom Left Corrner")]
        public static GooPoint2D BottomLeft(this DiGi.Geometry.Planar.Classes.BoundingBox2D boundingBox2D)
        {
            if (boundingBox2D == null)
            {
                return null;
            }

            return new GooPoint2D(boundingBox2D.BottomLeft);
        }

        [Inspect("BottomRight", "BottomRight", "Bottom Right Corrner")]
        public static GooPoint2D BottomRight(this DiGi.Geometry.Planar.Classes.BoundingBox2D boundingBox2D)
        {
            if (boundingBox2D == null)
            {
                return null;
            }

            return new GooPoint2D(boundingBox2D.BottomRight);
        }

        [Inspect("Centroid", "Centroid", "Centroid")]
        public static GooPoint2D Centroid(this DiGi.Geometry.Planar.Classes.BoundingBox2D boundingBox2D)
        {
            if (boundingBox2D == null)
            {
                return null;
            }

            return new GooPoint2D(boundingBox2D.GetCentroid());
        }

        [Inspect("Height", "Height", "Height")]
        public static GH_Number Height(this DiGi.Geometry.Planar.Classes.BoundingBox2D boundingBox2D)
        {
            if (boundingBox2D == null)
            {
                return null;
            }

            return new GH_Number(boundingBox2D.Height);
        }

        [Inspect("Points", "Points", "Points")]
        public static IEnumerable<GooPoint2D> Points(this DiGi.Geometry.Planar.Classes.BoundingBox2D boundingBox2D)
        {
            if (boundingBox2D == null)
            {
                return null;
            }

            return boundingBox2D.GetPoints().ConvertAll(x => new GooPoint2D(x));
        }

        [Inspect("Segments", "Segments", "Segments")]
        public static IEnumerable<GooSegment2D> Segments(this DiGi.Geometry.Planar.Classes.BoundingBox2D boundingBox2D)
        {
            if (boundingBox2D == null)
            {
                return null;
            }

            return boundingBox2D.GetSegments().ConvertAll(x => new GooSegment2D(x));
        }

        [Inspect("TopLeft", "TopLeft", "Top Left Corrner")]
        public static GooPoint2D TopLeft(this DiGi.Geometry.Planar.Classes.BoundingBox2D boundingBox2D)
        {
            if (boundingBox2D == null)
            {
                return null;
            }

            return new GooPoint2D(boundingBox2D.TopLeft);
        }

        [Inspect("TopRight", "TopRight", "Top Right Corrner")]
        public static GooPoint2D TopRight(this DiGi.Geometry.Planar.Classes.BoundingBox2D boundingBox2D)
        {
            if (boundingBox2D == null)
            {
                return null;
            }

            return new GooPoint2D(boundingBox2D.TopRight);
        }

        [Inspect("Width", "Width", "Width")]
        public static GH_Number Width(this DiGi.Geometry.Planar.Classes.BoundingBox2D boundingBox2D)
        {
            if(boundingBox2D == null)
            {
                return null;
            }

            return new GH_Number(boundingBox2D.Width);
        }
    }
}
