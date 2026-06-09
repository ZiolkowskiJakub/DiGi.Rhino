using DiGi.Rhino.Core.Classes;
using Grasshopper.Kernel.Types;

namespace DiGi.Rhino.Geometry.Spatial
{
    public static partial class Inspect
    {
        /// <summary>
        /// Gets the X coordinate of the specified 3D point as a Grasshopper number.
        /// </summary>
        /// <param name="point3D">The 3D point to inspect.</param>
        /// <returns>A <see cref="GH_Number"/> containing the X coordinate, or <c>null</c> if the point is null.</returns>
        [Inspect("X", "X", "X Coordinate")]
        public static GH_Number? X(this DiGi.Geometry.Spatial.Classes.Point3D? point3D)
        {
            if (point3D == null)
            {
                return null;
            }

            return new GH_Number(point3D.X);
        }

        /// <summary>
        /// Gets the Y coordinate of the specified 3D point as a Grasshopper number.
        /// </summary>
        /// <param name="point3D">The 3D point to inspect.</param>
        /// <returns>A <see cref="GH_Number"/> containing the Y coordinate, or <c>null</c> if the point is null.</returns>
        [Inspect("Y", "Y", "Y Coordinate")]
        public static GH_Number? Y(this DiGi.Geometry.Spatial.Classes.Point3D? point3D)
        {
            if (point3D == null)
            {
                return null;
            }

            return new GH_Number(point3D.Y);
        }

        /// <summary>
        /// Gets the Z coordinate of the specified 3D point as a Grasshopper number.
        /// </summary>
        /// <param name="point3D">The 3D point to inspect.</param>
        /// <returns>A <see cref="GH_Number"/> containing the Z coordinate, or <c>null</c> if the point is null.</returns>
        [Inspect("Z", "Z", "Z Coordinate")]
        public static GH_Number? Z(this DiGi.Geometry.Spatial.Classes.Point3D? point3D)
        {
            if (point3D == null)
            {
                return null;
            }

            return new GH_Number(point3D.Z);
        }
    }
}