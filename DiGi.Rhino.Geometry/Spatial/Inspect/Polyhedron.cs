using DiGi.Geometry.Spatial.Classes;
using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Geometry.Planar.Classes;
using DiGi.Rhino.Geometry.Spatial.Classes;
using System.Collections;

namespace DiGi.Rhino.Geometry.Spatial
{
    public static partial class Inspect
    {
        [Inspect("PolygonalFaces", "PolygonalFaces", "Polygonal Faces")]
        public static IEnumerable PolygonalFaces(this Polyhedron polyhedron)
        {
            if (polyhedron == null)
            {
                return null;
            }

            return polyhedron.PolygonalFaces?.ConvertAll(x => new GooPolygonalFace3D(x));
        }

        [Inspect("InternalPoint", "InternalPoint", "Internal Point")]
        public static GooPoint3D InternalPoint(this Polyhedron polyhedron)
        {
            if (polyhedron == null)
            {
                return null;
            }

            DiGi.Geometry.Spatial.Classes.Point3D point3D = polyhedron.GetInternalPoint();

            return point3D == null ? null : new GooPoint3D(point3D);
        }

        [Inspect("BoundingBox", "BoundingBox", "BoundingBox")]
        public static GooBoundingBox3D BoundingBox(this Polyhedron polyhedron)
        {
            if (polyhedron == null)
            {
                return null;
            }

            BoundingBox3D boundingBox3D = polyhedron.GetBoundingBox();

            return boundingBox3D == null ? null : new GooBoundingBox3D(boundingBox3D);
        }

        [Inspect("Mesh3D", "Mesh3D", "Mesh3D")]
        public static GooMesh3D Mesh3D(this Polyhedron polyhedron)
        {
            Mesh3D mesh3D = DiGi.Geometry.Spatial.Create.Mesh3D(polyhedron);

            return mesh3D == null ? null : new GooMesh3D(mesh3D);
        }
    }
}
