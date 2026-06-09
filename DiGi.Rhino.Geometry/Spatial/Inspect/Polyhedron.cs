using DiGi.Geometry.Spatial.Classes;
using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Geometry.Planar.Classes;
using DiGi.Rhino.Geometry.Spatial.Classes;
using System.Collections;

namespace DiGi.Rhino.Geometry.Spatial
{
    public static partial class Inspect
    {
        /// <summary>
        /// Retrieves the polygonal faces of the specified polyhedron.
        /// </summary>
        /// <param name="polyhedron">The polyhedron to inspect.</param>
        /// <returns>A collection of polygonal faces as <see cref="GooPolygonalFace3D"/> objects, or <c>null</c> if the polyhedron is null.</returns>
        [Inspect("PolygonalFaces", "PolygonalFaces", "Polygonal Faces")]
        public static IEnumerable? PolygonalFaces(this Polyhedron? polyhedron)
        {
            if (polyhedron == null)
            {
                return null;
            }

            return polyhedron.PolygonalFaces?.ConvertAll(x => new GooPolygonalFace3D(x));
        }

        /// <summary>
        /// Retrieves the internal point of the specified polyhedron.
        /// </summary>
        /// <param name="polyhedron">The polyhedron to inspect.</param>
        /// <returns>The <see cref="GooPoint3D"/> representing the internal point, or <c>null</c> if the polyhedron is null or no internal point exists.</returns>
        [Inspect("InternalPoint", "InternalPoint", "Internal Point")]
        public static GooPoint3D? InternalPoint(this Polyhedron? polyhedron)
        {
            if (polyhedron == null)
            {
                return null;
            }

            DiGi.Geometry.Spatial.Classes.Point3D? point3D = polyhedron.GetInternalPoint();

            return point3D == null ? null : new GooPoint3D(point3D);
        }

        /// <summary>
        /// Retrieves the bounding box of the specified polyhedron.
        /// </summary>
        /// <param name="polyhedron">The polyhedron to inspect.</param>
        /// <returns>The <see cref="GooBoundingBox3D"/> representing the bounding box, or <c>null</c> if the polyhedron is null or no bounding box exists.</returns>
        [Inspect("BoundingBox", "BoundingBox", "BoundingBox")]
        public static GooBoundingBox3D? BoundingBox(this Polyhedron? polyhedron)
        {
            if (polyhedron == null)
            {
                return null;
            }

            BoundingBox3D? boundingBox3D = polyhedron.GetBoundingBox();

            return boundingBox3D == null ? null : new GooBoundingBox3D(boundingBox3D);
        }

        /// <summary>
        /// Creates a mesh representation of the specified polyhedron.
        /// </summary>
        /// <param name="polyhedron">The polyhedron to convert into a mesh.</param>
        /// <returns>The <see cref="GooMesh3D"/> representing the polyhedron, or <c>null</c> if the conversion fails or the input is null.</returns>
        [Inspect("Mesh3D", "Mesh3D", "Mesh3D")]
        public static GooMesh3D? Mesh3D(this Polyhedron? polyhedron)
        {
            Mesh3D? mesh3D = DiGi.Geometry.Spatial.Create.Mesh3D(polyhedron);

            return mesh3D == null ? null : new GooMesh3D(mesh3D);
        }
    }
}