using DiGi.Geometry.Spatial.Classes;
using Rhino.Geometry;

namespace DiGi.Rhino.Geometry.Spatial
{
    public static partial class Query
    {
        /// <summary>
        /// Attempts to retrieve a <see cref="DiGi.Geometry.Spatial.Classes.Plane"/> from a Rhino <see cref="BrepFace"/>.
        /// </summary>
        /// <param name="brepFace">The Brep face to analyze.</param>
        /// <param name="plane">When this method returns, contains the extracted plane if successful; otherwise, null.</param>
        /// <param name="tolerance">The tolerance used to determine if the face is planar. Defaults to <see cref="DiGi.Core.Constants.Tolerance.Distance"/>.</param>
        /// <returns>True if a valid plane was successfully extracted from the face; otherwise, false.</returns>
        public static bool TryGetPlane(BrepFace? brepFace, out DiGi.Geometry.Spatial.Classes.Plane? plane, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            plane = null;
            if (brepFace == null)
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
            if (plane == null)
            {
                return false;
            }

            Vector3D? normal = brepFace.NormalAt(0.5, 0.5).ToDiGi();
            if (normal != null && !DiGi.Geometry.Spatial.Query.SameHalf(plane.Normal, normal, 0))
            {
                plane.Flip();
            }

            return true;
        }
    }
}