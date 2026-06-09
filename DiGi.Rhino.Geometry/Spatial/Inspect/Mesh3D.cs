using DiGi.Geometry.Spatial.Classes;
using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Geometry.Spatial.Classes;
using System.Collections.Generic;

namespace DiGi.Rhino.Geometry.Spatial
{
    public static partial class Inspect
    {
        /// <summary>
        /// Retrieves the collection of triangles from the specified 3D mesh.
        /// </summary>
        /// <param name="mesh3D">The 3D mesh to extract triangles from.</param>
        /// <returns>A collection of <see cref="GooTriangle3D"/> objects if the mesh is not null; otherwise, null.</returns>
        [Inspect("Triangles", "Triangles", "Triangles")]
        public static IEnumerable<GooTriangle3D>? Triangles(this Mesh3D? mesh3D)
        {
            if (mesh3D == null)
            {
                return null;
            }

            return mesh3D.GetTriangles()?.ConvertAll(x => new GooTriangle3D(x));
        }

        /// <summary>
        /// Retrieves the collection of points from the specified 3D mesh.
        /// </summary>
        /// <param name="mesh3D">The 3D mesh to extract points from.</param>
        /// <returns>A collection of <see cref="GooPoint3D"/> objects if the mesh is not null; otherwise, null.</returns>
        [Inspect("Points", "Points", "Points")]
        public static IEnumerable<GooPoint3D>? Points(this Mesh3D? mesh3D)
        {
            if (mesh3D == null)
            {
                return null;
            }

            return mesh3D.GetPoints()?.ConvertAll(x => new GooPoint3D(x));
        }
    }
}