using DiGi.Geometry.Spatial.Classes;

namespace DiGi.Rhino.Geometry.Spatial
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts a <see cref="BoundingBox3D"/> to a Rhino <see path="global::Rhino.Geometry.BoundingBox"/>.
        /// </summary>
        /// <param name="boundingBox3D">The 3D bounding box to convert.</param>
        /// <returns>The corresponding Rhino bounding box, or <see cref="global::Rhino.Geometry.BoundingBox.Unset"/> if the input is null.</returns>
        public static global::Rhino.Geometry.BoundingBox ToRhino(this BoundingBox3D? boundingBox3D)
        {
            if (boundingBox3D == null)
            {
                return global::Rhino.Geometry.BoundingBox.Unset;
            }

            return new global::Rhino.Geometry.BoundingBox(boundingBox3D.Min.ToRhino(), boundingBox3D.Max.ToRhino());
        }
    }
}