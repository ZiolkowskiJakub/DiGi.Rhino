using DiGi.Core.Interfaces;
using DiGi.Rhino.Core.Enums;
using Grasshopper.Kernel;
using System;
using System.Collections.Generic;

namespace DiGi.Rhino.Core.Classes
{
    public class Write : VariableParameterComponent
    {
        /// <summary>
        /// Gets the unique ID for this component. Do not change this ID after release.
        /// </summary>
        public override Guid ComponentGuid => new Guid("df9e0fa7-ae39-47ae-94a2-bf1d69f4c37d");

        /// <summary>
        /// Provides an Icon for the component.
        /// </summary>
        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public override GH_Exposure Exposure => GH_Exposure.primary;

        /// <summary>
        /// Initializes a new instance of the SAM_point3D class.
        /// </summary>
        public Write()
          : base("Core.Write", "Core.Write",
              "Write SerializableObjects to file",
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
                List<Param> result = new List<Param>();
                result.Add(new Param(new Grasshopper.Kernel.Parameters.Param_FilePath() { Name = "Path", NickName = "Path", Description = "File Path", Access = GH_ParamAccess.item }, ParameterVisibility.Binding));
                result.Add(new Param(new GooSerializableObjectParam() { Name = "SerializableObjects", NickName = "SerializableObjects", Description = "DiGi SerializableObjects", Access = GH_ParamAccess.list }, ParameterVisibility.Binding));
                return result.ToArray();
            }
        }

        /// <summary>
        /// Registers all the output parameters for this component.
        /// </summary>
        protected override Param[] Outputs
        {
            get
            {
                List<Param> result = new List<Param>();
                result.Add(new Param(new Grasshopper.Kernel.Parameters.Param_Boolean() { Name = "Succeed", NickName = "Succeed", Description = "Succeed", Access = GH_ParamAccess.item }, ParameterVisibility.Binding));
                result.Add(new Param(new Grasshopper.Kernel.Parameters.Param_String() { Name = "Json", NickName = "Json", Description = "Json", Access = GH_ParamAccess.item }, ParameterVisibility.Voluntary));

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
            int index_Succeed = Params.IndexOfInputParam("Succeed");
            dataAccess.SetData(index_Succeed, false);

            int index;

            index = Params.IndexOfInputParam("Path");
            string path = null;
            if (index == -1 || !dataAccess.GetData(index, ref path) || path == null)
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
                return;
            }

            index = Params.IndexOfInputParam("SerializableObjects");
            List<ISerializableObject> serializableObjects = new List<ISerializableObject>();
            if (index == -1 || !dataAccess.GetDataList(index, serializableObjects) || serializableObjects == null)
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
            }

            string json = DiGi.Core.Convert.ToJson(serializableObjects)?.ToString();

            index = Params.IndexOfOutputParam("Json");
            if (index != -1)
            {
                dataAccess.SetData(index, json);
            }

            System.IO.File.WriteAllText(path, json);

            dataAccess.SetData(index_Succeed, true);
        }
    }
}