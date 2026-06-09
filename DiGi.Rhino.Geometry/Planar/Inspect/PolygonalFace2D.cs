using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Geometry.Planar.Classes;
using Grasshopper.Kernel.Types;
using System.Collections;

namespace DiGi.Rhino.Geometry.Planar
{
    public static partial class Inspect
    {
        /// <summary>
        /// Gets the centroid of the specified polygonal face.
        /// </summary>
        /// <param name="polygonalFace2D">The polygonal face to evaluate.</param>
        /// <returns>A <see cref="GooPoint2D"/> representing the centroid, or <c>null</c> if the input is null.</returns>
        [Inspect("Centroid", "Centroid", "Centroid")]
        public static GooPoint2D? Centroid(this DiGi.Geometry.Planar.Classes.PolygonalFace2D? polygonalFace2D)
        {
            if (polygonalFace2D == null)
            {
                return null;
            }

            return new GooPoint2D(DiGi.Geometry.Planar.Query.Centroid(polygonalFace2D));
        }

        /// <summary>
        /// Gets an internal point of the specified polygonal face.
        /// </summary>
        /// <param name="polygonalFace2D">The polygonal face to evaluate.</param>
        /// <returns>A <see cref="GooPoint2D"/> representing a point inside the face, or <c>null</c> if the input is null.</returns>
        [Inspect("InternalPoint", "InternalPoint", "InternalPoint")]
        public static GooPoint2D? InternalPoint(this DiGi.Geometry.Planar.Classes.PolygonalFace2D? polygonalFace2D)
        {
            if (polygonalFace2D == null)
            {
                return null;
            }

            return new GooPoint2D(polygonalFace2D.GetInternalPoint());
        }

        /// <summary>
        /// Gets the area of the specified polygonal face.
        /// </summary>
        /// <param name="polygonalFace2D">The polygonal face to evaluate.</param>
        /// <returns>A <see cref="GH_Number"/> representing the area, or <c>null</c> if the input is null.</returns>
        [Inspect("Area", "Area", "Area")]
        public static GH_Number? Area(this DiGi.Geometry.Planar.Classes.PolygonalFace2D? polygonalFace2D)
        {
            if (polygonalFace2D == null)
            {
                return null;
            }

            return new GH_Number(polygonalFace2D.GetArea());
        }

        /// <summary>
        /// Gets the external edge of the specified polygonal face.
        /// </summary>
        /// <param name="polygonalFace2D">The polygonal face to evaluate.</param>
        /// <returns>A <see cref="GooPolygonal2D"/> representing the outer boundary, or <c>null</c> if the input is null.</returns>
        [Inspect("ExternalEdge", "ExternalEdge", "ExternalEdge")]
        public static GooPolygonal2D? ExternalEdge(this DiGi.Geometry.Planar.Classes.PolygonalFace2D? polygonalFace2D)
        {
            if (polygonalFace2D == null)
            {
                return null;
            }

            return new GooPolygonal2D(polygonalFace2D.ExternalEdge);
        }

        /// <summary>
        /// Gets the internal edges of the specified polygonal face.
        /// </summary>
        /// <param name="polygonalFace2D">The polygonal face to evaluate.</param>
        /// <returns>An enumerable collection of <see cref="GooPolygonal2D"/> representing internal boundaries, or <c>null</c> if the input is null.</returns>
        [Inspect("InternalEdges", "InternalEdges", "InternalEdges")]
        public static IEnumerable? InternalEdges(this DiGi.Geometry.Planar.Classes.PolygonalFace2D? polygonalFace2D)
        {
            if (polygonalFace2D == null)
            {
                return null;
            }

            return polygonalFace2D.InternalEdges?.ConvertAll(x => new GooPolygonal2D(x));
        }
    }
}