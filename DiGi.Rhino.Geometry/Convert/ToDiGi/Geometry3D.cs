using DiGi.Geometry.Spatial.Interfaces;
using Grasshopper.Kernel.Types;

namespace DiGi.Rhino.Geometry
{
    public static partial class Convert
    {
        public static IGeometry3D ToDiGi(this IGH_GeometricGoo geometricGoo)
        {
            if (geometricGoo == null)
            {
                return null;
            }

            object @object = null;
            try
            {
                @object = (geometricGoo as dynamic).Value;
            }
            catch
            {
                return null;
            }

            if(@object == null)
            {
                return null;
            }

            if (@object is global::Rhino.Geometry.Point3d) 
            {
                return ToDiGi((global::Rhino.Geometry.Point3d)@object);
            }

            if (@object is global::Rhino.Geometry.LineCurve)
            {
                return ToDiGi((global::Rhino.Geometry.LineCurve)@object);
            }

            if (@object is global::Rhino.Geometry.Line)
            {
                return ToDiGi((global::Rhino.Geometry.Line)@object);
            }

            return null;
        }
    }
}
