using DiGi.Core.Interfaces;
using DiGi.Rhino.Core.Enums;
using Grasshopper.Kernel;
using System;
using System.Collections.Generic;

namespace DiGi.Rhino.Core.Classes
{
    public class FilterByMask : VariableParameterComponent
    {
        /// <summary>
        /// Gets the unique ID for this component. Do not change this ID after release.
        /// </summary>
        public override Guid ComponentGuid => new Guid("6c2fe566-8408-4aa6-b0af-d978db84720a");

        /// <summary>
        /// Provides an Icon for the component.
        /// </summary>
        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public override GH_Exposure Exposure => GH_Exposure.primary;

        /// <summary>
        /// Initializes a new instance of the SAM_point3D class.
        /// </summary>
        public FilterByMask()
          : base("Core.FilterByMask", "Core.FilterByMask",
              "Filter objects by mask",
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
                result.Add(new Param(new GooSerializableObjectParam() { Name = "SerializableObjects", NickName = "SerializableObjects", Description = "DiGi SerializableObjects", Access = GH_ParamAccess.list }, ParameterVisibility.Binding));
                result.Add(new Param(new Grasshopper.Kernel.Parameters.Param_Boolean() { Name = "Mask", NickName = "Mask", Description = "Mask", Access = GH_ParamAccess.list }, ParameterVisibility.Binding));
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
                result.Add(new Param(new GooSerializableObjectParam() { Name = "In", NickName = "In", Description = "In", Access = GH_ParamAccess.list }, ParameterVisibility.Binding));
                result.Add(new Param(new GooSerializableObjectParam() { Name = "Out", NickName = "Out", Description = "Out", Access = GH_ParamAccess.list }, ParameterVisibility.Binding));
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

            index = Params.IndexOfInputParam("SerializableObjects");
            List<ISerializableObject> serializableObjects = new List<ISerializableObject>();
            if (index == -1 || !dataAccess.GetDataList(index, serializableObjects) || serializableObjects == null)
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
                return;
            }


            index = Params.IndexOfInputParam("Mask");
            List<bool> mask = new List<bool>();
            if (index == -1 || !dataAccess.GetDataList(index, mask) || mask == null || mask.Count == 0)
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
                return;
            }

            List<ISerializableObject> serializableObjects_In = new List<ISerializableObject>();
            List<ISerializableObject> serializableObjects_Out = new List<ISerializableObject>();

            for (int i=0; i < serializableObjects.Count; i++)
            {
                List<ISerializableObject> serializableObjects_Temp = mask[i % mask.Count] ? serializableObjects_In : serializableObjects_Out;
                serializableObjects_Temp.Add(serializableObjects[i]);

            }

            index = Params.IndexOfOutputParam("In");
            if (index != -1)
            {
                dataAccess.SetDataList(index, serializableObjects_In?.ConvertAll(x => new GooSerializableObject(x)));
            }

            index = Params.IndexOfOutputParam("Out");
            if (index != -1)
            {
                dataAccess.SetDataList(index, serializableObjects_Out?.ConvertAll(x => new GooSerializableObject(x)));
            }
        }
    }
}