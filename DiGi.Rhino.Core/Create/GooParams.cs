using DiGi.Core.Interfaces;
using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Core.Interfaces;
using System.Collections.Generic;

namespace DiGi.Rhino.Core
{
    public static partial class Create
    {
        public static HashSet<GooParam> GooParams(this IGooSerializableObject gooSerializableObject)
        {
            if(gooSerializableObject == null)
            {
                return null;
            }

            List<InspectMethod> inspectMethods = Settings.InspectManager.GetInspectMethods(gooSerializableObject.GetValue<ISerializableObject>()?.GetType());
            if(inspectMethods == null)
            {
                return null;
            }

            HashSet<GooParam> result = new HashSet<GooParam>();
            foreach (InspectMethod inspectMethod in inspectMethods)
            {
                if(inspectMethod == null || !inspectMethod.IsValid(out bool enumerable))
                {
                    continue;
                }

                InspectAttribute inspectAttribute = inspectMethod?.InspectAttribute;
                if (inspectAttribute == null)
                {
                    continue;
                }

                GooParam gooParam = new GooParam(inspectAttribute.Name, inspectAttribute.Nickname, inspectAttribute.Description, enumerable ? Grasshopper.Kernel.GH_ParamAccess.list : Grasshopper.Kernel.GH_ParamAccess.item);
                result.Add(gooParam);
            }

            return result;
        }
    }
}
