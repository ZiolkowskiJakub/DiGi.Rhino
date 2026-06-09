using DiGi.Geometry.Spatial.Classes;

namespace DiGi.Rhino.Geometry.Spatial
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts a <see cref="Segment3D"/> to a Rhino <see cref="global::Rhino.Geometry.Line"/>.
        /// </summary>
        /// <param name="segment3D">The 3D line segment to convert.</param>
        /// <returns>A Rhino <see cref="global::Rhino.Geometry.Line"/> representation of the segment.</returns>
        public static global::Rhino.Geometry.Line ToRhino_Line(this Segment3D segment3D)
        {
            return new global::Rhino.Geometry.Line(segment3D[0].ToRhino(), segment3D[1].ToRhino());
        }

        /// <summary>
        /// Converts a <see cref="Segment3D"/> to a Rhino <see cref="global::Rhino.Geometry.LineCurve"/>.
        /// </summary>
        /// <param name="segment3D">The 3D line segment to convert.</param>
        /// <returns>A Rhino <see cref="global::Rhino.Geometry.LineCurve"/> representation of the segment.</returns>
        public static global::Rhino.Geometry.LineCurve ToRhino(this Segment3D segment3D)
        {
            return new global::Rhino.Geometry.LineCurve(segment3D[0].ToRhino(), segment3D[1].ToRhino());
        }
    }
}