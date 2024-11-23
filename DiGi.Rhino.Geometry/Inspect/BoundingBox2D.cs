using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Geometry.Classes;
using Grasshopper.Kernel.Types;

namespace DiGi.Rhino.Geometry
{
    public static partial class Inspect
    {
        [Inspect("Width", "Width", "Width")]
        public static GH_Number Width(this DiGi.Geometry.Planar.Classes.BoundingBox2D boundingBox2D)
        {
            if(boundingBox2D == null)
            {
                return null;
            }

            return new GH_Number(boundingBox2D.Width);
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

        [Inspect("Centroid", "Centroid", "Centroid")]
        public static GooPoint2D Centroid(this DiGi.Geometry.Planar.Classes.BoundingBox2D boundingBox2D)
        {
            if (boundingBox2D == null)
            {
                return null;
            }

            return new GooPoint2D(boundingBox2D.GetCentroid());
        }
    }
}
