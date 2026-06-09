using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Geometry.Spatial.Classes;
using Grasshopper.Kernel.Types;

namespace DiGi.Rhino.Geometry.Spatial
{
    public static partial class Inspect
    {
        /// <summary>
        /// Gets the length of the specified vector as a GH_Number.
        /// </summary>
        /// <param name="vector3D">The Vector3D instance to measure.</param>
        /// <returns>A <see cref="GH_Number"/> containing the length of the vector, or <c>null</c> if the input vector is null.</returns>
        [Inspect("Length", "Length", "Vector Length")]
        public static GH_Number? Length(this DiGi.Geometry.Spatial.Classes.Vector3D? vector3D)
        {
            if (vector3D == null)
            {
                return null;
            }

            return new GH_Number(vector3D.Length);
        }

        /// <summary>
        /// Gets the unit vector of the specified vector as a GooVector3D.
        /// </summary>
        /// <param name="vector3D">The Vector3D instance to normalize.</param>
        /// <returns>A <see cref="GooVector3D"/> representing the unit vector, or <c>null</c> if the input vector is null.</returns>
        [Inspect("Unit", "Unit", "Unit Vector3D")]
        public static GooVector3D? Unit(this DiGi.Geometry.Spatial.Classes.Vector3D? vector3D)
        {
            if (vector3D == null)
            {
                return null;
            }

            return new GooVector3D(vector3D.Unit);
        }

        /// <summary>
        /// Gets the X coordinate of the specified vector as a GH_Number.
        /// </summary>
        /// <param name="vector3D">The Vector3D instance.</param>
        /// <returns>A <see cref="GH_Number"/> containing the X component, or <c>null</c> if the input vector is null.</returns>
        [Inspect("X", "X", "X Coordinate")]
        public static GH_Number? X(this DiGi.Geometry.Spatial.Classes.Vector3D? vector3D)
        {
            if (vector3D == null)
            {
                return null;
            }

            return new GH_Number(vector3D.X);
        }

        /// <summary>
        /// Gets the Y coordinate of the specified vector as a GH_Number.
        /// </summary>
        /// <param name="vector3D">The Vector3D instance.</param>
        /// <returns>A <see cref="GH_Number"/> containing the Y component, or <c>null</c> if the input vector is null.</returns>
        [Inspect("Y", "Y", "Y Coordinate")]
        public static GH_Number? Y(this DiGi.Geometry.Spatial.Classes.Vector3D? vector3D)
        {
            if (vector3D == null)
            {
                return null;
            }

            return new GH_Number(vector3D.Y);
        }

        /// <summary>
        /// Gets the Z coordinate of the specified vector as a GH_Number.
        /// </summary>
        /// <param name="vector3D">The Vector3D instance.</param>
        /// <returns>A <see cref="GH_Number"/> containing the Z component, or <c>null</c> if the input vector is null.</returns>
        [Inspect("Z", "Z", "Z Coordinate")]
        public static GH_Number? Z(this DiGi.Geometry.Spatial.Classes.Vector3D? vector3D)
        {
            if (vector3D == null)
            {
                return null;
            }

            return new GH_Number(vector3D.Z);
        }
    }
}