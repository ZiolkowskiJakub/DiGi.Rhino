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

            List<Point3D> point3Ds = mesh3D.GetPoints();
            foreach(Point3D point3D in point3Ds)
            {
                result.Vertices.Add(point3D.X, point3D.Y, point3D.Z);
            }

            List<int[]> indexesList = mesh3D.GetIndexes();
            foreach (int[] indexes in indexesList)
            {
                result.Faces.AddFace(indexes[0], indexes[1], indexes[2]);
            }

            result.Normals.ComputeNormals();
            result.Compact();

            //List<Triangle3D> triangle3Ds = mesh3D.GetTriangles();
            //if (triangle3Ds != null)
            //{
            //    foreach (Triangle3D triangle3D in triangle3Ds)
            //    {
            //        if (triangle3D == null)
            //        {
            //            continue;
            //        }

            //        result.Vertices.Add();

            //        List<Curve> lines = triangle3D.GetSegments().ConvertAll(x => (Curve)x.ToRhino());

            //        Mesh mesh = Mesh.CreateFromLines(lines.ToArray(), 3, DiGi.Core.Constans.Tolerance.Distance);
            //        if (mesh == null)
            //        {
            //            continue;
            //        }

            //        result.Append(mesh);
            //    }
            //}

            return result;
        }
    }
}