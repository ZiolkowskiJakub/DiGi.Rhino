using DiGi.Core.Interfaces;

namespace DiGi.Rhino.Core.Interfaces
{
    public interface IGooSerializableObject
    {
        T GetValue<T>() where T : ISerializableObject;
    }
}
