using DiGi.Geometry.Spatial.Classes;
using Grasshopper.Kernel.Types;

namespace DiGi.Rhino.Geometry.Spatial
{
    public static partial class Convert
    {
        public static GH_Mesh ToGrasshopper(this Mesh3D mesh3D)
        {
            if (mesh3D == null)
            {
                return null;
            }

            return new GH_Mesh(mesh3D.ToRhino());
        }
    }
}
