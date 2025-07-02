using DiGi.Rhino.Core.Classes;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.GIS.Rhino.Classes
{
    public class GooAddress : GooSerializableObject<Core.Classes.Address>
    {
        public GooAddress()
            : base()
        {
        }

        public GooAddress(Core.Classes.Address address)
            : base()
        {
            Value = address;
        }

        public override IGH_Goo Duplicate()
        {
            return new GooAddress(Value);
        }

    }

    public class GooAddressParam : GooPresistentParam<GooAddress, Core.Classes.Address>
    {
        public override Guid ComponentGuid => new Guid("dbe281ef-b816-4923-89bb-21943ef8b779");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public GooAddressParam()
            : base()
        {
        }
    }
}

