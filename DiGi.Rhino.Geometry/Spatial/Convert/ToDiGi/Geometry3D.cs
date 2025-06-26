using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using Grasshopper.Kernel.Types;
using Rhino.Geometry;
using Rhino.Geometry.Collections;

namespace DiGi.Rhino.Geometry.Spatial
{
    public static partial class Convert
    {
        public static IGeometry3D ToDiGi(this IGH_GeometricGoo geometricGoo, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (geometricGoo == null)
            {
                return null;
            }

            object @object = null;
            try
            {
                @object = (geometricGoo as dynamic).Value;
            }
            catch
            {
                return null;
            }

            if(@object == null)
            {
                return null;
            }

            if (@object is Point3d) 
            {
                return ToDiGi((Point3d)@object);
            }

            if (@object is Rectangle3d)
            {
                return ToDiGi((Rectangle3d)@object);
            }

            if (@object is LineCurve)
            {
                return ToDiGi((LineCurve)@object);
            }

            if (@object is Line)
            {
                return ToDiGi((Line)@object);
            }

            if (@object is Curve)
            {
                return ToDiGi((Curve)@object, tolerance);
            }

            if (@object is Ellipse)
            {
                return ToDiGi((Ellipse)@object);
            }

            if (@object is Brep)
            {
                Brep brep = (Brep)@object;

                if(brep.IsSolid)
                {
                    Polyhedron polyhedron = brep.ToDiGi_Polyhedron(tolerance);
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

            if (@object is global::Rhino.Geometry.Plane)
            {
                return ToDiGi((global::Rhino.Geometry.Plane)@object);
            }

            return null;
        }
    }
}
