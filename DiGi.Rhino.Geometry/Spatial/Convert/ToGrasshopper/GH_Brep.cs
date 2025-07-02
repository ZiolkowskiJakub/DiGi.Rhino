using DiGi.Geometry.Spatial.Classes;
using Grasshopper.Kernel.Types;

namespace DiGi.Rhino.Geometry.Spatial
{
    public static partial class Convert
    {
        public static GH_Brep ToGrasshopper(this PolygonalFace3D polygonalFace3D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (polygonalFace3D == null)
            {
                return null;
            }

            return new GH_Brep(polygonalFace3D.ToRhino(tolerance));
        }

        public static GH_Brep ToGrasshopper(this Polyhedron polyhedron, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (polyhedron == null)
            {
                return null;
            }

            return new GH_Brep(polyhedron.ToRhino(tolerance));
        }

        public static GH_Brep ToGrasshopper(this Ellipsoid ellipsoid)
        {
            if (ellipsoid == null)
            {
                return null;
            }

            return new GH_Brep(ellipsoid.ToRhino());
        }
    }
}
