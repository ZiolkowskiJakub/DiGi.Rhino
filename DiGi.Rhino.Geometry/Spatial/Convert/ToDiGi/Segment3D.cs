using DiGi.Geometry.Spatial.Classes;

namespace DiGi.Rhino.Geometry.Spatial
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts a <see cref="global::Rhino.Geometry.Line"/> to a <see cref="Segment3D"/>.
        /// </summary>
        /// <param name="line">The Rhino line to convert.</param>
        /// <returns>A <see cref="Segment3D"/> representation of the line, or <c>null</c> if the line is invalid.</returns>
        public static Segment3D? ToDiGi(this global::Rhino.Geometry.Line line)
        {
            if (!line.IsValid)
            {
                return null;
            }

            return new Segment3D(line.From.ToDiGi(), line.To.ToDiGi());
        }

        /// <summary>
        /// Converts a <see cref="global::Rhino.Geometry.LineCurve"/> to a <see cref="Segment3D"/>.
        /// </summary>
        /// <param name="lineCurve">The Rhino line curve to convert.</param>
        /// <returns>A <see cref="Segment3D"/> representation of the line curve, or <c>null</c> if the input is null.</returns>
        public static Segment3D? ToDiGi(this global::Rhino.Geometry.LineCurve lineCurve)
        {
            if (lineCurve == null)
            {
                return null;
            }

            return new Segment3D(lineCurve.PointAtStart.ToDiGi(), lineCurve.PointAtEnd.ToDiGi());
        }
    }
}