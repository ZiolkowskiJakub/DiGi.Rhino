using DiGi.Core.Interfaces;
using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Core.Interfaces;
using System.Collections.Generic;

namespace DiGi.Rhino.Core
{
    public static partial class Create
    {
        public static List<GooParam>? GooParams(this IGooSerializableObject? gooSerializableObject)
        {
            if (!Query.TryGetValue(gooSerializableObject, out ISerializableObject? serializableObject) || serializableObject is null)
            {
                return null;
            }

            return GooParams(serializableObject);
        }

        public static List<GooParam>? GooParams(this object? @object)
        {
            if (@object?.GetType() is not System.Type type)
            {
                return null;
            }

            List<InspectMethod>? inspectMethods = Settings.InspectManager.GetInspectMethods(type);
            if (inspectMethods == null)
            {
                return null;
            }

            List<GooParam> result = [];
            foreach (InspectMethod inspectMethod in inspectMethods)
            {
                if (inspectMethod == null || !inspectMethod.IsValid(out bool enumerable))
                {
                    continue;
                }

                InspectAttribute? inspectAttribute = inspectMethod?.InspectAttribute;
                if (string.IsNullOrWhiteSpace(inspectAttribute?.Name))
                {
                    continue;
                }

                if (result.Find(x => x.Name == inspectAttribute.Name) != null)
                {
                    continue;
                }

                GooParam gooParam = new(inspectAttribute.Name, inspectAttribute.Nickname, inspectAttribute.Description, enumerable ? Grasshopper.Kernel.GH_ParamAccess.list : Grasshopper.Kernel.GH_ParamAccess.item);
                result.Add(gooParam);
            }

            return result;
        }
    }
}