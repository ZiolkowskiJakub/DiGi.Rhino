using GH_IO.Serialization;
using Grasshopper.Kernel;
using System;
using System.Windows.Forms;

namespace DiGi.Rhino.Core.Classes
{
    /// <summary>
    /// An abstract base class for Grasshopper components that manage a value of a specific enumeration type.
    /// </summary>
    /// <typeparam name="T">The enumeration type used by the component.</typeparam>
    public abstract class EnumComponent<T> : GH_Component where T : Enum
    {
        private T? value;

        /// <summary>
        /// Initializes a new instance of the <see cref="EnumComponent{T}"/> class with specified metadata.
        /// </summary>
        /// <param name="name">The full name of the component.</param>
        /// <param name="nickname">The short nickname of the component.</param>
        /// <param name="description">A detailed description of the component's functionality.</param>
        /// <param name="category">The primary category in the Grasshopper menu.</param>
        /// <param name="subCategory">The sub-category in the Grasshopper menu.</param>
        public EnumComponent(string name, string nickname, string description, string category, string subCategory)
          : base(name, nickname, description, category, subCategory)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnumComponent{T}"/> class using a prefix to automatically generate metadata.
        /// </summary>
        /// <param name="prefix">The prefix used to construct the component's identity and category path.</param>
        public EnumComponent(string prefix)
            : base(string.Format("{0}.{1}", prefix, typeof(T).Name), string.Format("{0}.{1}", prefix, typeof(T).Name), DiGi.Core.Query.Description(typeof(T)), "DiGi", string.Format("{0}.{1}", "DiGi", prefix))
        {
        }

        /// <summary>
        /// Reads the serialized state of the component from the provided reader.
        /// </summary>
        /// <param name="reader">The reader used to retrieve stored data.</param>
        /// <returns>True if the read operation was successful; otherwise, false.</returns>
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

        /// <summary>
        /// Writes the current state of the component to the provided writer for serialization.
        /// </summary>
        /// <param name="writer">The writer used to store data.</param>
        /// <returns>True if the write operation was successful; otherwise, false.</returns>
        public override bool Write(GH_IWriter writer)
        {
            writer.SetInt32(typeof(T).Name, value == null ? int.MinValue : value.GetHashCode());
            return base.Write(writer);
        }

        /// <summary>
        /// Appends the enumeration values of type <typeparamref name="T"/> as selectable items in the component's context menu.
        /// </summary>
        /// <param name="menu">The drop-down menu to which the items are appended.</param>
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
        /// <param name="inputParamManager">The manager used to register input parameters.</param>
        protected override void RegisterInputParams(GH_InputParamManager inputParamManager)
        {
        }

        /// <summary>
        /// Registers all the output parameters for this component.
        /// </summary>
        /// <param name="outputParamManager">The manager used to register output parameters.</param>
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
            dataAccess.SetData(0, new GooEnum(value));
        }

        private void Menu_Changed(object? sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem toolStripMenuItem && toolStripMenuItem.Tag is T t)
            {
                value = t;
                ExpireSolution(true);
            }
        }
    }
}