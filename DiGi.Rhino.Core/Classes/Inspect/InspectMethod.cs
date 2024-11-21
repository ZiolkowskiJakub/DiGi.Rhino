using Grasshopper.Kernel.Types;
using System.Collections;
using System.Reflection;

namespace DiGi.Rhino.Core.Classes
{
    public class InspectMethod
    {
        public MethodInfo MethodInfo { get; }
        
        public InspectAttribute InspectAttribute { get; }

        public InspectMethod(MethodInfo methodInfo, InspectAttribute inspectAttribute)
        {
            MethodInfo = methodInfo;
            InspectAttribute = inspectAttribute;
        }

        public bool IsValid(out bool enumerable)
        {
            enumerable = false;

            if(MethodInfo == null || InspectAttribute == null)
            {
                return false;
            }

            System.Type type = MethodInfo.ReturnType;

            if (typeof(IGH_Goo).IsAssignableFrom(type))
            {
                return true;
            }

            if (!typeof(IEnumerable).IsAssignableFrom(type) && !type.IsArray)
            {
                return false;
            }

            enumerable = true;

            if(type == typeof(IEnumerable))
            {
                return true;
            }

            if (typeof(IGH_Goo).IsAssignableFrom(type.GetGenericArguments()[0]))
            {
                return true;
            }

            return false;
        }

        public bool IsValid()
        {
            return IsValid(out bool enumerable);
        }

        public bool IsEnumerable()
        {
            IsValid(out bool result);

            return result;
        }

        public bool TryGetValue<T>(object @object, out T value)
        {
            value = default;

            if(@object == null || MethodInfo == null)
            {
                return false;
            }

            object value_Temp = MethodInfo.Invoke(null, new object[] { @object });
            if(value_Temp is T)
            {
                value = (T)value_Temp;
                return true;
            }

            if(value_Temp is IGH_Goo)
            {
                value_Temp = ((dynamic)value_Temp).Value;
            }

            if(!DiGi.Core.Query.TryConvert(value_Temp, out value))
            {
                return false;
            }

            return true;
        }
    }
}

