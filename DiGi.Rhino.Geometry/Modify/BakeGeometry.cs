using System;
using DiGi.Geometry.Spatial.Interfaces;
using Rhino.DocObjects;
using Rhino;
using System.Collections.Generic;
using DiGi.Geometry.Spatial.Classes;

namespace DiGi.Rhino.Geometry
{
    public static partial class Modify
    {
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

            return false;
        }
    }
}
