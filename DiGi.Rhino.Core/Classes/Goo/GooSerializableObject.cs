using DiGi.Core.Interfaces;
using DiGi.Rhino.Core.Interfaces;
using Grasshopper.Kernel;
using Grasshopper.Kernel.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DiGi.Rhino.Core.Classes
{
    /// <summary>
    /// Represents a Goo wrapper for an object that implements the <see cref="ISerializableObject"/> interface, 
    /// allowing it to be passed through Grasshopper wires while maintaining serialization capabilities.
    /// </summary>
    /// <typeparam name="TSerializableObject">The type of the serializable object.</typeparam>
    public class GooSerializableObject<TSerializableObject> : GooObject<TSerializableObject?>, IGooSerializableObject<TSerializableObject> where TSerializableObject : ISerializableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GooSerializableObject{TSerializableObject}"/> class.
        /// </summary>
        public GooSerializableObject()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GooSerializableObject{TSerializableObject}"/> class with a specified serializable object.
        /// </summary>
        /// <param name="serializableObject">The serializable object to wrap.</param>
        public GooSerializableObject(TSerializableObject? serializableObject)
            : base(serializableObject)
        {
            Value = serializableObject;
        }

        /// <summary>
        /// Creates a duplicate of the current Goo object.
        /// </summary>
        /// <returns>A new instance of <see cref="GooSerializableObject{TSerializableObject}"/> containing the same value.</returns>
        public override IGH_Goo? Duplicate()
        {
            return new GooSerializableObject<TSerializableObject>(Value);
        }
    }

    /// <summary>
    /// Represents a non-generic Goo wrapper for any object implementing <see cref="ISerializableObject"/>.
    /// </summary>
    public class GooSerializableObject : GooSerializableObject<ISerializableObject>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GooSerializableObject"/> class.
        /// </summary>
        public GooSerializableObject()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GooSerializableObject"/> class with a specified serializable object.
        /// </summary>
        /// <param name="serializableObject">The serializable object to wrap.</param>
        public GooSerializableObject(ISerializableObject? serializableObject)
        {
            Value = serializableObject;
        }

        /// <summary>
        /// Creates a duplicate of the current Goo object.
        /// </summary>
        /// <returns>A new instance of <see cref="GooSerializableObject"/> containing the same value.</returns>
        public override IGH_Goo? Duplicate()
        {
            return new GooSerializableObject(Value);
        }
    }

    /// <summary>
    /// A Grasshopper persistent parameter that handles <see cref="GooSerializableObject"/> types.
    /// </summary>
    public class GooSerializableObjectParam : GH_PersistentParam<GooSerializableObject?>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GooSerializableObjectParam"/> class.
        /// </summary>
        public GooSerializableObjectParam()
            : base(Query.Name(typeof(ISerializableObject)), Query.Name(typeof(ISerializableObject)), typeof(ISerializableObject).FullName?.Replace(".", " "), "Params", Query.Subcategory(typeof(ISerializableObject)))
        {
        }

        /// <summary>
        /// Gets the unique identifier for this component.
        /// </summary>
        public override Guid ComponentGuid => new("a557ef4b-4fa1-47a4-a5cc-894c03f057e7");

        /// <summary>
        /// Appends additional custom menu items to the parameter's context menu.
        /// </summary>
        /// <param name="menu">The dropdown menu to append items to.</param>
        public override void AppendAdditionalMenuItems(ToolStripDropDown menu)
        {
            Menu_AppendItem(menu, "Save As...", Menu_SaveAs, VolatileData.AllData(true).Any());

            //Menu_AppendSeparator(menu);

            base.AppendAdditionalMenuItems(menu);
        }

        /// <summary>
        /// Prompts the user to select multiple values for the parameter.
        /// </summary>
        /// <param name="values">The list of selected values.</param>
        /// <returns>A result indicating whether the operation was successful.</returns>
        protected override GH_GetterResult Prompt_Plural(ref List<GooSerializableObject?> values)
        {
            throw new NotImplementedException();
        }

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;
        /// <summary>
        /// Prompts the user to select a single value for the parameter.
        /// </summary>
        /// <param name="value">The selected value.</param>
        /// <returns>A result indicating whether the operation was successful.</returns>
        protected override GH_GetterResult Prompt_Singular(ref GooSerializableObject? value)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Handles the "Save As..." menu item click event.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event arguments.</param>
        private void Menu_SaveAs(object? sender, EventArgs? e)
        {
            Query.SaveAs(VolatileData);
        }
    }
}