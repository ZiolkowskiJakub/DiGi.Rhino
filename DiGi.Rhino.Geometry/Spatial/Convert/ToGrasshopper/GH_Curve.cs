using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using Grasshopper.Kernel.Types;

namespace DiGi.Rhino.Geometry.Spatial
{
    public static partial class Convert
    {
        public static GH_Curve ToGrasshopper(this Segment3D segment3D)
        {
            if (segment3D == null)
            {
                return null;
            }

            return new GH_Curve(segment3D.ToRhino());
        }

        public static GH_Curve ToGrasshopper(this IPolygonal3D polygonal3D)
        {
            if (polygonal3D == null)
            {
                return null;
            }

            return new GH_Curve(polygonal3D.ToRhino());
        }
    }
}
