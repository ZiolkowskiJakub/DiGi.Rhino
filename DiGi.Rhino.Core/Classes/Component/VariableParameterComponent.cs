using DiGi.Rhino.Core.Enums;
using Grasshopper.Kernel;
using System.Linq;

namespace DiGi.Rhino.Core.Classes
{
    public abstract class VariableParameterComponent : Component, IGH_VariableParameterComponent
    {
        protected abstract Parameter[] Inputs { get; }

        protected abstract Parameter[] Outputs { get; }

        public VariableParameterComponent(string name, string nickname, string description, string category, string subCategory)
            : base(name, nickname, description, category, subCategory)
        {

        }

        public bool CanInsertParameter(GH_ParameterSide parameterSide, int index)
        {
            var templateParams = parameterSide == GH_ParameterSide.Input ? Inputs : Outputs;
            var componentParams = parameterSide == GH_ParameterSide.Input ? Params.Input : Params.Output;

            if (index >= templateParams.Length)
            {
                return false;
            }

            if (index == 0)
            {
                if (componentParams.Count == 0)
                {
                    return templateParams.Length > 0;
                }

                return componentParams[0].Name != templateParams[0].Param.Name;
            }

            if (index >= componentParams.Count)
            {
                return componentParams[componentParams.Count - 1].Name != templateParams[templateParams.Length - 1].Param.Name;
            }

            string previous = componentParams[index - 1].Name;

            for (int i = 0; i < templateParams.Length; ++i)
            {
                if (templateParams[i].Param.Name == previous)
                {
                    return templateParams[i + 1].Param.Name != componentParams[index].Name;
                }
            }

            return false;
        }

        public bool CanRemoveParameter(GH_ParameterSide parameterSide, int index)
        {
            var templateParams = parameterSide == GH_ParameterSide.Input ? Inputs : Outputs;
            var componentParams = parameterSide == GH_ParameterSide.Input ? Params.Input : Params.Output;

            string current = componentParams[index].Name;
            for (int i = 0; i < templateParams.Length; ++i)
            {
                if (templateParams[i].Param.Name == current)
                {
                    return !templateParams[i].ParameterVisibility.HasFlag(Enums.ParameterVisibility.Mandatory);
                }
            }

            return true;
        }

        private IGH_Param GetTemplateParam(GH_ParameterSide parameterSide, int index)
        {
            var templateParams = parameterSide == GH_ParameterSide.Input ? Inputs : Outputs;
            var componentParams = parameterSide == GH_ParameterSide.Input ? Params.Input : Params.Output;

            int offset = index == 0 ? -1 : +1;
            int reference = index == 0 ? index : index - 1;

            if (componentParams.Count == 0)
            {
                if (templateParams.Length > 0)
                {
                    return templateParams[templateParams.Length + offset].Param;
                }
            }
            else
            {
                var currentName = componentParams[reference].Name;
                for (int i = 0; i < templateParams.Length; ++i)
                {
                    if (templateParams[i].Param.Name == currentName)
                    {
                        return templateParams[i + offset].Param;
                    }
                }
            }

            return default;
        }

        public IGH_Param CreateParameter(GH_ParameterSide parameterSide, int index)
        {
            if (GetTemplateParam(parameterSide, index) is IGH_Param param)
            {
                return param.Clone();
            }

            return default;
        }

        public virtual bool DestroyParameter(GH_ParameterSide parameterSide, int index) => CanRemoveParameter(parameterSide, index);

        public void VariableParameterMaintenance()
        {

        }

        protected override sealed void RegisterInputParams(GH_InputParamManager inputParamManager)
        {
            foreach (var definition in Inputs.Where(x => x.ParameterVisibility.HasFlag(ParameterVisibility.Default)))
            {
                inputParamManager.AddParameter(definition.Param.Clone());
            }
        }

        protected override sealed void RegisterOutputParams(GH_OutputParamManager outputParamManager)
        {
            foreach (var definition in Outputs.Where(x => x.ParameterVisibility.HasFlag(ParameterVisibility.Default)))
            {
                outputParamManager.AddParameter(definition.Param.Clone());
            }
        }
    }
}
