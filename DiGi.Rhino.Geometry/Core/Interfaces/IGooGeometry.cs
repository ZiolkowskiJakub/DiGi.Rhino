using Grasshopper.Kernel;
using Rhino.DocObjects;
using Rhino;
using System;
using System.Collections.Generic;

namespace DiGi.Rhino.Geometry.Core.Interfaces
{
    public interface IGooGeometry : IGH_PreviewData, IGH_BakeAwareData
    {
        bool BakeGeometry(RhinoDoc rhinoDoc, ObjectAttributes objectAttributes, out List<Guid> guids);
    }
}
