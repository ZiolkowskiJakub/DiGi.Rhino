using Grasshopper.Kernel;
using Rhino.DocObjects;
using Rhino;
using System;
using System.Collections.Generic;

namespace DiGi.Rhino.Geometry.Core.Interfaces
{
    public interface IGooBakeAwareParam : IGH_PreviewObject, IGH_BakeAwareObject
    {
        void BakeGeometry(RhinoDoc rhinoDoc, ObjectAttributes objectAttributes, List<Guid> guids);
    }
}
