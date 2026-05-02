using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using Rhino.Geometry;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Rhino.Geometry.Spatial
{
    public static partial class Convert
    {
        public static Brep? ToRhino(this IPolygonalFace3D? polygonalFace3D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            List<IPolygonal3D>? polygonal3Ds = polygonalFace3D?.Edges;
            if (polygonal3Ds == null || polygonal3Ds.Count == 0)
            {
                return null;
            }

            double unitScale = Core.Query.UnitScale();

            Brep[] breps = Brep.CreatePlanarBreps(polygonal3Ds.ConvertAll(x => x.ToRhino()), unitScale * tolerance);
            if (breps == null || breps.Length == 0)
            {
                return null;
            }

            if (breps.Length == 1)
            {
                return breps[0];
            }

            List<Brep> brepList = [.. breps];
            brepList.Sort((x, y) => x.GetArea().CompareTo(y.GetArea()));

            Brep brep = brepList.Last();
            brepList.Remove(brep);

            breps = Brep.CreateBooleanIntersection([brep], brepList, unitScale * tolerance);
            if (breps == null || breps.Length == 0)
                return null;

            return breps[0];
        }

        public static Brep? ToRhino(this Polyhedron? polyhedron, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            List<IPolygonalFace3D>? polygonalFace3Ds = polyhedron?.PolygonalFaces;
            if (polygonalFace3Ds == null)
            {
                return null;
            }

            List<Brep> breps = [];
            foreach (IPolygonalFace3D polygonalFace3D in polygonalFace3Ds)
            {
                Brep? brep = polygonalFace3D.ToRhino(tolerance);
                if (brep == null)
                {
                    continue;
                }

                breps.Add(brep);
            }

            if (breps == null || breps.Count == 0)
            {
                return null;
            }

            double unitScale = Core.Query.UnitScale();

            Brep[] result = Brep.JoinBreps(breps, unitScale * tolerance);
            if (result == null || result.Length == 0)
            {
                return null;
            }

            return result[0];
        }

        public static Brep? ToRhino(this Ellipsoid? ellipsoid)
        {
            Point3d center = ToRhino(ellipsoid?.Center);
            if (!center.IsValid)
            {
                return null;
            }

            if (ellipsoid!.DirectionA is not Vector3D directionA)
            {
                return null;
            }

            if (ellipsoid!.DirectionB is not Vector3D directionB)
            {
                return null;
            }

            Plane plane = global::Rhino.Geometry.Plane.WorldXY;// new global::Rhino.Geometry.Plane(center, ellipsoid.DirectionA.ToRhino(), ellipsoid.DirectionB.ToRhino());

            Sphere sphere = new(Point3d.Origin, 1.0);
            NurbsSurface nurbSurface = sphere.ToNurbsSurface();

            Transform scale = Transform.Scale(plane, ellipsoid.A, ellipsoid.B, ellipsoid.C);

            nurbSurface.Transform(scale);

            Transform orient = Transform.PlaneToPlane(plane, new Plane(center, directionA.ToRhino(), directionB.ToRhino()));

            nurbSurface.Transform(orient);

            return nurbSurface.ToBrep();
        }
    }
}