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
        /// <summary>
        /// Converts a Rhino <see cref="Curve"/> to a DiGi <see cref="ICurve3D"/>.
        /// </summary>
        /// <param name="curve">The Rhino curve to convert.</param>
        /// <param name="tolerance">The distance tolerance used for geometric evaluations. Defaults to <see cref="DiGi.Core.Constants.Tolerance.Distance"/>.</param>
        /// <returns>A DiGi <see cref="ICurve3D"/> instance if the conversion is successful; otherwise, <c>null</c>.</returns>
        /// <exception cref="System.NotImplementedException">Thrown when the specific curve type is not yet supported for conversion.</exception>
        public static ICurve3D? ToDiGi(this Curve? curve, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
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

        /// <summary>
        /// Converts a Rhino <see cref="PolyCurve"/> to a DiGi <see cref="ICurve3D"/>.
        /// </summary>
        /// <param name="polyCurve">The Rhino polycurve to convert.</param>
        /// <param name="tolerance">The distance tolerance used for geometric evaluations. Defaults to <see cref="DiGi.Core.Constants.Tolerance.Distance"/>.</param>
        /// <returns>A DiGi <see cref="ICurve3D"/> instance (such as <see cref="Polyline3D"/> or <see cref="Polygon3D"/>) if the conversion is successful; otherwise, <c>null</c>.</returns>
        /// <exception cref="System.NotImplementedException">Thrown when the polycurve contains non-linear segments that are not supported.</exception>
        public static ICurve3D? ToDiGi(this PolyCurve? polyCurve, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
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