using DiGi.Rhino.Core.Classes;
using Grasshopper.Kernel.Types;
using System.Collections;
using System.Linq;

namespace DiGi.Rhino.Core
{
    public static partial class Inspect
    {
        /// <summary>
        /// Extracts the date-times from a time series and converts them into a collection of Grasshopper GH_Time objects.
        /// </summary>
        /// <param name="timeSeries">The time series instance to inspect.</param>
        /// <returns>An enumerable collection of <see cref="GH_Time"/> objects if the time series is provided; otherwise, null.</returns>
        [Inspect("DateTimes", "DateTimes", "DateTimes")]
        public static IEnumerable? DateTimes(this DiGi.Core.Interfaces.ITimeSeries? timeSeries)
        {
            if (timeSeries == null)
            {
                return null;
            }

            return timeSeries.GetDateTimes()?.ToList().ConvertAll(x => new GH_Time(x));
        }
    }
}