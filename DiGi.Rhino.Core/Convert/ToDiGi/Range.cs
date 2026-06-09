using DiGi.Core.Classes;
using Rhino.Geometry;

namespace DiGi.Rhino.Core
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts a <see cref="Interval"/> to a nullable <see cref="Range{T}"/>.
        /// </summary>
        /// <param name="interval">The interval to convert.</param>
        /// <returns>A <see cref="Range{T}"/> of <see langword="double"/> representing the interval, or <see langword="null"/> if the interval is unset.</returns>
        public static Range<double>? ToDiGi(this Interval interval)
        {
            if (interval == Interval.Unset)
            {
                return null;
            }

            return new Range<double>(interval.T0, interval.T1);
        }
    }
}