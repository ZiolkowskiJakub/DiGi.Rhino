using DiGi.Core.Interfaces;

namespace DiGi.Rhino.Core.Interfaces
{
    public interface IGooSerializableObject : IGoo
    {
        T GetValue<T>() where T : ISerializableObject;
    }
}
