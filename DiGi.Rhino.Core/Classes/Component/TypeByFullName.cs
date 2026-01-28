using DiGi.Rhino.Core.Enums;
using Grasshopper.Kernel;
using System;
using System.Collections.Generic;

namespace DiGi.Rhino.Core.Classes
{
    public class TypeByFullName : VariableParameterComponent
    {
        /// <summary>
        /// Gets the unique ID for this component. Do not change this ID after release.
        /// </summary>
        public override Guid ComponentGuid => new("c77ada5b-8c47-482a-acdc-7988a402a36e");

        /// <summary>
        /// Provides an Icon for the component.
        /// </summary>
        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public override GH_Exposure Exposure => GH_Exposure.primary;

        /// <summary>
        /// Initializes a new instance of object.
        /// </summary>
        public TypeByFullName()
          : base("Core.TypeByFullName", "Core.TypeByFullName",
              "Create type by full name",
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
                    new Param(new Grasshopper.Kernel.Parameters.Param_String() { Name = "FullName", NickName = "FullName", Description = "FullName", Access = GH_ParamAccess.item }, ParameterVisibility.Binding),
                ];

                Grasshopper.Kernel.Parameters.Param_Boolean param_Boolean = new() { Name = "IgnoreCase", NickName = "IgnoreCase", Description = "IgnoreCase", Access = GH_ParamAccess.item, Optional = true };
                param_Boolean.SetPersistentData(true);

                result.Add(new Param(param_Boolean, ParameterVisibility.Voluntary));

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
                    new Param(new GooTypeParam() { Name = "Type", NickName = "Type", Description = "Type", Access = GH_ParamAccess.item }, ParameterVisibility.Binding),
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

            index = Params.IndexOfInputParam("FullName");
            string? typeName = null;
            if (index == -1 || !dataAccess.GetData(index, ref typeName))
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
                return;
            }

            index = Params.IndexOfInputParam("IgnoreCase");
            bool ignoreCase = true;
            if (index == -1 || !dataAccess.GetData(index, ref ignoreCase))
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
                return;
            }

            Type? type = DiGi.Core.Query.Type(typeName, ignoreCase);

            index = Params.IndexOfOutputParam("Type");
            if (index != -1)
            {
                dataAccess.SetData(index, new GooType(type));
            }
        }
    }
}