using Grasshopper.Kernel;

namespace DiGi.Rhino.Geometry.Core.Interfaces
{
    /// <summary>
    /// Defines an interface for objects that are both previewable and bake-aware within the Grasshopper environment.
    /// </summary>
    public interface IGooBakeAwareParam : IGH_PreviewObject, IGH_BakeAwareObject
    {
    }
}