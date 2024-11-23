using DiGi.Geometry.Planar;
using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Geometry.Classes;

namespace DiGi.Rhino.Geometry
{
    public static partial class Inspect
    {
        [Inspect("Rectangle2D", "Rectangle2D", "Rectangle2D")]
        public static GooRectangle2D Rectangle2D(this DiGi.Geometry.Planar.Interfaces.ISegmentable2D segmentable2D)
        {
            if(segmentable2D == null)
            {
                return null;
            }

            return new GooRectangle2D(Create.Rectangle2D(segmentable2D));
        }
    }
}
