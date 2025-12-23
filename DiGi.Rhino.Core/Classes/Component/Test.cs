using Grasshopper.Kernel;
using System;
using System.Collections.Generic;

namespace DiGi.Rhino.Core.Classes
{

    public abstract class ElementLogicalFilter : Component, IGH_VariableParameterComponent
    {
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

        static int ToIndex(char value) => value - 'A';
        static char ToChar(int value) => (char)('A' + value);

        public bool CanInsertParameter(GH_ParameterSide side, int index)
        {
            return side == GH_ParameterSide.Input && index <= ToIndex('Z') && index == Params.Input.Count;
        }

        public bool CanRemoveParameter(GH_ParameterSide side, int index)
        {
            return side == GH_ParameterSide.Input && index > ToIndex('B') && index == Params.Input.Count - 1;
        }

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

        public bool DestroyParameter(GH_ParameterSide side, int index) => CanRemoveParameter(side, index);
        public void VariableParameterMaintenance() { }

        public override void AddedToDocument(GH_Document document)
        {
            Grasshopper.CentralSettings.CanvasFullNamesChanged += CentralSettings_CanvasFullNamesChanged;
            base.AddedToDocument(document);
        }

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

    public class ElementLogicalAndFilter : ElementLogicalFilter
    {
        public override Guid ComponentGuid => new("0E534AFB-7264-4AFF-99F3-7F7EA7DB9F3D");
        public override GH_Exposure Exposure => GH_Exposure.primary;

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
