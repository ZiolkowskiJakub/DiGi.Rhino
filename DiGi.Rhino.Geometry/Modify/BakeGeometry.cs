using System;
using Rhino.DocObjects;
using Rhino;
using System.Collections.Generic;
using DiGi.Geometry.Spatial.Interfaces;
using DiGi.Geometry.Planar.Interfaces;
using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Core.Interfaces;

namespace DiGi.Rhino.Geometry
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

            return false;
        }
    }
}
