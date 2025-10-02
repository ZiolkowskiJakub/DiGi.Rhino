using DiGi.Core.Classes;
using DiGi.Core.Interfaces;

namespace DiGi.Rhino.Core.Interfaces
{
    public interface IGooSerializableObject<TSerializableObject> : IGooObject<TSerializableObject> where TSerializableObject : ISerializableObject
    {
    }

    public interface IGooSerializableObject : IGooSerializableObject<ISerializableObject>
    {

    }
}
