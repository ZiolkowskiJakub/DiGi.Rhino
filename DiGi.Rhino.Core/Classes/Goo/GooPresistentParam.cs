using Grasshopper.Kernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DiGi.Core.Interfaces;

namespace DiGi.Rhino.Core.Classes
{
    public abstract class GooPresistentParam<T, X> : GH_PersistentParam<T> where T : GooSerializableObject<X> where X : ISerializableObject
    {
        public GooPresistentParam()
            : base(typeof(X).Name, typeof(X).Name, typeof(X).FullName.Replace(".", " "), "Params", "DiGi")
        {
        }

        public override void AppendAdditionalMenuItems(ToolStripDropDown menu)
        {
            Menu_AppendItem(menu, "Save As...", Menu_SaveAs, VolatileData.AllData(true).Any());

            //Menu_AppendSeparator(menu);

            base.AppendAdditionalMenuItems(menu);
        }

        protected override GH_GetterResult Prompt_Plural(ref List<T> values)
        {
            throw new NotImplementedException();
        }

        protected override GH_GetterResult Prompt_Singular(ref T value)
        {
            throw new NotImplementedException();
        }
        
        private void Menu_SaveAs(object sender, EventArgs e)
        {
            Query.SaveAs(VolatileData);
        }
    }
}
