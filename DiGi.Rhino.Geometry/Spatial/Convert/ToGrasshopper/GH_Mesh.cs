using DiGi.Geometry.Spatial.Classes;
using Grasshopper.Kernel.Types;

namespace DiGi.Rhino.Geometry.Spatial
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts a <see cref="Mesh3D"/> instance to a Grasshopper <see cref="GH_Mesh"/>.
        /// </summary>
        /// <param name="mesh3D">The <see cref="Mesh3D"/> object to convert.</param>
        /// <returns>A <see cref="GH_Mesh"/> representation of the mesh, or <c>null</c> if the provided <paramref name="mesh3D"/> is null.</returns>
        public static GH_Mesh? ToGrasshopper(this Mesh3D? mesh3D)
        {
            if (mesh3D == null)
            {
                return null;
            }

            return new GH_Mesh(mesh3D.ToRhino());
        }
    }
}