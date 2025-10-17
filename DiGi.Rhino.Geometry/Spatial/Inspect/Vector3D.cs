using DiGi.Geometry.Spatial.Classes;
using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Geometry.Spatial.Classes;

namespace DiGi.Rhino.Geometry.Spatial
{
    public static partial class Inspect
    {
        [Inspect("Direction", "Direction", "Direction")]
        public static GooVector3D? Direction(this Ray3D? ray3D)
        {
            if (ray3D == null)
            {
                return null;
            }

            Vector3D? direction = ray3D.Direction;

            return direction == null ? null : new GooVector3D(direction);
        }

        [Inspect("Origin", "Origin", "Origin")]
        public static GooPoint3D? Origin(this Ray3D? ray3D)
        {
            if (ray3D == null)
            {
                return null;
            }

            DiGi.Geometry.Spatial.Classes.Point3D? origin = ray3D.Origin;

            return origin == null ? null : new GooPoint3D(origin);
        }
    }
}
