using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Geometry.Spatial.Classes;
using Grasshopper.Kernel.Types;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Rhino.Geometry.Spatial
{
    public static partial class Inspect
    {
        [Inspect("A", "A", "A")]
        public static GH_Number A(this DiGi.Geometry.Spatial.Classes.Ellipsoid ellipsoid)
        {
            if(ellipsoid == null)
            {
                return null;
            }

            return new GH_Number(ellipsoid.A);
        }

        [Inspect("B", "B", "B")]
        public static GH_Number B(this DiGi.Geometry.Spatial.Classes.Ellipsoid ellipsoid)
        {
            if (ellipsoid == null)
            {
                return null;
            }

            return new GH_Number(ellipsoid.B);
        }

        [Inspect("C", "C", "C")]
        public static GH_Number C(this DiGi.Geometry.Spatial.Classes.Ellipsoid ellipsoid)
        {
            if (ellipsoid == null)
            {
                return null;
            }

            return new GH_Number(ellipsoid.C);
        }

        [Inspect("Center", "Center", "Center")]
        public static GooPoint3D Center(this DiGi.Geometry.Spatial.Classes.Ellipsoid ellipsoid)
        {
            if (ellipsoid == null)
            {
                return null;
            }

            return new GooPoint3D(ellipsoid.Center);
        }

        [Inspect("DirectionA", "DirectionA", "Direction A")]
        public static GooVector3D DirectionA(this DiGi.Geometry.Spatial.Classes.Ellipsoid ellipsoid)
        {
            if (ellipsoid == null)
            {
                return null;
            }

            return new GooVector3D(ellipsoid.DirectionA);
        }

        [Inspect("DirectionB", "DirectionB", "Direction B")]
        public static GooVector3D DirectionB(this DiGi.Geometry.Spatial.Classes.Ellipsoid ellipsoid)
        {
            if (ellipsoid == null)
            {
                return null;
            }

            return new GooVector3D(ellipsoid.DirectionB);
        }

        [Inspect("DirectionC", "DirectionC", "Direction C")]
        public static GooVector3D DirectionC(this DiGi.Geometry.Spatial.Classes.Ellipsoid ellipsoid)
        {
            if (ellipsoid == null)
            {
                return null;
            }

            return new GooVector3D(ellipsoid.DirectionC);
        }

        [Inspect("FocalPoints", "FocalPoints", "Focal Points")]
        public static IEnumerable<GooPoint3D> FocalPoints(this DiGi.Geometry.Spatial.Classes.Ellipsoid ellipsoid)
        {
            if (ellipsoid == null)
            {
                return null;
            }


            return ellipsoid.GetFocalPoints()?.ToList().ConvertAll(x => new GooPoint3D(x));
        }
    }
}
