using System;
using System.Collections.Generic;
using System.Reflection;

namespace DiGi.Rhino.Core.Classes
{
    public class InspectManager
    {
        private Dictionary<Type, List<InspectMethod>> dictionary = null;

        public InspectManager()
        {

        }

        public List<InspectMethod> GetInspectMethods(Type type)
        {
            if (dictionary == null)
            {
                Load();
            }

            List<InspectMethod> result = new List<InspectMethod>();
            foreach(KeyValuePair<Type, List<InspectMethod>> keyValuePair in dictionary)
            {
                if(!keyValuePair.Key.IsAssignableFrom(type))
                {
                    continue;
                }

                result.AddRange(keyValuePair.Value);
            }

            return result;
        }

        private void Load()
        {
            dictionary = new Dictionary<Type, List<InspectMethod>>();

            List<MethodInfo> methodInfos = DiGi.Core.Query.ExtensionMethodInfos();
            if(methodInfos == null)
            {
                return;
            }

            foreach(MethodInfo methodInfo in methodInfos)
            {
                InspectAttribute inspectAttribute = methodInfo?.GetCustomAttribute<InspectAttribute>();
                if (inspectAttribute == null)
                {
                    continue;
                }

                ParameterInfo[] parameterInfos = methodInfo.GetParameters();
                if(parameterInfos == null || parameterInfos.Length != 1)
                {
                    continue;
                }

                ParameterInfo parameterInfo = parameterInfos[0];

                Type type = parameterInfo.ParameterType;
                if(!dictionary.TryGetValue(type, out List<InspectMethod> inspectMethods) || inspectMethods == null)
                {
                    inspectMethods = new List<InspectMethod>();
                    dictionary[type] = inspectMethods;
                }

                InspectMethod inspectMethod = new InspectMethod(methodInfo, inspectAttribute);
                if(!inspectMethod.IsValid())
                {
                    continue;
                }

                inspectMethods.Add(inspectMethod);
            }
        }
    }
}
