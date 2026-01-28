using Grasshopper.Kernel;
using Rhino;
using Rhino.DocObjects;
using System;
using System.Collections.Generic;

namespace DiGi.Rhino.Geometry.Core.Interfaces
{
    public interface IGooBakeAware : IGH_PreviewData, IGH_BakeAwareData
    {
        bool BakeGeometry(RhinoDoc? rhinoDoc, ObjectAttributes? objectAttributes, out List<Guid>? guids);
    }
}