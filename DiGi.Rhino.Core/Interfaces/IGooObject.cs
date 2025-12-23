using Grasshopper.Kernel.Types;

namespace DiGi.Rhino.Core.Interfaces
{
    public interface IGooObject : IGH_Goo
    {

    }

    public interface IGooObject<TObject> : IGooObject
    {
        TObject? Value { get; }

        XObject? GetValue<XObject>() where XObject : TObject;
    }
}
