using DiGi.Geometry.Spatial.Classes;
using Grasshopper.Kernel.Types;

namespace DiGi.Rhino.Geometry.Spatial
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts a <see cref="Point3D"/> to a Grasshopper <see cref="GH_Point"/>.
        /// </summary>
        /// <param name="point3D">The 3D point to convert.</param>
        /// <returns>A <see cref="GH_Point"/> if the provided point is not null; otherwise, <c>null</c>.</returns>
        public static GH_Point? ToGrasshopper(this Point3D? point3D)
        {
            if (point3D == null)
            {
                return null;
            }

            return new GH_Point(point3D.ToRhino());
        }
    }
}