using DiGi.Geometry.Spatial.Classes;
using Grasshopper.Kernel.Types;

namespace DiGi.Rhino.Geometry
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
    }
}
