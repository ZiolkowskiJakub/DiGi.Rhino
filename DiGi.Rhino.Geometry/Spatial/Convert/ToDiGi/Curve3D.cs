using DiGi.Core;
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
        public static ICurve3D? ToDiGi(this Curve? curve, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (curve == null || !curve.IsValid)
            {
                return null;
            }

            if (curve is LineCurve lineCurve)
            {
                return ToDiGi(lineCurve);
            }

            if (curve is PolyCurve polyCurve)
            {
                return ToDiGi(polyCurve, tolerance);
            }

            if (curve.IsEllipse() && curve.TryGetEllipse(out Ellipse ellipse))
            {
                return ToDiGi(ellipse);
            }

            throw new System.NotImplementedException();
        }

        public static ICurve3D? ToDiGi(this PolyCurve? polyCurve, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            List<Curve>? curves = polyCurve?.Explode()?.ToList();
            if (curves == null || curves.Count == 0)
            {
                return null;
            }

            double tolerance_Temp = Core.Query.UnitScale() * tolerance;

            if (curves.TrueForAll(x => x.IsLinear(tolerance_Temp)))
            {
                List<Point3D> point3Ds = [];
                foreach (Curve curve in curves)
                {
                    if (curve.PointAtStart.ToDiGi() is Point3D point3D_Temp)
                    {
                        point3Ds.Add(point3D_Temp);
                    }
                }

                if (curves.Last().PointAtEnd.ToDiGi() is Point3D point3D)
                {
                    point3Ds.Add(point3D);
                }

                if (polyCurve!.IsClosed && polyCurve.IsPlanar(tolerance_Temp) && polyCurve.TryGetPlane(out global::Rhino.Geometry.Plane plane_Rhino, tolerance_Temp) && plane_Rhino.IsValid)
                {
                    DiGi.Geometry.Spatial.Classes.Plane? plane = plane_Rhino.ToDiGi();
                    return new Polygon3D(plane, point3Ds?.ConvertAll(plane.Convert).FilterNulls());
                }

                return new Polyline3D(point3Ds);
            }

            throw new System.NotImplementedException();
        }
    }
}
