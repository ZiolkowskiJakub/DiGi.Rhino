using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using DiGi.Geometry.Spatial;
using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using Rhino.Geometry;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Rhino.Geometry
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

            double unitScale = Query.UnitScale();

            List<PolygonalFace3D> polygonalFace3Ds = new List<PolygonalFace3D>();
            foreach (BrepFace brepFace in brep.Faces)
            {
                if (!brepFace.IsPlanar(unitScale * tolerance))
                {
                    return null;
                }

                if (!Query.TryGetPlane(brepFace, out DiGi.Geometry.Spatial.Classes.Plane plane, tolerance) || plane == null)
                {
                    return null;
                }

                List<IPolygonal2D> polygonal2Ds = new List<IPolygonal2D>();
                foreach (BrepLoop brepLoop in brepFace.Loops)
                {
                    IPolygonal3D polygonal3D = brepLoop?.To3dCurve()?.ToDiGi(tolerance) as IPolygonal3D;
                    if(polygonal3D == null)
                    {
                        return null;
                    }

                    IPolygonal2D polygonal2D = plane.Convert(polygonal3D);
                    if(polygonal2D == null)
                    {
                        return null;
                    }

                    polygonal2Ds.Add(polygonal2D);
                }

                IPolygonalFace2D polygonalFace2D = DiGi.Geometry.Planar.Create.PolygonalFace2Ds(polygonal2Ds, tolerance).FirstOrDefault();
                if(polygonalFace2D == null)
                {
                    return null;
                }

                polygonalFace3Ds.Add(new PolygonalFace3D(plane, polygonalFace2D));
            }

            if(polygonalFace3Ds == null || polygonalFace3Ds.Count == 0)
            {
                return null;
            }

            return Create.Polyhedron(polygonalFace3Ds);
        }
    }
}
