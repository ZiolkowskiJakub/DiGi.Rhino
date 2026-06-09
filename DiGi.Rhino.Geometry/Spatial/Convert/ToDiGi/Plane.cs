using DiGi.Geometry.Spatial.Classes;

namespace DiGi.Rhino.Geometry.Spatial
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts a Rhino Plane to a DiGi Plane.
        /// </summary>
        /// <param name="plane">The Rhino plane to convert.</param>
        /// <returns>A new <see cref="Plane"/> instance if the provided plane is valid; otherwise, <c>null</c>.</returns>
        public static Plane? ToDiGi(this global::Rhino.Geometry.Plane plane)
        {
            if (!plane.IsValid)
            {
                return null;
            }

            return new Plane(plane.Origin.ToDiGi(), plane.XAxis.ToDiGi(), plane.YAxis.ToDiGi());
        }
    }
}