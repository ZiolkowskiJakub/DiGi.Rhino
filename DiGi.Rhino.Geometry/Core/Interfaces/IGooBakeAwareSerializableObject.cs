using DiGi.Geometry.Core.Interfaces;

namespace DiGi.Rhino.Geometry.Core.Interfaces
{
    public interface IGooBakeAwareSerializableObject : IGooBakeAware
    {
        IGeometry[] Geometries { get; }
    }
}
