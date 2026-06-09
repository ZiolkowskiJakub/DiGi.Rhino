using DiGi.Rhino.Core.Classes;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.GIS.Rhino.Classes
{
    /// <summary>
    /// Represents a Grasshopper Goo wrapper for a physical mailing address.
    /// </summary>
    public class GooAddress : GooSerializableObject<Core.Classes.Address>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GooAddress"/> class.
        /// </summary>
        public GooAddress()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GooAddress"/> class with the specified address.
        /// </summary>
        /// <param name="address">The physical mailing address to wrap.</param>
        public GooAddress(Core.Classes.Address? address)
            : base()
        {
            Value = address;
        }

        /// <summary>
        /// Creates a duplicate of this Goo object.
        /// </summary>
        /// <returns>A new <see cref="IGH_Goo"/> instance containing the same address value.</returns>
        public override IGH_Goo Duplicate()
        {
            return new GooAddress(Value);
        }
    }

    /// <summary>
    /// Represents a Grasshopper parameter that handles <see cref="GooAddress"/> objects.
    /// </summary>
    public class GooAddressParam : GooSerializablePresistentParam<GooAddress, Core.Classes.Address>
    {
        /// <summary>
        /// Gets the unique identifier for the <see cref="GooAddressParam"/> component.
        /// </summary>
        /// <value>The GUID of the component.</value>
        public override Guid ComponentGuid => new("dbe281ef-b816-4923-89bb-21943ef8b779");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        /// <summary>
        /// Initializes a new instance of the <see cref="GooAddressParam"/> class.
        /// </summary>
        public GooAddressParam()
            : base()
        {
        }
    }
}