using DiGi.Geometry.Spatial.Classes;
using Rhino.Geometry;
using System.Collections.Generic;

namespace DiGi.Rhino.Geometry.Spatial
{
    public static partial class Convert
    {
        public static Mesh ToRhino(this Mesh3D mesh3D)
        {
            if (mesh3D == null)
            {
                return null;
            }

            Mesh result = new Mesh();

            List<Triangle3D> triangle3Ds = mesh3D.GetTriangles();
            if (triangle3Ds != null)
            {
                foreach (Triangle3D triangle3D in triangle3Ds)
                {
                    if (triangle3D == null)
                    {
                        continue;
                    }

                    List<Curve> lines = triangle3D.GetSegments().ConvertAll(x => (Curve)x.ToRhino());

                    Mesh mesh = Mesh.CreateFromLines(lines.ToArray(), 3, DiGi.Core.Constans.Tolerance.Distance);
                    if (mesh == null)
                    {
                        continue;
                    }

                    result.Append(mesh);
                }
            }

            return result;
        }
    }
}