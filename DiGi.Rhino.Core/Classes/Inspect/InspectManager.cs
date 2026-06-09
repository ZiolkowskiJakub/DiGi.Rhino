using System;
using System.Collections.Generic;
using System.Reflection;

namespace DiGi.Rhino.Core.Classes
{
    /// <summary>
    /// Manages the discovery and retrieval of inspection methods associated with specific types.
    /// </summary>
    public class InspectManager
    {
        private Dictionary<Type, List<InspectMethod>>? dictionary = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="InspectManager"/> class.
        /// </summary>
        public InspectManager()
        {
        }

        /// <summary>
        /// Retrieves a list of inspection methods that are applicable to the specified type.
        /// </summary>
        /// <param name="type">The type for which to retrieve inspection methods.</param>
        /// <returns>A list of <see cref="InspectMethod"/> objects associated with the provided type or its base types; returns null if the internal dictionary fails to initialize.</returns>
        public List<InspectMethod>? GetInspectMethods(Type? type)
        {
            if (dictionary == null)
            {
                Load();
            }

            if (dictionary == null)
            {
                return null;
            }

            List<InspectMethod> result = [];
            foreach (KeyValuePair<Type, List<InspectMethod>> keyValuePair in dictionary)
            {
                if (!keyValuePair.Key.IsAssignableFrom(type))
                {
                    continue;
                }

                result.AddRange(keyValuePair.Value);
            }

            return result;
        }

        private void Load()
        {
            dictionary = [];

            List<MethodInfo> methodInfos = DiGi.Core.Query.ExtensionMethodInfos();
            if (methodInfos == null)
            {
                return;
            }

            foreach (MethodInfo methodInfo in methodInfos)
            {
                InspectAttribute? inspectAttribute = methodInfo?.GetCustomAttribute<InspectAttribute>();
                if (inspectAttribute == null)
                {
                    continue;
                }

                ParameterInfo[]? parameterInfos = methodInfo!.GetParameters();
                if (parameterInfos == null || parameterInfos.Length != 1)
                {
                    continue;
                }

                ParameterInfo parameterInfo = parameterInfos[0];

                Type type = parameterInfo.ParameterType;
                if (!dictionary.TryGetValue(type, out List<InspectMethod>? inspectMethods) || inspectMethods == null)
                {
                    inspectMethods = [];
                    dictionary[type] = inspectMethods;
                }

                InspectMethod inspectMethod = new(methodInfo, inspectAttribute);
                if (!inspectMethod.IsValid())
                {
                    continue;
                }

                inspectMethods.Add(inspectMethod);
            }
        }
    }
}