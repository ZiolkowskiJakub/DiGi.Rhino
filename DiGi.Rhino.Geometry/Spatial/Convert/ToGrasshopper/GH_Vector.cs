using DiGi.Geometry.Spatial.Classes;
using Grasshopper.Kernel.Types;

namespace DiGi.Rhino.Geometry.Spatial
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts a <see cref="Vector3D"/> to a Grasshopper <see cref="GH_Vector"/>.
        /// </summary>
        /// <param name="vector3D">The 3D vector to convert.</param>
        /// <returns>A <see cref="GH_Vector"/> instance if the input is not null; otherwise, <c>null</c>.</returns>
        public static GH_Vector? ToGrasshopper(this Vector3D? vector3D)
        {
            if (vector3D == null)
            {
                return null;
            }

            return new GH_Vector(vector3D.ToRhino());
        }
    }
}