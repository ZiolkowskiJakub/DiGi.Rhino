using DiGi.Core.Interfaces;

namespace DiGi.Rhino.Core.Interfaces
{
    public interface IGooSerializableObject : IGooObject
    {
    }

    public interface IGooSerializableObject<TSerializableObject> : IGooSerializableObject, IGooObject<TSerializableObject?> where TSerializableObject : ISerializableObject
    {
    }
}