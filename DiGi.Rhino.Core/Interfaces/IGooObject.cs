namespace DiGi.Rhino.Core.Interfaces
{
    public interface IGooObject
    {

    }

    public interface IGooObject<TObject> : IGooObject
    {
        XObject? GetValue<XObject>() where XObject : TObject;
    }
}
