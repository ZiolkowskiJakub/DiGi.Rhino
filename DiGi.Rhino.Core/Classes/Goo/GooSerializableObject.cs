using Grasshopper.Kernel.Types;
using Grasshopper.Kernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DiGi.Rhino.Core.Interfaces;
using DiGi.Core.Interfaces;
using GH_IO.Serialization;

namespace DiGi.Rhino.Core.Classes
{
    public class GooSerializableObject<TSerializableObject> : GooObject<TSerializableObject?>, IGooSerializableObject<TSerializableObject?> where TSerializableObject : ISerializableObject
    {
        public GooSerializableObject()
            : base()
        {
        }

        public GooSerializableObject(TSerializableObject? serializableObject)
            :base(serializableObject)
        {
            Value = serializableObject;
        }
        
        public override IGH_Goo? Duplicate()
        {
            return new GooSerializableObject<TSerializableObject>(Value);
        }
    }

    public class GooSerializableObject : GooSerializableObject<ISerializableObject>
    {
        public GooSerializableObject()
            : base()
        {
        }

        public GooSerializableObject(ISerializableObject? serializableObject)
        {
            Value = serializableObject;
        }

        public override IGH_Goo? Duplicate()
        {
            return new GooSerializableObject(Value);
        }
    }

    public class GooSerializableObjectParam : GH_PersistentParam<GooSerializableObject>
    {
        public GooSerializableObjectParam()
            : base(Query.Name(typeof(ISerializableObject)), Query.Name(typeof(ISerializableObject)), typeof(ISerializableObject).FullName?.Replace(".", " "), "Params", Query.Subcategory(typeof(ISerializableObject)))
        {
        }

        public override Guid ComponentGuid => new("a557ef4b-4fa1-47a4-a5cc-894c03f057e7");
        public override void AppendAdditionalMenuItems(ToolStripDropDown menu)
        {
            Menu_AppendItem(menu, "Save As...", Menu_SaveAs, VolatileData.AllData(true).Any());

            //Menu_AppendSeparator(menu);

            base.AppendAdditionalMenuItems(menu);
        }

        protected override GH_GetterResult Prompt_Plural(ref List<GooSerializableObject> values)
        {
            throw new NotImplementedException();
        }

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;
        protected override GH_GetterResult Prompt_Singular(ref GooSerializableObject value)
        {
            throw new NotImplementedException();
        }
        private void Menu_SaveAs(object? sender, EventArgs? e)
        {
            Query.SaveAs(VolatileData);
        }
    }
}
