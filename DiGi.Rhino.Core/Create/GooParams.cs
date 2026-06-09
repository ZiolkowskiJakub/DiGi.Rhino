using DiGi.Core.Interfaces;
using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Core.Interfaces;
using System.Collections.Generic;

namespace DiGi.Rhino.Core
{
    public static partial class Create
    {
        /// <summary>
        /// Retrieves the list of goo parameters associated with the specified serializable object.
        /// </summary>
        /// <param name="gooSerializableObject">The serializable object to extract parameters from.</param>
        /// <returns>A list of <see cref="GooParam"/> objects if found; otherwise, <c>null</c>.</returns>
        public static List<GooParam>? GooParams(this IGooSerializableObject? gooSerializableObject)
        {
            if (!Query.TryGetValue(gooSerializableObject, out ISerializableObject? serializableObject) || serializableObject is null)
            {
                return null;
            }

            return GooParams(serializableObject);
        }

        /// <summary>
        /// Retrieves the list of goo parameters associated with the specified object based on its type and inspection settings.
        /// </summary>
        /// <param name="object">The object to inspect for parameters.</param>
        /// <returns>A list of <see cref="GooParam"/> objects if found; otherwise, <c>null</c>.</returns>
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