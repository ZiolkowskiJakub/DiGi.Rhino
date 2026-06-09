using DiGi.Geometry.Spatial.Classes;
using Grasshopper.Kernel.Types;

namespace DiGi.Rhino.Geometry.Spatial
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts a <see cref="Rectangle3D"/> instance to a Grasshopper <see cref="GH_Rectangle"/>.
        /// </summary>
        /// <param name="rectangle3D">The three-dimensional rectangle to convert.</param>
        /// <returns>A <see cref="GH_Rectangle"/> representation of the input, or <c>null</c> if the provided <paramref name="rectangle3D"/> is null.</returns>
        public static GH_Rectangle? ToGrasshopper(this Rectangle3D? rectangle3D)
        {
            if (rectangle3D == null)
            {
                return null;
            }

            return new GH_Rectangle(rectangle3D.ToRhino());
        }
    }
}