using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Geometry.Planar.Classes;
using Grasshopper.Kernel.Types;

namespace DiGi.Rhino.Geometry.Planar
{
    public static partial class Inspect
    {
        /// <summary>
        /// Returns the inversed version of the provided 2D vector as a <see cref="GooVector2D"/>.
        /// </summary>
        /// <param name="vector2D">The 2D vector to invert.</param>
        /// <returns>A <see cref="GooVector2D"/> containing the inverted vector, or <c>null</c> if the input vector is null.</returns>
        [Inspect("Inversed", "Inversed", "Inversed Vector2D")]
        public static GooVector2D? Inversed(this DiGi.Geometry.Planar.Classes.Vector2D? vector2D)
        {
            if (vector2D == null)
            {
                return null;
            }

            return new GooVector2D(vector2D.GetInversed());
        }

        /// <summary>
        /// Returns the length of the provided 2D vector as a <see cref="GH_Number"/>.
        /// </summary>
        /// <param name="vector2D">The 2D vector whose length is to be calculated.</param>
        /// <returns>A <see cref="GH_Number"/> representing the length, or <c>null</c> if the input vector is null.</returns>
        [Inspect("Length", "Length", "Vector Length")]
        public static GH_Number? Length(this DiGi.Geometry.Planar.Classes.Vector2D? vector2D)
        {
            if (vector2D == null)
            {
                return null;
            }

            return new GH_Number(vector2D.Length);
        }

        /// <summary>
        /// Returns the unit (normalized) version of the provided 2D vector as a <see cref="GooVector2D"/>.
        /// </summary>
        /// <param name="vector2D">The 2D vector to normalize.</param>
        /// <returns>A <see cref="GooVector2D"/> containing the unit vector, or <c>null</c> if the input vector is null.</returns>
        [Inspect("Unit", "Unit", "Unit Vector2D")]
        public static GooVector2D? Unit(this DiGi.Geometry.Planar.Classes.Vector2D? vector2D)
        {
            if (vector2D == null)
            {
                return null;
            }

            return new GooVector2D(vector2D?.Unit);
        }

        /// <summary>
        /// Returns the X coordinate of the provided 2D vector as a <see cref="GH_Number"/>.
        /// </summary>
        /// <param name="vector2D">The 2D vector whose X coordinate is to be retrieved.</param>
        /// <returns>A <see cref="GH_Number"/> representing the X coordinate, or <c>null</c> if the input vector is null.</returns>
        [Inspect("X", "X", "X Coordinate")]
        public static GH_Number? X(this DiGi.Geometry.Planar.Classes.Vector2D? vector2D)
        {
            if (vector2D == null)
            {
                return null;
            }

            return new GH_Number(vector2D.X);
        }

        /// <summary>
        /// Returns the Y coordinate of the provided 2D vector as a <see cref="GH_Number"/>.
        /// </summary>
        /// <param name="vector2D">The 2D vector whose Y coordinate is to be retrieved.</param>
        /// <returns>A <see cref="GH_Number"/> representing the Y coordinate, or <c>null</c> if the input vector is null.</returns>
        [Inspect("Y", "Y", "Y Coordinate")]
        public static GH_Number? Y(this DiGi.Geometry.Planar.Classes.Vector2D? vector2D)
        {
            if (vector2D == null)
            {
                return null;
            }

            return new GH_Number(vector2D.Y);
        }
    }
}