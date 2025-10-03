using DiGi.Core.Interfaces;
using DiGi.Rhino.Core.Interfaces;
using Grasshopper.Kernel.Types;
using System.Reflection;

namespace DiGi.Rhino.Core
{
    public static partial class Query
    {
        public static bool TryGetValue<TSerializableObject>(this IGooSerializableObject? gooSerializableObject, out TSerializableObject? serializableObject) where TSerializableObject : ISerializableObject
        {
            serializableObject = default;

            if(!TryGetValue(gooSerializableObject, out object? @object)|| @object is null)
            {
                return false;
            }

            if(@object is not TSerializableObject)
            {
                return false;
            }

            serializableObject = (TSerializableObject)@object;
            return true;
        }

        public static bool TryGetValue(this IGH_Goo? gH_Goo, out object? value)
        {
            value = null;

            if(gH_Goo?.GetType() is not System.Type type)
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

        public static bool TryGetValue<TObject>(this object? @object, out TObject? value)
        {
            value = default;
            if(@object is null)
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
