using DiGi.Geometry.Spatial.Classes;
using Rhino.Geometry;

namespace DiGi.Rhino.Geometry.Spatial
{
    public static partial class Convert
    {
        public static Rectangle3d ToRhino(this Rectangle3D? rectangle3D)
        {
            if(rectangle3D == null)
            {
                return Rectangle3d.Unset;
            }

            if(rectangle3D.Plane is not DiGi.Geometry.Spatial.Classes.Plane plane_Temp)
            {
                return Rectangle3d.Unset;
            }

            global::Rhino.Geometry.Plane plane = plane_Temp.ToRhino();
            if(plane == global::Rhino.Geometry.Plane.Unset)
            {
                return Rectangle3d.Unset;
            }

            return new Rectangle3d(plane, rectangle3D.Width, rectangle3D.Height);
        }
    }
}