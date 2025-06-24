using DiGi.Geometry.Spatial.Classes;

namespace DiGi.Rhino.Geometry.Spatial
{
    public static partial class Convert
    {
        public static Rectangle3D ToDiGi(this global::Rhino.Geometry.Rectangle3d rectangle3D)
        {
            if(!rectangle3D.IsValid)
            {
                return null;
            }

            return new Rectangle3D(rectangle3D.Plane.ToDiGi(), rectangle3D.Width, rectangle3D.Height);
        }
    }
}
