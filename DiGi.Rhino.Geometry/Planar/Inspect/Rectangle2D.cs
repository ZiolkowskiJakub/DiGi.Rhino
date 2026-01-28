using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Geometry.Planar.Classes;
using Grasshopper.Kernel.Types;
using System.Collections.Generic;

namespace DiGi.Rhino.Geometry.Planar
{
    public static partial class Inspect
    {
        [Inspect("Width", "Width", "Rectangle2D Width")]
        public static GH_Number? Width(this DiGi.Geometry.Planar.Classes.Rectangle2D? rectangle2D)
        {
            if (rectangle2D == null)
            {
                return null;
            }

            return new GH_Number(rectangle2D.Width);
        }

        [Inspect("Height", "Height", "Rectangle2D Height")]
        public static GH_Number? Height(this DiGi.Geometry.Planar.Classes.Rectangle2D? rectangle2D)
        {
            if (rectangle2D == null)
            {
                return null;
            }

            return new GH_Number(rectangle2D.Height);
        }

        [Inspect("Points", "Points", "Points")]
        public static IEnumerable<GooPoint2D>? Points(this DiGi.Geometry.Planar.Classes.Rectangle2D? rectangle2D)
        {
            if (rectangle2D == null)
            {
                return null;
            }

            return rectangle2D?.GetPoints()?.ConvertAll(x => new GooPoint2D(x));
        }

        [Inspect("WidthDirection", "WidthDirection", "Width Direction")]
        public static GooVector2D? WidthDirection(this DiGi.Geometry.Planar.Classes.Rectangle2D? rectangle2D)
        {
            if (rectangle2D == null)
            {
                return null;
            }

            return new GooVector2D(rectangle2D?.WidthDirection);
        }

        [Inspect("HeightDirection", "HeightDirection", "Height Direction")]
        public static GooVector2D? HeightDirection(this DiGi.Geometry.Planar.Classes.Rectangle2D? rectangle2D)
        {
            if (rectangle2D == null)
            {
                return null;
            }

            return new GooVector2D(rectangle2D?.HeightDirection);
        }

        [Inspect("Centroid", "Centroid", "Rectnagle2D Centroid")]
        public static GooPoint2D? Centroid(this DiGi.Geometry.Planar.Classes.Rectangle2D? rectangle2D)
        {
            if (rectangle2D == null)
            {
                return null;
            }

            return new GooPoint2D(rectangle2D?.GetCentroid());
        }

        [Inspect("Origin", "Origin", "Rectnagle2D Origin")]
        public static GooPoint2D? Origin(this DiGi.Geometry.Planar.Classes.Rectangle2D? rectangle2D)
        {
            if (rectangle2D == null)
            {
                return null;
            }

            return new GooPoint2D(rectangle2D?.Origin);
        }

        [Inspect("BoundingBox", "BoundingBox", "Rectnagle2D BoundingBox")]
        public static GooBoundingBox2D? BoundingBox(this DiGi.Geometry.Planar.Classes.Rectangle2D? rectangle2D)
        {
            if (rectangle2D == null)
            {
                return null;
            }

            return new GooBoundingBox2D(rectangle2D?.GetBoundingBox());
        }

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