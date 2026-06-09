using Grasshopper.Kernel;
using System;
using System.Collections.Generic;

namespace DiGi.Rhino.Core.Classes
{
    /// <summary>
    /// Base abstract class for logical filter components that support a variable number of input parameters.
    /// </summary>
    public abstract class ElementLogicalFilter : Component, IGH_VariableParameterComponent
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ElementLogicalFilter"/> class.
        /// </summary>
        /// <param name="name">The full name of the component.</param>
        /// <param name="nickname">The short nickname of the component.</param>
        /// <param name="description">A description of what the component does.</param>
        /// <param name="category">The category in the Grasshopper menu.</param>
        /// <param name="subCategory">The sub-category in the Grasshopper menu.</param>
        protected ElementLogicalFilter(string name, string nickname, string description, string category, string subCategory)
        : base(name, nickname, description, category, subCategory)
        { }

        protected override void RegisterInputParams(GH_InputParamManager manager)
        {
            manager.AddParameter(new Grasshopper.Kernel.Parameters.Param_String(), "Filter A", "A", string.Empty, GH_ParamAccess.item);
            manager.AddParameter(new Grasshopper.Kernel.Parameters.Param_String(), "Filter B", "B", string.Empty, GH_ParamAccess.item);
        }

        protected override void RegisterOutputParams(GH_OutputParamManager manager)
        {
            manager.AddParameter(new Grasshopper.Kernel.Parameters.Param_String(), "Filter", "F", string.Empty, GH_ParamAccess.item);
        }

        private static int ToIndex(char value) => value - 'A';

        private static char ToChar(int value) => (char)('A' + value);

        /// <summary>
        /// Determines whether a parameter can be inserted at the specified side and index.
        /// </summary>
        /// <param name="side">The side of the component where the parameter would be inserted.</param>
        /// <param name="index">The zero-based index of the parameter.</param>
        /// <returns><c>true</c> if the parameter can be inserted; otherwise, <c>false</c>.</returns>
        public bool CanInsertParameter(GH_ParameterSide side, int index)
        {
            return side == GH_ParameterSide.Input && index <= ToIndex('Z') && index == Params.Input.Count;
        }

        /// <summary>
        /// Determines whether a parameter can be removed from the specified side and index.
        /// </summary>
        /// <param name="side">The side of the component where the parameter would be removed.</param>
        /// <param name="index">The zero-based index of the parameter.</param>
        /// <returns><c>true</c> if the parameter can be removed; otherwise, <c>false</c>.</returns>
        public bool CanRemoveParameter(GH_ParameterSide side, int index)
        {
            return side == GH_ParameterSide.Input && index > ToIndex('B') && index == Params.Input.Count - 1;
        }

        /// <summary>
        /// Creates a new parameter for the specified side and index.
        /// </summary>
        /// <param name="side">The side of the component where the parameter is created.</param>
        /// <param name="index">The zero-based index of the parameter.</param>
        /// <returns>The newly created <see cref="IGH_Param"/>, or <c>null</c> if creation is not possible.</returns>
        public IGH_Param? CreateParameter(GH_ParameterSide side, int index)
        {
            if (side == GH_ParameterSide.Output)
            {
                return default;
            }

            var name = $"Filter {ToChar(index)}";
            var nickName = ToChar(index).ToString();
            return new Grasshopper.Kernel.Parameters.Param_String()
            {
                Name = name,
                NickName = Grasshopper.CentralSettings.CanvasFullNames ? name : nickName
            };
        }

        /// <summary>
        /// Destroys the parameter at the specified side and index.
        /// </summary>
        /// <param name="side">The side of the component where the parameter is located.</param>
        /// <param name="index">The zero-based index of the parameter.</param>
        /// <returns><c>true</c> if the parameter was successfully destroyed; otherwise, <c>false</c>.</returns>
        public bool DestroyParameter(GH_ParameterSide side, int index) => CanRemoveParameter(side, index);

        /// <summary>
        /// Performs maintenance on variable parameters to ensure consistency.
        /// </summary>
        public void VariableParameterMaintenance()
        { }

        /// <summary>
        /// Called when the component is added to a Grasshopper document.
        /// </summary>
        /// <param name="document">The document the component is being added to.</param>
        public override void AddedToDocument(GH_Document document)
        {
            Grasshopper.CentralSettings.CanvasFullNamesChanged += CentralSettings_CanvasFullNamesChanged;
            base.AddedToDocument(document);
        }

        /// <summary>
        /// Called when the component is removed from a Grasshopper document.
        /// </summary>
        /// <param name="document">The document the component is being removed from.</param>
        public override void RemovedFromDocument(GH_Document document)
        {
            Grasshopper.CentralSettings.CanvasFullNamesChanged -= CentralSettings_CanvasFullNamesChanged;
            base.RemovedFromDocument(document);
        }

        private void CentralSettings_CanvasFullNamesChanged()
        {
            for (int i = 0; i < Params.Input.Count; ++i)
            {
                var param = Params.Input[i];
                var name = $"Filter {ToChar(i)}";
                var nickName = ToChar(i).ToString();

                if (Grasshopper.CentralSettings.CanvasFullNames)
                {
                    if (param.NickName == nickName)
                        param.NickName = name;
                }
                else
                {
                    if (param.NickName == name)
                        param.NickName = nickName;
                }
            }
        }
    }

    /// <summary>
    /// Implementation of a logical AND filter that combines multiple input filters into a single output string.
    /// </summary>
    public class ElementLogicalAndFilter : ElementLogicalFilter
    {
        /// <summary>
        /// Gets the unique identifier for this component.
        /// </summary>
        public override Guid ComponentGuid => new("0E534AFB-7264-4AFF-99F3-7F7EA7DB9F3D");

        /// <summary>
        /// Gets the exposure level of the component.
        /// </summary>
        public override GH_Exposure Exposure => GH_Exposure.primary;

        /// <summary>
        /// Initializes a new instance of the <see cref="ElementLogicalAndFilter"/> class.
        /// </summary>
        public ElementLogicalAndFilter()
          : base("Core.Test", "Core.Test",
              "Test",
              "DiGi", "DiGi.Core")
        {
        }

        protected override void SolveInstance(IGH_DataAccess DA)
        {
            var filters = new List<string>(Params.Input.Count);
            for (int i = 0; i < Params.Input.Count; ++i)
            {
                string filter = string.Empty;
                if (DA.GetData(i, ref filter) && filter is not null)
                {
                    filters.Add(filter);
                }
            }

            DA.SetData("Filter", string.Join("_", filters));
        }
    }
}