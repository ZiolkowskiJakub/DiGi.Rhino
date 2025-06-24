using DiGi.Geometry.Spatial.Classes;

namespace DiGi.Rhino.Geometry.Spatial
{
    public static partial class Convert
    {
        public static global::Rhino.Geometry.Plane ToRhino(this Plane plane)
        {
            if(plane == null)
            {
                return global::Rhino.Geometry.Plane.Unset;
            }

            return new global::Rhino.Geometry.Plane(plane.Origin.ToRhino(), plane.AxisX.ToRhino(), plane.AxisY.ToRhino());
        }
    }
}