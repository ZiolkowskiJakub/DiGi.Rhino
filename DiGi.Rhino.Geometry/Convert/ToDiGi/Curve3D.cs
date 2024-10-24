using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using Rhino.Geometry;
using System.Collections.Generic;
using System.Linq;
using DiGi.Geometry.Spatial;

namespace DiGi.Rhino.Geometry
{
    public static partial class Convert
    {
        public static ICurve3D ToDiGi(this Curve curve, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if(curve == null || !curve.IsValid)
            {
                return null;
            }

            if(curve is LineCurve)
            {
                return ToDiGi((LineCurve)curve);
            }

            if (curve is PolyCurve)
            {
                return ToDiGi((PolyCurve)curve, tolerance);
            }

            throw new System.NotImplementedException();
        }

        public static ICurve3D ToDiGi(this PolyCurve polyCurve, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            List<Curve> curves = polyCurve?.Explode()?.ToList();
            if(curves == null || curves.Count == 0)
            {
                return null;
            }

            double tolerance_Temp = Query.UnitScale() * tolerance;

            if (curves.TrueForAll(x => x.IsLinear(tolerance_Temp)))
            {
                List<Point3D> point3Ds = new List<Point3D>();
                foreach(Curve curve in curves)
                {
                    point3Ds.Add(curve.PointAtStart.ToDiGi());
                }

                point3Ds.Add(curves.Last().PointAtEnd.ToDiGi());

                if(polyCurve.IsClosed && polyCurve.IsPlanar(tolerance_Temp) && polyCurve.TryGetPlane(out global::Rhino.Geometry.Plane plane_Rhino, tolerance_Temp) && plane_Rhino.IsValid)
                {
                    DiGi.Geometry.Spatial.Classes.Plane plane = plane_Rhino.ToDiGi();
                    return new Polygon3D(plane, point3Ds.ConvertAll(x => plane.Convert(x)));
                }

                return new Polyline3D(point3Ds);
            }

            throw new System.NotImplementedException();
        }
    }
}
