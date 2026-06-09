using DiGi.Geometry.Core.Interfaces;
using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using Grasshopper.Kernel;
using System.Collections.Generic;

namespace DiGi.Rhino.Geometry.Spatial
{
    public static partial class Modify
    {
        /// <summary>
        /// Draws the viewport meshes for a given geometry using the provided preview arguments and material.
        /// </summary>
        /// <param name="geometry">The geometry to draw.</param>
        /// <param name="gH_PreviewMeshArgs">The Grasshopper preview mesh arguments containing pipeline information.</param>
        /// <param name="displayMaterial">Optional display material to use; defaults to the one provided in <paramref name="gH_PreviewMeshArgs"/>.</param>
        public static void DrawViewportMeshes(this IGeometry? geometry, GH_PreviewMeshArgs? gH_PreviewMeshArgs, global::Rhino.Display.DisplayMaterial? displayMaterial = null)
        {
            if (geometry is IGeometry3D geometry3D)
            {
                DrawViewportMeshes(geometry3D, gH_PreviewMeshArgs, displayMaterial);
            }
        }

        /// <summary>
        /// Draws the viewport meshes for a given 3D geometry using the provided preview arguments and material.
        /// </summary>
        /// <param name="geometry3D">The 3D geometry to draw.</param>
        /// <param name="gH_PreviewMeshArgs">The Grasshopper preview mesh arguments containing pipeline information.</param>
        /// <param name="displayMaterial">Optional display material to use; defaults to the one provided in <paramref name="gH_PreviewMeshArgs"/>.</param>
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

        /// <summary>
        /// Draws the viewport meshes for a collection of geometries using the provided preview arguments and material.
        /// </summary>
        /// <typeparam name="TGeometry">The type of geometry, which must implement <see cref="IGeometry"/>.</typeparam>
        /// <param name="geometries">An enumerable collection of geometries to draw.</param>
        /// <param name="gH_PreviewMeshArgs">The Grasshopper preview mesh arguments containing pipeline information.</param>
        /// <param name="displayMaterial">Optional display material to use; defaults to the one provided in <paramref name="gH_PreviewMeshArgs"/>.</param>
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

        /// <summary>
        /// Draws the viewport meshes for the results of a 3D intersection using the provided preview arguments and material.
        /// </summary>
        /// <param name="intersectionResult3D">The result of a 3D intersection operation.</param>
        /// <param name="gH_PreviewMeshArgs">The Grasshopper preview mesh arguments containing pipeline information.</param>
        /// <param name="displayMaterial">Optional display material to use; defaults to the one provided in <paramref name="gH_PreviewMeshArgs"/>.</param>
        public static void DrawViewportMeshes(this IIntersectionResult3D? intersectionResult3D, GH_PreviewMeshArgs? gH_PreviewMeshArgs, global::Rhino.Display.DisplayMaterial? displayMaterial = null)
        {
            DrawViewportMeshes(intersectionResult3D?.GetGeometry3Ds<IGeometry3D>(), gH_PreviewMeshArgs, displayMaterial);
        }
    }
}