using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Geometry.Classes;
using Grasshopper.Kernel.Types;

namespace DiGi.Rhino.Geometry
{
    public static partial class Inspect
    {
        [Inspect("Inversed", "Inversed", "Inversed Vector2D")]
        public static GooVector2D Inversed(this DiGi.Geometry.Planar.Classes.Vector2D vector2D)
        {
            if (vector2D == null)
            {
                return null;
            }

            return new GooVector2D(vector2D.GetInversed());
        }

        [Inspect("Length", "Length", "Vector Length")]
        public static GH_Number Length(this DiGi.Geometry.Planar.Classes.Vector2D vector2D)
        {
            if (vector2D == null)
            {
                return null;
            }

            return new GH_Number(vector2D.Length);
        }

        [Inspect("Unit", "Unit", "Unit Vector2D")]
        public static GooVector2D Unit(this DiGi.Geometry.Planar.Classes.Vector2D vector2D)
        {
            if (vector2D == null)
            {
                return null;
            }

            return new GooVector2D(vector2D.Unit);
        }

        [Inspect("X", "X", "X Coordinate")]
        public static GH_Number X(this DiGi.Geometry.Planar.Classes.Vector2D vector2D)
        {
            if(vector2D == null)
            {
                return null;
            }

            return new GH_Number(vector2D.X);
        }

        [Inspect("Y", "Y", "Y Coordinate")]
        public static GH_Number Y(this DiGi.Geometry.Planar.Classes.Vector2D vector2D)
        {
            if (vector2D == null)
            {
                return null;
            }

            return new GH_Number(vector2D.Y);
        }
    }
}
