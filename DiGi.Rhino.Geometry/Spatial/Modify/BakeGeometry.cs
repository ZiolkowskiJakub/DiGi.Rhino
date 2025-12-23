using DiGi.Geometry.Core.Interfaces;
using DiGi.Geometry.Planar.Interfaces;
using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using Rhino;
using Rhino.DocObjects;
using System;
using System.Collections.Generic;

namespace DiGi.Rhino.Geometry.Spatial
{
    public static partial class Modify
    {
        public static bool BakeGeometry(this IGeometry? geometry, RhinoDoc? rhinoDoc, ObjectAttributes? objectAttributes, out List<Guid>? guids)
        {
            guids = null;

            if (geometry == null || rhinoDoc == null || objectAttributes == null)
            {
                return false;
            }

            if (geometry is IGeometry2D geometry2D)
            {
                return BakeGeometry(geometry2D, rhinoDoc, objectAttributes, out guids);
            }
            else if (geometry is IGeometry3D geometry3D)
            {
                return BakeGeometry(geometry3D, rhinoDoc, objectAttributes, out guids);
            }

            return false;
        }

        public static bool BakeGeometry(this IGeometry2D? geometry2D, RhinoDoc? rhinoDoc, ObjectAttributes? objectAttributes, out List<Guid>? guids)
        {
            guids = null;

            if (geometry2D == null || rhinoDoc == null || objectAttributes == null)
            {
                return false;
            }

            IGeometry3D? geometry3D = DiGi.Geometry.Spatial.Query.Convert(DiGi.Geometry.Spatial.Constans.Plane.WorldZ, geometry2D);
            if (geometry3D == null)
            {
                return false;
            }

            return BakeGeometry(geometry3D, rhinoDoc, objectAttributes, out guids);
        }

        public static bool BakeGeometry(this IGeometry3D? geometry3D, RhinoDoc? rhinoDoc, ObjectAttributes? objectAttributes, out List<Guid>? guids)
        {
            guids = null;

            if (geometry3D == null || rhinoDoc == null || objectAttributes == null)
            {
                return false;
            }

            guids = [];

            if (geometry3D is Point3D point3D)
            {
                Guid guid = rhinoDoc.Objects.AddPoint(point3D.ToRhino(), objectAttributes, null, false);
                guids.Add(guid);
                return true;
            }

            if (geometry3D is Segment3D segment3D && segment3D[0] is Point3D point3D_1 && segment3D[1] is Point3D point3D_2)
            {
                Guid guid = rhinoDoc.Objects.AddLine(point3D_1.ToRhino(), point3D_2.ToRhino(), objectAttributes, null, false);
                guids.Add(guid);
                return true;
            }

            if (geometry3D is IPolygonal3D polygonal3D)
            {
                Guid guid = rhinoDoc.Objects.AddCurve(Convert.ToRhino(polygonal3D), objectAttributes);
                guids.Add(guid);
                return true;
            }

            if (geometry3D is Mesh3D mesh3D)
            {
                Guid guid = rhinoDoc.Objects.AddMesh(Convert.ToRhino(mesh3D), objectAttributes);
                guids.Add(guid);
                return true;
            }

            if (geometry3D is IPolygonalFace3D polygonalFace3D)
            {
                Guid guid = rhinoDoc.Objects.AddBrep(Convert.ToRhino(polygonalFace3D), objectAttributes);
                guids.Add(guid);
                return true;
            }

            if (geometry3D is Polyhedron polyhedron)
            {
                Guid guid = rhinoDoc.Objects.AddBrep(Convert.ToRhino(polyhedron), objectAttributes);
                guids.Add(guid);
                return true;
            }

            if (geometry3D is Ellipsoid ellipsoid)
            {
                Guid guid = rhinoDoc.Objects.AddBrep(Convert.ToRhino(ellipsoid), objectAttributes);
                guids.Add(guid);
                return true;
            }

            if (geometry3D is BoundingBox3D boundingBox3D)
            {
                Guid guid = rhinoDoc.Objects.AddBox(Convert.ToRhino_Box(boundingBox3D), objectAttributes);
                guids.Add(guid);
                return true;
            }

            if (geometry3D is Polyline3D polyline3D)
            {
                Guid guid = rhinoDoc.Objects.AddCurve(Convert.ToRhino(polyline3D), objectAttributes);
                guids.Add(guid);
                return true;
            }

            return false;
        }

        public static bool BakeGeometry<TGeometry>(this IEnumerable<TGeometry>? geometries, RhinoDoc? rhinoDoc, ObjectAttributes? objectAttributes, out List<Guid>? guids) where TGeometry : IGeometry
        {
            guids = null;

            if (geometries == null || rhinoDoc == null || objectAttributes == null)
            {
                return false;
            }

            guids = [];
            foreach (IGeometry geometry in geometries)
            {
                if (!BakeGeometry(geometry, rhinoDoc, objectAttributes, out List<Guid>? guids_Temp) || guids_Temp == null || guids_Temp.Count == 0)
                {
                    continue;
                }

                foreach (Guid guid_Temp in guids_Temp)
                {
                    guids.Add(guid_Temp);
                }
            }

            return guids != null && guids.Count > 0;
        }

        public static bool BakeGeometry(this IIntersectionResult3D? intersectionResult3D, RhinoDoc? rhinoDoc, ObjectAttributes? objectAttributes, out List<Guid>? guids)
        {
            return BakeGeometry(intersectionResult3D?.GetGeometry3Ds<IGeometry3D>(), rhinoDoc, objectAttributes, out guids);
        }
    }
}
