using DiGi.Core.Interfaces;

namespace DiGi.Rhino.Core.Interfaces
{
    /// <summary>
    /// Defines a contract for an object that is both a Goo object and serializable.
    /// </summary>
    public interface IGooSerializableObject : IGooObject
    {
    }

    /// <summary>
    /// Defines a generic contract for an object that is both a Goo object and serializable, associated with a specific serializable object type.
    /// </summary>
    /// <typeparam name="TSerializableObject">The type of the serializable object. Must implement <see cref="ISerializableObject"/>.</typeparam>
    public interface IGooSerializableObject<TSerializableObject> : IGooSerializableObject, IGooObject<TSerializableObject?> where TSerializableObject : ISerializableObject
    {
    }
}