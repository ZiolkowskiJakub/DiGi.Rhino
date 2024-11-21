using GH_IO.Serialization;
using Grasshopper.Kernel;
using System;
using System.Windows.Forms;

namespace DiGi.Rhino.Core.Classes
{
    public abstract class EnumComponent<T> : GH_Component where T : Enum
    {
        private T value;

        public EnumComponent(string name, string nickname, string description, string category, string subCategory)
          : base(name, nickname, description, category, subCategory)
        {
        }

        public EnumComponent(string prefix)
            : base(string.Format("{0}.{1}", prefix, typeof(T).Name), string.Format("{0}.{1}", prefix, typeof(T).Name), DiGi.Core.Query.Description(typeof(T)), "DiGi", string.Format("{0}.{1}", "DiGi", prefix))
        {
        }

        public override bool Read(GH_IReader reader)
        {
            int @int = -1;
            if (reader.TryGetInt32(typeof(T).Name, ref @int) && @int != -1)
            {
                try
                {
                    value = (T)Enum.ToObject(typeof(T), @int);
                }
                catch
                {

                }
            }

            return base.Read(reader);
        }

        public override bool Write(GH_IWriter writer)
        {
            writer.SetInt32(typeof(T).Name, value.GetHashCode());
            return base.Write(writer);
        }

        protected override void AppendAdditionalComponentMenuItems(ToolStripDropDown menu)
        {
            foreach (Enum @enum in Enum.GetValues(typeof(T)))
            {
                Menu_AppendItem(menu, @enum.ToString(), Menu_Changed, true, @enum.Equals(value)).Tag = @enum;
            }

            base.AppendAdditionalComponentMenuItems(menu);
        }

        /// <summary>
        /// Registers all the input parameters for this component.
        /// </summary>
        protected override void RegisterInputParams(GH_InputParamManager inputParamManager)
        {
        }

        /// <summary>
        /// Registers all the output parameters for this component.
        /// </summary>
        protected override void RegisterOutputParams(GH_OutputParamManager outputParamManager)
        {
            outputParamManager.AddParameter(new GooEnumParam<T>() { Name = typeof(T).Name, NickName = typeof(T).Name, Description = typeof(T).Name, Access = GH_ParamAccess.item });
        }

        /// <summary>
        /// This is the method that actually does the work.
        /// </summary>
        /// <param name="dataAccess">
        /// The DA object is used to retrieve from inputs and store in outputs.
        /// </param>
        protected override void SolveInstance(IGH_DataAccess dataAccess)
        {
            dataAccess.SetData(0, new GooEnum<T>(value));
        }

        private void Menu_Changed(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem item && item.Tag is T)
            {
                value = (T)item.Tag;
                ExpireSolution(true);
            }
        }
    }
}
