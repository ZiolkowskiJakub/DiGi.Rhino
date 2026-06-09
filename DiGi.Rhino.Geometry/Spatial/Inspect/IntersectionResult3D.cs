using DiGi.Geometry.Spatial.Interfaces;
using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Geometry.Spatial.Classes;
using System.Collections;
using System.Collections.Generic;

namespace DiGi.Rhino.Geometry.Spatial
{
    public static partial class Inspect
    {
        /// <summary>
        /// Extracts the 3D geometries from the specified intersection result.
        /// </summary>
        /// <param name="intersectionResult3D">The intersection result to inspect.</param>
        /// <returns>An enumerable collection of 3D geometries, or <c>null</c> if the intersection result is null or contains no geometries.</returns>
        [Inspect("Geometry3Ds", "Geometry3Ds", "Geometry3Ds")]
        public static IEnumerable? Geometry3Ds(this IIntersectionResult3D? intersectionResult3D)
        {
            List<IGeometry3D>? geometry3Ds = intersectionResult3D?.GetGeometry3Ds<IGeometry3D>();
            if (geometry3Ds == null)
            {
                return null;
            }

            List<GooGeometry3D> result = [];
            foreach (IGeometry3D geometry3D in geometry3Ds)
            {
                result.Add(new GooGeometry3D(geometry3D));
            }

            return result;
        }
    }
}