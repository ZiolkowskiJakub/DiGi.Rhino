using DiGi.Core.Interfaces;
using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Core.Interfaces;
using System.Collections.Generic;

namespace DiGi.Rhino.Core
{
    public static partial class Query
    {
        public static object Value(this IGooSerializableObject gooSerializableObject, GooParam gooParam)
        {
            if(gooParam == null || gooSerializableObject == null)
            {
                return null;
            }

            List<InspectMethod> inspectMethods = Settings.InspectManager.GetInspectMethods(gooSerializableObject.GetValue<ISerializableObject>()?.GetType());
            if(inspectMethods == null)
            {
                return null;
            }

            foreach(InspectMethod inspectMethod in inspectMethods)
            {
                if(inspectMethod?.InspectAttribute?.Name == gooParam.Name)
                {
                    inspectMethod.TryGetValue(gooSerializableObject.GetValue<ISerializableObject>(), out object value);
                    return value;
                }
            }

            return null;
        }
    }
}
