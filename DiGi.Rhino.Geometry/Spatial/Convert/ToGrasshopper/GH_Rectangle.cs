using DiGi.Geometry.Spatial.Classes;
using Grasshopper.Kernel.Types;

namespace DiGi.Rhino.Geometry.Spatial
{
    public static partial class Convert
    {
        public static GH_Rectangle ToGrasshopper(this Rectangle3D rectangle3D)
        {
            if (rectangle3D == null)
            {
                return null;
            }

            return new GH_Rectangle(rectangle3D.ToRhino());
        }
    }
}
