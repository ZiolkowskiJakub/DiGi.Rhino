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
    /// A Grasshopper component that retrieves a value for a given parameter definition from a parametrized object.
    /// </summary>
    public class GetValue : VariableParameterComponent
    {
        /// <summary>
        /// Gets the unique identifier for this component.
        /// </summary>
        public override Guid ComponentGuid => new("5c5b9f88-974a-4a56-95d8-cc840087151b");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        /// <summary>
        /// Gets the exposure level of this component.
        /// </summary>
        public override GH_Exposure Exposure => GH_Exposure.primary;

        /// <summary>
        /// Initializes a new instance of the <see cref="GetValue"/> class.
        /// </summary>
        public GetValue()
          : base("Core.GetValue", "Core.GetValue",
              "Gets value for given parameter",
              "DiGi", "DiGi.Core")
        {
        }

        /// <summary>
        /// Registers all the input parameters for this component.
        /// </summary>
        protected override Param[] Inputs
        {
            get
            {
                List<Param> result =
                [
                    new Param(new GooParametrizedObjectParam() { Name = "ParametrizedObject", NickName = "ParametrizedObject", Description = "DiGi ParametrizedObject", Access = GH_ParamAccess.item }, ParameterVisibility.Binding),
                    new Param(new GooParameterDefinitionParam() { Name = "ParameterDefinition", NickName = "ParameterDefinition", Description = "ParameterDefinition", Access = GH_ParamAccess.item }, ParameterVisibility.Binding),
                ];
                return [.. result];
            }
        }

        /// <summary>
        /// Registers all the output parameters for this component.
        /// </summary>
        protected override Param[] Outputs
        {
            get
            {
                List<Param> result =
                [
                    new Param(new Grasshopper.Kernel.Parameters.Param_GenericObject() { Name = "Value", NickName = "Value", Description = "Value", Access = GH_ParamAccess.item }, ParameterVisibility.Binding),
                ];
                return [.. result];
            }
        }

        /// <summary>
        /// Performs the main logic of the component, retrieving a value from the parametrized object based on the provided parameter definition.
        /// </summary>
        /// <param name="dataAccess">The DA object used to retrieve from inputs and store in outputs.</param>
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

            IGH_Goo? gH_Goo = null;

            if (parametrizedObject.TryGetValue(parameterDefinition, out object? value, new DiGi.Core.Parameter.Classes.GetValueSettings(true, true)))
            {
                gH_Goo = Create.GH_Goo(parameterDefinition.ParameterType, value);
            }

            index = Params.IndexOfOutputParam("Value");
            if (index != -1)
            {
                dataAccess.SetData(index, gH_Goo);
            }
        }
    }
}