using DiGi.Geometry.Spatial.Classes;

namespace DiGi.Rhino.Geometry.Spatial
{
    public static partial class Convert
    {
        public static global::Rhino.Geometry.Line ToRhino_Line(this Segment3D segment3D)
        {
            return new global::Rhino.Geometry.Line(segment3D[0].ToRhino(), segment3D[1].ToRhino());
        }

        public static global::Rhino.Geometry.LineCurve ToRhino(this Segment3D segment3D)
        {
            return new global::Rhino.Geometry.LineCurve(segment3D[0].ToRhino(), segment3D[1].ToRhino());
        }
    }
}