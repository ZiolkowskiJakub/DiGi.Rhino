using DiGi.Core.Parameter.Interfaces;
using DiGi.GIS.Rhino.Classes;
using DiGi.Rhino.Core.Enums;
using Grasshopper.Kernel;
using Grasshopper.Kernel.Types;
using System;
using System.Collections.Generic;

namespace DiGi.Rhino.Core.Classes
{
    /// <summary>
    /// A Grasshopper component that sets a value for a given parameter definition on a parametrized object.
    /// </summary>
    public class SetValue : VariableParameterComponent
    {
        /// <summary> Gets the unique ID for this component. Do not change this ID after release. </summary>
        public override Guid ComponentGuid => new("7d05550a-df79-4b5e-8911-1eeb0e501881");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        /// <summary> Gets the exposure level of the component. </summary>
        public override GH_Exposure Exposure => GH_Exposure.primary;

        /// <summary>
        /// Initializes a new instance of object.
        /// </summary>
        public SetValue()
          : base("Core.SetValue", "Core.SetValue",
              "Sets value for given parameter",
              "DiGi", "DiGi.Core")
        {
        }

        /// <summary>
        /// Registers all the input parameters for this component.
        /// </summary>
        /// <returns>An array of input parameters.</returns>
        protected override Param[] Inputs
        {
            get
            {
                List<Param> result =
                [
                    new Param(new GooParametrizedObjectParam() { Name = "ParametrizedObject", NickName = "ParametrizedObject", Description = "DiGi ParametrizedObject", Access = GH_ParamAccess.item }, ParameterVisibility.Binding),
                    new Param(new GooParameterDefinitionParam() { Name = "ParameterDefinition", NickName = "ParameterDefinition", Description = "ParameterDefinition", Access = GH_ParamAccess.item }, ParameterVisibility.Binding),
                    new Param(new Grasshopper.Kernel.Parameters.Param_GenericObject() { Name = "Value", NickName = "Value", Description = "Value", Access = GH_ParamAccess.item }, ParameterVisibility.Binding),
                ];
                return [.. result];
            }
        }

        /// <summary>
        /// Registers all the output parameters for this component.
        /// </summary>
        /// <returns>An array of output parameters.</returns>
        protected override Param[] Outputs
        {
            get
            {
                List<Param> result =
                [
                    new Param(new GooParametrizedObjectParam() { Name = "ParametrizedObject", NickName = "ParametrizedObject", Description = "ParametrizedObject", Access = GH_ParamAccess.item }, ParameterVisibility.Binding),
                    new Param(new Grasshopper.Kernel.Parameters.Param_Boolean() { Name = "Succeeded", NickName = "Succeeded", Description = "Succeeded", Access = GH_ParamAccess.item }, ParameterVisibility.Binding),
                ];
                return [.. result];
            }
        }

        /// <summary>
        /// This is the method that actually does the work.
        /// </summary>
        /// <param name="dataAccess">
        /// The DA object is used to retrieve from inputs and store in outputs.
        /// </param>
        protected override void SolveInstance(IGH_DataAccess dataAccess)
        {
            int index;

            index = Params.IndexOfInputParam("ParametrizedObject");
            IParametrizedObject? parametrizedObject = null;
            if (index == -1 || !dataAccess.GetData(index, ref parametrizedObject) || parametrizedObject == null)
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
                return;
            }

            index = Params.IndexOfInputParam("ParameterDefinition");
            IParameterDefinition? parameterDefinition = null;
            if (index == -1 || !dataAccess.GetData(index, ref parameterDefinition) || parameterDefinition == null)
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
                return;
            }

            index = Params.IndexOfInputParam("Value");
            GH_ObjectWrapper? gH_ObjectWrapper = null;
            if (index == -1 || !dataAccess.GetData(index, ref gH_ObjectWrapper))
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
                return;
            }

            parametrizedObject = DiGi.Core.Query.Clone(parametrizedObject);

            bool succeeded = parametrizedObject!.SetValue(parameterDefinition, gH_ObjectWrapper?.Value, new DiGi.Core.Parameter.Classes.SetValueSettings(true, true));

            index = Params.IndexOfOutputParam("ParametrizedObject");
            if (index != -1)
            {
                dataAccess.SetData(index, new GooParametrizedObject(parametrizedObject));
            }

            index = Params.IndexOfOutputParam("Succeeded");
            if (index != -1)
            {
                dataAccess.SetData(index, new GH_Boolean(succeeded));
            }
        }
    }
}