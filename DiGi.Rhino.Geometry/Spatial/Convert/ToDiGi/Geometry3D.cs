using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using Grasshopper.Kernel.Types;

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

            if (@object is global::Rhino.Geometry.Point3d) 
            {
                return ToDiGi((global::Rhino.Geometry.Point3d)@object);
            }

            if (@object is global::Rhino.Geometry.Rectangle3d)
            {
                return ToDiGi((global::Rhino.Geometry.Rectangle3d)@object);
            }

            if (@object is global::Rhino.Geometry.LineCurve)
            {
                return ToDiGi((global::Rhino.Geometry.LineCurve)@object);
            }

            if (@object is global::Rhino.Geometry.Line)
            {
                return ToDiGi((global::Rhino.Geometry.Line)@object);
            }

            if (@object is global::Rhino.Geometry.Curve)
            {
                return ToDiGi((global::Rhino.Geometry.Curve)@object, tolerance);
            }

            if (@object is global::Rhino.Geometry.Ellipse)
            {
                return ToDiGi((global::Rhino.Geometry.Ellipse)@object);
            }

            if (@object is global::Rhino.Geometry.Brep)
            {
                global::Rhino.Geometry.Brep brep = (global::Rhino.Geometry.Brep)@object;

                Polyhedron polyhedron = brep.ToDiGi_Polyhedron(tolerance);
                if(polyhedron != null)
                {
                    return polyhedron;
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
