using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Core.Classes.Goo;
using DiGi.Rhino.Core.Enums;
using Grasshopper.Kernel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Rhino.Core
{
    public class ToDiGi : VariableParameterComponent
    {
        /// <summary>
        /// Gets the unique ID for this component. Do not change this ID after release.
        /// </summary>
        public override Guid ComponentGuid => new Guid("d60640ab-a230-4465-a772-00ead8d7eda7");

        /// <summary>
        /// Provides an Icon for the component.
        /// </summary>
        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public override GH_Exposure Exposure => GH_Exposure.primary;

        /// <summary>
        /// Initializes a new instance of the SAM_point3D class.
        /// </summary>
        public ToDiGi()
          : base("Core.ToDiGi", "Core.ToDiGi",
              "Converts File to SerializableObjects",
              "DiGi", "DiGi.Core")
        {
        }

        /// <summary>
        /// Registers all the input parameters for this component.
        /// </summary>
        protected override Parameter[] Inputs
        {
            get
            {
                List<Parameter> result = new List<Parameter>();
                result.Add(new Parameter(new Grasshopper.Kernel.Parameters.Param_FilePath() { Name = "path", NickName = "path", Description = "File Path", Access = GH_ParamAccess.item }, ParameterVisibility.Binding));
                return result.ToArray();
            }
        }

        /// <summary>
        /// Registers all the output parameters for this component.
        /// </summary>
        protected override Parameter[] Outputs
        {
            get
            {
                List<Parameter> result = new List<Parameter>();
                result.Add(new Parameter(new GooSerializableObjectParam<ISerializableObject>() { Name = "serializableObjects", NickName = "serializableObjects", Description = "DiGi SerializableObjects", Access = GH_ParamAccess.list }, ParameterVisibility.Binding));
                return result.ToArray();
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

            index = Params.IndexOfInputParam("path");
            string path = null;
            if (index == -1 || !dataAccess.GetData(index, ref path) || path == null)
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
                return;
            }

            Path? path_Temp = path;

            if(!path_Temp.Value.FileExists)
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "File does not exist or is invalid.");
                return;
            }

            List<ISerializableObject> serializableObjects = DiGi.Core.Convert.ToDiGi<ISerializableObject>(path_Temp);

            index = Params.IndexOfOutputParam("serializableObjects");
            if (index != -1)
            {
                dataAccess.SetDataList(index, serializableObjects.ConvertAll(x => new GooSerializableObject<ISerializableObject>(x)));
            }
        }
    }
}