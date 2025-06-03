using DiGi.Core.Interfaces;
using DiGi.Rhino.Core.Enums;
using Grasshopper.Kernel;
using Grasshopper.Kernel.Types;
using System;
using System.Collections.Generic;

namespace DiGi.Rhino.Core.Classes
{
    public class FilterByText : VariableParameterComponent
    {
        /// <summary>
        /// Gets the unique ID for this component. Do not change this ID after release.
        /// </summary>
        public override Guid ComponentGuid => new Guid("b5b79ad2-998a-406f-97a6-81d6b6fdee96");

        /// <summary>
        /// Provides an Icon for the component.
        /// </summary>
        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public override GH_Exposure Exposure => GH_Exposure.primary;

        /// <summary>
        /// Initializes a new instance of the SAM_point3D class.
        /// </summary>
        public FilterByText()
          : base("Core.FilterByText", "Core.FilterByText",
              "Filter objects by text",
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
                result.Add(new Param(new Grasshopper.Kernel.Parameters.Param_String() { Name = "ParameterName", NickName = "ParameterName", Description = "Parameter Name", Access = GH_ParamAccess.item }, ParameterVisibility.Binding));
                result.Add(new Param(new Grasshopper.Kernel.Parameters.Param_String() { Name = "Value", NickName = "Value", Description = "Value", Access = GH_ParamAccess.item }, ParameterVisibility.Binding));


                GooEnumParam<DiGi.Core.Enums.TextComparisonType> gooEnumParam = new GooEnumParam<DiGi.Core.Enums.TextComparisonType>() { Name = "TextComparisonType", NickName = "TextComparisonType", Description = "DiGi Core TextComparisonType", Access = GH_ParamAccess.item };
                gooEnumParam.SetPersistentData(DiGi.Core.Enums.TextComparisonType.Equals);
                result.Add(new Param(gooEnumParam, ParameterVisibility.Binding));

                result.Add(new Param(new Grasshopper.Kernel.Parameters.Param_Boolean() { Name = "CaseSensitive", NickName = "CaseSensitive", Description = "Case sensitive", Access = GH_ParamAccess.item, Optional = true }, ParameterVisibility.Voluntary));

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
                result.Add(new Param(new Grasshopper.Kernel.Parameters.Param_Boolean() { Name = "Mask", NickName = "Mask", Description = "Mask", Access = GH_ParamAccess.list }, ParameterVisibility.Voluntary));
                result.Add(new Param(new GooSerializableObjectParam() { Name = "Invalid", NickName = "Invalid", Description = "Invalid", Access = GH_ParamAccess.list }, ParameterVisibility.Voluntary));
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


            index = Params.IndexOfInputParam("ParameterName");
            string parameterName = null;
            if (index == -1 || !dataAccess.GetData(index, ref parameterName) || parameterName == null)
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
                return;
            }

            index = Params.IndexOfInputParam("Value");
            string value_1 = null;
            if (index == -1 || !dataAccess.GetData(index, ref value_1) || value_1 == null)
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
                return;
            }

            index = Params.IndexOfInputParam("TextComparisonType");
            DiGi.Core.Enums.TextComparisonType textComparisonType = DiGi.Core.Enums.TextComparisonType.Equals;
            if (index == -1 || !dataAccess.GetData(index, ref textComparisonType))
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
                return;
            }

            bool caseSensitive = true;

            index = Params.IndexOfInputParam("CaseSensitive");
            if(index != -1)
            {
                bool caseSensitive_Temp = true;
                if (dataAccess.GetData(index, ref caseSensitive))
                {
                    caseSensitive = caseSensitive_Temp;
                }
            }

            List<ISerializableObject> serializableObjects_In = new List<ISerializableObject>();
            List<ISerializableObject> serializableObjects_Out = new List<ISerializableObject>();
            List<ISerializableObject> serializableObjects_Invalid = new List<ISerializableObject>();

            List<bool> mask = new List<bool>();

            Dictionary<Type, InspectMethod> dictionary = new Dictionary<Type, InspectMethod>();
            foreach(ISerializableObject serializableObject in serializableObjects)
            {
                if(serializableObject == null)
                {
                    mask.Add(false);
                    continue;
                }

                Type type = serializableObject?.GetType();
                if(type == null)
                {
                    mask.Add(false);
                    continue;
                }

                if(!dictionary.TryGetValue(type, out InspectMethod inspectMethod))
                {
                    inspectMethod = Settings.InspectManager.GetInspectMethods(type).Find(x => x.InspectAttribute?.Name == parameterName);
                    dictionary[type] = inspectMethod;
                }

                if(inspectMethod == null || !inspectMethod.TryGetValue(serializableObject, out string value_2))
                {
                    serializableObjects_Invalid.Add(serializableObject);
                    mask.Add(false);
                    continue;
                }

                if(DiGi.Core.Query.Compare(value_2, value_1, textComparisonType, caseSensitive))
                {
                    mask.Add(true);
                    serializableObjects_In.Add(serializableObject);
                }
                else
                {
                    mask.Add(false);
                    serializableObjects_Out.Add(serializableObject);
                }
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

            index = Params.IndexOfOutputParam("Mask");
            if (index != -1)
            {
                dataAccess.SetDataList(index, mask?.ConvertAll(x => new GH_Boolean(x)));
            }

            index = Params.IndexOfOutputParam("Invalid");
            if (index != -1)
            {
                dataAccess.SetDataList(index, serializableObjects_Invalid?.ConvertAll(x => new GooSerializableObject(x)));
            }
        }
    }
}