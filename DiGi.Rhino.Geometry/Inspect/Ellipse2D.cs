using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Geometry.Classes;
using Grasshopper.Kernel.Types;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Rhino.Geometry
{
    public static partial class Inspect
    {
        [Inspect("A", "A", "A")]
        public static GH_Number A(this DiGi.Geometry.Planar.Classes.Ellipse2D ellipse2D)
        {
            if(ellipse2D == null)
            {
                return null;
            }

            return new GH_Number(ellipse2D.A);
        }

        [Inspect("B", "B", "B")]
        public static GH_Number B(this DiGi.Geometry.Planar.Classes.Ellipse2D ellipse2D)
        {
            if (ellipse2D == null)
            {
                return null;
            }

            return new GH_Number(ellipse2D.B);
        }

        [Inspect("Center", "Center", "Center")]
        public static GooPoint2D Centroid(this DiGi.Geometry.Planar.Classes.Ellipse2D ellipse2D)
        {
            if (ellipse2D == null)
            {
                return null;
            }

            return new GooPoint2D(ellipse2D.Center);
        }

        [Inspect("FocalPoints", "FocalPoints", "Focal Points")]
        public static IEnumerable<GooPoint2D> FocalPoints(this DiGi.Geometry.Planar.Classes.Ellipse2D ellipse2D)
        {
            if (ellipse2D == null)
            {
                return null;
            }


            return ellipse2D.GetFocalPoints()?.ToList().ConvertAll(x => new GooPoint2D(x));
        }

    }
}
