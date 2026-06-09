using DiGi.Geometry.Spatial.Classes;

namespace DiGi.Rhino.Geometry.Spatial
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts a <see cref="Ellipse3D"/> instance to a Rhino <see cref="global::Rhino.Geometry.Ellipse"/>.
        /// </summary>
        /// <param name="ellipse3D">The 3D ellipse to convert.</param>
        /// <returns>A Rhino <see cref="global::Rhino.Geometry.Ellipse"/> representation of the provided ellipse, or a default Rhino ellipse if the input is null or incomplete.</returns>
        public static global::Rhino.Geometry.Ellipse ToRhino(this Ellipse3D? ellipse3D)
        {
            Plane? plane = ellipse3D?.Plane;
            if (plane == null)
            {
                return new global::Rhino.Geometry.Ellipse();
            }

            Vector3D? axisX = ellipse3D!.Direction;
            if (axisX == null)
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