using DiGi.Rhino.Core.Classes;
using Grasshopper.Kernel.Types;
using System.Collections;
using System.Linq;

namespace DiGi.Rhino.Geometry.Spatial
{
    public static partial class Inspect
    {

        [Inspect("DateTimes", "DateTimes", "DateTimes")]
        public static IEnumerable DateTimes(this DiGi.Core.Interfaces.ITimeSeries timeSeries)
        {
            if(timeSeries == null)
            {
                return null;
            }

            return timeSeries.GetDateTimes()?.ToList().ConvertAll(x => new GH_Time(x));
        }
    }
}
