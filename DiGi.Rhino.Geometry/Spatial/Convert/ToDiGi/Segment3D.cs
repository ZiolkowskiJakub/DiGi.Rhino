﻿using DiGi.Geometry.Spatial.Classes;

namespace DiGi.Rhino.Geometry.Spatial
{
    public static partial class Convert
    {
        public static Segment3D ToDiGi(this global::Rhino.Geometry.Line line)
        {
            if(!line.IsValid)
            {
                return null;
            }

            return new Segment3D(line.From.ToDiGi(), line.To.ToDiGi());
        }

        public static Segment3D ToDiGi(this global::Rhino.Geometry.LineCurve lineCurve)
        {
            if (lineCurve == null)
            {
                return null;
            }

            return new Segment3D(lineCurve.PointAtStart.ToDiGi(), lineCurve.PointAtEnd.ToDiGi());
        }
    }
}
