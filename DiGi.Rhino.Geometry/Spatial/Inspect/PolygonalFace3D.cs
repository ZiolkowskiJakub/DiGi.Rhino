using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Geometry.Planar.Classes;
using DiGi.Rhino.Geometry.Spatial.Classes;

namespace DiGi.Rhino.Geometry.Spatial
{
    public static partial class Inspect
    {
        [Inspect("InternalPoint", "InternalPoint", "Internal Point")]
        public static GooPoint3D InternalPoint(this IPolygonalFace3D polygonalFace3D)
        {
            if (polygonalFace3D == null)
            {
                return null;
            }

            DiGi.Geometry.Spatial.Classes.Point3D point3D = polygonalFace3D.GetInternalPoint();

            return point3D == null ? null : new GooPoint3D(point3D);
        }

        [Inspect("BoundingBox", "BoundingBox", "BoundingBox")]
        public static GooBoundingBox3D BoundingBox(this IPolygonalFace3D polygonalFace3D)
        {
            if (polygonalFace3D == null)
            {
                return null;
            }

            BoundingBox3D boundingBox3D = polygonalFace3D.GetBoundingBox();

            return boundingBox3D == null ? null : new GooBoundingBox3D(boundingBox3D);
        }

        [Inspect("Mesh3D", "Mesh3D", "Mesh3D")]
        public static GooMesh3D Mesh3D(this IPolygonalFace3D polygonalFace3D)
        {
            Mesh3D mesh3D = DiGi.Geometry.Spatial.Create.Mesh3D(polygonalFace3D);

            return mesh3D == null ? null : new GooMesh3D(mesh3D);
        }
    }
}
