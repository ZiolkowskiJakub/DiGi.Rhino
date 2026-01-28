using DiGi.Core.Parameter.Classes;
using DiGi.Core.Parameter.Interfaces;
using DiGi.GIS.Rhino.Classes;
using DiGi.Rhino.Core.Classes;
using System.Collections;
using System.Collections.Generic;

namespace DiGi.Rhino.Core
{
    public static partial class Inspect
    {
        [Inspect("Parameters", "Parameters", "Parameters")]
        public static IEnumerable? Parameters(this IParametrizedObject? parametrizedObject)
        {
            if (parametrizedObject == null)
            {
                return null;
            }

            List<IParameterDefinition>? parameterDefinitions = parametrizedObject.GetParameterDefinitions<IParameterDefinition>();
            if (parameterDefinitions == null)
            {
                return null;
            }

            GetValueSettings getValueSettings = new(true, true);
            SetValueSettings setValueSettings = new(true, false);

            List<GooParameter> result = [];
            foreach (IParameterDefinition parameterDefinition in parameterDefinitions)
            {
                if (parametrizedObject.TryGetValue(parameterDefinition, out object? value, getValueSettings))
                {
                    Parameter? parameter = DiGi.Core.Parameter.Create.Parameter(parameterDefinition, value, setValueSettings);
                    if (parameter == null)
                    {
                        continue;
                    }

                    result.Add(new GooParameter(parameter));
                }
            }

            return result;
        }
    }
}