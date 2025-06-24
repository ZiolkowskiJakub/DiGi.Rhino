using DiGi.Geometry.Spatial.Classes;
using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Geometry.Spatial.Classes;
using Grasshopper.Kernel.Types;
using System.Collections.Generic;

namespace DiGi.Rhino.Geometry.Spatial
{
    public static partial class Inspect
    {
        [Inspect("Points", "Points", "Points")]
        public static IEnumerable<GooPoint3D> Points(this Triangle3D triangle3D)
        {
            if (triangle3D == null)
            {
                return null;
            }

            return triangle3D.GetPoints()?.ConvertAll(x => new GooPoint3D(x));
        }

        [Inspect("Centroid", "Centroid", "Centroid")]
        public static GooPoint3D Centroid(this Triangle3D triangle3D)
        {
            if (triangle3D == null)
            {
                return null;
            }

            return new GooPoint3D(triangle3D.GetCentroid());
        }

        [Inspect("Area", "Area", "Area")]
        public static GH_Number Area(this Triangle3D triangle3D)
        {
            if (triangle3D == null)
            {
                return null;
            }

            return new GH_Number(triangle3D.GetArea());
        }

        [Inspect("Segments", "Segments", "Segments")]
        public static IEnumerable<GooSegment3D> Segments(this Triangle3D triangle3D)
        {
            if (triangle3D == null)
            {
                return null;
            }

            return triangle3D.GetSegments()?.ConvertAll(x => new GooSegment3D(x));
        }

        [Inspect("Length", "Length", "Length")]
        public static GH_Number Length(this Triangle3D triangle3D)
        {
            if (triangle3D == null)
            {
                return null;
            }

            return new GH_Number(triangle3D.Length);
        }

        [Inspect("Plane", "Plane", "Plane")]
        public static GooPlane Plane(this Triangle3D triangle3D)
        {
            if (triangle3D == null)
            {
                return null;
            }

            return new GooPlane(triangle3D.Plane);
        }
    }
}
