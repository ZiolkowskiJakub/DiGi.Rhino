using DiGi.Geometry.Core.Interfaces;
using DiGi.Geometry.Planar.Interfaces;
using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using Grasshopper.Kernel;
using System.Collections.Generic;

namespace DiGi.Rhino.Geometry.Spatial
{
    public static partial class Modify
    {
        public static void DrawViewportWires(this IGeometry geometry, GH_PreviewWireArgs gH_PreviewWireArgs, System.Drawing.Color color)
        {
            if(geometry is IGeometry3D)
            {
                DrawViewportWires((IGeometry3D)geometry, gH_PreviewWireArgs, color);
            }
            else if(geometry is IGeometry2D)
            {
                DrawViewportWires((IGeometry2D)geometry, gH_PreviewWireArgs, color);
            }
        }

        public static void DrawViewportWires(this IGeometry3D geometry3D, GH_PreviewWireArgs gH_PreviewWireArgs, System.Drawing.Color color)
        {
            if(geometry3D == null || gH_PreviewWireArgs == null)
            {
                return;
            }

            if (geometry3D is Point3D)
            {
                gH_PreviewWireArgs.Pipeline.DrawPoint(((Point3D)geometry3D).ToRhino(), color);
            }

            if (geometry3D is Segment3D)
            {
                gH_PreviewWireArgs.Pipeline.DrawCurve(((Segment3D)geometry3D).ToRhino(), color);
            }

            if (geometry3D is Ellipse3D)
            {
                gH_PreviewWireArgs.Pipeline.DrawCurve(((Ellipse3D)geometry3D).ToRhino()?.ToNurbsCurve(), color);
            }

            if (geometry3D is IPolygonal3D)
            {
                gH_PreviewWireArgs.Pipeline.DrawCurve(((IPolygonal3D)geometry3D).ToRhino(), color);
            }

            if (geometry3D is Polyline3D)
            {
                gH_PreviewWireArgs.Pipeline.DrawCurve(((Polyline3D)geometry3D).ToRhino(), color);
            }

            if (geometry3D is PolygonalFace3D)
            {
                gH_PreviewWireArgs.Pipeline.DrawBrepWires(((PolygonalFace3D)geometry3D).ToRhino(), color);
            }

            if (geometry3D is Polyhedron)
            {
                gH_PreviewWireArgs.Pipeline.DrawBrepWires(((Polyhedron)geometry3D).ToRhino(), color);
            }

            if (geometry3D is BoundingBox3D)
            {
                gH_PreviewWireArgs.Pipeline.DrawBox(((BoundingBox3D)geometry3D).ToRhino(), color);
            }
        }

        public static void DrawViewportWires(this IGeometry2D geometry2D, GH_PreviewWireArgs gH_PreviewWireArgs, System.Drawing.Color color)
        {
            if(geometry2D == null || gH_PreviewWireArgs == null)
            {
                return;
            }

            IGeometry3D geometry3D = DiGi.Geometry.Spatial.Query.Convert(DiGi.Geometry.Spatial.Constans.Plane.WorldZ, geometry2D);
            if (geometry3D == null)
            {
                return;
            }

            DrawViewportWires(geometry3D, gH_PreviewWireArgs, color);
        }
        
        public static void DrawViewportWires<TGeometry>(this IEnumerable<TGeometry> geometries, GH_PreviewWireArgs gH_PreviewWireArgs, System.Drawing.Color color) where TGeometry : IGeometry
        {
            if (geometries == null || gH_PreviewWireArgs == null)
            {
                return;
            }

            foreach (TGeometry geometry in geometries)
            {
                DrawViewportWires(geometry, gH_PreviewWireArgs, color);
            }
        }

        public static void DrawViewportWires(this IIntersectionResult3D intersectionResult3D, GH_PreviewWireArgs gH_PreviewWireArgs, System.Drawing.Color color)
        {
            DrawViewportWires(intersectionResult3D?.GetGeometry3Ds<IGeometry3D>(), gH_PreviewWireArgs, color);
        }
    }
}
