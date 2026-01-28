using DiGi.Geometry.Spatial.Classes;
using Rhino.Geometry;
using Rhino.Geometry.Collections;
using System.Collections.Generic;

namespace DiGi.Rhino.Geometry.Spatial
{
    public static partial class Convert
    {
        public static Mesh3D? ToDiGi(this Mesh? mesh)
        {
            if (mesh == null || !mesh.IsValid)
            {
                return null;
            }

            Mesh mesh_Temp = mesh.DuplicateMesh();
            mesh_Temp.Faces.ConvertQuadsToTriangles();

            MeshVertexList meshVertexList = mesh_Temp.Vertices;
            if (meshVertexList == null)
            {
                return null;
            }

            IEnumerable<MeshFace> meshFaces = mesh_Temp.Faces;
            if (meshFaces == null)
            {
                return null;
            }
            SortedDictionary<int, Point3D> dictionary = [];
            List<int[]> indexes = [];

            foreach (MeshFace meshFace in meshFaces)
            {
                if (meshFace.IsQuad)
                {
                    int index_1 = meshFace.A;
                    int index_2 = meshFace.B;
                    int index_3 = meshFace.C;
                    int index_4 = meshFace.D;

                    if (!dictionary.ContainsKey(index_1))
                    {
                        if (meshVertexList[index_1].ToDiGi() is Point3D point3D)
                        {
                            dictionary[index_1] = point3D;
                        }
                    }

                    if (!dictionary.ContainsKey(index_2))
                    {
                        if (meshVertexList[index_2].ToDiGi() is Point3D point3D)
                        {
                            dictionary[index_2] = point3D;
                        }
                    }

                    if (!dictionary.ContainsKey(index_3))
                    {
                        if (meshVertexList[index_3].ToDiGi() is Point3D point3D)
                        {
                            dictionary[index_3] = point3D;
                        }
                    }

                    if (!dictionary.ContainsKey(index_4))
                    {
                        if (meshVertexList[index_4].ToDiGi() is Point3D point3D)
                        {
                            dictionary[index_4] = point3D;
                        }
                    }

                    indexes.Add([index_1, index_2, index_3]);
                    indexes.Add([index_1, index_3, index_4]);
                }
                else if (meshFace.IsTriangle)
                {
                    int index_1 = meshFace.A;
                    int index_2 = meshFace.B;
                    int index_3 = meshFace.C;

                    if (!dictionary.ContainsKey(index_1))
                    {
                        if (meshVertexList[index_1].ToDiGi() is Point3D point3D)
                        {
                            dictionary[index_1] = point3D;
                        }
                    }

                    if (!dictionary.ContainsKey(index_2))
                    {
                        if (meshVertexList[index_2].ToDiGi() is Point3D point3D)
                        {
                            dictionary[index_2] = point3D;
                        }
                    }

                    if (!dictionary.ContainsKey(index_3))
                    {
                        if (meshVertexList[index_3].ToDiGi() is Point3D point3D)
                        {
                            dictionary[index_3] = point3D;
                        }
                    }

                    indexes.Add([index_1, index_2, index_3]);
                }
            }

            return new Mesh3D(dictionary.Values, indexes);
        }
    }
}