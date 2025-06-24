using DiGi.Geometry.Spatial.Classes;
using Rhino.Geometry;

namespace DiGi.Rhino.Geometry.Spatial
{
    public static partial class Convert
    {
        public static Rectangle3d ToRhino(this Rectangle3D rectangle3D)
        {
            if(rectangle3D == null)
            {
                return Rectangle3d.Unset;
            }

            return new Rectangle3d(rectangle3D.Plane.ToRhino(), rectangle3D.Width, rectangle3D.Height);
        }
    }
}