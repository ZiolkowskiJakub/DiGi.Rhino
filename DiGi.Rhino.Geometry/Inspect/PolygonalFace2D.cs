using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Geometry.Classes;

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
    }
}
