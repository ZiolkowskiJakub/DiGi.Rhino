using DiGi.Geometry.Spatial.Classes;
using Grasshopper.Kernel.Types;

namespace DiGi.Rhino.Geometry.Spatial
{
    public static partial class Convert
    {
        public static GH_Vector ToGrasshopper(this Vector3D vector3D)
        {
            if (vector3D == null)
            {
                return null;
            }

            return new GH_Vector(vector3D.ToRhino());
        }
    }
}
