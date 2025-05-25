using DiGi.Geometry.Spatial.Classes;
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
        public static GH_Number A(this Ellipse3D ellipse3D)
        {
            if(ellipse3D == null)
            {
                return null;
            }

            return new GH_Number(ellipse3D.A);
        }

        [Inspect("B", "B", "B")]
        public static GH_Number B(this Ellipse3D ellipse3D)
        {
            if (ellipse3D == null)
            {
                return null;
            }

            return new GH_Number(ellipse3D.B);
        }

        [Inspect("Center", "Center", "Center")]
        public static GooPoint3D Center(this Ellipse3D ellipse3D)
        {
            if (ellipse3D == null)
            {
                return null;
            }

            return new GooPoint3D(ellipse3D.Center);
        }

        [Inspect("FocalPoints", "FocalPoints", "Focal Points")]
        public static IEnumerable<GooPoint3D> FocalPoints(this Ellipse3D ellipse3D)
        {
            if (ellipse3D == null)
            {
                return null;
            }


            return ellipse3D.GetFocalPoints()?.ToList().ConvertAll(x => new GooPoint3D(x));
        }

    }
}
