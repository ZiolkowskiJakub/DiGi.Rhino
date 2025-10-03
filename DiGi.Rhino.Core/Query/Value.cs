using DiGi.Core.Interfaces;
using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Core.Interfaces;
using System.Collections.Generic;

namespace DiGi.Rhino.Core
{
    public static partial class Query
    {
        public static object? Value(this IGooSerializableObject? gooSerializableObject, GooParam? gooParam)
        {
            if(gooParam == null || gooSerializableObject == null)
            {
                return null;
            }

            if (!TryGetValue(gooSerializableObject, out ISerializableObject? serializableObject) || serializableObject is null)
            {
                return null;
            }

            return Value(serializableObject, gooParam);
        }

        public static object? Value(this ISerializableObject? serializableObject, GooParam? gooParam)
        {
            if (gooParam == null || serializableObject?.GetType() is not System.Type type)
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
                    inspectMethod.TryGetValue(serializableObject, out object? value);
                    return value;
                }
            }

            return null;
        }
    }
}
