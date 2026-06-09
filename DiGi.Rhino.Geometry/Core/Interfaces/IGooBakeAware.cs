using Grasshopper.Kernel;
using Rhino;
using Rhino.DocObjects;
using System;
using System.Collections.Generic;

namespace DiGi.Rhino.Geometry.Core.Interfaces
{
    /// <summary>
    /// Defines a contract for objects that can be baked into the Rhino document and are aware of the baking process.
    /// </summary>
    public interface IGooBakeAware : IGH_PreviewData, IGH_BakeAwareData
    {
        /// <summary>
        /// Bakes the geometry associated with this object into the specified Rhino document.
        /// </summary>
        /// <param name="rhinoDoc">The target <see cref="RhinoDoc"/> where the geometry should be baked.</param>
        /// <param name="objectAttributes">The <see cref="ObjectAttributes"/> to apply to the baked objects.</param>
        /// <param name="guids">When this method returns, contains a list of unique identifiers for the objects created in the Rhino document.</param>
        /// <returns><c>true</c> if the geometry was successfully baked; otherwise, <c>false</c>.</returns>
        bool BakeGeometry(RhinoDoc? rhinoDoc, ObjectAttributes? objectAttributes, out List<Guid>? guids);
    }
}