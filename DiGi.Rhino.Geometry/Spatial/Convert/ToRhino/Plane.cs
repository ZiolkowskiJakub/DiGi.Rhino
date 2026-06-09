using DiGi.Geometry.Spatial.Classes;

namespace DiGi.Rhino.Geometry.Spatial
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts a <see cref="Plane"/> instance to its corresponding Rhino geometry plane representation.
        /// </summary>
        /// <param name="plane">The source plane to convert.</param>
        /// <returns>A <see cref="global::Rhino.Geometry.Plane"/> representing the converted plane, or <see cref="global::Rhino.Geometry.Plane.Unset"/> if the conversion fails or the input is null.</returns>
        public static global::Rhino.Geometry.Plane ToRhino(this Plane plane)
        {
            if (plane == null)
            {
                return global::Rhino.Geometry.Plane.Unset;
            }

            if (plane.AxisX is not Vector3D axisX)
            {
                return global::Rhino.Geometry.Plane.Unset;
            }

            global::Rhino.Geometry.Vector3d axisX_Rhino = axisX.ToRhino();
            if (axisX_Rhino == global::Rhino.Geometry.Vector3d.Unset)
            {
                return global::Rhino.Geometry.Plane.Unset;
            }

            if (plane.AxisY is not Vector3D axisY)
            {
                return global::Rhino.Geometry.Plane.Unset;
            }

            global::Rhino.Geometry.Vector3d axisY_Rhino = axisY.ToRhino();
            if (axisY_Rhino == global::Rhino.Geometry.Vector3d.Unset)
            {
                return global::Rhino.Geometry.Plane.Unset;
            }

            return new global::Rhino.Geometry.Plane(plane.Origin.ToRhino(), axisX_Rhino, axisY_Rhino);
        }
    }
}