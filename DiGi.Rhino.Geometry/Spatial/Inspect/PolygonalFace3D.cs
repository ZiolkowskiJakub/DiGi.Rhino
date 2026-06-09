using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Geometry.Planar.Classes;
using DiGi.Rhino.Geometry.Spatial.Classes;

namespace DiGi.Rhino.Geometry.Spatial
{
    public static partial class Inspect
    {
        /// <summary>
        /// Retrieves the internal point of the specified polygonal face.
        /// </summary>
        /// <param name="polygonalFace3D">The polygonal face to inspect.</param>
        /// <returns>A <see cref="GooPoint3D"/> representing the internal point, or <c>null</c> if the input is null or no internal point exists.</returns>
        [Inspect("InternalPoint", "InternalPoint", "Internal Point")]
        public static GooPoint3D? InternalPoint(this IPolygonalFace3D? polygonalFace3D)
        {
            if (polygonalFace3D == null)
            {
                return null;
            }

            DiGi.Geometry.Spatial.Classes.Point3D? point3D = polygonalFace3D.GetInternalPoint();

            return point3D == null ? null : new GooPoint3D(point3D);
        }

        /// <summary>
        /// Retrieves the bounding box of the specified polygonal face.
        /// </summary>
        /// <param name="polygonalFace3D">The polygonal face to inspect.</param>
        /// <returns>A <see cref="GooBoundingBox3D"/> representing the bounding box, or <c>null</c> if the input is null or no bounding box exists.</returns>
        [Inspect("BoundingBox", "BoundingBox", "BoundingBox")]
        public static GooBoundingBox3D? BoundingBox(this IPolygonalFace3D? polygonalFace3D)
        {
            if (polygonalFace3D == null)
            {
                return null;
            }

            BoundingBox3D? boundingBox3D = polygonalFace3D.GetBoundingBox();

            return boundingBox3D == null ? null : new GooBoundingBox3D(boundingBox3D);
        }

        /// <summary>
        /// Creates a mesh representation of the specified polygonal face.
        /// </summary>
        /// <param name="polygonalFace3D">The polygonal face to convert to a mesh.</param>
        /// <returns>A <see cref="GooMesh3D"/> representing the mesh, or <c>null</c> if the conversion fails or the input is null.</returns>
        [Inspect("Mesh3D", "Mesh3D", "Mesh3D")]
        public static GooMesh3D? Mesh3D(this IPolygonalFace3D? polygonalFace3D)
        {
            Mesh3D? mesh3D = DiGi.Geometry.Spatial.Create.Mesh3D(polygonalFace3D);

            return mesh3D == null ? null : new GooMesh3D(mesh3D);
        }
    }
}