using DiGi.Core.Interfaces;
using Grasshopper.Kernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DiGi.Rhino.Core.Classes
{
    /// <summary>
    /// Represents a persistent parameter that handles serializable objects of type <typeparamref name="T"/> and <typeparamref name="X"/>.
    /// </summary>
    /// <typeparam name="T">The type of the Goo object, which must derive from <see cref="GooSerializableObject{X}"/>.</typeparam>
    /// <typeparam name="X">The underlying serializable data type that implements <see cref="ISerializableObject"/>.</typeparam>
    public class GooSerializablePresistentParam<T, X> : GooPresistentParam<T, X> where T : GooSerializableObject<X> where X : ISerializableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GooSerializablePresistentParam{T, X}"/> class with a specified name and subcategory.
        /// </summary>
        /// <param name="name">The display name of the parameter.</param>
        /// <param name="subcategory">The subcategory used for grouping in the Grasshopper interface.</param>
        public GooSerializablePresistentParam(string name, string subcategory)
            : base(name, subcategory)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GooSerializablePresistentParam{T, X}"/> class.
        /// </summary>
        public GooSerializablePresistentParam()
            : base()
        {
        }

        /// <summary> Gets the unique identifier for this component type. </summary>
        public override Guid ComponentGuid => new("f360150a-d89b-4324-aff2-43c883eb3c98");

        /// <summary>
        /// Appends additional custom items to the context menu of the parameter.
        /// </summary>
        /// <param name="menu">The <see cref="ToolStripDropDown"/> menu to which items will be added.</param>
        public override void AppendAdditionalMenuItems(ToolStripDropDown menu)
        {
            Menu_AppendItem(menu, "Save As...", Menu_SaveAs, VolatileData.AllData(true).Any());

            //Menu_AppendSeparator(menu);

            base.AppendAdditionalMenuItems(menu);
        }

        /// <summary>
        /// Prompts the user to provide multiple values for the parameter.
        /// </summary>
        /// <param name="values">A reference to the list of values to be retrieved.</param>
        /// <returns>The result of the getter operation as a <see cref="GH_GetterResult"/>.</returns>
        protected override GH_GetterResult Prompt_Plural(ref List<T?> values)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Prompts the user to provide a single value for the parameter.
        /// </summary>
        /// <param name="value">A reference to the value to be retrieved.</param>
        /// <returns>The result of the getter operation as a <see cref="GH_GetterResult"/>.</returns>
        protected override GH_GetterResult Prompt_Singular(ref T? value)
        {
            throw new NotImplementedException();
        }

        private void Menu_SaveAs(object? sender, EventArgs e)
        {
            Query.SaveAs(VolatileData);
        }
    }
}