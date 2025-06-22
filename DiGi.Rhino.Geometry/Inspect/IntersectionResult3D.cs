using DiGi.Geometry.Spatial.Interfaces;
using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Geometry.Classes;
using Grasshopper.Kernel.Types;
using System.Collections;
using System.Collections.Generic;

namespace DiGi.Rhino.Geometry
{
    public static partial class Inspect
    {
        [Inspect("Geometry3Ds", "Geometry3Ds", "Geometry3Ds")]
        public static IEnumerable Geometry3Ds(this IIntersectionResult3D intersectionResult3D)
        {
            List<IGeometry3D> geometry3Ds = intersectionResult3D?.GetGeometry3Ds<IGeometry3D>();
            if(geometry3Ds == null)
            {
                return null;
            }

            List<GooGeometry3D> result = new List<GooGeometry3D>();
            foreach(IGeometry3D geometry3D in geometry3Ds)
            {
                result.Add(new GooGeometry3D(geometry3D));
            }

            return result;
        }
    }
}
