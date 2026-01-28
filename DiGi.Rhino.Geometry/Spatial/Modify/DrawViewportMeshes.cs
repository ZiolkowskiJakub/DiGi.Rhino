using DiGi.Geometry.Core.Interfaces;
using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using Grasshopper.Kernel;
using System.Collections.Generic;

namespace DiGi.Rhino.Geometry.Spatial
{
    public static partial class Modify
    {
        public static void DrawViewportMeshes(this IGeometry? geometry, GH_PreviewMeshArgs? gH_PreviewMeshArgs, global::Rhino.Display.DisplayMaterial? displayMaterial = null)
        {
            if (geometry is IGeometry3D geometry3D)
            {
                DrawViewportMeshes(geometry3D, gH_PreviewMeshArgs, displayMaterial);
            }
        }

        public static void DrawViewportMeshes(this IGeometry3D? geometry3D, GH_PreviewMeshArgs? gH_PreviewMeshArgs, global::Rhino.Display.DisplayMaterial? displayMaterial = null)
        {
            if (geometry3D == null || gH_PreviewMeshArgs == null)
            {
                return;
            }

            displayMaterial ??= gH_PreviewMeshArgs.Material;

            if (geometry3D is PolygonalFace3D polygonalFace3D)
            {
                gH_PreviewMeshArgs.Pipeline.DrawBrepShaded(polygonalFace3D.ToRhino(), displayMaterial);
            }
            else if (geometry3D is Polyhedron polyhedron)
            {
                gH_PreviewMeshArgs.Pipeline.DrawBrepShaded(polyhedron.ToRhino(), displayMaterial);
            }
            else if (geometry3D is Mesh3D mesh3D)
            {
                gH_PreviewMeshArgs.Pipeline.DrawMeshShaded(mesh3D.ToRhino(), displayMaterial);
            }
            else if (geometry3D is Ellipsoid ellipsoid)
            {
                gH_PreviewMeshArgs.Pipeline.DrawBrepShaded(ellipsoid.ToRhino(), displayMaterial);
            }
        }

        public static void DrawViewportMeshes<TGeometry>(this IEnumerable<TGeometry>? geometries, GH_PreviewMeshArgs? gH_PreviewMeshArgs, global::Rhino.Display.DisplayMaterial? displayMaterial = null) where TGeometry : IGeometry
        {
            if (geometries == null || gH_PreviewMeshArgs == null)
            {
                return;
            }

            displayMaterial ??= gH_PreviewMeshArgs.Material;

            foreach (TGeometry geometry in geometries)
            {
                DrawViewportMeshes(geometry, gH_PreviewMeshArgs, displayMaterial);
            }
        }

        public static void DrawViewportMeshes(this IIntersectionResult3D? intersectionResult3D, GH_PreviewMeshArgs? gH_PreviewMeshArgs, global::Rhino.Display.DisplayMaterial? displayMaterial = null)
        {
            DrawViewportMeshes(intersectionResult3D?.GetGeometry3Ds<IGeometry3D>(), gH_PreviewMeshArgs, displayMaterial);
        }
    }
}