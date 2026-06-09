using DiGi.Core.Interfaces;
using Grasshopper.Kernel;
using Grasshopper.Kernel.Attributes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DiGi.Rhino.Core.Classes
{
    /// <summary>
    /// A Grasshopper component that inspects DiGi objects and dynamically generates
    /// output parameters based on the input object's serializable properties.
    /// </summary>
    public class Inspect : Component, IGH_VariableParameterComponent
    {
        /// <summary>
        /// Gets the unique identifier for this Grasshopper component.
        /// </summary>
        public override Guid ComponentGuid => new("cd6ddc4e-e56a-4b66-9023-5415b96ff7c8");

        /// <summary>
        /// Gets the exposure level of the component in the Grasshopper toolbar.
        /// </summary>
        public override GH_Exposure Exposure => GH_Exposure.primary;

        /// <summary>
        /// Initializes a new instance of the <see cref="Inspect"/> component.
        /// </summary>
        public Inspect()
          : base("Core.Inspect", "Core.Inspect",
              "Inspect Object",
              "DiGi", "DiGi.Core")
        {
        }

        /// <summary>
        /// Appends additional custom menu items to the component's right-click context menu.
        /// </summary>
        /// <param name="menu">The tool strip dropdown menu to which items are appended.</param>
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

        private void PopulateOutputParameters(IEnumerable<IGH_Param> @params)
        {
            if (Params is null)
            {
                return;
            }

            Dictionary<string, IList<IGH_Param>> dictionary = [];
            foreach (IGH_Param gH_Param in Params.Output)
            {
                if (gH_Param?.Recipients == null && gH_Param!.Recipients.Count == 0)
                {
                    continue;
                }

                dictionary.Add(gH_Param.Name, [.. gH_Param.Recipients]);
            }

            while (Params.Output != null && Params.Output.Count > 0)
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

                    if (!dictionary.TryGetValue(param.Name, out IList<IGH_Param>? @params_Temp))
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

        private void AddOutputParameter(IGH_Param param)
        {
            param.Attributes ??= new GH_LinkedParamAttributes(param, Attributes);

            Params.RegisterOutputParam(param);
        }

        private void Menu_PopulateOutputsWithAllParameters(object? sender, EventArgs e)
        {
            List<GooParam> gooParams = [];
            foreach (object @object in Params.Input[0].VolatileData.AllData(true).OfType<object>())
            {
                object? @object_Temp = null;
                if (Query.TryGetValue(@object, out ISerializableObject? serializableObject))
                {
                    @object_Temp = serializableObject;
                }
                else if (Query.TryGetValue(@object, out object? @object_Converted))
                {
                    @object_Temp = @object_Converted;
                }

                if (object_Temp is null)
                {
                    continue;
                }

                List<GooParam>? gooParams_Temp = Create.GooParams(@object_Temp);
                if (gooParams_Temp == null)
                {
                    continue;
                }

                foreach (GooParam gooParam_Temp in gooParams_Temp)
                {
                    if (gooParam_Temp == null || gooParams.Find(x => x.Name == gooParam_Temp.Name) != null)
                    {
                        continue;
                    }

                    gooParams.Add(gooParam_Temp);
                }
            }

            RecordUndoEvent("Get Common Parameters");

            List<GooParam> gooParams_Sorted = [.. gooParams];
            gooParams_Sorted.Sort((x, y) => x.Name.CompareTo(y.Name));

            PopulateOutputParameters(gooParams_Sorted);
        }

        private void Menu_PopulateOutputsWithCommonParameters(object? sender, EventArgs e)
        {
            Dictionary<Type, List<GooParam>> dictionary = [];
            foreach (object @object in Params.Input[0].VolatileData.AllData(true).OfType<object>())
            {
                if (!Query.TryGetValue(@object, out ISerializableObject? serializableObject) || serializableObject == null)
                {
                    dictionary = [];
                    break;
                }

                Type type = serializableObject.GetType();

                if (dictionary.ContainsKey(type))
                {
                    continue;
                }

                List<GooParam>? gooParams_Temp = Create.GooParams(serializableObject);
                if (gooParams_Temp == null || gooParams_Temp.Count == 0)
                {
                    dictionary = [];
                    break;
                }

                dictionary[type] = gooParams_Temp;
            }

            RecordUndoEvent("Get Common Parameters");

            List<GooParam> gooParams = [];
            if (dictionary.Count != 0)
            {
                gooParams = [.. dictionary.Values.First()];
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

        private void Menu_RemoveUnconnectedParameters(object? sender, EventArgs e)
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
        /// Registers all input parameters for this component.
        /// </summary>
        /// <param name="inputParamManager">The manager used to register input parameters.</param>
        protected override void RegisterInputParams(GH_InputParamManager inputParamManager)
        {
            inputParamManager.AddGenericParameter("Object", "Object", "Object", GH_ParamAccess.item);
        }

        /// <summary>
        /// Registers all output parameters for this component.
        /// </summary>
        /// <param name="outputParamManager">The manager used to register output parameters.</param>
        protected override void RegisterOutputParams(GH_OutputParamManager outputParamManager)
        {
        }

        /// <summary>
        /// Executes the main logic of the component, reading the input object and setting
        /// values on the dynamically generated output parameters.
        /// </summary>
        /// <param name="dataAccess">The data access object used to retrieve inputs and set outputs.</param>
        protected override void SolveInstance(IGH_DataAccess dataAccess)
        {
            object? @object = null;
            if (!dataAccess.GetData(0, ref @object))
            {
                return;
            }

            object? @object_Temp = null;
            if (Query.TryGetValue(@object, out ISerializableObject? serializableObject))
            {
                @object_Temp = serializableObject;
            }
            else if (Query.TryGetValue(@object, out object? @object_Converted))
            {
                @object_Temp = @object_Converted;
            }

            if (object_Temp is null)
            {
                return;
            }

            for (int i = 0; i < Params.Output.Count; ++i)
            {
                if (Params.Output[i] is not GooParam gooParam)
                {
                    continue;
                }

                object? value = Query.Value(@object_Temp, gooParam);

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

        /// <summary>
        /// Determines whether a parameter can be inserted at the specified index on the given side.
        /// </summary>
        /// <param name="side">The side (input or output) where the parameter would be inserted.</param>
        /// <param name="index">The zero-based index position for insertion.</param>
        /// <returns><see langword="false"/>; insertion is not supported.</returns>
        bool IGH_VariableParameterComponent.CanInsertParameter(GH_ParameterSide side, int index) => false;

        /// <summary>
        /// Determines whether a parameter can be removed from the specified index on the given side.
        /// </summary>
        /// <param name="side">The side (input or output) where the parameter would be removed.</param>
        /// <param name="index">The zero-based index position for removal.</param>
        /// <returns><see langword="true"/> if <paramref name="side"/> is <see cref="GH_ParameterSide.Output"/>; otherwise <see langword="false"/>.</returns>
        bool IGH_VariableParameterComponent.CanRemoveParameter(GH_ParameterSide side, int index) => side == GH_ParameterSide.Output;

        /// <summary>
        /// Creates a new parameter for the specified side and index.
        /// </summary>
        /// <param name="side">The side (input or output) for which the parameter should be created.</param>
        /// <param name="index">The zero-based index position for creation.</param>
        /// <returns><see langword="null"/>; dynamic parameter creation is not supported.</returns>
        IGH_Param? IGH_VariableParameterComponent.CreateParameter(GH_ParameterSide side, int index) => null;

        /// <summary>
        /// Destroys the parameter at the specified index on the given side.
        /// </summary>
        /// <param name="side">The side (input or output) where the parameter should be destroyed.</param>
        /// <param name="index">The zero-based index position for destruction.</param>
        /// <returns><see langword="true"/>.</returns>
        bool IGH_VariableParameterComponent.DestroyParameter(GH_ParameterSide side, int index) => true;

        /// <summary>
        /// Performs any maintenance required when variable parameters change.
        /// </summary>
        void IGH_VariableParameterComponent.VariableParameterMaintenance()
        {
        }

        /// <summary>
        /// Called when this component is added to a Grasshopper document.
        /// </summary>
        /// <param name="document">The Grasshopper document to which the component is being added.</param>
        public override void AddedToDocument(GH_Document document)
        {
            base.AddedToDocument(document);
        }
    }
}