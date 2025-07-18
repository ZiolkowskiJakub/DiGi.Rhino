using DiGi.Geometry.Spatial.Classes;
using Rhino.Geometry;
using Rhino.Geometry.Collections;
using System.Collections;
using System.Collections.Generic;

namespace DiGi.Rhino.Geometry.Spatial
{
    public static partial class Convert
    {
        public static Mesh3D ToDiGi(this Mesh mesh)
        {
            if(mesh == null || !mesh.IsValid)
            {
                return null;
            }

            Mesh mesh_Temp = mesh.DuplicateMesh();
            mesh_Temp.Faces.ConvertQuadsToTriangles();

            MeshVertexList meshVertexList = mesh_Temp.Vertices;
            if(meshVertexList == null)
            {
                return null;
            }

            IEnumerable<MeshFace> meshFaces = mesh_Temp.Faces;
            if(meshFaces == null)
            {
                return null;    
            }
            SortedDictionary<int, Point3D> dictionary = new SortedDictionary<int, Point3D>();
            List<int[]> indexes = new List<int[]>();

            foreach( MeshFace meshFace in meshFaces )
            {
                if(meshFace.IsQuad)
                {
                    int index_1 = meshFace.A;
                    int index_2 = meshFace.B;
                    int index_3 = meshFace.C;
                    int index_4 = meshFace.D;

                    if (!dictionary.ContainsKey(index_1))
                    {
                        dictionary[index_1] = meshVertexList[index_1].ToDiGi();
                    }

                    if (!dictionary.ContainsKey(index_2))
                    {
                        dictionary[index_2] = meshVertexList[index_2].ToDiGi();
                    }

                    if (!dictionary.ContainsKey(index_3))
                    {
                        dictionary[index_3] = meshVertexList[index_3].ToDiGi();
                    }

                    if (!dictionary.ContainsKey(index_4))
                    {
                        dictionary[index_4] = meshVertexList[index_4].ToDiGi();
                    }

                    indexes.Add([index_1, index_2, index_3]);
                    indexes.Add([index_1, index_3, index_4]);
                }
                else if(meshFace.IsTriangle)
                {
                    int index_1 = meshFace.A;
                    int index_2 = meshFace.B;
                    int index_3 = meshFace.C;

                    if(!dictionary.ContainsKey(index_1))
                    {
                        dictionary[index_1] = meshVertexList[index_1].ToDiGi();
                    }

                    if (!dictionary.ContainsKey(index_2))
                    {
                        dictionary[index_2] = meshVertexList[index_2].ToDiGi();
                    }

                    if (!dictionary.ContainsKey(index_3))
                    {
                        dictionary[index_3] = meshVertexList[index_3].ToDiGi();
                    }

                    indexes.Add([index_1, index_2, index_3]);
                }
            }
            
            return new Mesh3D(dictionary.Values, indexes);
        }
    }
}
