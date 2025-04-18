﻿using DiGi.Geometry.Planar;
using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Geometry.Classes;
using Grasshopper.Kernel.Types;

namespace DiGi.Rhino.Geometry
{
    public static partial class Inspect
    {
        [Inspect("Centroid", "Centroid", "Centroid")]
        public static GooPoint2D Centroid(this DiGi.Geometry.Planar.Classes.PolygonalFace2D polygonalFace2D)
        {
            if(polygonalFace2D == null)
            {
                return null;
            }

            return new GooPoint2D(DiGi.Geometry.Planar.Query.Centroid(polygonalFace2D));
        }

        [Inspect("Height", "Height", "Height")]
        public static GH_Number B(this DiGi.Geometry.Planar.Classes.BoundingBox2D boundingBox2D)
        {
            if (boundingBox2D == null)
            {
                return null;
            }

            return new GH_Number(boundingBox2D.Height);
        }
    }
}
