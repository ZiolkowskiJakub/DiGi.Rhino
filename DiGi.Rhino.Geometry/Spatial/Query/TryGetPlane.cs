using DiGi.Geometry.Spatial.Classes;
using Rhino.Geometry;

namespace DiGi.Rhino.Geometry.Spatial
{
    public static partial class Query
    {
        public static bool TryGetPlane(BrepFace brepFace, out DiGi.Geometry.Spatial.Classes.Plane plane, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            plane = null;
            if(brepFace == null)
            {
                return false;
            }

            double unitScale = Core.Query.UnitScale();

            if (!brepFace.IsPlanar(unitScale * tolerance))
            {
                return false;
            }

            if (!brepFace.TryGetPlane(out global::Rhino.Geometry.Plane plane_BrepFace) || !plane_BrepFace.IsValid)
            {
                return false;
            }

            plane = plane_BrepFace.ToDiGi();
            if(plane == null)
            {
                return false;
            }

            Vector3D normal = brepFace.NormalAt(0.5, 0.5).ToDiGi();
            if (normal != null && !DiGi.Geometry.Spatial.Query.SameHalf(plane.Normal, normal, 0))
            {
                plane.Inverse();
            }

            return true;
        }
    }
}
