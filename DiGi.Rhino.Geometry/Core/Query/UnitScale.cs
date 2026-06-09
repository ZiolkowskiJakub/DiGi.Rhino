using Rhino;

namespace DiGi.Rhino.Geometry.Core
{
    public static partial class Query
    {
        /// <summary>
        /// Gets the unit scale of the currently active Rhino document.
        /// </summary>
        /// <returns>The unit scale as a double.</returns>
        public static double UnitScale()
        {
            return UnitScale(RhinoDoc.ActiveDoc);
        }

        /// <summary>
        /// Gets the unit scale for the specified Rhino document relative to meters.
        /// </summary>
        /// <param name="rhinoDoc">The Rhino document to query.</param>
        /// <returns>The unit scale as a double, or <see cref="double.NaN"/> if the provided document is null.</returns>
        public static double UnitScale(RhinoDoc rhinoDoc)
        {
            if (rhinoDoc == null)
            {
                return double.NaN;
            }

            return RhinoMath.UnitScale(UnitSystem.Meters, rhinoDoc.ModelUnitSystem);
        }
    }
}