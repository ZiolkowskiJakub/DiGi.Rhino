using System;
using Grasshopper.Kernel;
using Grasshopper;
using DiGi.Rhino.Core.Classes;
using DiGi.Geometry.Spatial.Interfaces;

namespace DiGi.Rhino.Geometry
{
    public static partial class Modify
    {
        public static void DrawViewportWires(this IGeometry3D geometry3D, GH_PreviewWireArgs gH_PreviewWireArgs, System.Drawing.Color color)
        {
            if(geometry3D == null || gH_PreviewWireArgs == null)
            {
                return;
            }

            if (geometry3D is DiGi.Geometry.Spatial.Classes.Point3D)
            {
                gH_PreviewWireArgs.Pipeline.DrawPoint(((DiGi.Geometry.Spatial.Classes.Point3D)geometry3D).ToRhino(), color);
            }

            if (geometry3D is DiGi.Geometry.Spatial.Classes.Segment3D)
            {
                gH_PreviewWireArgs.Pipeline.DrawCurve(((DiGi.Geometry.Spatial.Classes.Segment3D)geometry3D).ToRhino(), color);
            }


        }
    }
}
