using Grasshopper.Kernel.Types;
using System.Collections;
using System.Reflection;

namespace DiGi.Rhino.Core.Classes
{
    /// <summary>
    /// Provides functionality to inspect and invoke a method associated with an <see cref="InspectAttribute"/>.
    /// </summary>
    public class InspectMethod
    {
        /// <summary>
        /// Gets the reflection information of the inspected method.
        /// </summary>
        public MethodInfo? MethodInfo { get; }

        /// <summary>
        /// Gets the attribute associated with the inspected method.
        /// </summary>
        public InspectAttribute? InspectAttribute { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="InspectMethod"/> class.
        /// </summary>
        /// <param name="methodInfo">The reflection information of the method.</param>
        /// <param name="inspectAttribute">The attribute associated with the method.</param>
        public InspectMethod(MethodInfo? methodInfo, InspectAttribute? inspectAttribute)
        {
            MethodInfo = methodInfo;
            InspectAttribute = inspectAttribute;
        }

        /// <summary>
        /// Determines whether the inspected method is valid based on its return type.
        /// </summary>
        /// <param name="enumerable">When this method returns, contains a boolean value indicating whether the return type is an enumerable collection.</param>
        /// <returns>True if the method is valid; otherwise, false.</returns>
        public bool IsValid(out bool enumerable)
        {
            enumerable = false;

            if (MethodInfo == null || InspectAttribute == null)
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

            if (type == typeof(IEnumerable))
            {
                return true;
            }

            if (typeof(IGH_Goo).IsAssignableFrom(type.GetGenericArguments()[0]))
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Determines whether the inspected method is valid.
        /// </summary>
        /// <returns>True if the method is valid; otherwise, false.</returns>
        public bool IsValid()
        {
            return IsValid(out _);
        }

        /// <summary>
        /// Checks if the inspected method is valid and specifically returns an enumerable collection.
        /// </summary>
        /// <returns>True if the method is valid and return type is enumerable; otherwise, false.</returns>
        public bool IsEnumerable()
        {
            IsValid(out bool result);

            return result;
        }

        /// <summary>
        /// Attempts to invoke the inspected method and convert its result to a specified type.
        /// </summary>
        /// <typeparam name="T">The target type for the return value.</typeparam>
        /// <param name="object">The object instance to use for invocation (if applicable).</param>
        /// <param name="value">When this method returns, contains the converted value if successful; otherwise, the default value of <typeparam ref="T"/>.</param>
        /// <returns>True if the value was successfully retrieved and converted; otherwise, false.</returns>
        public bool TryGetValue<T>(object? @object, out T? value)
        {
            value = default;

            if (@object == null || MethodInfo == null)
            {
                return false;
            }

            object? value_Temp = MethodInfo.Invoke(null, [@object]);
            if (value_Temp is T t)
            {
                value = t;
                return true;
            }

            if (value_Temp is IGH_Goo)
            {
                value_Temp = ((dynamic)value_Temp).Value;
            }

            if (!DiGi.Core.Query.TryConvert(value_Temp, out value))
            {
                return false;
            }

            return true;
        }
    }
}