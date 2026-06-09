using DiGi.Geometry.Spatial.Classes;
using Rhino.Geometry;
using System.Collections.Generic;

namespace DiGi.Rhino.Geometry.Spatial
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts a Rhino <see cref="Brep"/> to a <see cref="Polyhedron"/>.
        /// </summary>
        /// <param name="brep">The <see cref="Brep"/> instance to convert.</param>
        /// <param name="tolerance">The tolerance used for planarity checks and conversion. Defaults to <see cref="DiGi.Core.Constants.Tolerance.Distance"/>.</param>
        /// <returns>A <see cref="Polyhedron"/> if the Brep is valid, solid, and consists of planar faces; otherwise, <c>null</c>.</returns>
        public static Polyhedron? ToDiGi_Polyhedron(this Brep? brep, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (brep == null || !brep.IsValid)
            {
                return null;
            }

            if (!brep.IsSolid)
            {
                return null;
            }

            double unitScale = Core.Query.UnitScale();

            List<PolygonalFace3D> polygonalFace3Ds = [];
            foreach (BrepFace brepFace in brep.Faces)
            {
                if (!brepFace.IsPlanar(unitScale * tolerance))
                {
                    return null;
                }

                PolygonalFace3D? polygonalFace3D = brepFace.ToDiGi_PolygonalFace3D(tolerance);
                if (polygonalFace3D == null)
                {
                    continue;
                }

                polygonalFace3Ds.Add(polygonalFace3D);
            }

            if (polygonalFace3Ds == null || polygonalFace3Ds.Count == 0)
            {
                return null;
            }

            return DiGi.Geometry.Spatial.Create.Polyhedron(polygonalFace3Ds);
        }
    }
}