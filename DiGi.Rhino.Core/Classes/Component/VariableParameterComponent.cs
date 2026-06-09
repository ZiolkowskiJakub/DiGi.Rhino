using DiGi.Rhino.Core.Enums;
using Grasshopper.Kernel;
using System.Linq;

namespace DiGi.Rhino.Core.Classes
{
    /// <summary>
    /// Provides a base implementation for Grasshopper components that support dynamic addition and removal of parameters based on predefined templates.
    /// </summary>
    public abstract class VariableParameterComponent : Component, IGH_VariableParameterComponent
    {
        /// <summary>
        /// Gets the template definitions for the input parameters.
        /// </summary>
        protected abstract Param[]? Inputs { get; }

        /// <summary>
        /// Gets the template definitions for the output parameters.
        /// </summary>
        protected abstract Param[]? Outputs { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="VariableParameterComponent"/> class.
        /// </summary>
        /// <param name="name">The name of the component.</param>
        /// <param name="nickname">The nickname of the component.</param>
        /// <param name="description">The description of the component.</param>
        /// <param name="category">The category the component belongs to.</param>
        /// <param name="subCategory">The sub-category the component belongs to.</param>
        public VariableParameterComponent(string name, string nickname, string description, string category, string subCategory)
            : base(name, nickname, description, category, subCategory)
        {
        }

        /// <summary>
        /// Determines whether a parameter can be inserted at the specified index on the given side of the component.
        /// </summary>
        /// <param name="parameterSide">The side (Input or Output) where the parameter is to be inserted.</param>
        /// <param name="index">The index position for insertion.</param>
        /// <returns><c>true</c> if the parameter can be inserted; otherwise, <c>false</c>.</returns>
        public bool CanInsertParameter(GH_ParameterSide parameterSide, int index)
        {
            var templateParams = parameterSide == GH_ParameterSide.Input ? Inputs : Outputs;
            var componentParams = parameterSide == GH_ParameterSide.Input ? Params.Input : Params.Output;

            if (templateParams == null || index >= templateParams.Length)
            {
                return false;
            }

            if (index == 0)
            {
                if (componentParams.Count == 0)
                {
                    return templateParams.Length > 0;
                }

                return componentParams[0].Name != templateParams[0].GH_Param.Name;
            }

            if (index >= componentParams.Count)
            {
                return componentParams[^1].Name != templateParams[^1].GH_Param.Name;
            }

            string previous = componentParams[index - 1].Name;

            for (int i = 0; i < templateParams.Length; ++i)
            {
                if (templateParams[i].GH_Param.Name == previous)
                {
                    return templateParams[i + 1].GH_Param.Name != componentParams[index].Name;
                }
            }

            return false;
        }

        /// <summary>
        /// Determines whether a parameter can be removed from the specified index on the given side of the component.
        /// </summary>
        /// <param name="parameterSide">The side (Input or Output) where the parameter is to be removed.</param>
        /// <param name="index">The index position of the parameter to remove.</param>
        /// <returns><c>true</c> if the parameter can be removed; otherwise, <c>false</c>.</returns>
        public bool CanRemoveParameter(GH_ParameterSide parameterSide, int index)
        {
            var templateParams = parameterSide == GH_ParameterSide.Input ? Inputs : Outputs;
            var componentParams = parameterSide == GH_ParameterSide.Input ? Params.Input : Params.Output;

            if (templateParams is null)
            {
                return false;
            }

            string current = componentParams[index].Name;
            for (int i = 0; i < templateParams.Length; ++i)
            {
                if (templateParams[i].GH_Param.Name == current)
                {
                    return !templateParams[i].ParameterVisibility.HasFlag(ParameterVisibility.Mandatory);
                }
            }

            return true;
        }

        private IGH_Param? GetTemplateParam(GH_ParameterSide parameterSide, int index)
        {
            var templateParams = parameterSide == GH_ParameterSide.Input ? Inputs : Outputs;
            if (templateParams is null)
            {
                return null;
            }

            var componentParams = parameterSide == GH_ParameterSide.Input ? Params.Input : Params.Output;

            int offset = index == 0 ? -1 : +1;
            int reference = index == 0 ? index : index - 1;

            if (componentParams.Count == 0)
            {
                if (templateParams.Length > 0)
                {
                    return templateParams[templateParams.Length + offset].GH_Param;
                }
            }
            else
            {
                var currentName = componentParams[reference].Name;
                for (int i = 0; i < templateParams.Length; ++i)
                {
                    if (templateParams[i].GH_Param.Name == currentName)
                    {
                        return templateParams[i + offset].GH_Param;
                    }
                }
            }

            return default;
        }

        /// <summary>
        /// Creates a new parameter based on the template definition for the specified side and index.
        /// </summary>
        /// <param name="parameterSide">The side (Input or Output) where the parameter is to be created.</param>
        /// <param name="index">The index position for creation.</param>
        /// <returns>A cloned instance of the template parameter, or <c>null</c> if no suitable template exists.</returns>
        public IGH_Param? CreateParameter(GH_ParameterSide parameterSide, int index)
        {
            if (GetTemplateParam(parameterSide, index) is IGH_Param param)
            {
                return param.Clone();
            }

            return default;
        }

        /// <summary>
        /// Destroys a parameter at the specified index on the given side of the component.
        /// </summary>
        /// <param name="parameterSide">The side (Input or Output) where the parameter is to be destroyed.</param>
        /// <param name="index">The index position of the parameter to destroy.</param>
        /// <returns><c>true</c> if the parameter was successfully destroyed; otherwise, <c>false</c>.</returns>
        public virtual bool DestroyParameter(GH_ParameterSide parameterSide, int index) => CanRemoveParameter(parameterSide, index);

        /// <summary>
        /// Performs maintenance tasks on the variable parameters of the component.
        /// </summary>
        public void VariableParameterMaintenance()
        {
        }

        /// <summary>
        /// Registers the default input parameters based on the provided templates.
        /// </summary>
        /// <param name="inputParamManager">The manager used to register input parameters.</param>
        protected override sealed void RegisterInputParams(GH_InputParamManager inputParamManager)
        {
            if (Inputs == null)
            {
                return;
            }

            foreach (var definition in Inputs.Where(x => x.ParameterVisibility.HasFlag(ParameterVisibility.Default)))
            {
                inputParamManager.AddParameter(definition.GH_Param.Clone());
            }
        }

        /// <summary>
        /// Registers the default output parameters based on the provided templates.
        /// </summary>
        /// <param name="outputParamManager">The manager used to register output parameters.</param>
        protected override sealed void RegisterOutputParams(GH_OutputParamManager outputParamManager)
        {
            if (Outputs == null)
            {
                return;
            }

            foreach (var definition in Outputs.Where(x => x.ParameterVisibility.HasFlag(ParameterVisibility.Default)))
            {
                outputParamManager.AddParameter(definition.GH_Param.Clone());
            }
        }
    }
}