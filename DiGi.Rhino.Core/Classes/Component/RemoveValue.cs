using DiGi.Core.Parameter.Interfaces;
using DiGi.GIS.Rhino.Classes;
using DiGi.Rhino.Core.Enums;
using Grasshopper.Kernel;
using Grasshopper.Kernel.Types;
using System;
using System.Collections.Generic;

namespace DiGi.Rhino.Core.Classes
{
    public class RemoveValue : VariableParameterComponent
    {
        /// <summary>
        /// Gets the unique ID for this component. Do not change this ID after release.
        /// </summary>
        public override Guid ComponentGuid => new ("0059dba9-e52e-4da3-aa67-3d9e22c111de");

        /// <summary>
        /// Provides an Icon for the component.
        /// </summary>
        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public override GH_Exposure Exposure => GH_Exposure.primary;

        /// <summary>
        /// Initializes a new instance of the SAM_point3D class.
        /// </summary>
        public RemoveValue()
          : base("Core.RemoveValue", "Core.RemoveValue",
              "Removes given parameter",
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
                    new Param(new GooParametrizedObjectParam() { Name = "ParametrizedObject", NickName = "ParametrizedObject", Description = "DiGi ParametrizedObject", Access = GH_ParamAccess.item }, ParameterVisibility.Binding),
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

            parametrizedObject = DiGi.Core.Query.Clone(parametrizedObject);

            bool succeeded = parametrizedObject is not null && parametrizedObject.Remove(parameterDefinition);

            index = Params.IndexOfOutputParam("Succeeded");
            if (index != -1)
            {
                dataAccess.SetData(index, new GH_Boolean(succeeded));
            }
        }
    }
}