using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Geometry.Spatial.Classes;
using Grasshopper.Kernel.Types;

namespace DiGi.Rhino.Geometry.Spatial
{
    public static partial class Inspect
    {
        [Inspect("Length", "Length", "Vector Length")]
        public static GH_Number Length(this DiGi.Geometry.Spatial.Classes.Vector3D vector3D)
        {
            if (vector3D == null)
            {
                return null;
            }

            return new GH_Number(vector3D.Length);
        }

        [Inspect("Unit", "Unit", "Unit Vector3D")]
        public static GooVector3D Unit(this DiGi.Geometry.Spatial.Classes.Vector3D vector3D)
        {
            if (vector3D == null)
            {
                return null;
            }

            return new GooVector3D(vector3D.Unit);
        }

        [Inspect("X", "X", "X Coordinate")]
        public static GH_Number X(this DiGi.Geometry.Spatial.Classes.Vector3D vector3D)
        {
            if(vector3D == null)
            {
                return null;
            }

            return new GH_Number(vector3D.X);
        }

        [Inspect("Y", "Y", "Y Coordinate")]
        public static GH_Number Y(this DiGi.Geometry.Spatial.Classes.Vector3D vector3D)
        {
            if (vector3D == null)
            {
                return null;
            }

            return new GH_Number(vector3D.Y);
        }

        [Inspect("Z", "Z", "Z Coordinate")]
        public static GH_Number Z(this DiGi.Geometry.Spatial.Classes.Vector3D vector3D)
        {
            if (vector3D == null)
            {
                return null;
            }

            return new GH_Number(vector3D.Z);
        }
    }
}
