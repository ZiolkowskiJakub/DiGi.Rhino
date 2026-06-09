using Grasshopper.Kernel.Types;

namespace DiGi.Rhino.Core.Interfaces
{
    /// <summary>
    /// Defines the base interface for all Goo objects within the DiGi Rhino core, extending Grasshopper's <see cref="IGH_Goo"/>.
    /// </summary>
    public interface IGooObject : IGH_Goo
    {
    }

    /// <summary>
    /// Defines a generic Goo object that wraps a value of type <typeparamref name="TObject"/>.
    /// </summary>
    /// <typeparam name="TObject">The type of the underlying data wrapped by the Goo object.</typeparam>
    public interface IGooObject<TObject> : IGooObject
    {
        /// <summary>
        /// Gets the underlying value contained within the Goo object.
        /// </summary>
        TObject? Value { get; }

        /// <summary>
        /// Retrieves the underlying value cast to a specific type <typeparamref name="XObject"/>.
        /// </summary>
        /// <typeparam name="XObject">The target type to retrieve the value as, which must derive from <typeparamref name="TObject"/>.</typeparam>
        /// <returns>The value cast to <typeparamref name="XObject"/>, or null if the cast is not possible or the value is null.</returns>
        XObject? GetValue<XObject>() where XObject : TObject;
    }
}