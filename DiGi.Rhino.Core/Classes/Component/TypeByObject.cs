using DiGi.Rhino.Core.Enums;
using Grasshopper.Kernel;
using Grasshopper.Kernel.Types;
using System;
using System.Collections.Generic;

namespace DiGi.Rhino.Core.Classes
{
    /// <summary>
    /// A Grasshopper component that retrieves the type of a given input object.
    /// </summary>
    public class TypeByObject : VariableParameterComponent
    {
        /// <summary>
        /// Gets the unique ID for this component. Do not change this ID after release.
        /// </summary>
        /// <returns>The unique identifier of the component.</returns>
        public override Guid ComponentGuid => new("055f06ef-dbc5-462f-a231-20c150e0785a");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        /// <summary>
        /// Gets the exposure level of the component, which defines how it is displayed in the Grasshopper canvas.
        /// </summary>
        /// <returns>The exposure level of the component.</returns>
        public override GH_Exposure Exposure => GH_Exposure.primary;

        /// <summary>
        /// Initializes a new instance of the <see cref="TypeByObject"/> class.
        /// </summary>
        public TypeByObject()
          : base("Core.TypeByObject", "Core.TypeByObject",
              "Create type by object",
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
                    new Param(new GooObjectParam() { Name = "Object", NickName = "Object", Description = "Object", Access = GH_ParamAccess.item }, ParameterVisibility.Binding),
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

            index = Params.IndexOfInputParam("Object");
            object? @object = null;
            if (index == -1 || !dataAccess.GetData(index, ref @object))
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
                return;
            }

            if (@object is IGH_Goo gH_Goo)
            {
                if (Query.TryGetValue(gH_Goo, out object? @object_Temp))
                {
                    @object = @object_Temp;
                }
            }

            index = Params.IndexOfOutputParam("Type");
            if (index != -1)
            {
                dataAccess.SetData(index, new GooType(@object?.GetType()));
            }
        }
    }
}