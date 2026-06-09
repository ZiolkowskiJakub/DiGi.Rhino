using DiGi.Core.Interfaces;
using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Core.Interfaces;
using System.Collections.Generic;

namespace DiGi.Rhino.Core
{
    public static partial class Query
    {
        /// <summary>
        /// Retrieves a value from an <see cref="IGooSerializableObject"/> based on the specified <see cref="GooParam"/>.
        /// </summary>
        /// <param name="gooSerializableObject">The serializable object to extract the value from.</param>
        /// <param name="gooParam">The parameter definition used to identify the value.</param>
        /// <returns>The extracted value if found; otherwise, <c>null</c>.</returns>
        public static object? Value(this IGooSerializableObject? gooSerializableObject, GooParam? gooParam)
        {
            if (gooParam == null || gooSerializableObject == null)
            {
                return null;
            }

            if (!TryGetValue(gooSerializableObject, out ISerializableObject? serializableObject) || serializableObject is null)
            {
                return null;
            }

            return Value(serializableObject, gooParam);
        }

        /// <summary>
        /// Retrieves a value from an object based on the specified <see cref="GooParam"/> by inspecting the object's type.
        /// </summary>
        /// <param name="object">The object to inspect.</param>
        /// <param name="gooParam">The parameter definition used to identify the value.</param>
        /// <returns>The extracted value if found; otherwise, <c>null</c>.</returns>
        public static object? Value(this object? @object, GooParam? gooParam)
        {
            if (gooParam == null || @object?.GetType() is not System.Type type)
            {
                return null;
            }

            List<InspectMethod>? inspectMethods = Settings.InspectManager.GetInspectMethods(type);
            if (inspectMethods == null)
            {
                return null;
            }

            foreach (InspectMethod inspectMethod in inspectMethods)
            {
                if (inspectMethod?.InspectAttribute?.Name == gooParam.Name)
                {
                    inspectMethod.TryGetValue(@object, out object? value);
                    return value;
                }
            }

            return null;
        }
    }
}