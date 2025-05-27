using DiGi.Rhino.Core.Interfaces;
using Grasshopper.Kernel;
using Grasshopper.Kernel.Attributes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DiGi.Rhino.Core.Classes
{
    public class Inspect : Component, IGH_VariableParameterComponent
    {
        /// <summary>
        /// Gets the unique ID for this component. Do not change this ID after release.
        /// </summary>
        public override Guid ComponentGuid => new Guid("cd6ddc4e-e56a-4b66-9023-5415b96ff7c8");

        public override GH_Exposure Exposure => GH_Exposure.primary;


        /// <summary>
        /// Initializes a new instance of the SAM_point3D class.
        /// </summary>
        public Inspect()
          : base("Core.Inspect", "Core.Inspect",
              "Inspect Object",
              "DiGi", "DiGi.Core")
        {

        }

        public override void AppendAdditionalMenuItems(ToolStripDropDown menu)
        {
            base.AppendAdditionalMenuItems(menu);

            bool hasInputData = !Params.Input[0].VolatileData.IsEmpty;
            bool hasOutputParameters = Params.Output.Count > 0;

            Menu_AppendSeparator(menu);
            Menu_AppendItem(menu, "Get common parameters", Menu_PopulateOutputsWithCommonParameters, hasInputData, false);
            Menu_AppendItem(menu, "Get all parameters", Menu_PopulateOutputsWithAllParameters, hasInputData, false);
            Menu_AppendItem(menu, "Remove unconnected parameters", Menu_RemoveUnconnectedParameters, hasOutputParameters, false);

            base.AppendAdditionalMenuItems(menu);
            Menu_AppendSeparator(menu);
        }

        void PopulateOutputParameters(IEnumerable<IGH_Param> @params)
        {
            Dictionary<string, IList<IGH_Param>> dictionary = new Dictionary<string, IList<IGH_Param>>();
            foreach (IGH_Param gH_Param in Params.Output)
            {
                if (gH_Param.Recipients == null && gH_Param.Recipients.Count == 0)
                {
                    continue;
                }

                dictionary.Add(gH_Param.Name, new List<IGH_Param>(gH_Param.Recipients));
            }

            while (Params.Output != null && Params.Output.Count() > 0)
            {
                Params.UnregisterOutputParameter(Params.Output[0]);
            }

            if (@params != null)
            {
                foreach (IGH_Param param in @params)
                {
                    if (param == null)
                    {
                        continue;
                    }

                    AddOutputParameter(param);

                    if (!dictionary.TryGetValue(param.Name, out IList<IGH_Param> @params_Temp))
                    {
                        continue;
                    }

                    foreach (IGH_Param param_Temp in @params_Temp)
                    {
                        param.AddSource(param_Temp);
                    }
                }
            }

            Params.OnParametersChanged();
            ExpireSolution(true);
        }

        void AddOutputParameter(IGH_Param param)
        {
            if (param.Attributes is null)
            {
                param.Attributes = new GH_LinkedParamAttributes(param, Attributes);
            }

            Params.RegisterOutputParam(param);
        }

        void Menu_PopulateOutputsWithAllParameters(object sender, EventArgs e)
        {
            List<GooParam> gooParams = new List<GooParam>();
            foreach (object @object in Params.Input[0].VolatileData.AllData(true).OfType<object>())
            {
                IGooSerializableObject gooSerializableObject = @object as IGooSerializableObject;
                if(gooSerializableObject == null)
                {
                    continue;
                }
                
                List<GooParam> gooParams_Temp = Create.GooParams(gooSerializableObject);
                if(gooParams_Temp == null)
                {
                    continue;
                }

                foreach(GooParam gooParam_Temp in gooParams_Temp)
                {
                    if(gooParam_Temp == null || gooParams.Find(x => x.Name == gooParam_Temp.Name) != null)
                    {
                        continue;
                    }

                    gooParams.Add(gooParam_Temp);
                }
            }

            RecordUndoEvent("Get Common Parameters");

            List<GooParam> gooParams_Sorted = gooParams.ToList();
            gooParams_Sorted.Sort((x, y) => x.Name.CompareTo(y.Name));

            PopulateOutputParameters(gooParams_Sorted);
        }

        void Menu_PopulateOutputsWithCommonParameters(object sender, EventArgs e)
        {
            Dictionary<Type, List<GooParam>> dictionary = new Dictionary<Type, List<GooParam>>();
            foreach (object @object in Params.Input[0].VolatileData.AllData(true).OfType<object>())
            {
                IGooSerializableObject gooSerializableObject = @object as IGooSerializableObject;
                if (gooSerializableObject == null)
                {
                    dictionary = new Dictionary<Type, List<GooParam>>();
                    break;
                }

                Type type = gooSerializableObject.GetType();

                if (dictionary.ContainsKey(type))
                {
                    continue;
                }

                List<GooParam> gooParams_Temp = Create.GooParams(gooSerializableObject);
                if (gooParams_Temp == null || gooParams_Temp.Count == 0)
                {
                    dictionary = new Dictionary<Type, List<GooParam>>();
                    break;
                }

                dictionary[type] = gooParams_Temp;
            }

            RecordUndoEvent("Get Common Parameters");

            List<GooParam> gooParams = new List<GooParam>();
            if (dictionary.Count != 0)
            {
                gooParams = new List<GooParam>(dictionary.Values.First());
                if (dictionary.Count > 0)
                {
                    foreach (KeyValuePair<Type, List<GooParam>> keyValuePair in dictionary)
                    {
                        for (int i = gooParams.Count - 1; i > 0; i--)
                        {
                            if (keyValuePair.Value.Contains(gooParams[i]))
                            {
                                continue;
                            }

                            gooParams.RemoveAt(i);

                            if (gooParams.Count == 0)
                            {
                                break;
                            }
                        }

                        if (gooParams.Count == 0)
                        {
                            break;
                        }
                    }
                }
            }

            gooParams.Sort((x, y) => x.Name.CompareTo(y.Name));

            PopulateOutputParameters(gooParams);
        }

        void Menu_RemoveUnconnectedParameters(object sender, EventArgs e)
        {
            RecordUndoEvent("Remove Unconnected Outputs");

            foreach (var output in Params.Output.ToArray())
            {
                if (output.Recipients.Count > 0)
                    continue;

                Params.UnregisterOutputParameter(output);
            }

            Params.OnParametersChanged();
            OnDisplayExpired(false);
        }

        /// <summary>
        /// Registers all the input parameters for this component.
        /// </summary>
        protected override void RegisterInputParams(GH_InputParamManager inputParamManager)
        {
            inputParamManager.AddGenericParameter("Object", "Object", "Object", GH_ParamAccess.item);
        }

        /// <summary>
        /// Registers all the output parameters for this component.
        /// </summary>
        protected override void RegisterOutputParams(GH_OutputParamManager outputParamManager)
        {

        }

        /// <summary>
        /// This is the method that actually does the work.
        /// </summary>
        /// <param name="dataAccess">
        /// The DA object is used to retrieve from inputs and store in outputs.
        /// </param>
        protected override void SolveInstance(IGH_DataAccess dataAccess)
        {
            object @object = null;
            if (!dataAccess.GetData(0, ref @object))
            {
                return;
            }

            IGooSerializableObject gooSerializableObject = @object as IGooSerializableObject;
            if(gooSerializableObject == null)
            {
                return;
            }

            for (int i = 0; i < Params.Output.Count; ++i)
            {
                GooParam gooParam = Params.Output[i] as GooParam;
                if(gooParam == null)
                {
                    continue;
                }

                object value = Query.Value(gooSerializableObject, gooParam);

                switch (gooParam.Access)
                {
                    case GH_ParamAccess.list:
                        dataAccess.SetDataList(i, value as IEnumerable);
                        break;

                    case GH_ParamAccess.item:
                        dataAccess.SetData(i, value);
                        break;

                    default:
                        dataAccess.SetData(i, null);
                        break;
                }
            }
        }

        bool IGH_VariableParameterComponent.CanInsertParameter(GH_ParameterSide side, int index) => false;

        bool IGH_VariableParameterComponent.CanRemoveParameter(GH_ParameterSide side, int index) => side == GH_ParameterSide.Output;

        IGH_Param IGH_VariableParameterComponent.CreateParameter(GH_ParameterSide side, int index) => null;

        bool IGH_VariableParameterComponent.DestroyParameter(GH_ParameterSide side, int index) => true;

        void IGH_VariableParameterComponent.VariableParameterMaintenance() { }

        public override void AddedToDocument(GH_Document document)
        {
            base.AddedToDocument(document);
        }
    }
}