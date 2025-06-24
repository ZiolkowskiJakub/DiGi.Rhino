using DiGi.Geometry.Spatial.Classes;

namespace DiGi.Rhino.Geometry.Spatial
{
    public static partial class Convert
    {
        public static global::Rhino.Geometry.Box ToRhino_Box(this BoundingBox3D boundingBox3D)
        {
            if(boundingBox3D == null)
            {
                return global::Rhino.Geometry.Box.Unset;
            }

            return new global::Rhino.Geometry.Box(ToRhino(boundingBox3D));
        }
    }
}