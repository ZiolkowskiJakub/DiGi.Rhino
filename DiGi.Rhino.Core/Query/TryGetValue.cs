using DiGi.Core.Interfaces;
using DiGi.Rhino.Core.Interfaces;
using Grasshopper.Kernel.Types;
using System.Reflection;

namespace DiGi.Rhino.Core
{
    public static partial class Query
    {
        /// <summary>
        /// Attempts to retrieve the value of a serializable object from an <see cref="IGooSerializableObject"/> wrapper, cast to a specific type.
        /// </summary>
        /// <typeparam name="TSerializableObject">The expected type of the serializable object. Must implement <see cref="ISerializableObject"/>.</typeparam>
        /// <param name="gooSerializableObject">The serializable object wrapper to extract the value from.</param>
        /// <param name="serializableObject">When this method returns, contains the extracted serializable object if successful; otherwise, the default value of <typeparamref name="TSerializableObject"/>.</param>
        /// <returns><c>true</c> if the value was successfully extracted and is of type <typeparamref name="TSerializableObject"/>; otherwise, <c>false</c>.</returns>
        public static bool TryGetValue<TSerializableObject>(this IGooSerializableObject? gooSerializableObject, out TSerializableObject? serializableObject) where TSerializableObject : ISerializableObject
        {
            serializableObject = default;

            if (!TryGetValue(gooSerializableObject, out object? @object) || @object is null)
            {
                return false;
            }

            if (@object is not TSerializableObject)
            {
                return false;
            }

            serializableObject = (TSerializableObject)@object;
            return true;
        }

        /// <summary>
        /// Attempts to retrieve the value from an <see cref="IGH_Goo"/> object by accessing its "Value" property via reflection.
        /// </summary>
        /// <param name="gH_Goo">The Grasshopper Goo object to extract the value from.</param>
        /// <param name="value">When this method returns, contains the extracted value if successful; otherwise, <c>null</c>.</param>
        /// <returns><c>true</c> if the "Value" property was found and successfully read; otherwise, <c>false</c>.</returns>
        public static bool TryGetValue(this IGH_Goo? gH_Goo, out object? value)
        {
            value = null;

            if (gH_Goo?.GetType() is not System.Type type)
            {
                return false;
            }

            PropertyInfo? propertyInfo = type.GetProperty("Value", BindingFlags.Public | BindingFlags.Instance);
            if (propertyInfo is null || !propertyInfo.CanRead)
            {
                return false;
            }

            value = propertyInfo.GetValue(gH_Goo);
            return true;
        }

        /// <summary>
        /// Attempts to retrieve a value of a specific type from an object, handling both standard objects and those wrapped in <see cref="IGH_Goo"/>.
        /// </summary>
        /// <typeparam name="TObject">The expected type of the resulting value.</typeparam>
        /// <param name="object">The object to evaluate.</param>
        /// <param name="value">When this method returns, contains the extracted value cast to <typeparamref name="TObject"/> if successful; otherwise, the default value of <typeparamref name="TObject"/>.</param>
        /// <returns><c>true</c> if the object (or its wrapped value) is of type <typeparamref name="TObject"/>; otherwise, <c>false</c>.</returns>
        public static bool TryGetValue<TObject>(this object? @object, out TObject? value)
        {
            value = default;
            if (@object is null)
            {
                return false;
            }

            if (@object is IGH_Goo gH_Goo)
            {
                if (TryGetValue(gH_Goo, out object? object_Temp) && object_Temp is TObject t)
                {
                    value = t;
                    return true;
                }
            }
            else if (@object is TObject t)
            {
                value = t;
                return true;
            }

            return false;
        }
    }
}