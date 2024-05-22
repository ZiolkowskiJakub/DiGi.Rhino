using DiGi.Geometry.Spatial.Classes;

namespace DiGi.Rhino.Geometry
{
    public static partial class Convert
    {
        public static Plane ToDiGi(this global::Rhino.Geometry.Plane plane)
        {
            if(plane == null || !plane.IsValid)
            {
                return null;
            }

            return new Plane(plane.Origin.ToDiGi(), plane.XAxis.ToDiGi(), plane.YAxis.ToDiGi());
        }
    }
}
