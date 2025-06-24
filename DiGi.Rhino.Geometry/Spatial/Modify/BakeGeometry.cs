using DiGi.Geometry.Core.Interfaces;
using DiGi.Geometry.Planar.Classes;
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
        public static bool BakeGeometry(this IGeometry geometry, RhinoDoc rhinoDoc, ObjectAttributes objectAttributes, out List<Guid> guids)
        {
            guids = null;

            if (geometry == null || rhinoDoc == null || objectAttributes == null)
            {
                return false;
            }

            if(geometry is IGeometry2D)
            {
                return BakeGeometry((IGeometry2D)geometry, rhinoDoc, objectAttributes, out guids);
            }
            else
            {
                return BakeGeometry((IGeometry3D)geometry, rhinoDoc, objectAttributes, out guids);
            }
        }

        public static bool BakeGeometry(this IGeometry2D geometry2D, RhinoDoc rhinoDoc, ObjectAttributes objectAttributes, out List<Guid> guids)
        {
            guids = null;

            if (geometry2D == null || rhinoDoc == null || objectAttributes == null)
            {
                return false;
            }

            IGeometry3D geometry3D = DiGi.Geometry.Spatial.Query.Convert(DiGi.Geometry.Spatial.Constans.Plane.WorldZ, geometry2D);
            if(geometry3D == null)
            {
                return false;
            }

            return BakeGeometry(geometry3D, rhinoDoc, objectAttributes, out guids);
        }

        public static bool BakeGeometry(this IGeometry3D geometry3D, RhinoDoc rhinoDoc, ObjectAttributes objectAttributes, out List<Guid> guids)
        {
            guids = null;

            if(geometry3D == null || rhinoDoc == null || objectAttributes == null)
            {
                return false;
            }

            guids = new List<Guid>();

            if (geometry3D is Point3D)
            {
                Guid guid = rhinoDoc.Objects.AddPoint(((Point3D)geometry3D).ToRhino(), objectAttributes, null, false);
                guids.Add(guid);
                return true;
            }

            if (geometry3D is Segment3D)
            {
                Segment3D segment3D = (Segment3D)geometry3D;

                Guid guid = rhinoDoc.Objects.AddLine(segment3D[0].ToRhino(), segment3D[1].ToRhino(), objectAttributes, null, false);
                guids.Add(guid);
                return true;
            }

            if (geometry3D is IPolygonal3D)
            {
                Guid guid = rhinoDoc.Objects.AddCurve(Convert.ToRhino((IPolygonal3D)geometry3D), objectAttributes);
                guids.Add(guid);
                return true;
            }

            if (geometry3D is Mesh3D)
            {
                Guid guid = rhinoDoc.Objects.AddMesh(Convert.ToRhino((Mesh3D)geometry3D), objectAttributes);
                guids.Add(guid);
                return true;
            }

            if (geometry3D is IPolygonalFace3D)
            {
                Guid guid = rhinoDoc.Objects.AddBrep(Convert.ToRhino((IPolygonalFace3D)geometry3D), objectAttributes);
                guids.Add(guid);
                return true;
            }

            if (geometry3D is Polyhedron)
            {
                Guid guid = rhinoDoc.Objects.AddBrep(Convert.ToRhino((Polyhedron)geometry3D), objectAttributes);
                guids.Add(guid);
                return true;
            }

            if (geometry3D is BoundingBox3D)
            {
                Guid guid = rhinoDoc.Objects.AddBox(Convert.ToRhino_Box((BoundingBox3D)geometry3D), objectAttributes);
                guids.Add(guid);
                return true;
            }

            return false;
        }

        public static bool BakeGeometry<TGeometry>(this IEnumerable<TGeometry> geometries, RhinoDoc rhinoDoc, ObjectAttributes objectAttributes, out List<Guid> guids) where TGeometry : IGeometry
        {
            guids = null;

            if (geometries == null || rhinoDoc == null || objectAttributes == null)
            {
                return false;
            }

            guids = new List<Guid>();
            foreach (IGeometry3D geometry3D in geometries)
            {
                if (!BakeGeometry(geometry3D, rhinoDoc, objectAttributes, out List<Guid> guids_Temp) || guids_Temp == null || guids_Temp.Count == 0)
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

        public static bool BakeGeometry(this IIntersectionResult3D intersectionResult3D, RhinoDoc rhinoDoc, ObjectAttributes objectAttributes, out List<Guid> guids)
        {
            return BakeGeometry(intersectionResult3D?.GetGeometry3Ds<IGeometry3D>(), rhinoDoc, objectAttributes, out guids);
        }
    }
}
