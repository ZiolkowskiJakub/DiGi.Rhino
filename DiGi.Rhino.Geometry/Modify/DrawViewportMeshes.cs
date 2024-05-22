using Grasshopper.Kernel;
using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using Rhino.Geometry;
using DiGi.Geometry.Core.Interfaces;

namespace DiGi.Rhino.Geometry
{
    public static partial class Modify
    {
        public static void DrawViewportMeshes(this IGeometry geometry, GH_PreviewMeshArgs gH_PreviewMeshArgs, global::Rhino.Display.DisplayMaterial displayMaterial = null)
        {
            if(geometry is IGeometry3D)
            {
                DrawViewportMeshes((IGeometry3D)geometry, gH_PreviewMeshArgs, displayMaterial);
            }
        }

        public static void DrawViewportMeshes(this IGeometry3D geometry3D, GH_PreviewMeshArgs gH_PreviewMeshArgs, global::Rhino.Display.DisplayMaterial displayMaterial = null)
        {
            if(geometry3D == null || gH_PreviewMeshArgs == null)
            {
                return;
            }

            if(displayMaterial == null)
            {
                displayMaterial = gH_PreviewMeshArgs.Material;
            }

            Brep brep = null;

            if (geometry3D is PolygonalFace3D)
            {
                brep = ((PolygonalFace3D)geometry3D).ToRhino();
            }
            else if (geometry3D is Polyhedron)
            {
                brep = ((Polyhedron)geometry3D).ToRhino();
            }

            if (brep == null)
            {
                return;
            }

            gH_PreviewMeshArgs.Pipeline.DrawBrepShaded(brep, displayMaterial);
        }
    }
}
