using DiGi.Core.Classes;
using Rhino.Geometry;

namespace DiGi.Rhino.Core
{
    public static partial class Convert
    {
        public static Range<double> ToDiGi(this Interval interval)
        {
            if(interval == Interval.Unset)
            {
                return null;
            }

            return new Range<double>(interval.T0, interval.T1);
        }
    }
}
