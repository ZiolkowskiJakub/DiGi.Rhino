using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Geometry.Planar.Classes;

namespace DiGi.Rhino.Geometry.Planar
{
    public static partial class Inspect
    {
        [Inspect("BoundinBox2D", "BoundinBox2D", "BoundinBox2D")]
        public static GooBoundingBox2D BoundinBox2D(this DiGi.Geometry.Planar.Interfaces.IBoundable2D boundable2D)
        {
            if(boundable2D == null)
            {
                return null;
            }

            return new GooBoundingBox2D(boundable2D.GetBoundingBox());
        }
    }
}
