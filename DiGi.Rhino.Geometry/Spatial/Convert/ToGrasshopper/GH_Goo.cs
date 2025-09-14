using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using Grasshopper.Kernel.Types;

namespace DiGi.Rhino.Geometry.Spatial
{
    public static partial class Convert
    {
        public static IGH_Goo? ToGrasshopper(this IGeometry3D? geometry3D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (geometry3D == null)
            {
                return default;
            }

            if (geometry3D is Point3D point3D)
            {
                return ToGrasshopper(point3D);
            }

            if (geometry3D is Vector3D vector3D)
            {
                return ToGrasshopper(vector3D);
            }

            if (geometry3D is Segment3D segment3D)
            {
                return ToGrasshopper(segment3D);
            }

            if (geometry3D is Rectangle3D rectangle3D)
            {
                return ToGrasshopper(rectangle3D);
            }

            if (geometry3D is Mesh3D mesh3D)
            {
                return ToGrasshopper(mesh3D);
            }

            if (geometry3D is PolygonalFace3D polygonalFace3D)
            {
                return ToGrasshopper(polygonalFace3D, tolerance);
            }

            if (geometry3D is Polyhedron polyhedron)
            {
                return ToGrasshopper(polyhedron, tolerance);
            }

            if (geometry3D is IPolygonal3D polygonal3D)
            {
                return ToGrasshopper(polygonal3D);
            }

            if (geometry3D is Ellipsoid ellipsoid)
            {
                return ToGrasshopper(ellipsoid);
            }

            if (geometry3D is Polyline3D polyline3D)
            {
                return ToGrasshopper(polyline3D);
            }

            return default;
        }
    }
}
