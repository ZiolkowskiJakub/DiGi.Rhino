using DiGi.Geometry.Spatial.Classes;
using Grasshopper.Kernel.Types;

namespace DiGi.Rhino.Geometry
{
    public static partial class Convert
    {
        public static GH_Point ToGrasshopper(this Point3D point3D)
        {
            if (point3D == null)
            {
                return null;
            }

            return new GH_Point(point3D.ToRhino());
        }
    }
}
