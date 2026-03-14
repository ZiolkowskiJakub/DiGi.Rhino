using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using Grasshopper.Kernel.Types;
using Rhino.Geometry;
using Rhino.Geometry.Collections;

namespace DiGi.Rhino.Geometry.Spatial
{
    public static partial class Convert
    {
        public static IGeometry3D? ToDiGi(this IGH_GeometricGoo? geometricGoo, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (geometricGoo == null)
            {
                return null;
            }

            object? @object;
            try
            {
                @object = (geometricGoo as dynamic).Value;
            }
            catch
            {
                return null;
            }

            if (@object == null)
            {
                return null;
            }

            if (@object is Point3d point3d)
            {
                return ToDiGi(point3d);
            }

            if (@object is Rectangle3d rectangle3D)
            {
                return ToDiGi(rectangle3D);
            }

            if (@object is LineCurve lineCurve)
            {
                return ToDiGi(lineCurve);
            }

            if (@object is Line line)
            {
                return ToDiGi(line);
            }

            if (@object is Curve curve)
            {
                return ToDiGi(curve, tolerance);
            }

            if (@object is Ellipse ellipse)
            {
                return ToDiGi(ellipse);
            }

            if (@object is Brep brep)
            {
                if (brep.IsSolid)
                {
                    Polyhedron? polyhedron = brep.ToDiGi_Polyhedron(tolerance);
                    if (polyhedron != null)
                    {
                        return polyhedron;
                    }
                }
                else
                {
                    double unitScale = Core.Query.UnitScale();

                    BrepFaceList brepFaceList = brep.Faces;
                    if (brepFaceList.Count == 1 && brepFaceList[0].IsPlanar(unitScale * tolerance))
                    {
                        return ToDiGi_PolygonalFace3D(brepFaceList[0], tolerance);
                    }
                }
            }

            if (@object is global::Rhino.Geometry.Plane plane)
            {
                return ToDiGi(plane);
            }

            return null;
        }
    }
}