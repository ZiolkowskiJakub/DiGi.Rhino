using DiGi.Geometry.Spatial.Classes;

namespace DiGi.Rhino.Geometry.Spatial
{
    public static partial class Convert
    {
        public static global::Rhino.Geometry.Ellipse ToRhino(this Ellipse3D? ellipse3D)
        {
            Plane? plane = ellipse3D?.Plane;
            if(plane == null)
            {
                return new global::Rhino.Geometry.Ellipse();
            }

            Vector3D? axisX = ellipse3D!.Direction;
            if(axisX == null)
            {
                return new global::Rhino.Geometry.Ellipse();
            }

            Point3D? center = ellipse3D.Center;

            Vector3D? axisY = axisX.CrossProduct(plane.Normal?.GetInversed());

            plane = new Plane(center, axisX, axisY);

            return new global::Rhino.Geometry.Ellipse(plane.ToRhino(), ellipse3D.A, ellipse3D.B);
        }
    }
}