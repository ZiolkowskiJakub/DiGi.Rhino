using DiGi.Rhino.Core.Classes;
using Grasshopper.Kernel.Types;

namespace DiGi.Rhino.Geometry.Planar
{
    public static partial class Inspect
    {
        /// <summary>
        /// Extracts the X coordinate of a 2D point as a Grasshopper number.
        /// </summary>
        /// <param name="point2D">The 2D point to inspect.</param>
        /// <returns>A <see cref="GH_Number"/> representing the X coordinate, or <c>null</c> if the input point is null.</returns>
        [Inspect("X", "X", "X Coordinate")]
        public static GH_Number? X(this DiGi.Geometry.Planar.Classes.Point2D? point2D)
        {
            if (point2D == null)
            {
                return null;
            }

            return new GH_Number(point2D.X);
        }

        /// <summary>
        /// Extracts the Y coordinate of a 2D point as a Grasshopper number.
        /// </summary>
        /// <param name="point2D">The 2D point to inspect.</param>
        /// <returns>A <see cref="GH_Number"/> representing the Y coordinate, or <c>null</c> if the input point is null.</returns>
        [Inspect("Y", "Y", "Y Coordinate")]
        public static GH_Number? Y(this DiGi.Geometry.Planar.Classes.Point2D? point2D)
        {
            if (point2D == null)
            {
                return null;
            }

            return new GH_Number(point2D.Y);
        }
    }
}