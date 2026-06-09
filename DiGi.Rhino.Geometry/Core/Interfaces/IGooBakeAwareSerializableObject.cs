using DiGi.Geometry.Core.Interfaces;

namespace DiGi.Rhino.Geometry.Core.Interfaces
{
    /// <summary>
    /// Defines a serializable object that is aware of the baking process and can provide its associated geometry representations.
    /// </summary>
    public interface IGooBakeAwareSerializableObject : IGooBakeAware
    {
        /// <summary>
        /// Gets the collection of geometries associated with this serializable object.
        /// </summary>
        /// <value>An array of <see cref="IGeometry"/> objects, or <c>null</c> if no geometries are available.</value>
        IGeometry[]? Geometries { get; }
    }
}