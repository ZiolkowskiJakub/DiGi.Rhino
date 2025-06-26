using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using DiGi.Geometry.Spatial;
using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using Rhino.Geometry;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Rhino.Geometry.Spatial
{
    public static partial class Convert
    {
        public static Polyhedron ToDiGi_Polyhedron(this Brep brep, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if(brep == null || !brep.IsValid)
            {
                return null;
            }

            if(!brep.IsSolid)
            {
                return null;
            }

            double unitScale = Core.Query.UnitScale();

            List<PolygonalFace3D> polygonalFace3Ds = new List<PolygonalFace3D>();
            foreach (BrepFace brepFace in brep.Faces)
            {
                if (!brepFace.IsPlanar(unitScale * tolerance))
                {
                    return null;
                }

                PolygonalFace3D polygonalFace3D = brepFace.ToDiGi_PolygonalFace3D(tolerance);
                if(polygonalFace3D == null)
                {
                    continue;
                }

                polygonalFace3Ds.Add(polygonalFace3D);
            }

            if(polygonalFace3Ds == null || polygonalFace3Ds.Count == 0)
            {
                return null;
            }

            return DiGi.Geometry.Spatial.Create.Polyhedron(polygonalFace3Ds);
        }
    }
}
