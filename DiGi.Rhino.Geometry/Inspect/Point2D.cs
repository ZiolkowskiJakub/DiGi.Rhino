using DiGi.Rhino.Core.Classes;
using Grasshopper.Kernel.Types;

namespace DiGi.Rhino.Geometry
{
    public static partial class Inspect
    {
        [Inspect("X", "X", "X Coordinate")]
        public static GH_Number X(this DiGi.Geometry.Planar.Classes.Point2D point2D)
        {
            if(point2D == null)
            {
                return null;
            }

            return new GH_Number(point2D.X);
        }

        [Inspect("Y", "Y", "Y Coordinate")]
        public static GH_Number Y(this DiGi.Geometry.Planar.Classes.Point2D point2D)
        {
            if (point2D == null)
            {
                return null;
            }

            return new GH_Number(point2D.Y);
        }

    }
}
