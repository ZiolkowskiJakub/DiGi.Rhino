using DiGi.Geometry.Spatial.Classes;

namespace DiGi.Rhino.Geometry.Spatial
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts a <see cref="BoundingBox3D"/> to a Rhino <see cref="global::Rhino.Geometry.Box"/>.
        /// </summary>
        /// <param name="boundingBox3D">The 3D bounding box to convert.</param>
        /// <returns>A Rhino <see cref="global::Rhino.Geometry.Box"/> representation of the bounding box, or <see cref="global::Rhino.Geometry.Box.Unset"/> if the input is null.</returns>
        public static global::Rhino.Geometry.Box ToRhino_Box(this BoundingBox3D boundingBox3D)
        {
            if (boundingBox3D == null)
            {
                return global::Rhino.Geometry.Box.Unset;
            }

            return new global::Rhino.Geometry.Box(ToRhino(boundingBox3D));
        }
    }
}