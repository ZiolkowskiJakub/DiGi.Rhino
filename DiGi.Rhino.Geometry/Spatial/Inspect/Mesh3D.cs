using DiGi.Geometry.Spatial.Classes;
using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Geometry.Spatial.Classes;
using System.Collections.Generic;

namespace DiGi.Rhino.Geometry.Spatial
{
    public static partial class Inspect
    {
        [Inspect("Triangles", "Triangles", "Triangles")]
        public static IEnumerable<GooTriangle3D> Triangles(this Mesh3D mesh3D)
        {
            if (mesh3D == null)
            {
                return null;
            }

            return mesh3D.GetTriangles()?.ConvertAll(x => new GooTriangle3D(x));
        }

        [Inspect("Points", "Points", "Points")]
        public static IEnumerable<GooPoint3D> Points(this Mesh3D mesh3D)
        {
            if (mesh3D == null)
            {
                return null;
            }

            return mesh3D.GetPoints()?.ConvertAll(x => new GooPoint3D(x));
        }
    }
}
