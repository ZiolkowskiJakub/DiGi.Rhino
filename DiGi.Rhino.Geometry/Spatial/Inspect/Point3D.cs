using DiGi.Rhino.Core.Classes;
using Grasshopper.Kernel.Types;

namespace DiGi.Rhino.Geometry.Spatial
{
    public static partial class Inspect
    {

        [Inspect("X", "X", "X Coordinate")]
        public static GH_Number X(this DiGi.Geometry.Spatial.Classes.Point3D point3D)
        {
            if(point3D == null)
            {
                return null;
            }

            return new GH_Number(point3D.X);
        }

        [Inspect("Y", "Y", "Y Coordinate")]
        public static GH_Number Y(this DiGi.Geometry.Spatial.Classes.Point3D point3D)
        {
            if (point3D == null)
            {
                return null;
            }

            return new GH_Number(point3D.Y);
        }

        [Inspect("Z", "Z", "Z Coordinate")]
        public static GH_Number Z(this DiGi.Geometry.Spatial.Classes.Point3D point3D)
        {
            if (point3D == null)
            {
                return null;
            }

            return new GH_Number(point3D.Z);
        }
    }
}
