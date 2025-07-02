using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Geometry.Planar.Classes;
using Grasshopper.Kernel.Types;
using System.Collections;

namespace DiGi.Rhino.Geometry.Planar
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

        [Inspect("InternalPoint", "InternalPoint", "InternalPoint")]
        public static GooPoint2D InternalPoint(this DiGi.Geometry.Planar.Classes.PolygonalFace2D polygonalFace2D)
        {
            if (polygonalFace2D == null)
            {
                return null;
            }

            return new GooPoint2D(polygonalFace2D.GetInternalPoint());
        }

        [Inspect("Area", "Area", "Area")]
        public static GH_Number Area(this DiGi.Geometry.Planar.Classes.PolygonalFace2D polygonalFace2D)
        {
            if (polygonalFace2D == null)
            {
                return null;
            }

            return new GH_Number(polygonalFace2D.GetArea());
        }

        [Inspect("ExternalEdge", "ExternalEdge", "ExternalEdge")]
        public static GooPolygonal2D ExternalEdge(this DiGi.Geometry.Planar.Classes.PolygonalFace2D polygonalFace2D)
        {
            if (polygonalFace2D == null)
            {
                return null;
            }

            return new GooPolygonal2D(polygonalFace2D.ExternalEdge);
        }

        [Inspect("InternalEdges", "InternalEdges", "InternalEdges")]
        public static IEnumerable InternalEdges(this DiGi.Geometry.Planar.Classes.PolygonalFace2D polygonalFace2D)
        {
            if (polygonalFace2D == null)
            {
                return null;
            }

            return polygonalFace2D.InternalEdges?.ConvertAll(x => new GooPolygonal2D(x));
        }
    }
}
