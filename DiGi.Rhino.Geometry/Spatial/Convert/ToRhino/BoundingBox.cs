using DiGi.Geometry.Spatial.Classes;

namespace DiGi.Rhino.Geometry.Spatial
{
    public static partial class Convert
    {
        public static global::Rhino.Geometry.BoundingBox ToRhino(this BoundingBox3D boundingBox3D)
        {
            if(boundingBox3D == null)
            {
                return global::Rhino.Geometry.BoundingBox.Unset;
            }

            return new global::Rhino.Geometry.BoundingBox(boundingBox3D.Min.ToRhino(), boundingBox3D.Max.ToRhino());
        }
    }
}