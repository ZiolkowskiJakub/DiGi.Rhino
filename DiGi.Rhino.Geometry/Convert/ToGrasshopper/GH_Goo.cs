using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using Grasshopper.Kernel.Types;

namespace DiGi.Rhino.Geometry
{
    public static partial class Convert
    {
        public static IGH_Goo ToGrasshopper(this IGeometry3D geometry3D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (geometry3D == null)
            {
                return default;
            }

            if(geometry3D is Segment3D)
            {
                return ToGrasshopper((Segment3D)geometry3D);
            }

            if (geometry3D is Point3D)
            {
                return ToGrasshopper((Point3D)geometry3D);
            }

            if (geometry3D is PolygonalFace3D)
            {
                return ToGrasshopper((PolygonalFace3D)geometry3D, tolerance);
            }

            if (geometry3D is Polyhedron)
            {
                return ToGrasshopper((Polyhedron)geometry3D, tolerance);
            }

            return default;
        }
    }
}
