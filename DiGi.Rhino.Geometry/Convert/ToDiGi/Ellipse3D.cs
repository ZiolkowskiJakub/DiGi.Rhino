using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Spatial;
using DiGi.Geometry.Spatial.Classes;

namespace DiGi.Rhino.Geometry
{
    public static partial class Convert
    {
        public static Ellipse3D ToDiGi(this global::Rhino.Geometry.Ellipse ellipse)
        {
            if(!ellipse.IsValid)
            {
                return null;
            }

            Plane plane = ellipse.Plane.ToDiGi();

            Vector2D direction = plane.Convert(plane.AxisX);

            Ellipse2D ellipse2D = new Ellipse2D(plane.Convert(ellipse.Center.ToDiGi()), ellipse.Radius1, ellipse.Radius2, direction);

            return new Ellipse3D(plane, ellipse2D);
        }
    }
}
